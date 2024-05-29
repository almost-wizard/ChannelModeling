using ChannelModeling.Objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChannelModeling.Controls
{
    public partial class DataChannel : UserControl
    {
        public DataChannel()
        {
            InitializeComponent();
        }

        private void DataChannel_Load(object sender, EventArgs e)
        {
            DataChannelComboBox.DataSource = new List<String> { "Кабельный телефонный выделеный", "Кабельный телефонный коммутируемый", 
                "Радиорелейный телефонный", "Тропосферный телефонный", "Радиотелеграфный КВ-канал", "Пользовательские данные"};
            DataChannelComboBox.SelectedIndex = 0;
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

            BitSequence markovBitSequence = new BitSequence(generator.GenerateInterferences(blockCount));
            ErrorsPackageSequence.Text = markovBitSequence.ToString();
            IntervalSequenceLabel.Text = markovBitSequence.ToIntervalString();

            ErrorsRateLabel.Text = markovBitSequence.ErrorsRate.ToString();
            PackagesWithErrorsCountLabel.Text = markovBitSequence.ErrorsCount.ToString();

            TransitionMatrixLablel.Text = generator.GetTransitionMatrix();

            TransitionMatrixLablel.Visible = true;
            BlockErrorsSequanceGroupBox.Visible = true;
        }

        private void DataChannelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fucking костыль but works good and заебца
            this.ErrorProbabilityTextBox.TextChanged -= new System.EventHandler(this.ErrorProbabilityTextBox_TextChanged);
            this.GroupCoefficientTextBox.TextChanged -= new System.EventHandler(this.GroupCoefficientTextBox_TextChanged);

            switch (DataChannelComboBox.SelectedIndex)
            {
                case 0:
                    ErrorProbabilityTextBox.Text = "0,00001";
                    GroupCoefficientTextBox.Text = "0,8";
                    break;
                case 1:
                    ErrorProbabilityTextBox.Text = "0,000667";
                    GroupCoefficientTextBox.Text = "0,33";
                    break;
                case 2:
                    ErrorProbabilityTextBox.Text = "0,0000428";
                    GroupCoefficientTextBox.Text = "0,6";
                    break;
                case 3:
                    ErrorProbabilityTextBox.Text = "0,0007";
                    GroupCoefficientTextBox.Text = "0,44";
                    break;
                case 4:
                    ErrorProbabilityTextBox.Text = "0,02";
                    GroupCoefficientTextBox.Text = "0,32";
                    break;
                case 5:
                    break;
            }

            this.ErrorProbabilityTextBox.TextChanged += new System.EventHandler(this.ErrorProbabilityTextBox_TextChanged);
            this.GroupCoefficientTextBox.TextChanged += new System.EventHandler(this.GroupCoefficientTextBox_TextChanged);
        }

        private void GroupCoefficientTextBox_TextChanged(object sender, EventArgs e)
        {
            DataChannelComboBox.SelectedIndex = 5;
        }

        private void ErrorProbabilityTextBox_TextChanged(object sender, EventArgs e)
        {
            DataChannelComboBox.SelectedIndex = 5;
        }
    }
}
