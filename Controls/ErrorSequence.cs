using ChannelModeling.Forms;
using ChannelModeling.Objects;
using ChannelModeling.Objects.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChannelModeling.Components
{
    public partial class ErrorSequence : UserControl
    {
        private BitPackageSequence BitPackageSequence { get; set; }
        private BitSequence BitSequence { get; set; }

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
            if (!packageLengthParsed || packageLength <= 0 || packageLength > 60)
            {
                MessageBox.Show("Введите корректное значение длины пакета из диапазона[1; 60]", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BitSequence = new BitSequence(generator.GenerateInterferences(sequenceLength));
            BitPackageSequence = new BitPackageSequence(BitSequence.ToBitPackages(packageLength));

            BitsSequenceLabel.Text = BitSequence.ToString();
            IntervalSequenceLabel.Text = BitSequence.ToIntervalString();
            PackageSequenceLabel.Text = BitPackageSequence.ToString();
            PackageIntervalSequenceLabel.Text = BitPackageSequence.ToIntervalString();

            ErrorsRateLabel.Text = Math.Round(BitSequence.ErrorsRate, 2).ToString();
            GroupingFactorLabel.Text = Math.Round(BitPackageSequence.GroupingFactor, 2).ToString();
            PackagesCountLabel.Text = BitPackageSequence.Value.Count.ToString();
            ErrorDensityLabel.Text = Math.Round(BitPackageSequence.ErrorDensity, 2).ToString();

            UpdateDataGrid(BitPackageSequence);

            ErrorSequenceModelGroupBox.Visible = true;
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

        private void ShowChartsButton_Click(object sender, EventArgs e)
        {
            using (DistribuitionCharts chartsForm = new DistribuitionCharts(BitSequence, BitPackageSequence))
            {
                chartsForm.ShowDialog();
            }
        }
    }
}
