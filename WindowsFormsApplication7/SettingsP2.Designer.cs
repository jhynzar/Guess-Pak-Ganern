namespace WindowsFormsApplication7
{
    partial class SettingsP2
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
            this.lblKeyboardP2 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeyboardP2
            // 
            this.lblKeyboardP2.AutoSize = true;
            this.lblKeyboardP2.Location = new System.Drawing.Point(31, 27);
            this.lblKeyboardP2.Name = "lblKeyboardP2";
            this.lblKeyboardP2.Size = new System.Drawing.Size(275, 13);
            this.lblKeyboardP2.TabIndex = 0;
            this.lblKeyboardP2.Text = "Please press a key from the keyboard PLAYER2 will use.";
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Transparent;
            this.butSave.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.saveee;
            this.butSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.ForeColor = System.Drawing.Color.DarkOrange;
            this.butSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butSave.Location = new System.Drawing.Point(68, 175);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(169, 58);
            this.butSave.TabIndex = 1;
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.Transparent;
            this.butCancel.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.NoPlayer2;
            this.butCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.ForeColor = System.Drawing.Color.DarkOrange;
            this.butCancel.Location = new System.Drawing.Point(271, 175);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(169, 58);
            this.butCancel.TabIndex = 2;
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // SettingsP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication7.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.lblKeyboardP2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsP2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsP2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsP2_FormClosed);
            this.Load += new System.EventHandler(this.SettingsP2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyboardP2;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
    }
}