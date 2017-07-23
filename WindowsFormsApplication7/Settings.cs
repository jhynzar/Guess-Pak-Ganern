using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RawInput_dll;

namespace WindowsFormsApplication7
{
    public partial class Settings : Form
    {

        private readonly RawInput _rawinput;
        public static string sourceP1 = "";
        public Settings()
        {
            InitializeComponent();

            _rawinput = new RawInput(Handle,true);

            _rawinput.AddMessageFilter();   // Adding a message filter will cause keypresses to be handled
            Win32.DeviceAudit();            // Writes a file DeviceAudit.txt to the current directory

            _rawinput.KeyPressed += OnKeyPressed;
        }

        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            sourceP1 = e.KeyPressEvent.Source;
            lblKeyboardP1.Text = "\n Source: " + e.KeyPressEvent.Source + "\n\n";
            lblKeyboardP1.Text += e.KeyPressEvent.ToString();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if(!sourceP1.Equals("")){
                Multiplayer.player1 = sourceP1;
                this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please press a Key First.");
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
