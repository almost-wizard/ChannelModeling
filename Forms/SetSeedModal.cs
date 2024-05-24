using System;
using System.Windows.Forms;

namespace ChannelModeling.Forms
{
    public partial class SetSeedModal : Form
    {
        private static readonly App.Randomizer Randomizer = App.Randomizer.GetInstance();

        public SetSeedModal()
        {
            InitializeComponent();
        }

        private void SetSeedModalForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void SetSeedButton_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(textBox1.Text, out int seed);
            if (success)
            {
                Randomizer.SetSeed(seed);
                Close();
            }
            else
            {
                MessageBox.Show("Введите корректное значение зерна генерации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
