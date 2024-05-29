using ChannelModeling.Objects;
using ChannelModeling.Objects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChannelModeling.Components
{
    public partial class ErrorSequence : UserControl
    {
        public ErrorSequence()
        {
            InitializeComponent();
        }

        private void ErrorSequenceImplementation_Load(object sender, EventArgs e)
        {
            BinominalGroupBox.Parent = this;
            EliotModelBroupBox.Parent = this;

            // update combobox list with allowed interference models
            InterferenceGeneratorComboBox.DataSource = new List<String> { "Идеальная", "Биномиальная", "Элиота" };
            InterferenceGeneratorComboBox.SelectedIndex = 1;

            // disable selection
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        }

        private void InterferenceGeneratorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinominalGroupBox.Visible = InterferenceGeneratorComboBox.SelectedIndex == 1;
            EliotModelBroupBox.Visible = InterferenceGeneratorComboBox.SelectedIndex == 2;
        }

        private void SimulateErrorSequenceButton_Click(object sender, EventArgs e)
        {
            InterferenceGenerator.InterferenceGenerator generator = GetSelectedInterferenceGenerator();

            if (generator == null)
            {
                return;
            }

            bool sequenceLengthParsed = int.TryParse(SequenceLenthTextBox.Text, out int sequenceLength);
            if (!sequenceLengthParsed || sequenceLength <= 0)
            {
                MessageBox.Show("Введите корректное значение длины последовательности", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool packageLengthParsed = int.TryParse(PackageLengthTextBox.Text, out int packageLength);
            if (!packageLengthParsed || packageLength <= 0)
            {
                MessageBox.Show("Введите корректное значение длины пакета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BitSequence bitSequence = new BitSequence(generator.GenerateInterferences(sequenceLength));
            BitPackageSequence bitPackageSequence = new BitPackageSequence(bitSequence.ToBitPackages(packageLength));

            BitsSequenceLabel.Text = bitSequence.ToString();
            IntervalSequenceLabel.Text = bitSequence.ToIntervalString();
            PackageSequenceLabel.Text = bitPackageSequence.ToString();
            PackageIntervalSequenceLabel.Text = bitPackageSequence.ToIntervalString();

            ErrorsRateLabel.Text = Math.Round(bitSequence.ErrorsRate, 2).ToString();
            GroupingFactorLabel.Text = Math.Round(bitPackageSequence.GroupingFactor, 2).ToString();
            PackagesCountLabel.Text = bitPackageSequence.Value.Count.ToString();
            ErrorDensityLabel.Text = Math.Round(bitPackageSequence.ErrorDensity, 2).ToString();

            UpdateChart(bitPackageSequence);
            UpdateDataGrid(bitPackageSequence);

            ErrorSequenceModelGroupBox.Visible = true;
        }

        private void UpdateChart(BitPackageSequence bitPackageSequence)
        {
            Dictionary<int, double> errorProbabilitiesDistribution = bitPackageSequence.GetErrorsProbabilitiesDistribution();
            List<int> errorsCounts = errorProbabilitiesDistribution.Select(kvp => kvp.Key).ToList();
            List<double> errorProbabilities = errorProbabilitiesDistribution.Select(kvp => kvp.Value).ToList();

            ErrorProbabilitiesChart.ChartAreas[0].AxisX.LabelStyle.Interval = bitPackageSequence.PackageSize;
            ErrorProbabilitiesChart.ChartAreas[0].AxisX.Maximum = bitPackageSequence.PackageSize;
            ErrorProbabilitiesChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ErrorProbabilitiesChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            ErrorProbabilitiesChart.ChartAreas[0].AxisX.Interval = 1;

            ErrorProbabilitiesChart.Series[0].Points.DataBindXY(errorsCounts, errorProbabilities);
        }

        private void UpdateDataGrid(BitPackageSequence bitPackageSequence)
        {
            dataGridView1.Rows.Clear();

            foreach (BitPackage package in bitPackageSequence.Value)
            {
                dataGridView1.Rows.Add(package.ToString(), Math.Round(package.ErrorsRate, 2));
            }
        }

        private InterferenceGenerator.InterferenceGenerator GetSelectedInterferenceGenerator()
        {
            InterferenceGenerator.InterferenceGenerator generator;

            switch (InterferenceGeneratorComboBox.SelectedIndex)
            {
                case 0:
                    generator = new InterferenceGenerator.IdealInterference();
                    break;
                case 1:
                    bool probabiltyParsed = double.TryParse(ErrorProbabilityTextBox.Text, out double probabilty);
                    if (probabiltyParsed && 0 <= probabilty && probabilty <= 1)
                    {
                        generator = new InterferenceGenerator.BinomialInterference(probabilty);
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное значение вероятности ошибки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    break;
                case 2:
                    bool averageErrorFreeSequenceLengthParsed = double.TryParse(ErrorFreeSequensAVGLengthTextBox.Text, out double averageErrorFreeSequenceLength);
                    bool averageErrorSequenceLengthParsed = double.TryParse(ErrorSequensAVGLengthTextBox.Text, out double averageErrorSequenceLength);
                    if (!averageErrorSequenceLengthParsed || !averageErrorFreeSequenceLengthParsed)
                    {
                        MessageBox.Show("Введите корректные значения параметров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    if (averageErrorFreeSequenceLength <= 0 || averageErrorSequenceLength <= 0 )
                    {
                        MessageBox.Show("Значения средних длин интервалов должны принимать значения больше 0 ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    generator = new InterferenceGenerator.EliotInterference(averageErrorFreeSequenceLength, averageErrorSequenceLength);
                    break;
                default:
                    MessageBox.Show("Выберите корректную модель генерации ошибок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }

            return generator;
        }
    }
}
