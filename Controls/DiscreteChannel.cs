using ChannelModeling.InterferenceGenerator;
using ChannelModeling.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChannelModeling.Controls
{
    public partial class DiscreteChannel : UserControl
    {
        public DiscreteChannel()
        {
            InitializeComponent();
        }

        private void DiscreteChannel_Load(object sender, EventArgs e)
        {
            DataForSmithGroupBox.Parent = this;
            DataForGilbertGroupBox.Parent = this;
            ModelComboBox.DataSource = new List<String> { "Модель Гильберта", "Модель Смита-Боуна-Джойса" };
            ModelComboBox.SelectedIndex = 0;
        }

        private void ModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ModelComboBox.SelectedIndex)
            {
                case 0:
                    DataForSmithGroupBox.Visible = false;
                    DataForGilbertGroupBox.Visible = true;
                    break;
                case 1:
                    DataForSmithGroupBox.Visible = true;
                    DataForGilbertGroupBox.Visible = false;
                    break;
            }
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            InterferenceGenerator.InterferenceGenerator generator = GetSelectedInterferenceGenerator();

            if (generator == null)
            {
                return;
            }

            bool sequenceLengthParsed = int.TryParse(SequenceLengthTextBox.Text, out int sequenceLength);
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

            if (ModelComboBox.SelectedIndex == 0)
            {
                InterferenceGenerator.GilbertInterference generator_1 = (GilbertInterference)generator;
                TransitionMatrixLabel.Text = generator_1.GetTransitionMatrix();
            }
            else
            {
                InterferenceGenerator.SmithInterference generator_1 = (SmithInterference)generator;
                TransitionMatrixLabel.Text = generator_1.GetTransitionMatrix();
            }
            TransitionMatrixLabel.Visible = true;
            BitSequence bitSequence = new BitSequence(generator.GenerateInterferences(sequenceLength));
            BitPackageSequence bitPackageSequence = new BitPackageSequence(bitSequence.ToBitPackages(packageLength));
            BitSequence packageStages = bitPackageSequence.GetPackagesStages();
            BitSequenceLabel.Text = bitSequence.ToString();
            PackageBitSequensLabel.Text = bitPackageSequence.ToString();
            PackageStagesLabel.Text = packageStages.ToString();
            PackagesCountLabel.Text = bitPackageSequence.Value.Count.ToString();
            ErrorDensityLabel.Text = Math.Round(bitPackageSequence.ErrorDensity, 2).ToString();
            ErrorsRateLabel.Text = Math.Round(bitPackageSequence.ErrorsRate, 2).ToString();
            GroupingFactorLabel.Text = Math.Round(bitPackageSequence.GroupingFactor, 2).ToString();
            ResultsGroupBox.Visible = true; 
        }

        private InterferenceGenerator.InterferenceGenerator GetSelectedInterferenceGenerator()
        {
            InterferenceGenerator.InterferenceGenerator generator;

            switch (ModelComboBox.SelectedIndex)
            {
                case 0:
                    bool packageErrorPropabilityParsed = double.TryParse(ETextBox.Text, out double packageErrorPropability);
                    bool P_10_Parsed = double.TryParse(P10TextBox.Text, out double p_10);
                    bool P_01_Parsed = double.TryParse(P01TextBox.Text, out double p_01);
                    if (!packageErrorPropabilityParsed || !P_10_Parsed || !P_01_Parsed)
                    {
                        MessageBox.Show("Введите корректные значения параметров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                        
                    }
                    if (packageErrorPropability < 0 || packageErrorPropability > 1)
                    {
                        MessageBox.Show("Значение вероятности ошибки в пакете должна принимать значения от 0 до 1 ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    if ((p_01 < 0 || p_01 > 1) || (p_10 < 0 || p_10 > 1))
                    {
                        MessageBox.Show("Значения переходных вероятностей должны принимать значения от 0 до 1 ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    generator = new InterferenceGenerator.GilbertInterference(packageErrorPropability, p_10, p_01);
                    break;
                case 1:
                    bool e_1_Parsed = double.TryParse(E1TextBox.Text, out double e_1);
                    bool e_2_Parsed = double.TryParse(E2TextBox.Text, out double e_2);
                    bool e_0_Parsed = double.TryParse(E0TextBox.Text, out double e_0);
                    bool P_21_Parsed = double.TryParse(P21TextBox.Text, out double p_21);
                    bool P_12_Parsed = double.TryParse(P12TextBox.Text, out double p_12);
                    bool P_20_Parsed = double.TryParse(P20TextBox.Text, out double p_20);
                    bool P_02_Parsed = double.TryParse(P02TextBox.Text, out double p_02);
                    if (!e_1_Parsed || !e_2_Parsed || !e_0_Parsed || !P_21_Parsed || !P_12_Parsed || !P_02_Parsed || !P_20_Parsed)
                    {
                        MessageBox.Show("Введите корректные значения параметров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    if ((e_0 < 0 || e_0 > 1) || (e_1 < 0 || e_1 > 1) || (e_2 < 0 || e_2 > 1))
                    {
                        MessageBox.Show("Значения вероятности ошибок в состояних канала должны принимать значения от 0 до 1 ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    if ((p_21 < 0 || p_21 > 1) || (p_12 < 0 || p_12 > 1) || (p_02 < 0 || p_02 > 1) || (p_20 < 0 || p_20 > 1))
                    {
                        MessageBox.Show("Значения переходных вероятностей должны принимать значения от 0 до 1 ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    generator = new InterferenceGenerator.SmithInterference(e_0, e_1, e_2, p_21, p_20, p_12, p_02);
                    break;
                default:
                    MessageBox.Show("Выберите корректную модель генерации ошибок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
            return generator;
        }
    }
}
