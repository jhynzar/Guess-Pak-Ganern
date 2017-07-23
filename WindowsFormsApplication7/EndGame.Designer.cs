namespace WindowsFormsApplication7
{
    partial class EndGame
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
            this.Score = new System.Windows.Forms.Label();
            this.CorrectWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(118, 70);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(110, 128);
            this.Score.TabIndex = 25;
            this.Score.Text = "0";
            // 
            // CorrectWords
            // 
            this.CorrectWords.AutoSize = true;
            this.CorrectWords.BackColor = System.Drawing.Color.Transparent;
            this.CorrectWords.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectWords.ForeColor = System.Drawing.Color.White;
            this.CorrectWords.Location = new System.Drawing.Point(215, 199);
            this.CorrectWords.Name = "CorrectWords";
            this.CorrectWords.Size = new System.Drawing.Size(165, 128);
            this.CorrectWords.TabIndex = 26;
            this.CorrectWords.Text = "88";
            this.CorrectWords.Click += new System.EventHandler(this.CorrectWords_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.EndGamePanel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 418);
            this.Controls.Add(this.CorrectWords);
            this.Controls.Add(this.Score);
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EndGame_FormClosed);
            this.Load += new System.EventHandler(this.EndGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label CorrectWords;
    }
}