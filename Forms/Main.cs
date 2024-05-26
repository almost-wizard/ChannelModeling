using System;
using System.Windows.Forms;

namespace ChannelModeling
{
    public partial class Main : Form
    {
        private static readonly int? DEFAULT_APP_SEED = 0;
        private static readonly App.Randomizer Randomizer = App.Randomizer.GetInstance();

        public Main()
        {
            InitializeComponent();
            Randomizer.SetSeed(DEFAULT_APP_SEED);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void SetSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.SetSeedModal form = new Forms.SetSeedModal();
            form.ShowDialog();
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Randomizer.SetSeed();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
