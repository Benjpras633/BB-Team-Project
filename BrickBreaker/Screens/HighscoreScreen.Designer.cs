﻿namespace BrickBreaker
{
    partial class HighscoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.highscoresLabel2 = new System.Windows.Forms.Label();
            this.highscoresLabel1 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // highscoresLabel2
            // 
            this.highscoresLabel2.Location = new System.Drawing.Point(577, 216);
            this.highscoresLabel2.Name = "highscoresLabel2";
            this.highscoresLabel2.Size = new System.Drawing.Size(374, 285);
            this.highscoresLabel2.TabIndex = 7;
            this.highscoresLabel2.Text = "label1";
            // 
            // highscoresLabel1
            // 
            this.highscoresLabel1.Location = new System.Drawing.Point(94, 216);
            this.highscoresLabel1.Name = "highscoresLabel1";
            this.highscoresLabel1.Size = new System.Drawing.Size(374, 285);
            this.highscoresLabel1.TabIndex = 6;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(84)))));
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(33)))));
            this.returnButton.FlatAppearance.BorderSize = 5;
            this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(139)))), ((int)(((byte)(73)))));
            this.returnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(139)))), ((int)(((byte)(73)))));
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(33)))));
            this.returnButton.Location = new System.Drawing.Point(829, 587);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(179, 76);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "RETURN\r\n";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BrickBreaker.Properties.Resources.highscoreBorder;
            this.pictureBox2.Location = new System.Drawing.Point(33, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(975, 415);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BrickBreaker.Properties.Resources.highscoresTitle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 119);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.highscoresLabel2);
            this.Controls.Add(this.highscoresLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HighscoreScreen";
            this.Size = new System.Drawing.Size(1067, 677);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label highscoresLabel2;
        private System.Windows.Forms.Label highscoresLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button returnButton;
    }
}
