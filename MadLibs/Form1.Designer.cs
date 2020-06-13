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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(532, 503);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

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
    }
}

