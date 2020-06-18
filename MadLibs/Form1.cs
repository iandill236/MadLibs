﻿using System;
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
            // make the title look like a title by doing everything below.
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
            // clears the title so it doesnt exist to the user anymore, out of sight out of mind you know?
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
            // lets you choose the bundle of joy that you are about the experience.
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
            // the bundle of joy has been chosen or disregarded and is now gone... you are left to what you have.
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
            // you now have basically complete control of the world you form around you, what choices will you make?
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
            // your choices have been made or disregarded, you will face the consequences of your actions.
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
            // you have made a fool of yourself, you can never turn back, well thats not true you can pretend you cant for the dramatic effect!
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
            // this is irrelevant but regardless if you see this on your screen doom has come to you and you must run, run like your life depends on it.
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

        
        public void turtleSetup()
        {
            // you have chosen the turtle story, do what you will with it.
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
            // what have you done the story is insane your choices their all there, oh my lord!
            storyPopUp.Text = "The " + word1 + " " + word2 + " " + word3 + " " + word4 + " are 4 " + word4 + " who are led ";
            storyPopUp.Text += "by a/an " + word5 + " in the fight against " + word6 + ". They strive to protect " + word7 + " from all ";
            storyPopUp.Text += "violence, but their most " + word8 + " enemy is the dreaded " + word9 + ". They also love ";
            storyPopUp.Text += "to " + word10 + " pizza!";
        }

        public void loveSetup()
        {
            // maybe in this story you will experience joy and love, this is dependent on the choices you make. 
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
        public void loveStory()
        {
            // you wrote a letter to your one to be, will you get a response, i highly doubt it
            storyPopUp.Text = "Dear " + word1 + ",";
            storyPopUp.Text += "\n\nYou are extremely " + word2 + " and I " + word3 + " you! I want to kiss your " + word4 + " " + word5;
            storyPopUp.Text += " times. You make my " + word6 + " burn with desire. When I first saw you, I " + word7 + " stared at you and ";
            storyPopUp.Text += "fell in love. Will you " + word8 + " out with me?";
            storyPopUp.Text += "\n\nYours forever, " + word9;
            storyPopUp.Text += "\n\nP.S.: Don't let your parents keep our love away, " + word10 + " are just jealous.";
        }

        public void timeSetup()
        {
            //time is running out read this fast and give us 100%
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
        public void timeStory()
        {
            // fight and thrive, will you survive the day, that depends on your choices
            storyPopUp.Text = "Once upon a time, there was a " + word1 + " called " + word2 + ". Their parents would describe ";
            storyPopUp.Text += "them as " + word3 + ", but all of their friends thought they were really " + word4 + ". ";
            storyPopUp.Text += "One day, a " + word5 + " " + word6 + " came to " + word2 + " and said, 'I hate ";
            storyPopUp.Text += word7 + "!' This made " + word2 + " really " + word8 + ", since they really liked " + word7;
            storyPopUp.Text += ". So " + word2 + " used their signature move, 'The " + word9 + "' on the " + word6;
            storyPopUp.Text += ". This made them so " + word10 + " that they screamed, 'I love " + word7 + "!', making " + word2 + " the hero of the day!";
        }

        public void fortuneSetup()
        {
            // Money money money make the right choices
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
        public void fortuneStory()
        {
            // This cookie holds your life! it has immense power! be afraid of it!
            storyPopUp.Text = "~~" + word1 + " " + word2 + " without being " + word3 + ".~~";
            storyPopUp.Text += "\n\n~~The universe does not have " + word4 + " -- it has~~";
            storyPopUp.Text += "\n~~" + word5 + ", and " + word5 + " can be " + word6 + ".~~";
            storyPopUp.Text += "\n\n~~The " + word7 + " of random " + word8 + "~~";
            storyPopUp.Text += "\n~~is too important to be left to chance.~~";
            storyPopUp.Text += "\n\n~~You can build a " + word9 + " with " + word10 + "~~";
            storyPopUp.Text += "\n~~but you can't sit on it for long.~~";
            storyPopUp.Text += "\n\nYour Lucky Numbers: 1, 2, 28, 37, 38, 46";
        }

        public void BlankSetup()
        {
            // Blank ball
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
        public void BlankStory()
        {
            // SCOOOOOORE did you make it?
            storyPopUp.Text = word1 + "ball is a very exciting sport. Whether you are " + word2 + " the ball with a ";
            storyPopUp.Text += word3 + ", or you are the " + word4 + " and striking out " + word5 + " batters in a row, you'll be having ";
            storyPopUp.Text += "fun. You can also be the catcher, standing at " + word6 + " plate, ready to " + word7 + " the next person ";
            storyPopUp.Text += "as they try to make it to " + word6 + ". But the best part of it is when someone hits a ";
            storyPopUp.Text += word8 + " slam when all the " + word9 + " are loaded during the last " + word10 + " to win the game.";
        }


        private void randButton_Click(object sender, EventArgs e)
        {
            // chooses your destiny for you, nerd.
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
                BlankSetup();
            }
        }


        private void turtleButton_Click_1(object sender, EventArgs e)
        {
            // you have chosen the turtle demise
            selectClear();
            wordSetup();
            turtleSetup();
        }
        private void loveButton_Click(object sender, EventArgs e)
        {
            // they dont love you stop trying, also it means you chose the love story
            selectClear();
            wordSetup();
            loveSetup();
        }
        private void timeButton_Click(object sender, EventArgs e)
        {
            // the world needs you, wake up! also it means you chose the time story
            selectClear();
            wordSetup();
            timeSetup();
        }
        private void fortuneButton_Click(object sender, EventArgs e)
        {
            // this cookie cant wake you up keep trying! also it means you chose the fortune story
            selectClear();
            wordSetup();
            fortuneSetup();
        }
        private void blankButton_Click_1(object sender, EventArgs e)
        {
            // Hit the ball all you want, wake up! also it means you chose the blankball story
            selectClear();
            wordSetup();
            BlankSetup();
        }


        private void selectButton_Click(object sender, EventArgs e)
        {
            // you choose your fate, choose wisely or else you may regret it
            titleClear();
            selectSetup();
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            // a wise choice, do not dabble in the magics of fate
            Environment.Exit(1);
        }
        private void mainButton_Click(object sender, EventArgs e)
        {
            // you may be rethinking your decisions? this brings you back to your main menu gateway
            selectClear();
            titleSetup();
            warningDown();
            wordClear();
            storyPopUp.Visible = false;
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            // your choices are confirmed, do you regret them? you can still go back.
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
                        loveStory();
                    }else if (story == 3){
                        timeStory();
                    }else if (story == 4){
                        fortuneStory();
                    }else if (story == 5){
                        BlankStory();
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
