namespace WindowsFormsApplication7
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
            this.Btn_Play = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SinglePlayer = new System.Windows.Forms.Button();
            this.MultiPlayer = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Play.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.playbutton2;
            this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Play.FlatAppearance.BorderSize = 0;
            this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Play.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Play.Location = new System.Drawing.Point(83, 330);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(216, 126);
            this.Btn_Play.TabIndex = 1;
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication7.Properties.Resources.pak2;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 321);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SinglePlayer
            // 
            this.SinglePlayer.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources._1player;
            this.SinglePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SinglePlayer.Location = new System.Drawing.Point(111, 132);
            this.SinglePlayer.Name = "SinglePlayer";
            this.SinglePlayer.Size = new System.Drawing.Size(144, 42);
            this.SinglePlayer.TabIndex = 2;
            this.SinglePlayer.UseVisualStyleBackColor = true;
            this.SinglePlayer.Visible = false;
            this.SinglePlayer.Click += new System.EventHandler(this.SinglePlayer_Click);
            // 
            // MultiPlayer
            // 
            this.MultiPlayer.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources._2Player;
            this.MultiPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MultiPlayer.Location = new System.Drawing.Point(111, 220);
            this.MultiPlayer.Name = "MultiPlayer";
            this.MultiPlayer.Size = new System.Drawing.Size(144, 42);
            this.MultiPlayer.TabIndex = 3;
            this.MultiPlayer.UseVisualStyleBackColor = true;
            this.MultiPlayer.Visible = false;
            this.MultiPlayer.Click += new System.EventHandler(this.MultiPlayer_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.setting2;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.Color.Transparent;
            this.Settings.Location = new System.Drawing.Point(125, 472);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(141, 42);
            this.Settings.TabIndex = 4;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.bg21;
            this.ClientSize = new System.Drawing.Size(373, 541);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.MultiPlayer);
            this.Controls.Add(this.SinglePlayer);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Button SinglePlayer;
        private System.Windows.Forms.Button MultiPlayer;
        private System.Windows.Forms.Button Settings;
    }
}

