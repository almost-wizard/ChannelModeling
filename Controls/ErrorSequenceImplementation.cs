using ChannelModeling.Objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChannelModeling.Components
{
    public partial class ErrorSequenceImplementation : UserControl
    {
        public ErrorSequenceImplementation()
        {
            InitializeComponent();
        }

        private void ErrorSequenceImplementation_Load(object sender, EventArgs e)
        {
            InterferenceGeneratorComboBox.DataSource = new List<String> { "Идеальная", "Биномиальная" };
            InterferenceGeneratorComboBox.SelectedIndex = 1;
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

            BitErrorSequence bitErrorSequence = new BitErrorSequence(generator.GenerateInterferences(sequenceLength));
            PackageErrorSequence packageErrorSequence = new PackageErrorSequence(bitErrorSequence.ToPackageErrors(packageLength));

            BitsSequenceLabel.Text = bitErrorSequence.ToString();
            IntervalSequenceLabel.Text = bitErrorSequence.ToIntervalString();
            PackageSequenceLabel.Text = packageErrorSequence.ToString();

            ErrorSequenceModelGroupBox.Visible = true;
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
