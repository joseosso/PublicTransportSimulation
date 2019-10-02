﻿namespace MIOSimulation
{
    partial class SimulacionMetroCali
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulacionMetroCali));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.StationStop_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zoom = new System.Windows.Forms.Button();
            this.zoomplus = new System.Windows.Forms.Button();
            this.slower = new System.Windows.Forms.Button();
            this.faster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.goSimulation = new System.Windows.Forms.Button();
            this.prueba = new System.Windows.Forms.Label();
            this.startSimulation = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zoomLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(1, -1);
            this.gmap.Margin = new System.Windows.Forms.Padding(1);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 10;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(917, 561);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 14D;
            this.gmap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.addStationsOverlay);
            // 
            // StationStop_CB
            // 
            this.StationStop_CB.FormattingEnabled = true;
            this.StationStop_CB.Location = new System.Drawing.Point(61, 63);
            this.StationStop_CB.Margin = new System.Windows.Forms.Padding(1);
            this.StationStop_CB.Name = "StationStop_CB";
            this.StationStop_CB.Size = new System.Drawing.Size(67, 21);
            this.StationStop_CB.TabIndex = 1;
            this.StationStop_CB.Text = "Estaciones y paradas";
            this.StationStop_CB.SelectedIndexChanged += new System.EventHandler(this.StationStop_CB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.zoomLbl);
            this.panel1.Controls.Add(this.zoom);
            this.panel1.Controls.Add(this.zoomplus);
            this.panel1.Controls.Add(this.slower);
            this.panel1.Controls.Add(this.faster);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.goSimulation);
            this.panel1.Controls.Add(this.prueba);
            this.panel1.Controls.Add(this.startSimulation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StationStop_CB);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(921, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 561);
            this.panel1.TabIndex = 3;
            // 
            // zoom
            // 
            this.zoom.ForeColor = System.Drawing.Color.Black;
            this.zoom.Location = new System.Drawing.Point(97, 185);
            this.zoom.Margin = new System.Windows.Forms.Padding(2);
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(53, 20);
            this.zoom.TabIndex = 10;
            this.zoom.Text = "- Zoom";
            this.zoom.UseVisualStyleBackColor = true;
            this.zoom.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // zoomplus
            // 
            this.zoomplus.ForeColor = System.Drawing.Color.Black;
            this.zoomplus.Location = new System.Drawing.Point(97, 160);
            this.zoomplus.Margin = new System.Windows.Forms.Padding(2);
            this.zoomplus.Name = "zoomplus";
            this.zoomplus.Size = new System.Drawing.Size(53, 20);
            this.zoomplus.TabIndex = 9;
            this.zoomplus.Text = "+ Zoom";
            this.zoomplus.UseVisualStyleBackColor = true;
            this.zoomplus.Click += new System.EventHandler(this.Zoomplus_Click);
            // 
            // slower
            // 
            this.slower.ForeColor = System.Drawing.Color.Black;
            this.slower.Location = new System.Drawing.Point(154, 184);
            this.slower.Margin = new System.Windows.Forms.Padding(2);
            this.slower.Name = "slower";
            this.slower.Size = new System.Drawing.Size(19, 23);
            this.slower.TabIndex = 8;
            this.slower.Text = "-";
            this.slower.UseVisualStyleBackColor = true;
            this.slower.Click += new System.EventHandler(this.Slower_Click);
            // 
            // faster
            // 
            this.faster.ForeColor = System.Drawing.Color.Black;
            this.faster.Location = new System.Drawing.Point(154, 157);
            this.faster.Margin = new System.Windows.Forms.Padding(2);
            this.faster.Name = "faster";
            this.faster.Size = new System.Drawing.Size(19, 23);
            this.faster.TabIndex = 7;
            this.faster.Text = "+";
            this.faster.UseVisualStyleBackColor = true;
            this.faster.Click += new System.EventHandler(this.Faster_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(31, 185);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pausar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // goSimulation
            // 
            this.goSimulation.ForeColor = System.Drawing.Color.Black;
            this.goSimulation.Location = new System.Drawing.Point(31, 161);
            this.goSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.goSimulation.Name = "goSimulation";
            this.goSimulation.Size = new System.Drawing.Size(62, 19);
            this.goSimulation.TabIndex = 5;
            this.goSimulation.Text = "Reanudar";
            this.goSimulation.UseVisualStyleBackColor = true;
            this.goSimulation.Click += new System.EventHandler(this.GoSimulation_Click);
            // 
            // prueba
            // 
            this.prueba.AutoSize = true;
            this.prueba.Location = new System.Drawing.Point(47, 131);
            this.prueba.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(109, 13);
            this.prueba.TabIndex = 4;
            this.prueba.Text = "Informacion de la ruta";
            // 
            // startSimulation
            // 
            this.startSimulation.ForeColor = System.Drawing.Color.Black;
            this.startSimulation.Location = new System.Drawing.Point(73, 96);
            this.startSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.startSimulation.Name = "startSimulation";
            this.startSimulation.Size = new System.Drawing.Size(53, 19);
            this.startSimulation.TabIndex = 3;
            this.startSimulation.Text = "Simular movimiento";
            this.startSimulation.UseVisualStyleBackColor = true;
            this.startSimulation.Click += new System.EventHandler(this.StartSimulation_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // zoomLbl
            // 
            this.zoomLbl.AutoSize = true;
            this.zoomLbl.Location = new System.Drawing.Point(77, 257);
            this.zoomLbl.Name = "zoomLbl";
            this.zoomLbl.Size = new System.Drawing.Size(0, 13);
            this.zoomLbl.TabIndex = 11;
            // 
            // SimulacionMetroCali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1116, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gmap);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SimulacionMetroCali";
            this.Text = "SimulacionMetroCali";
            this.Load += new System.EventHandler(this.Map_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ComboBox StationStop_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startSimulation;
        private System.Windows.Forms.Label prueba;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button goSimulation;
        private System.Windows.Forms.Button slower;
        private System.Windows.Forms.Button faster;
        private System.Windows.Forms.Button zoom;
        private System.Windows.Forms.Button zoomplus;
        private System.Windows.Forms.Label zoomLbl;
    }
}
