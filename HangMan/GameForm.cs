using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace HangMan
{
    
    public partial class GameForm : Form
    {
        private Bitmap[] hangImages = {HangMan.Properties.Resources._1 , HangMan.Properties.Resources._2 , 
                                       HangMan.Properties.Resources._3 , HangMan.Properties.Resources._4 ,
                                       HangMan.Properties.Resources._5 , HangMan.Properties.Resources._6 ,
                                       HangMan.Properties.Resources._7};
        private int wrongGuesses = 0;
        private string current = "";
        private string copyCurrent = "";
        private string[] words;
        public  static int quick=StartUpPage.quickest;
        
        public GameForm()
        {
            InitializeComponent();
        }
        private void loadwords()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("Words.txt");
            words = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                words[index++] = line[1];
            }

        }

        private void setupWordChoice()
        {
            wrongGuesses = 0;
            hangImage.Image = hangImages[wrongGuesses];
            int guessIndex = (new Random()).Next(words.Length);
            current = words[guessIndex];
            copyCurrent = "";
            for(int index=0; index<current.Length; index++)
            {
                copyCurrent += "_";
            }
            displayCopy();        }
        private void displayCopy()
        {
            lblShowWord.Text = "";
            for (int index = 0; index < copyCurrent.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index, 1);
                lblShowWord.Text += " ";
            }
        }
        private void updateCopy(char guess)
        {

        }
        private void guessClick(object sender, EventArgs e)
        {
            Button choise = sender as Button;
            choise.Enabled = false;
            if (current.Contains(choise.Text))
            {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choise.Text.ElementAt(0);
                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();

            }
            else
            {
                wrongGuesses++;
            }
            
            if (wrongGuesses < 7)
            {
                hangImage.Image = hangImages[wrongGuesses];
            }
            else
            {
                lblResult.Text = "You Lose!";
            }
            if (copyCurrent.Equals(current))
            {
                lblResult.Text = "You Win";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoice();
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            quick--;
            TimeLabel.Text = quick / 60 + "." + ((quick % 60) >= 10 ? (quick % 60).ToString() : "O" + (quick % 60));
            if (TimeLabel.Text == "0:00")
            {
                timer1.Stop();
                Button sas = sender as Button;
                sas.Enabled = false;
                MessageBox.Show("The time done");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start newForm = new Start();
            newForm.Show();
            this.Hide();
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm newForm = new GameForm();
            newForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartUpPage newForm = new StartUpPage();
            newForm.Show();
            this.Hide();
        }
    }
}
