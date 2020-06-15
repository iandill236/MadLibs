using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibs
{
    public partial class Form1 : Form
    {
        int randomNum = 0;
        Random randGen = new Random();

        string word1, word2, word3, word4, word5, word6, word7, word8, word9, word10;

        int popUp = 0;

        public Form1()
        {

            InitializeComponent();
        }

        public void titleSetup()
        {
            titleSmile.Visible = true;
            titleLabel.Visible = true;
            titleLabel.Text = "Mad Libs";
            subtitleLabel.Visible = true;
            randButton.Visible = true;
            selectButton.Visible = true;
            quitButton.Visible = true;
            randButton.Enabled = true;
            selectButton.Enabled = true;
            randButton.Enabled = true;
        }
        public void titleClear()
        {
            titleSmile.Visible = false;
            titleLabel.Visible = false;
            subtitleLabel.Visible = false;
            randButton.Visible = false;
            selectButton.Visible = false;
            quitButton.Visible = false;
            randButton.Enabled = false;
            selectButton.Enabled = false;
            randButton.Enabled = false;
        }
        public void selectSetup()
        {
            titleLabel.Visible = true;
            titleLabel.Text = "Stages";
            turtleButton.Visible = true;
            loveButton.Visible = true;
            timeButton.Visible = true;
            fortuneButton.Visible = true;
            blankButton.Visible = true;
            mainButton.Visible = true;
            blankButton.Enabled = true;
        }
        public void selectClear()
        {
            titleLabel.Visible = false;
            titleLabel.Text = "Mad Libs";
            turtleButton.Visible = false;
            loveButton.Visible = false;
            timeButton.Visible = false;
            fortuneButton.Visible = false;
            blankButton.Visible = false;
            mainButton.Visible = false;
            blankButton.Enabled = false;
        }
        public void wordSetup()
        {
            mainButton.Visible = true;
            confirmButton.Visible = true;
            confirmButton.Enabled = true;

            word1Label.Visible = true;
            word1Box.Visible = true;
            word2Label.Visible = true;
            word2Box.Visible = true;
            word3Label.Visible = true;
            word3Box.Visible = true;
            word4Label.Visible = true;
            word4Box.Visible = true;
            word5Label.Visible = true;
            word5Box.Visible = true;
            word6Label.Visible = true;
            word6Box.Visible = true;
            word7Label.Visible = true;
            word7Box.Visible = true;
            word8Label.Visible = true;
            word8Box.Visible = true;
            word9Label.Visible = true;
            word9Box.Visible = true;
            word10Label.Visible = true;
            word10Box.Visible = true;
        }
        public void wordClear()
        {
            mainButton.Visible = false;
            confirmButton.Visible = false;
            confirmButton.Enabled = false;

            word1Label.Visible = false;
            word1Box.Visible = false;
            word2Label.Visible = false;
            word2Box.Visible = false;
            word3Label.Visible = false;
            word3Box.Visible = false;
            word4Label.Visible = false;
            word4Box.Visible = false;
            word5Label.Visible = false;
            word5Box.Visible = false;
            word6Label.Visible = false;
            word6Box.Visible = false;
            word7Label.Visible = false;
            word7Box.Visible = false;
            word8Label.Visible = false;
            word8Box.Visible = false;
            word9Label.Visible = false;
            word9Box.Visible = false;
            word10Label.Visible = false;
            word10Box.Visible = false;
        }
        public void warningUp()
        {
            word1Label.Visible = false;
            word1Box.Visible = false;
            word2Label.Visible = false;
            word2Box.Visible = false;
            word3Label.Visible = false;
            word3Box.Visible = false;
            word4Label.Visible = false;
            word4Box.Visible = false;
            word5Label.Visible = false;
            word5Box.Visible = false;
            word6Label.Visible = false;
            word6Box.Visible = false;
            word7Label.Visible = false;
            word7Box.Visible = false;
            word8Label.Visible = false;
            word8Box.Visible = false;
            word9Label.Visible = false;
            word9Box.Visible = false;
            word10Label.Visible = false;
            word10Box.Visible = false;
        }
        public void warningDown()
        {
            word1Label.Visible = true;
            word1Box.Visible = true;
            word2Label.Visible = true;
            word2Box.Visible = true;
            word3Label.Visible = true;
            word3Box.Visible = true;
            word4Label.Visible = true;
            word4Box.Visible = true;
            word5Label.Visible = true;
            word5Box.Visible = true;
            word6Label.Visible = true;
            word6Box.Visible = true;
            word7Label.Visible = true;
            word7Box.Visible = true;
            word8Label.Visible = true;
            word8Box.Visible = true;
            word9Label.Visible = true;
            word9Box.Visible = true;
            word10Label.Visible = true;
            word10Box.Visible = true;
        }


        private void randButton_Click(object sender, EventArgs e)
        {
            titleClear();

            randomNum = randGen.Next(1, 6);

            // if (randomNum == 1){}
            // if (randomNum == 2){}
            // if (randomNum == 3){}
            // if (randomNum == 4){}
            // if (randomNum == 5){}
        }

        
        private void turtleButton_Click_1(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
        }
        private void loveButton_Click(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
        }
        private void timeButton_Click(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
        }
        private void fortuneButton_Click(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
        }
        private void blankButton_Click_1(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
        }


        private void selectButton_Click(object sender, EventArgs e)
        {
            titleClear();
            selectSetup();
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void mainButton_Click(object sender, EventArgs e)
        {
            wordClear();
            selectClear();
            titleSetup();
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (popUp == 0)
            {
                if (word1Box.Text==null||word1Box.Text == ""|| word2Box.Text == null || word2Box.Text == "" || word3Box.Text == null || word3Box.Text == "" || word4Box.Text == null || word4Box.Text == "" || word5Box.Text == null || word5Box.Text == "" || word6Box.Text == null || word6Box.Text == "" || word7Box.Text == null || word7Box.Text == "" || word8Box.Text == null || word8Box.Text == "" || word9Box.Text == null || word9Box.Text == "" || word10Box.Text == null || word10Box.Text == "")
                {
                    warningUp();
                    popUp = 1;
                    warningPopUp.Visible = true;
                    confirmButton.Text = "Review my Choices";
                    mainButton.Visible = false;
                    confirmButton.Location = new Point(confirmButton.Location.X + 77, confirmButton.Location.Y);                    
                }
                else
                {
                    word1 = Convert.ToString(word1Box.Text);
                    word2 = Convert.ToString(word2Box.Text);
                    word3 = Convert.ToString(word3Box.Text);
                    word4 = Convert.ToString(word4Box.Text);
                    word5 = Convert.ToString(word5Box.Text);
                    word6 = Convert.ToString(word6Box.Text);
                    word7 = Convert.ToString(word7Box.Text);
                    word8 = Convert.ToString(word8Box.Text);
                    word9 = Convert.ToString(word9Box.Text);
                    word10 = Convert.ToString(word10Box.Text);
                }
            }
            else if(popUp == 1)
            {
                warningDown();
                popUp = 0;
                warningPopUp.Visible = false;
                confirmButton.Text = "Confirm my Choices";
                mainButton.Visible = true;
                confirmButton.Location = new Point(confirmButton.Location.X - 77, confirmButton.Location.Y);
            }
        }
    }
}
