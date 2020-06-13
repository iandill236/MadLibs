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

        private void selectButton_Click(object sender, EventArgs e)
        {
            titleClear();
            selectSetup();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
