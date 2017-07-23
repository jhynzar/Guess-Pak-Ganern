namespace WindowsFormsApplication7
{
    partial class Settings
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
            this.lblKeyboardP1 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeyboardP1
            // 
            this.lblKeyboardP1.AutoSize = true;
            this.lblKeyboardP1.Location = new System.Drawing.Point(24, 24);
            this.lblKeyboardP1.Name = "lblKeyboardP1";
            this.lblKeyboardP1.Size = new System.Drawing.Size(275, 13);
            this.lblKeyboardP1.TabIndex = 2;
            this.lblKeyboardP1.Text = "Please press a key from the keyboard PLAYER1 will use.";
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Transparent;
            this.butSave.FlatAppearance.BorderSize = 0;
            this.butSave.ForeColor = System.Drawing.Color.Transparent;
            this.butSave.Image = global::WindowsFormsApplication7.Properties.Resources.Untitled_3copy;
            this.butSave.Location = new System.Drawing.Point(156, 175);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(169, 58);
            this.butSave.TabIndex = 1;
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.ControlBox = false;
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.lblKeyboardP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyboardP1;
        private System.Windows.Forms.Button butSave;
    }
}