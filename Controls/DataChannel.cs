using ChannelModeling.Objects;
using System;
using System.Windows.Forms;

namespace ChannelModeling.Controls
{
    public partial class DataChannel : UserControl
    {
        public DataChannel()
        {
            InitializeComponent();
        }

        private void SimulateTwoLevelChannelButton_Click(object sender, EventArgs e)
        {
            bool errorProbabilityParsed = double.TryParse(ErrorProbabilityTextBox.Text, out double errorProbabilty);
            bool groupCoefficientParsed = double.TryParse(GroupCoefficientTextBox.Text, out double groupCoefficient);
            bool blockLengthParsed = int.TryParse(PackageLengthTextBox.Text, out int blockLength);
            bool blockCountParsed = int.TryParse(PackageCountTextBox.Text, out int blockCount);

            if (!errorProbabilityParsed || !groupCoefficientParsed || !blockLengthParsed || !blockCountParsed)
            {
                MessageBox.Show("Введите корректные значения параметров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InterferenceGenerator.MarkovInterference generator;

            if (errorProbabilty < 0 || errorProbabilty > 0.5)
            {
                MessageBox.Show("Вероятность ошибки в двоичном символе должна принимать значения от 0 до 0,5", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (groupCoefficient < 0 || groupCoefficient > 1)
            {
                MessageBox.Show("Коэффициент группирования должен принимать значения от 0 до 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (blockLength < 10 || blockLength > 500)
            {
                MessageBox.Show("Длина пакета должна принимать значения от 10 до 500", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (blockCount <= 0)
            {
                MessageBox.Show("Количество пакетов должно быть натуральным числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            generator = new InterferenceGenerator.MarkovInterference(errorProbabilty, groupCoefficient, blockLength);

            BitSequence bitSequence = new BitSequence(generator.GenerateInterferences(blockCount));
            ErrorsPackageSequence.Text = bitSequence.ToString();

            TransitionMatrixLablel.Text = generator.GetTransitionMatrix();

            TransitionMatrixLablel.Visible = true;
            BlockErrorsSequanceGroupBox.Visible = true;
        }
    }
}
