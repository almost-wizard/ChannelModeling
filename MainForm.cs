using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChannelModeling
{
    public partial class MainForm : Form
    {
        private static readonly int? DEFAULT_APP_SEED = 0;
        private static readonly App.Randomizer Randomizer = App.Randomizer.GetInstance();

        public MainForm()
        {
            InitializeComponent();
            Randomizer.SetSeed(DEFAULT_APP_SEED);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;

            InterferenceGeneratorComboBox.DataSource = new List<String> { "Идеальная", "Биномиальная" };
            InterferenceGeneratorComboBox.SelectedIndex = 1;
        }

        private void SetSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.SetSeedModal form = new Forms.SetSeedModal();
            form.ShowDialog();
        }

        private void ResetSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Randomizer.SetSeed();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InterferenceGeneratorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorProbabilityTextBox.Visible = InterferenceGeneratorComboBox.SelectedIndex == 1;
            ErrorProbabilityLabel.Visible = InterferenceGeneratorComboBox.SelectedIndex == 1;
        }

        private void CalculateErrorSequenceButton_Click(object sender, EventArgs e)
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
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Выберите корректную модель генерации ошибок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Models.ErrorSequence errorSequenceModel = new Models.ErrorSequence(generator, sequenceLength, packageLength);
            errorSequenceModel.Simulate();

            BitsSequenceLabel.Text = errorSequenceModel.BitsSequence;
            IntervalSequenceLabel.Text = errorSequenceModel.IntervalsSequence;

            ErrorSequenceModelGroupBox.Visible = true;
        }
    }
}
