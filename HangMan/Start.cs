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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            StartUpPage newForm = new StartUpPage();
            newForm.Show();
            this.Hide();
        }

        private void NormalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
