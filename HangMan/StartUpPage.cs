using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class StartUpPage : Form
    {
        public static int quickest;
        public StartUpPage()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            quickest = 120;
            GameForm newForm = new GameForm();
            newForm.Show();
            this.Hide();
        }

        private void NormalButton_Click(object sender, EventArgs e)
        {
            quickest = 90;
            GameForm newForm = new GameForm();
            newForm.Show();
            this.Hide();
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            quickest = 60;
            GameForm newForm = new GameForm();
            newForm.Show();
            this.Hide();
        }
    }
}
