using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {

        bool isConfigured = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            if(SettingsP2.noPlayer2 == true){
                MultiPlayer.Enabled = false;
                MessageBox.Show("Configure the keyboard settings for player 2 to Play in Multiplayer mode.");
            }
            else
            {
                MultiPlayer.Enabled = true;
            }

            pictureBox1.Visible = false;
            Btn_Play.Visible = false;
            SinglePlayer.Visible = true;
            MultiPlayer.Visible = true;
        
        }


        private void SinglePlayer_Click(object sender, EventArgs e)
        {
             Pause g = new Pause();
            this.Hide();
            g.ShowDialog();
        }

        private void MultiPlayer_Click(object sender, EventArgs e)
        {
              Multiplayer m = new Multiplayer();
            this.Hide();
            m.ShowDialog();
        }

        private void s_Close(object sender, FormClosedEventArgs e)
        {
            SettingsP2 s2 = new SettingsP2();
            s2.FormClosed += new FormClosedEventHandler(s2_Close);
            s2.ShowDialog();
        }
        private void s2_Close(object sender, FormClosedEventArgs e)
        {
            this.Show();
            Btn_Play.Enabled = true;

            if(SettingsP2.noPlayer2 == true){
                MultiPlayer.Enabled = false;
            }
            else
            {
                MultiPlayer.Enabled = true;
            }
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.FormClosed += new FormClosedEventHandler(s_Close);
            this.Hide();
            s.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        }
    }

