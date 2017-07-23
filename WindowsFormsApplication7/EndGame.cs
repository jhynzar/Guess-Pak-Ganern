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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            
            Score.Text = ""+Pause.score;
            CorrectWords.Text = "" + Pause.correct;
        }

        private void CorrectWords_Click(object sender, EventArgs e)
        {

        }

        private void EndGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
