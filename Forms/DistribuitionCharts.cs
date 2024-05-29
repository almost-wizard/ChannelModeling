using ChannelModeling.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChannelModeling.Forms
{
    public partial class DistribuitionCharts : Form
    {
        public BitSequence BitSequence { get; set; }
        public BitPackageSequence BitPackageSequence { get; set; }

        public DistribuitionCharts(BitSequence bitSequence, BitPackageSequence bitPackageSequence = null)
        {
            InitializeComponent();

            BitSequence = bitSequence;
            BitPackageSequence = bitPackageSequence;
        }

        private void DistribuitionCharts_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;

            ErrorProbabilitiesChart.Visible = BitPackageSequence != null;
            ErrorProbabilitiesLabel.Visible = BitPackageSequence != null;

            if (BitPackageSequence != null)
            {
                UpdateChart(ErrorProbabilitiesChart, BitPackageSequence.GetErrorsProbabilitiesDistribution());
            }

            UpdateChart(GoodSequencesProbabilitiesChart, BitSequence.GetGoodSequencesProbabilitiesDistribution());
            UpdateChart(BadSequencesProbabilitiesChart, BitSequence.GetErrorSequencesProbabilitiesDistribution());
        }

        private void UpdateChart(Chart chart, Dictionary<int, double> data)
        {
            List<int> x = data.Select(kvp => kvp.Key).ToList();
            List<double> y = data.Select(kvp => kvp.Value).ToList();

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chart.ChartAreas[0].AxisY.Interval = 0.2;
            chart.ChartAreas[0].AxisY.Maximum = 1;
            chart.ChartAreas[0].AxisY.Minimum = 0;

            chart.Series[0].Points.DataBindXY(x, y);
        }
    }
}
