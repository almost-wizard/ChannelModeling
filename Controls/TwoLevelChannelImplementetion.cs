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
    public partial class TwoLevelChannelImplementetion : UserControl
    {
        public TwoLevelChannelImplementetion()
        {
            InitializeComponent();
        }

        private void SimulateTwoLevelChannelButton_Click(object sender, EventArgs e)
        {
            bool errorProbabilityParsed = double.TryParse(ErrorProbabilityTextBox.Text, out double errorProbabilty);
            bool groupCoefficientParsed = double.TryParse(GroupCoefficientTextBox.Text, out double groupCoefficient);
            bool blockLengthParsed = int.TryParse(BlockLengthTextBox.Text, out int blockLength);
            bool blockCountParsed = int.TryParse(BlockCountTextBox.Text, out int blockCount);

            if (errorProbabilityParsed && groupCoefficientParsed && blockLengthParsed && blockCountParsed)
            {
                BlocksInterferenceGenerator.TwoLevelInterference generator;

                if (errorProbabilty < 0 || errorProbabilty > 0.5)
                {
                    MessageBox.Show("Вероятность ошибки в двоичном символе должна принимать значения от 0 до 0.5", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (groupCoefficient < 0 || groupCoefficient > 1)
                {
                    MessageBox.Show("Коэффициент группирования должен принимать значения от 0 до 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (blockLength < 10 || blockLength > 500)
                {
                    MessageBox.Show("Длина блока должна принимать значения от 10 до 500", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (blockCount <= 0)
                {
                    MessageBox.Show("Количество блоков должно быть натуральным числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                generator = new BlocksInterferenceGenerator.TwoLevelInterference(errorProbabilty, groupCoefficient, blockLength);

                PackageStatesSequence packageError = new PackageStatesSequence(generator.GenerateBlockInterferences(blockCount));
                BlockErrorsSequence.Text = packageError.ToString();

                TransitionMatrixLablel.Text = generator.GetTransitionMatrix();

                TransitionMatrixGroupBox.Visible = true;
                BlockErrorsSequanceGroupBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Введите корректные значения параметров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
