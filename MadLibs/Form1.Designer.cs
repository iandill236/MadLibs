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
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(508, 98);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(532, 503);
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
    }
}

