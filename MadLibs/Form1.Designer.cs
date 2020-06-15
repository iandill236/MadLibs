namespace MadLibs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.randButton = new System.Windows.Forms.Button();
            this.titleSmile = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.blankButton = new System.Windows.Forms.Button();
            this.loveButton = new System.Windows.Forms.Button();
            this.turtleButton = new System.Windows.Forms.Button();
            this.timeButton = new System.Windows.Forms.Button();
            this.fortuneButton = new System.Windows.Forms.Button();
            this.warningPopUp = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.word1Label = new System.Windows.Forms.Label();
            this.word1Box = new System.Windows.Forms.TextBox();
            this.word5Label = new System.Windows.Forms.Label();
            this.word10Label = new System.Windows.Forms.Label();
            this.word9Label = new System.Windows.Forms.Label();
            this.word8Label = new System.Windows.Forms.Label();
            this.word7Label = new System.Windows.Forms.Label();
            this.word6Label = new System.Windows.Forms.Label();
            this.word4Label = new System.Windows.Forms.Label();
            this.word3Label = new System.Windows.Forms.Label();
            this.word2Label = new System.Windows.Forms.Label();
            this.word9Box = new System.Windows.Forms.TextBox();
            this.word8Box = new System.Windows.Forms.TextBox();
            this.word7Box = new System.Windows.Forms.TextBox();
            this.word6Box = new System.Windows.Forms.TextBox();
            this.word5Box = new System.Windows.Forms.TextBox();
            this.word4Box = new System.Windows.Forms.TextBox();
            this.word3Box = new System.Windows.Forms.TextBox();
            this.word2Box = new System.Windows.Forms.TextBox();
            this.word10Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(508, 137);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Mad Libs";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(28, 107);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(492, 23);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "By Ian Dill and Drew Johnson";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // randButton
            // 
            this.randButton.BackColor = System.Drawing.Color.LightCyan;
            this.randButton.FlatAppearance.BorderSize = 0;
            this.randButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.randButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.randButton.Location = new System.Drawing.Point(199, 198);
            this.randButton.Name = "randButton";
            this.randButton.Size = new System.Drawing.Size(148, 59);
            this.randButton.TabIndex = 3;
            this.randButton.Text = "Random\r\nStory";
            this.randButton.UseVisualStyleBackColor = false;
            this.randButton.Click += new System.EventHandler(this.randButton_Click);
            // 
            // titleSmile
            // 
            this.titleSmile.Image = global::MadLibs.Properties.Resources.Title_Smile;
            this.titleSmile.Location = new System.Drawing.Point(-3, 334);
            this.titleSmile.Name = "titleSmile";
            this.titleSmile.Size = new System.Drawing.Size(203, 170);
            this.titleSmile.TabIndex = 2;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.LightCyan;
            this.selectButton.FlatAppearance.BorderSize = 0;
            this.selectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectButton.Location = new System.Drawing.Point(199, 291);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(148, 59);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "Select\r\nStory";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.LightCoral;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quitButton.Location = new System.Drawing.Point(199, 384);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(148, 59);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.LightCoral;
            this.mainButton.FlatAppearance.BorderSize = 0;
            this.mainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.mainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainButton.Location = new System.Drawing.Point(290, 375);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(153, 107);
            this.mainButton.TabIndex = 7;
            this.mainButton.Text = "Return to Main Menu";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Visible = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // blankButton
            // 
            this.blankButton.BackColor = System.Drawing.Color.LightCyan;
            this.blankButton.FlatAppearance.BorderSize = 0;
            this.blankButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.blankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blankButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blankButton.Location = new System.Drawing.Point(86, 375);
            this.blankButton.Name = "blankButton";
            this.blankButton.Size = new System.Drawing.Size(153, 107);
            this.blankButton.TabIndex = 8;
            this.blankButton.Text = "Story 5:\r\nBlankball";
            this.blankButton.UseVisualStyleBackColor = false;
            this.blankButton.Visible = false;
            this.blankButton.Click += new System.EventHandler(this.blankButton_Click_1);
            // 
            // loveButton
            // 
            this.loveButton.BackColor = System.Drawing.Color.LightCyan;
            this.loveButton.FlatAppearance.BorderSize = 0;
            this.loveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.loveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loveButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loveButton.Location = new System.Drawing.Point(290, 149);
            this.loveButton.Name = "loveButton";
            this.loveButton.Size = new System.Drawing.Size(153, 107);
            this.loveButton.TabIndex = 10;
            this.loveButton.Text = "Story 2:\r\nLove Letter";
            this.loveButton.UseVisualStyleBackColor = false;
            this.loveButton.Visible = false;
            this.loveButton.Click += new System.EventHandler(this.loveButton_Click);
            // 
            // turtleButton
            // 
            this.turtleButton.BackColor = System.Drawing.Color.LightCyan;
            this.turtleButton.FlatAppearance.BorderSize = 0;
            this.turtleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.turtleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turtleButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turtleButton.Location = new System.Drawing.Point(86, 149);
            this.turtleButton.Name = "turtleButton";
            this.turtleButton.Size = new System.Drawing.Size(153, 107);
            this.turtleButton.TabIndex = 11;
            this.turtleButton.Text = "Story 1:\r\nRip-Off Ninja Turtles";
            this.turtleButton.UseVisualStyleBackColor = false;
            this.turtleButton.Visible = false;
            this.turtleButton.Click += new System.EventHandler(this.turtleButton_Click_1);
            // 
            // timeButton
            // 
            this.timeButton.BackColor = System.Drawing.Color.LightCyan;
            this.timeButton.FlatAppearance.BorderSize = 0;
            this.timeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.timeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeButton.Location = new System.Drawing.Point(86, 262);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(153, 107);
            this.timeButton.TabIndex = 12;
            this.timeButton.Text = "Story 3:\r\n Once Upon a Time";
            this.timeButton.UseVisualStyleBackColor = false;
            this.timeButton.Visible = false;
            this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
            // 
            // fortuneButton
            // 
            this.fortuneButton.BackColor = System.Drawing.Color.LightCyan;
            this.fortuneButton.FlatAppearance.BorderSize = 0;
            this.fortuneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.fortuneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fortuneButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fortuneButton.Location = new System.Drawing.Point(290, 262);
            this.fortuneButton.Name = "fortuneButton";
            this.fortuneButton.Size = new System.Drawing.Size(153, 107);
            this.fortuneButton.TabIndex = 13;
            this.fortuneButton.Text = "Story 4:\r\n Fortune Cookies";
            this.fortuneButton.UseVisualStyleBackColor = false;
            this.fortuneButton.Visible = false;
            this.fortuneButton.Click += new System.EventHandler(this.fortuneButton_Click);
            // 
            // warningPopUp
            // 
            this.warningPopUp.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningPopUp.Location = new System.Drawing.Point(13, 9);
            this.warningPopUp.Name = "warningPopUp";
            this.warningPopUp.Size = new System.Drawing.Size(507, 360);
            this.warningPopUp.TabIndex = 14;
            this.warningPopUp.Text = "Uh oh! An error occurred!\r\n\r\nPlease make sure all boxes are filled before continu" +
    "ing to the story.";
            this.warningPopUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningPopUp.Visible = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.LightGreen;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmButton.Location = new System.Drawing.Point(86, 375);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(153, 107);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "Confirm my Choices\r\n";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // word1Label
            // 
            this.word1Label.BackColor = System.Drawing.Color.Transparent;
            this.word1Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word1Label.Location = new System.Drawing.Point(16, 37);
            this.word1Label.Name = "word1Label";
            this.word1Label.Size = new System.Drawing.Size(223, 23);
            this.word1Label.TabIndex = 16;
            this.word1Label.Text = "label1";
            this.word1Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word1Label.Visible = false;
            // 
            // word1Box
            // 
            this.word1Box.Location = new System.Drawing.Point(245, 40);
            this.word1Box.Name = "word1Box";
            this.word1Box.Size = new System.Drawing.Size(232, 22);
            this.word1Box.TabIndex = 17;
            this.word1Box.Visible = false;
            // 
            // word5Label
            // 
            this.word5Label.BackColor = System.Drawing.Color.Transparent;
            this.word5Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word5Label.Location = new System.Drawing.Point(16, 160);
            this.word5Label.Name = "word5Label";
            this.word5Label.Size = new System.Drawing.Size(223, 23);
            this.word5Label.TabIndex = 19;
            this.word5Label.Text = "label1";
            this.word5Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word5Label.Visible = false;
            // 
            // word10Label
            // 
            this.word10Label.BackColor = System.Drawing.Color.Transparent;
            this.word10Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word10Label.Location = new System.Drawing.Point(16, 327);
            this.word10Label.Name = "word10Label";
            this.word10Label.Size = new System.Drawing.Size(223, 23);
            this.word10Label.TabIndex = 20;
            this.word10Label.Text = "label1";
            this.word10Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word10Label.Visible = false;
            // 
            // word9Label
            // 
            this.word9Label.BackColor = System.Drawing.Color.Transparent;
            this.word9Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word9Label.Location = new System.Drawing.Point(16, 291);
            this.word9Label.Name = "word9Label";
            this.word9Label.Size = new System.Drawing.Size(223, 23);
            this.word9Label.TabIndex = 21;
            this.word9Label.Text = "label1";
            this.word9Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word9Label.Visible = false;
            // 
            // word8Label
            // 
            this.word8Label.BackColor = System.Drawing.Color.Transparent;
            this.word8Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word8Label.Location = new System.Drawing.Point(16, 259);
            this.word8Label.Name = "word8Label";
            this.word8Label.Size = new System.Drawing.Size(223, 23);
            this.word8Label.TabIndex = 22;
            this.word8Label.Text = "label1";
            this.word8Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word8Label.Visible = false;
            // 
            // word7Label
            // 
            this.word7Label.BackColor = System.Drawing.Color.Transparent;
            this.word7Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word7Label.Location = new System.Drawing.Point(16, 224);
            this.word7Label.Name = "word7Label";
            this.word7Label.Size = new System.Drawing.Size(223, 23);
            this.word7Label.TabIndex = 23;
            this.word7Label.Text = "label1";
            this.word7Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word7Label.Visible = false;
            // 
            // word6Label
            // 
            this.word6Label.BackColor = System.Drawing.Color.Transparent;
            this.word6Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word6Label.Location = new System.Drawing.Point(16, 190);
            this.word6Label.Name = "word6Label";
            this.word6Label.Size = new System.Drawing.Size(223, 23);
            this.word6Label.TabIndex = 24;
            this.word6Label.Text = "label1";
            this.word6Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word6Label.Visible = false;
            // 
            // word4Label
            // 
            this.word4Label.BackColor = System.Drawing.Color.Transparent;
            this.word4Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word4Label.Location = new System.Drawing.Point(16, 130);
            this.word4Label.Name = "word4Label";
            this.word4Label.Size = new System.Drawing.Size(223, 23);
            this.word4Label.TabIndex = 25;
            this.word4Label.Text = "label1";
            this.word4Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word4Label.Visible = false;
            // 
            // word3Label
            // 
            this.word3Label.BackColor = System.Drawing.Color.Transparent;
            this.word3Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word3Label.Location = new System.Drawing.Point(16, 100);
            this.word3Label.Name = "word3Label";
            this.word3Label.Size = new System.Drawing.Size(223, 23);
            this.word3Label.TabIndex = 26;
            this.word3Label.Text = "label1";
            this.word3Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word3Label.Visible = false;
            // 
            // word2Label
            // 
            this.word2Label.BackColor = System.Drawing.Color.Transparent;
            this.word2Label.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2Label.Location = new System.Drawing.Point(16, 69);
            this.word2Label.Name = "word2Label";
            this.word2Label.Size = new System.Drawing.Size(223, 23);
            this.word2Label.TabIndex = 27;
            this.word2Label.Text = "label1";
            this.word2Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.word2Label.Visible = false;
            // 
            // word9Box
            // 
            this.word9Box.Location = new System.Drawing.Point(245, 292);
            this.word9Box.Name = "word9Box";
            this.word9Box.Size = new System.Drawing.Size(232, 22);
            this.word9Box.TabIndex = 28;
            this.word9Box.Visible = false;
            // 
            // word8Box
            // 
            this.word8Box.Location = new System.Drawing.Point(245, 259);
            this.word8Box.Name = "word8Box";
            this.word8Box.Size = new System.Drawing.Size(232, 22);
            this.word8Box.TabIndex = 29;
            this.word8Box.Visible = false;
            // 
            // word7Box
            // 
            this.word7Box.Location = new System.Drawing.Point(245, 224);
            this.word7Box.Name = "word7Box";
            this.word7Box.Size = new System.Drawing.Size(232, 22);
            this.word7Box.TabIndex = 30;
            this.word7Box.Visible = false;
            // 
            // word6Box
            // 
            this.word6Box.Location = new System.Drawing.Point(245, 193);
            this.word6Box.Name = "word6Box";
            this.word6Box.Size = new System.Drawing.Size(232, 22);
            this.word6Box.TabIndex = 31;
            this.word6Box.Visible = false;
            // 
            // word5Box
            // 
            this.word5Box.Location = new System.Drawing.Point(245, 161);
            this.word5Box.Name = "word5Box";
            this.word5Box.Size = new System.Drawing.Size(232, 22);
            this.word5Box.TabIndex = 32;
            this.word5Box.Visible = false;
            // 
            // word4Box
            // 
            this.word4Box.Location = new System.Drawing.Point(245, 133);
            this.word4Box.Name = "word4Box";
            this.word4Box.Size = new System.Drawing.Size(232, 22);
            this.word4Box.TabIndex = 33;
            this.word4Box.Visible = false;
            // 
            // word3Box
            // 
            this.word3Box.Location = new System.Drawing.Point(245, 100);
            this.word3Box.Name = "word3Box";
            this.word3Box.Size = new System.Drawing.Size(232, 22);
            this.word3Box.TabIndex = 34;
            this.word3Box.Visible = false;
            // 
            // word2Box
            // 
            this.word2Box.Location = new System.Drawing.Point(245, 68);
            this.word2Box.Name = "word2Box";
            this.word2Box.Size = new System.Drawing.Size(232, 22);
            this.word2Box.TabIndex = 35;
            this.word2Box.Visible = false;
            // 
            // word10Box
            // 
            this.word10Box.Location = new System.Drawing.Point(245, 330);
            this.word10Box.Name = "word10Box";
            this.word10Box.Size = new System.Drawing.Size(232, 22);
            this.word10Box.TabIndex = 37;
            this.word10Box.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(532, 503);
            this.Controls.Add(this.warningPopUp);
            this.Controls.Add(this.word10Box);
            this.Controls.Add(this.word2Box);
            this.Controls.Add(this.word3Box);
            this.Controls.Add(this.word4Box);
            this.Controls.Add(this.word5Box);
            this.Controls.Add(this.word6Box);
            this.Controls.Add(this.word7Box);
            this.Controls.Add(this.word8Box);
            this.Controls.Add(this.word9Box);
            this.Controls.Add(this.word2Label);
            this.Controls.Add(this.word3Label);
            this.Controls.Add(this.word4Label);
            this.Controls.Add(this.word6Label);
            this.Controls.Add(this.word7Label);
            this.Controls.Add(this.word8Label);
            this.Controls.Add(this.word9Label);
            this.Controls.Add(this.word10Label);
            this.Controls.Add(this.word5Label);
            this.Controls.Add(this.word1Box);
            this.Controls.Add(this.word1Label);
            this.Controls.Add(this.fortuneButton);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.turtleButton);
            this.Controls.Add(this.loveButton);
            this.Controls.Add(this.blankButton);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.randButton);
            this.Controls.Add(this.titleSmile);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.confirmButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label titleSmile;
        private System.Windows.Forms.Button randButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button blankButton;
        private System.Windows.Forms.Button loveButton;
        private System.Windows.Forms.Button turtleButton;
        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.Button fortuneButton;
        private System.Windows.Forms.Label warningPopUp;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label word1Label;
        private System.Windows.Forms.TextBox word1Box;
        private System.Windows.Forms.Label word5Label;
        private System.Windows.Forms.Label word10Label;
        private System.Windows.Forms.Label word9Label;
        private System.Windows.Forms.Label word8Label;
        private System.Windows.Forms.Label word7Label;
        private System.Windows.Forms.Label word6Label;
        private System.Windows.Forms.Label word4Label;
        private System.Windows.Forms.Label word3Label;
        private System.Windows.Forms.Label word2Label;
        private System.Windows.Forms.TextBox word9Box;
        private System.Windows.Forms.TextBox word8Box;
        private System.Windows.Forms.TextBox word7Box;
        private System.Windows.Forms.TextBox word6Box;
        private System.Windows.Forms.TextBox word5Box;
        private System.Windows.Forms.TextBox word4Box;
        private System.Windows.Forms.TextBox word3Box;
        private System.Windows.Forms.TextBox word2Box;
        private System.Windows.Forms.TextBox word10Box;
    }
}

