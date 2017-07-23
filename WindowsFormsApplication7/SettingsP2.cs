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
    public partial class SettingsP2 : Form
    {
        private readonly RawInput _rawinput;
        public static string sourceP2 = "";
        public static bool noPlayer2 = true;
        public SettingsP2()
        {
            InitializeComponent();

            _rawinput = new RawInput(Handle, true);

            _rawinput.AddMessageFilter();   // Adding a message filter will cause keypresses to be handled
            Win32.DeviceAudit();            // Writes a file DeviceAudit.txt to the current directory

            _rawinput.KeyPressed += OnKeyPressed;
        }

        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            sourceP2 = e.KeyPressEvent.Source;
            lblKeyboardP2.Text = "\n Source: " + e.KeyPressEvent.Source + "\n\n";
            lblKeyboardP2.Text += e.KeyPressEvent.ToString();
        }

        private void SettingsP2_Load(object sender, EventArgs e)
        {

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (!sourceP2.Equals("") && (!sourceP2.Equals(Settings.sourceP1)))
            {
                Multiplayer.player2 = sourceP2;
                this.Close();
                noPlayer2 = false;
            }
            else if (sourceP2.Equals(Settings.sourceP1))
            {
                MessageBox.Show("Please use a different keyboard for PLAYER2");
            }
            else
            {
                MessageBox.Show("Please press a Key First.");
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            noPlayer2 = true;
        }

        private void SettingsP2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
