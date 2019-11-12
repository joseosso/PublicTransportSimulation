﻿using GMap.NET;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIOSimulation
{
    class BusSimulationControl
    {
        private List<List<BusLocation>> timeLine;
        private List<Bus> busesInSimulation;
        private long start;
        private long finish;
        private long offset;
        private int movingTo;
        private Dictionary<String, Bus> busReference;
        private Dictionary<String, int> busMatch;
        private DBConnection dataConnection;

        public BusSimulationControl(long start, long finish)
        {

            this.start = start;
            this.finish = finish;
            movingTo = -1;
            busReference = new Dictionary<string, Bus>();
            busMatch = new Dictionary<string, int>();
            busesInSimulation = new List<Bus>();
            timeLine = new List<List<BusLocation>>();
            InitializeSimulation();
            dataConnection = new DBConnection();
        }

        // Date;IdBus;IdStop;Odometer;TaskId;LineId;TripId;Lng;Lat
        // 2019-06-20 18:00:17
        private void InitializeSimulation()
        {
            FileReader br = new FileReader("dataSimulation1.txt");
            List<String> data = br.readFile();
            String lastDate = "";
            int position = -1;
            foreach (String line in data)
            {
                string[] splitData = line.Split(',');
                String date = splitData[0];
                String busId = splitData[1];
                String stopId = splitData[2];
                String Lng = splitData[4];
                String Lat = splitData[5];
                PointLatLng location = new PointLatLng(Double.Parse(Lat, CultureInfo.InvariantCulture.NumberFormat)/10000000, Double.Parse(Lng, CultureInfo.InvariantCulture.NumberFormat)/ 10000000);
                BusLocation temp;
                switch (Convert.ToInt32(stopId))
                {
                    case -1:
                        temp = new BusLocation(location, busId, Int32.Parse(stopId), true);
                        break;
                    default:
                        temp = new BusLocation(location, busId, Int32.Parse(stopId), false);
                        break;
                }
                if (!busReference.ContainsKey(busId))
                {
                    busReference.Add(busId, new Bus(busId, ""));
                }

                if (date.CompareTo(lastDate) == 0)
                {
                    timeLine[position].Add(temp);
                }
                else
                {
                    if (lastDate.Equals(""))
                    {
                        lastDate = date;
                        offset = createNumber(lastDate);
                        position++;
                        timeLine.Add(new List<BusLocation>());
                    }
                    else {
                        long start = createNumber(lastDate);
                        long finish = createNumber(date);
                        for (long i = start + 1; i <= finish; i++)
                        {
                            position++;
                            timeLine.Add(new List<BusLocation>());
                        }
                    }
                    
                    timeLine[position].Add(temp);
                    lastDate = date;
                }
            }

        }

        public long createNumber(string date)
        {
            String[] fecha = date.Split(' ')[1].Split(':');
            String[] data = date.Split(' ')[1].Split(':');

            long result = long.Parse(data[0]) * 3600 + long.Parse(data[1]) * 60 + long.Parse(data[2]);
            return result;
        }

        public void setInterval(String s, String f)
        {
            start = createNumber(s) - offset;
            finish = createNumber(f) - offset;
            movingTo = (int)start;
        }

        public List<Bus> Next30()
        {
            busesInSimulation = new List<Bus>();
            busMatch = new Dictionary<string, int>();
            int steps = 0;
            while (movingTo <= finish && steps <= 30)
            {
                foreach (BusLocation location in timeLine[movingTo])
                {
                    if (busReference.ContainsKey(location.BusName))
                    {
                        if (!busMatch.ContainsKey(location.BusName))
                        {
                            busReference[location.BusName].ActualPosition = location.Postion;
                            busReference[location.BusName].PreviousStop = location.StopId;
                            busReference[location.BusName].TimeElapse -= movingTo;
                            busMatch.Add(location.BusName, -1);
                            if (location.IsIddle)
                            {
                                busReference[location.BusName].IsIddle = true;
                            }
                            else
                            {
                                busReference[location.BusName].IsIddle = false;
                            }
                        }
                    }
                }
                movingTo++;
                steps++;
            }
            checkNext30();
            checkValid();
            return busesInSimulation;
        }


        private void checkNext30()
        {
            int steps = 0;
            while (movingTo <= finish && steps <= 30)
            {
                foreach (BusLocation location in timeLine[movingTo])
                {
                    if (busReference.ContainsKey(location.BusName))
                    {
                        Bus actualBus = busReference[location.BusName];
                        actualBus.NextPosition = location.Postion;
                        actualBus.ActualStop = location.StopId;
                        if (busMatch.ContainsKey(location.BusName)) {
                            int solution = movingTo - (int)actualBus.TimeElapse;
                            busMatch.Remove(location.BusName);
                            busMatch.Add(location.BusName, solution);
                        }
                    }
                }
                movingTo++;
                steps++;
            }
            movingTo -= steps;
        }

        private void checkValid()
        {
            foreach (var item in busMatch)
            {
                if (item.Value >= 0)
                {
                    Bus actualBus = busReference[item.Key];
                    if (actualBus.PreviousStop != actualBus.ActualStop)
                    {
                        actualBus.TimeLocation = 0;
                        actualBus.TimeLocation -= item.Value;
                        //actualBus.TimeLocation += dataConnection.getArcTime(actualBus.PreviousStop, actualBus.ActualStop);
                        actualBus.TimeElapse = 0;

                    }
                    busesInSimulation.Add(busReference[item.Key]);
                }
            }

        }
    }
}