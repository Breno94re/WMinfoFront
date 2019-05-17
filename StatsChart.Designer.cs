namespace WMinfo_Front
{
    partial class StatsChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GPUP = new System.Windows.Forms.Panel();
            this.cputext = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.GPUP.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.chart1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.Beige;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-3, 59);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DarkRed;
            series1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.DarkRed;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.LegendText = "Max:";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(570, 288);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // GPUP
            // 
            this.GPUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GPUP.Controls.Add(this.cputext);
            this.GPUP.Controls.Add(this.comboBox1);
            this.GPUP.Controls.Add(this.panel4);
            this.GPUP.Controls.Add(this.button3);
            this.GPUP.Controls.Add(this.button2);
            this.GPUP.Controls.Add(this.button1);
            this.GPUP.Controls.Add(this.chart1);
            this.GPUP.Location = new System.Drawing.Point(0, 0);
            this.GPUP.Name = "GPUP";
            this.GPUP.Size = new System.Drawing.Size(567, 356);
            this.GPUP.TabIndex = 59;
            // 
            // cputext
            // 
            this.cputext.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cputext.ForeColor = System.Drawing.Color.White;
            this.cputext.Location = new System.Drawing.Point(116, 0);
            this.cputext.Name = "cputext";
            this.cputext.Size = new System.Drawing.Size(304, 75);
            this.cputext.TabIndex = 67;
            this.cputext.Text = "CPU - Temperatures";
            this.cputext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Temperature",
            "Load"});
            this.comboBox1.Location = new System.Drawing.Point(442, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.Text = "    Change Instance";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel4.Controls.Add(this.monthCalendar2);
            this.panel4.Location = new System.Drawing.Point(217, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 161);
            this.panel4.TabIndex = 65;
            this.panel4.Visible = false;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar2.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 64;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(443, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 45);
            this.button3.TabIndex = 63;
            this.button3.Text = "Date";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(443, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 62;
            this.button2.Text = "Daily";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(443, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 61;
            this.button1.Text = "Real Time";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatsChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.GPUP);
            this.Name = "StatsChart";
            this.Size = new System.Drawing.Size(1141, 720);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.GPUP.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Panel GPUP;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.MonthCalendar monthCalendar2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label cputext;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
    }
}
