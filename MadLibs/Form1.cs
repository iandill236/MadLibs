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
        int story = 0;
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
            word1Box.Text = "";
            word2Label.Visible = false;
            word2Box.Visible = false;
            word2Box.Text = "";
            word3Label.Visible = false;
            word3Box.Visible = false;
            word3Box.Text = "";
            word4Label.Visible = false;
            word4Box.Visible = false;
            word4Box.Text = "";
            word5Label.Visible = false;
            word5Box.Visible = false;
            word5Box.Text = "";
            word6Label.Visible = false;
            word6Box.Visible = false;
            word6Box.Text = "";
            word7Label.Visible = false;
            word7Box.Visible = false;
            word7Box.Text = "";
            word8Label.Visible = false;
            word8Box.Visible = false;
            word8Box.Text = "";
            word9Label.Visible = false;
            word9Box.Visible = false;
            word9Box.Text = "";
            word10Label.Visible = false;
            word10Box.Visible = false;
            word10Box.Text = "";
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

        //storyPopUp.Text = "";
        //storyPopUp.Text += "";
        
        public void turtleSetup()
        {
            story = 1;
            word1Label.Text = "Adjective:";
            word2Label.Text = "Adjective:";
            word3Label.Text = "Occupation:";
            word4Label.Text = "Animal (Plural):";
            word5Label.Text = "Animal:";
            word6Label.Text = "Noun:";
            word7Label.Text = "Noun (Plural):";
            word8Label.Text = "Adjective:";
            word9Label.Text = "Kitchen Appliance:";
            word10Label.Text = "Verb:";
        }
        public void turtleStory()
        {
            storyPopUp.Text = "The " + word1 + " " + word2 + " " + word3 + " " + word4 + " are 4 " + word4 + " who are led ";
            storyPopUp.Text += "by a/an " + word5 + " in the fight against " + word6 + ". They strive to protect " + word7 + " from all ";
            storyPopUp.Text += "violence, but their most " + word8 + " enemy is the dreaded " + word9 + ". They also love ";
            storyPopUp.Text += "to " + word10 + " pizza!";
        }

        public void loveSetup()
        {
            story = 2;
            word1Label.Text = "Famous Name:";
            word2Label.Text = "Adjective:";
            word3Label.Text = "Verb:";
            word4Label.Text = "Part of The Body:";
            word5Label.Text = "Number:";
            word6Label.Text = "Noun:";
            word7Label.Text = "Adverb:";
            word8Label.Text = "Verb:";
            word9Label.Text = "Name:";
            word10Label.Text = "Pronoun (Plural):";
        }
        public void timeSetup()
        {
            story = 3;
            word1Label.Text = "Noun:";
            word2Label.Text = "Famous Name:";
            word3Label.Text = "Negative Adjective:";
            word4Label.Text = "Positive Adjective:";
            word5Label.Text = "Negative Adjective:";
            word6Label.Text = "Noun:";
            word7Label.Text = "Noun (Plural):";
            word8Label.Text = "Adjective:";
            word9Label.Text = "Fighting Move:";
            word10Label.Text = "Adjective:";
        }
        public void fortuneSetup()
        {
            story = 4;
            word1Label.Text = "Verb:";
            word2Label.Text = "Adverb:";
            word3Label.Text = "Adjective:";
            word4Label.Text = "Noun (Plural):";
            word5Label.Text = "Noun (Plural):";
            word6Label.Text = "Adjective:";
            word7Label.Text = "Verb (Ending in 'ing'):";
            word8Label.Text = "Noun (Plural):";
            word9Label.Text = "Noun:";
            word10Label.Text = "Weapon (Plural):";
        }
        public void blankSetup()
        {
            story = 5;
            word1Label.Text = "Noun:";
            word2Label.Text = "Verb (Ending in 'ing'):";
            word3Label.Text = "Noun:";
            word4Label.Text = "Occupation:";
            word5Label.Text = "Number:";
            word6Label.Text = "Location:";
            word7Label.Text = "Verb:";
            word8Label.Text = "Adjective:";
            word9Label.Text = "Noun (Plural):";
            word10Label.Text = "Noun:";
        }


        private void randButton_Click(object sender, EventArgs e)
        {
            titleClear();

            story = randGen.Next(1, 6);

            if (story == 1){
                selectClear();
                wordSetup();
                turtleSetup();
            }
            else if (story == 2)
            {
                selectClear();
                wordSetup();
                loveSetup();
            }
            else if (story == 3)
            {
                selectClear();
                wordSetup();
                timeSetup();
            }
            else if (story == 4)
            {
                selectClear();
                wordSetup();
                fortuneSetup();
            }
            else if (story == 5)
            {
                selectClear();
                wordSetup();
                blankSetup();
            }
        }


        private void turtleButton_Click_1(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
            turtleSetup();
        }
        private void loveButton_Click(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
            loveSetup();
        }
        private void timeButton_Click(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
            timeSetup();
        }
        private void fortuneButton_Click(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
            fortuneSetup();
        }
        private void blankButton_Click_1(object sender, EventArgs e)
        {
            selectClear();
            wordSetup();
            blankSetup();
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
            selectClear();
            titleSetup();
            warningDown();
            wordClear();
            storyPopUp.Visible = false;
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (popUp == 0)
            {
                if (word1Box.Text == null || word1Box.Text == "" || word2Box.Text == null || word2Box.Text == "" || word3Box.Text == null || word3Box.Text == "" || word4Box.Text == null || word4Box.Text == "" || word5Box.Text == null || word5Box.Text == "" || word6Box.Text == null || word6Box.Text == "" || word7Box.Text == null || word7Box.Text == "" || word8Box.Text == null || word8Box.Text == "" || word9Box.Text == null || word9Box.Text == "" || word10Box.Text == null || word10Box.Text == "")
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

                    warningUp();
                    storyPopUp.Visible = true;
                    popUp = 2;
                    confirmButton.Text = "Review my Choices";

                    if (story == 1){
                        turtleStory();
                    }else if (story == 2){

                    }else if (story == 3){

                    }else if (story == 4){

                    }else if (story == 5){

                    }

                }
            }
            else if (popUp == 1)
            {
                warningDown();
                popUp = 0;
                warningPopUp.Visible = false;
                confirmButton.Text = "Confirm my Choices";
                mainButton.Visible = true;
                confirmButton.Location = new Point(confirmButton.Location.X - 77, confirmButton.Location.Y);
            }
            else if (popUp == 2)
            {
                warningDown();
                popUp = 0;
                confirmButton.Text = "Confirm my Choices";
                storyPopUp.Visible = false;
            }
        }
    }
}
