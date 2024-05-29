namespace ChannelModeling.Forms
{
    partial class DistribuitionCharts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GoodSequencesProbabilitiesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ErrorProbabilitiesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BadSequencesProbabilitiesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ErrorProbabilitiesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GoodSequencesProbabilitiesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadSequencesProbabilitiesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProbabilitiesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GoodSequencesProbabilitiesChart
            // 
            this.GoodSequencesProbabilitiesChart.BackColor = System.Drawing.Color.Transparent;
            this.GoodSequencesProbabilitiesChart.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea7.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea7.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea7.AxisY.Interval = 1D;
            chartArea7.AxisY.MaximumAutoSize = 100F;
            chartArea7.AxisY.Minimum = 0D;
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.GoodSequencesProbabilitiesChart.ChartAreas.Add(chartArea7);
            this.GoodSequencesProbabilitiesChart.Location = new System.Drawing.Point(12, 12);
            this.GoodSequencesProbabilitiesChart.Name = "GoodSequencesProbabilitiesChart";
            series7.BorderWidth = 5;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.MarkerBorderColor = System.Drawing.Color.Transparent;
            series7.MarkerColor = System.Drawing.Color.Red;
            series7.MarkerSize = 8;
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Series1";
            this.GoodSequencesProbabilitiesChart.Series.Add(series7);
            this.GoodSequencesProbabilitiesChart.Size = new System.Drawing.Size(300, 300);
            this.GoodSequencesProbabilitiesChart.TabIndex = 22;
            this.GoodSequencesProbabilitiesChart.Text = "chart1";
            // 
            // ErrorProbabilitiesLabel
            // 
            this.ErrorProbabilitiesLabel.Font = new System.Drawing.Font("Consolas", 12F);
            this.ErrorProbabilitiesLabel.Location = new System.Drawing.Point(341, 472);
            this.ErrorProbabilitiesLabel.Name = "ErrorProbabilitiesLabel";
            this.ErrorProbabilitiesLabel.Size = new System.Drawing.Size(296, 97);
            this.ErrorProbabilitiesLabel.TabIndex = 24;
            this.ErrorProbabilitiesLabel.Text = "Распределение вероятностей P(k,m) возникновения k ошибок в блоке длиной m";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(8, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 61);
            this.label2.TabIndex = 25;
            this.label2.Text = "Распределения длин серий правильных символов P(⅄), ⅄ = 0, 1, 2...";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(345, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 44);
            this.label3.TabIndex = 26;
            this.label3.Text = "Распределения длин серий ошибок P(⅄), ⅄ = 0, 1, 2...";
            // 
            // BadSequencesProbabilitiesChart
            // 
            this.BadSequencesProbabilitiesChart.BackColor = System.Drawing.Color.Transparent;
            this.BadSequencesProbabilitiesChart.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea8.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea8.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.Minimum = 0D;
            chartArea8.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea8.AxisY.Interval = 1D;
            chartArea8.AxisY.MaximumAutoSize = 100F;
            chartArea8.AxisY.Minimum = 0D;
            chartArea8.BackColor = System.Drawing.Color.Transparent;
            chartArea8.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.BadSequencesProbabilitiesChart.ChartAreas.Add(chartArea8);
            this.BadSequencesProbabilitiesChart.Location = new System.Drawing.Point(337, 12);
            this.BadSequencesProbabilitiesChart.Name = "BadSequencesProbabilitiesChart";
            series8.BorderWidth = 5;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.MarkerBorderColor = System.Drawing.Color.Transparent;
            series8.MarkerColor = System.Drawing.Color.Red;
            series8.MarkerSize = 8;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Series1";
            this.BadSequencesProbabilitiesChart.Series.Add(series8);
            this.BadSequencesProbabilitiesChart.Size = new System.Drawing.Size(300, 300);
            this.BadSequencesProbabilitiesChart.TabIndex = 27;
            this.BadSequencesProbabilitiesChart.Text = "chart1";
            // 
            // ErrorProbabilitiesChart
            // 
            this.ErrorProbabilitiesChart.BackColor = System.Drawing.Color.Transparent;
            this.ErrorProbabilitiesChart.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea9.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea9.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX.Minimum = 0D;
            chartArea9.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea9.AxisY.Interval = 1D;
            chartArea9.AxisY.MaximumAutoSize = 100F;
            chartArea9.AxisY.Minimum = 0D;
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            this.ErrorProbabilitiesChart.ChartAreas.Add(chartArea9);
            this.ErrorProbabilitiesChart.Location = new System.Drawing.Point(12, 394);
            this.ErrorProbabilitiesChart.Name = "ErrorProbabilitiesChart";
            series9.BorderWidth = 5;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.MarkerBorderColor = System.Drawing.Color.Transparent;
            series9.MarkerColor = System.Drawing.Color.Red;
            series9.MarkerSize = 8;
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series9.Name = "Series1";
            this.ErrorProbabilitiesChart.Series.Add(series9);
            this.ErrorProbabilitiesChart.Size = new System.Drawing.Size(300, 211);
            this.ErrorProbabilitiesChart.TabIndex = 28;
            this.ErrorProbabilitiesChart.Text = "chart1";
            // 
            // DistribuitionCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 617);
            this.Controls.Add(this.ErrorProbabilitiesChart);
            this.Controls.Add(this.BadSequencesProbabilitiesChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ErrorProbabilitiesLabel);
            this.Controls.Add(this.GoodSequencesProbabilitiesChart);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DistribuitionCharts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики распределения вероятностей";
            this.Load += new System.EventHandler(this.DistribuitionCharts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoodSequencesProbabilitiesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadSequencesProbabilitiesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProbabilitiesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart GoodSequencesProbabilitiesChart;
        private System.Windows.Forms.Label ErrorProbabilitiesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart BadSequencesProbabilitiesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ErrorProbabilitiesChart;
    }
}