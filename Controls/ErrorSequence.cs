using ChannelModeling.Objects;
using ChannelModeling.Objects.Data;
using System;
using System.Collections.Generic;
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
            // update combobox list with allowed interference models
            InterferenceGeneratorComboBox.DataSource = new List<String> { "Идеальная", "Биномиальная" };
            InterferenceGeneratorComboBox.SelectedIndex = 1;

            // disable selection
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        }

        private void InterferenceGeneratorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorProbabilityTextBox.Visible = InterferenceGeneratorComboBox.SelectedIndex == 1;
            ErrorProbabilityLabel.Visible = InterferenceGeneratorComboBox.SelectedIndex == 1;
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

            UpdateDataGrid(bitPackageSequence);

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
                default:
                    MessageBox.Show("Выберите корректную модель генерации ошибок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }

            return generator;
        }
    }
}
