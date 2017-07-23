using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RawInput_dll;

namespace WindowsFormsApplication7
{
 
    public partial class Pause : Form
    {
        int min;
        int sec;
        WordsReader wr;
        private readonly RawInput _rawinput;


        int openLetterCtr = 0;
        int showAnsCtr = 0;


        public Pause()
        {
            InitializeComponent();

            //Mj Code
            wr = new WordsReader();


            //For EVENT
            _rawinput = new RawInput(Handle, true);

            _rawinput.AddMessageFilter();   // Adding a message filter will cause keypresses to be handled
            Win32.DeviceAudit();            // Writes a file DeviceAudit.txt to the current directory

            _rawinput.KeyPressed += Game_KeyPress;
            //END


            timer1.Start();
            Timelimit.Start();
            Gameflow.Start();

        }
        public void showCorrectAnswer()
        {
            Hint1.Text = hint1;
            Hint2.Text = hint2;
            Hint3.Text = hint3;
            Hint4.Text = hint4;
        }




       public static string guess = "TAPIRUU";
       public static string hint1 = "pogi";
       public static string hint2 = "cute";
       public static string hint3 = "tangkad";
       public static string hint4 = "macho";
        public static int A = 0;
        public static int B = 0;
        public static int C = 0;
        public static int D = 0;
        public static int E = 0;
        public static int F = 0;
        public static int G = 0;
        public static int H = 0;
        public static int I = 0;
        public static int J = 0;
        public static int K = 0;
        public static int L = 0;
        public static int M = 0;
        public static int N = 0;
        public static int O = 0;
        public static int P = 0;
        public static int Q = 0;
        public static int R = 0;
        public static int S = 0;
        public static int T = 0;
        public static int U = 0;
        public static int V = 0;
        public static int W = 0;
        public static int X = 0;
        public static int Y = 0;
        public static int Z = 0;
        public static int score =0;
        public static int level = 1;
        public static int correct = 0;

        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }

        public void GuessWord()
        {

            if (guess.Length == 2)
            {
                Answerbox1.Visible = true;
                Answerbox2.Visible = true;
                Answerbox1.Location = new System.Drawing.Point(164, 476);
                Answerbox2.Location = new System.Drawing.Point(209, 476);
            }
           else if (guess.Length == 3)
            {
                Answerbox1.Visible = true;
                Answerbox2.Visible = true;
                Answerbox3.Visible = true;
                Answerbox1.Location = new System.Drawing.Point(133, 476);
                Answerbox2.Location = new System.Drawing.Point(178, 476);
                Answerbox3.Location = new System.Drawing.Point(223, 476);
            }
           else if (guess.Length == 4)
            {
                Answerbox1.Visible = true;
                Answerbox2.Visible = true;
                Answerbox3.Visible = true;
                Answerbox4.Visible = true;
                Answerbox1.Location = new System.Drawing.Point(112, 476);
                Answerbox2.Location = new System.Drawing.Point(157, 476);
                Answerbox3.Location = new System.Drawing.Point(202, 476);
                Answerbox4.Location = new System.Drawing.Point(247, 476);
            }
            else if (guess.Length == 5)
            {
                Answerbox1.Visible = true;
                Answerbox2.Visible = true;
                Answerbox3.Visible = true;
                Answerbox4.Visible = true;
                Answerbox5.Visible = true;
                Answerbox1.Location = new System.Drawing.Point(86, 476);
                Answerbox2.Location = new System.Drawing.Point(131, 476);
                Answerbox3.Location = new System.Drawing.Point(176, 476);
                Answerbox4.Location = new System.Drawing.Point(221, 476);
                Answerbox5.Location = new System.Drawing.Point(266, 476);
            }
            else if (guess.Length == 6)
            {
                Answerbox1.Visible = true;
                Answerbox2.Visible = true;
                Answerbox3.Visible = true;
                Answerbox4.Visible = true;
                Answerbox5.Visible = true;
                Answerbox6.Visible = true;
                Answerbox1.Location = new System.Drawing.Point(61, 476);
                Answerbox2.Location = new System.Drawing.Point(106, 476);
                Answerbox3.Location = new System.Drawing.Point(151, 476);
                Answerbox4.Location = new System.Drawing.Point(196, 476);
                Answerbox5.Location = new System.Drawing.Point(241, 476);
                Answerbox6.Location = new System.Drawing.Point(286, 476);
            }
            else if (guess.Length ==7 )
            {
                Answerbox1.Visible = true;
                Answerbox2.Visible = true;
                Answerbox3.Visible = true;
                Answerbox4.Visible = true;
                Answerbox5.Visible = true;
                Answerbox6.Visible = true;
                Answerbox7.Visible = true;
                Answerbox1.Location = new System.Drawing.Point(47, 476);
                Answerbox2.Location = new System.Drawing.Point(92, 476);
                Answerbox3.Location = new System.Drawing.Point(137, 476);
                Answerbox4.Location = new System.Drawing.Point(182, 476);
                Answerbox5.Location = new System.Drawing.Point(227, 476);
                Answerbox6.Location = new System.Drawing.Point(272, 476);
                Answerbox7.Location = new System.Drawing.Point(317, 476);
            }
            else if (guess.Length == 8)
            {
                Answerbox1.Visible = true;
                Answerbox2.Visible = true;
                Answerbox3.Visible = true;
                Answerbox4.Visible = true;
                Answerbox5.Visible = true;
                Answerbox6.Visible = true;
                Answerbox7.Visible = true;
                Answerbox8.Visible = true;
                Answerbox1.Location = new System.Drawing.Point(26, 476);
                Answerbox2.Location = new System.Drawing.Point(71, 476);
                Answerbox3.Location = new System.Drawing.Point(116, 476);
                Answerbox4.Location = new System.Drawing.Point(161, 476);
                Answerbox5.Location = new System.Drawing.Point(206, 476);
                Answerbox6.Location = new System.Drawing.Point(251, 476);
                Answerbox7.Location = new System.Drawing.Point(296, 476);
                Answerbox8.Location = new System.Drawing.Point(341, 476);
            }
            else if (guess.Length == 9)
            {
                Answerbox1.Visible = true;
                Answerbox2.Visible = true;
                Answerbox3.Visible = true;
                Answerbox4.Visible = true;
                Answerbox5.Visible = true;
                Answerbox6.Visible = true;
                Answerbox7.Visible = true;
                Answerbox8.Visible = true;
                Answerbox9.Visible = true;
                Answerbox1.Location = new System.Drawing.Point(7, 476);
                Answerbox2.Location = new System.Drawing.Point(52, 476);
                Answerbox3.Location = new System.Drawing.Point(97, 476);
                Answerbox4.Location = new System.Drawing.Point(142, 476);
                Answerbox5.Location = new System.Drawing.Point(187, 476);
                Answerbox6.Location = new System.Drawing.Point(232, 476);
                Answerbox7.Location = new System.Drawing.Point(277, 476);
                Answerbox8.Location = new System.Drawing.Point(321, 476);
                Answerbox9.Location = new System.Drawing.Point(364, 476);
            }
            else if (guess.Length == 10)
            {
                Answerbox1.Visible = true;
                Answerbox2.Visible = true;
                Answerbox3.Visible = true;
                Answerbox4.Visible = true;
                Answerbox5.Visible = true;
                Answerbox6.Visible = true;
                Answerbox7.Visible = true;
                Answerbox8.Visible = true;
                Answerbox9.Visible = true;
                Answerbox10.Visible = true;
                Answerbox1.Location = new System.Drawing.Point(4, 476);
                Answerbox2.Location = new System.Drawing.Point(45, 476);
                Answerbox3.Location = new System.Drawing.Point(86, 476);
                Answerbox4.Location = new System.Drawing.Point(126, 476);
                Answerbox5.Location = new System.Drawing.Point(166, 476);
                Answerbox6.Location = new System.Drawing.Point(206, 476);
                Answerbox7.Location = new System.Drawing.Point(246, 476);
                Answerbox8.Location = new System.Drawing.Point(286, 476);
                Answerbox9.Location = new System.Drawing.Point(326, 476);
                Answerbox10.Location = new System.Drawing.Point(366, 476);
            }

        }

        public void NextLevel() {
            Btn_Nxt.Visible = false;
            Btn_Nxt.Location = new System.Drawing.Point(-197, 455);
            string[] wordAndHints = wr.getRandomWord();
           
            guess = wordAndHints[0];
            hint1 = wordAndHints[1];
            hint2 = wordAndHints[2];
            hint3 = wordAndHints[3];
            hint4 = wordAndHints[4];
            GuessWord();
            Gameflow.Start();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            Hint1.Text = hint1;
            Hint2.Text = "";
            Hint3.Text = "";
            Hint4.Text = "";
          A = 0;
          B = 0;
          C = 0;
          D = 0;
          E = 0;
          F = 0;
          G = 0;
          H = 0;
          I = 0;
          J = 0;
          K = 0;
          L = 0;
          M = 0;
          N = 0;
          O = 0;
          P = 0;
          Q = 0;
          R = 0;
          S = 0;
          T = 0;
          U = 0;
          V = 0;
          W = 0;
          X = 0;
          Y = 0;
          Z = 0;

    }
        public void scoringsystem() {
            if (Hint2.Text == "")
            {
                score = score + 5;
            }
            if (Hint3.Text == "")
            {
                score = score + 5;
            }
            if (Hint4.Text == "")
            {
                score = score + 5;
            }
            if (score < 10)
            {
                score = score + 10;
                label8.Text = "" + score;
            }
            else if (score >= 10 && score < 100)
            {
                score = score + 10;
                label8.Text = "" + score;
            }
            else if (score >= 100 && score < 1000)
            {
                score = score + 10;
                label8.Text = "" + score;
            }
            else if (score >= 1000)
            {
                score = score + 10;
                label8.Text = "" + score;

            }
        }

        private void Game_KeyPress(object sender, RawInputEventArg e)
        {
            SoundPlayer wrong = new SoundPlayer(Properties.Resources.WALEYsound);
            SoundPlayer correct = new SoundPlayer(Properties.Resources.PAK1);

            if (e.KeyPressEvent.VKeyName.ToLower() == "a")
            {

                if (A == 0)
                {
                    if (label1.Text == "A")
                    {
                        label1.Visible = true;

                    }
                    if (label2.Text == "A")
                    {
                        label2.Visible = true;

                    }
                    if (label3.Text == "A")
                    {
                        label3.Visible = true;

                    }
                    if (label4.Text == "A")
                    {
                        label4.Visible = true;

                    }
                    if (label5.Text == "A")
                    {
                        label5.Visible = true;

                    }
                    if (label6.Text == "A")
                    {
                        label6.Visible = true;

                    }
                    if (label7.Text == "A")
                    {
                        label7.Visible = true;

                    }
                    if (label9.Text == "A")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "A")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "A")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "A" && label2.Text != "A" && label3.Text != "A" && label4.Text != "A" && label5.Text != "A" && label6.Text != "A" && label7.Text != "A" && label9.Text != "A" && label10.Text != "A" && label11.Text != "A")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true;
                        Pak.Visible = false;

                    }
                    else
                    {
                        correct.Play();
                        Pak.Visible = true; Waley.Visible = false;

                    }
                    A = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "b")
            {
                if (B == 0)
                {
                    if (label1.Text == "B")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "B")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "B")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "B")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "B")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "B")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "B")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "B")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "B")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "B")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "B" && label2.Text != "B" && label3.Text != "B" && label4.Text != "B" && label5.Text != "B" && label6.Text != "B" && label7.Text != "B" && label9.Text != "B" && label10.Text != "B" && label11.Text != "B")
                    {
                        Shake(this);

                        sec = sec - 10;

                        wrong.Play();
                        Waley.Visible = true;
                        Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play();
                        Pak.Visible = true; Waley.Visible = false;
                    }
                    B = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "c")
            {
                if (C == 0)
                {
                    if (label1.Text == "C")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "C")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "C")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "C")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "C")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "C")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "C")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "C")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "C")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "C")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "C" && label2.Text != "C" && label3.Text != "C" && label4.Text != "C" && label5.Text != "C" && label6.Text != "C" && label7.Text != "C" && label9.Text != "C" && label10.Text != "C" && label11.Text != "C")
                    {
                        Shake(this);

                        sec = sec - 10;

                        wrong.Play();
                        Waley.Visible = true;
                        Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play();
                        Pak.Visible = true;
                        Waley.Visible = false;
                    }
                    C = 1;
                }

            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "d")
            {
                if (D == 0)
                {
                    if (label1.Text == "D")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "D")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "D")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "D")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "D")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "D")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "D")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "D")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "D")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "D")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "D" && label2.Text != "D" && label3.Text != "D" && label4.Text != "D" && label5.Text != "D" && label6.Text != "D" && label7.Text != "D" && label9.Text != "D" && label10.Text != "D" && label11.Text != "D")
                    {
                        Shake(this);

                        sec = sec - 10;

                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }

                    else
                    {
                        correct.Play();
                        Pak.Visible = true; Waley.Visible = false;
                    }
                    D = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "e")
            {
                if (E == 0)
                {
                    if (label1.Text == "E")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "E")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "E")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "E")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "E")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "E")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "E")
                    {
                        label7.Visible = true;
                    }
                     if (label9.Text == "E")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "E")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "E")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "E" && label2.Text != "E" && label3.Text != "E" && label4.Text != "E" && label5.Text != "E" && label6.Text != "E" && label7.Text != "E" && label9.Text != "E" && label10.Text != "E" && label11.Text != "E")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    E = 1;
                }
        }
         
            else if (e.KeyPressEvent.VKeyName.ToLower() == "f")
            {
                if (F == 0)
                {
                    if (label1.Text == "F")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "F")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "F")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "F")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "F")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "F")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "F")
                    {
                        label7.Visible = true;
                    }
                   if (label9.Text == "F")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "F")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "F")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "F" && label2.Text != "F" && label3.Text != "F" && label4.Text != "F" && label5.Text != "F" && label6.Text != "F" && label7.Text != "F" && label9.Text != "F" && label10.Text != "F" && label11.Text != "F")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    F = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "g")
            {
                if (G == 0)
                {
                    if (label1.Text == "G")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "G")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "G")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "G")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "G")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "G")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "G")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "G")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "G")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "G")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "G" && label2.Text != "G" && label3.Text != "G" && label4.Text != "G" && label5.Text != "G" && label6.Text != "G" && label7.Text != "G" && label9.Text != "G" && label10.Text != "G" && label11.Text != "G")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    G = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "h")
            {
                if (H == 0)
                {
                    if (label1.Text == "H")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "H")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "H")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "H")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "H")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "H")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "H")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "H")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "H")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "H")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "H" && label2.Text != "H" && label3.Text != "H" && label4.Text != "H" && label5.Text != "H" && label6.Text != "H" && label7.Text != "H" && label9.Text != "H" && label10.Text != "H" && label11.Text != "H")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    H = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "i")
            {
                if (I == 0)
                {
                    if (label1.Text == "I")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "I")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "I")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "I")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "I")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "I")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "I")
                    {
                        label7.Visible = true;
                    }
                   if (label9.Text == "I")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "I")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "I")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "I" && label2.Text != "I" && label3.Text != "I" && label4.Text != "I" && label5.Text != "I" && label6.Text != "I" && label7.Text != "I" && label9.Text != "I" && label10.Text != "I" && label11.Text != "I")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    I = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "j")
            {
                if (J == 0)
                {
                    if (label1.Text == "J")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "J")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "J")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "J")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "J")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "J")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "J")
                    {
                        label7.Visible = true;
                    }
                   if (label9.Text == "J")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "J")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "J")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "J" && label2.Text != "J" && label3.Text != "J" && label4.Text != "J" && label5.Text != "J" && label6.Text != "J" && label7.Text != "J" && label9.Text != "J" && label10.Text != "J" && label11.Text != "J")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    J = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "k")
            {
                if (K == 0)
                {
                    if (label1.Text == "K")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "K")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "K")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "K")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "K")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "K")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "K")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "K")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "K")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "K")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "K" && label2.Text != "K" && label3.Text != "K" && label4.Text != "K" && label5.Text != "K" && label6.Text != "K" && label7.Text != "K" && label9.Text != "K" && label10.Text != "K" && label11.Text != "K")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    K = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "l")
            {
                if (L == 0)
                {
                    if (label1.Text == "L")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "L")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "L")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "L")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "L")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "L")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "L")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "L")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "L")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "L")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "L" && label2.Text != "L" && label3.Text != "L" && label4.Text != "L" && label5.Text != "L" && label6.Text != "L" && label7.Text != "L" && label9.Text != "L" && label10.Text != "L" && label11.Text != "L")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    L = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "m")
            {
                if (M == 0)
                {

                    if (label1.Text == "M")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "M")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "M")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "M")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "M")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "M")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "M")
                    {
                        label7.Visible = true;
                    }
                     if (label9.Text == "M")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "M")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "M")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "M" && label2.Text != "M" && label3.Text != "M" && label4.Text != "M" && label5.Text != "M" && label6.Text != "M" && label7.Text != "M" && label9.Text != "M" && label10.Text != "M" && label11.Text != "M")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    M = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "n")
            {
                if (N == 0)
                {
                    if (label1.Text == "N")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "N")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "N")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "N")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "N")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "N")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "N")
                    {
                        label7.Visible = true;
                    }
               if (label9.Text == "N")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "N")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "N")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "N" && label2.Text != "N" && label3.Text != "N" && label4.Text != "N" && label5.Text != "N" && label6.Text != "N" && label7.Text != "N" && label9.Text != "N" && label10.Text != "N" && label11.Text != "N")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    N = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "o")
            {
                if (O == 0)
                {
                    if (label1.Text == "O")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "O")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "O")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "O")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "O")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "O")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "O")
                    {
                        label7.Visible = true;
                    }
                  if (label9.Text == "O")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "O")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "O")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "O" && label2.Text != "O" && label3.Text != "O" && label4.Text != "O" && label5.Text != "O" && label6.Text != "O" && label7.Text != "O" && label9.Text != "O" && label10.Text != "O" && label11.Text != "O")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    O = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "p")
            {
                if (P == 0)
                {
                    if (label1.Text == "P")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "P")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "P")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "P")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "P")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "P")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "P")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "P")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "P")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "P")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "P" && label2.Text != "P" && label3.Text != "P" && label4.Text != "P" && label5.Text != "P" && label6.Text != "P" && label7.Text != "P" && label9.Text != "P" && label10.Text != "P" && label11.Text != "P")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    P = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "q")
            {
                if (Q == 0)
                {
                    if (label1.Text == "Q")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "Q")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "Q")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "Q")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "Q")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "Q")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "Q")
                    {
                        label7.Visible = true;
                    }
                   if (label9.Text == "Q")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "Q")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "Q")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "Q" && label2.Text != "Q" && label3.Text != "Q" && label4.Text != "Q" && label5.Text != "Q" && label6.Text != "Q" && label7.Text != "Q" && label9.Text != "Q" && label10.Text != "Q" && label11.Text != "Q")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    Q = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "r")
            {
                if (R == 0)
                {
                    if (label1.Text == "R")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "R")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "R")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "R")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "R")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "R")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "R")
                    {
                        label7.Visible = true;
                    }
                     if (label9.Text == "R")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "R")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "R")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "R" && label2.Text != "R" && label3.Text != "R" && label4.Text != "R" && label5.Text != "R" && label6.Text != "R" && label7.Text != "R" && label9.Text != "R" && label10.Text != "R" && label11.Text != "R")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    R = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "s")
            {
                if (S == 0)
                {
                    if (label1.Text == "S")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "S")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "S")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "S")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "S")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "S")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "S")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "S")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "S")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "S")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "S" && label2.Text != "S" && label3.Text != "S" && label4.Text != "S" && label5.Text != "S" && label6.Text != "S" && label7.Text != "S" && label9.Text != "S" && label10.Text != "S" && label11.Text != "S")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    S = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "t")
            {
                if (T == 0)
                {
                    if (label1.Text == "T")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "T")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "T")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "T")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "T")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "T")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "T")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "T")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "T")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "T")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "T" && label2.Text != "T" && label3.Text != "T" && label4.Text != "T" && label5.Text != "T" && label6.Text != "T" && label7.Text != "T" && label9.Text != "T" && label10.Text != "T" && label11.Text != "T")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    T = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "u")
            {
                if (U == 0)
                {
                    if (label1.Text == "U")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "U")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "U")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "U")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "U")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "U")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "U")
                    {
                        label7.Visible = true;
                   
                    }
                    if (label9.Text == "U")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "U")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "U")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "U" && label2.Text != "U" && label3.Text != "U" && label4.Text != "U" && label5.Text != "U" && label6.Text != "U" && label7.Text != "U" && label9.Text != "U" && label10.Text != "U" && label11.Text != "U")
                    {
                        Shake(this);

                        sec = sec - 10;
            
                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    U = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "v")
            {
                if (V == 0)
                {
                    if (label1.Text == "V")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "V")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "V")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "V")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "V")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "V")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "V")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "V")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "V")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "V")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "V" && label2.Text != "V" && label3.Text != "V" && label4.Text != "V" && label5.Text != "V" && label6.Text != "V" && label7.Text != "V" && label9.Text != "V" && label10.Text != "V" && label11.Text != "V")
                    {
                        Shake(this);

                        sec = sec - 10;

                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    V = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "w")
            {
                if (W == 0)
                {
                    if (label1.Text == "W")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "W")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "W")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "W")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "W")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "W")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "W")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "W")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "W")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "W")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "W" && label2.Text != "W" && label3.Text != "W" && label4.Text != "W" && label5.Text != "W" && label6.Text != "W" && label7.Text != "W" && label9.Text != "W" && label10.Text != "W" && label11.Text != "W")
                    {
                        Shake(this);

                        sec = sec - 10;

                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    W = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "x")
            {
                if (X == 0)
                {
                    if (label1.Text == "X")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "X")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "X")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "X")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "X")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "X")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "X")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "X")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "X")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "X")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "X" && label2.Text != "X" && label3.Text != "X" && label4.Text != "X" && label5.Text != "X" && label6.Text != "X" && label7.Text != "X" && label9.Text != "X" && label10.Text != "X" && label11.Text != "X")
                    {
                        Shake(this);

                        sec = sec - 10;

                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    X = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "y")
            {
                if (Y == 0)
                {
                    if (label1.Text == "Y")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "Y")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "Y")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "Y")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "Y")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "Y")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "Y")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "Y")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "Y")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "Y")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "Y" && label2.Text != "Y" && label3.Text != "Y" && label4.Text != "Y" && label5.Text != "Y" && label6.Text != "Y" && label7.Text != "Y" && label9.Text != "Y" && label10.Text != "Y" && label11.Text != "Y")
                    {
                        Shake(this);

                        sec = sec - 10;

                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play(); Pak.Visible = true; Waley.Visible = false;
                    }
                    Y = 1;
                }
            }
            else if (e.KeyPressEvent.VKeyName.ToLower() == "z")
            {
                if (Z == 0)
                {
                    if (label1.Text == "Z")
                    {
                        label1.Visible = true;
                    }
                    if (label2.Text == "Z")
                    {
                        label2.Visible = true;
                    }
                    if (label3.Text == "Z")
                    {
                        label3.Visible = true;
                    }
                    if (label4.Text == "Z")
                    {
                        label4.Visible = true;
                    }
                    if (label5.Text == "Z")
                    {
                        label5.Visible = true;
                    }
                    if (label6.Text == "Z")
                    {
                        label6.Visible = true;
                    }
                    if (label7.Text == "Z")
                    {
                        label7.Visible = true;
                    }
                    if (label9.Text == "Z")
                    {
                        label9.Visible = true;

                    }
                    if (label10.Text == "Z")
                    {
                        label10.Visible = true;

                    }
                    if (label11.Text == "Z")
                    {
                        label11.Visible = true;

                    }
                    if (label1.Text != "Z" && label2.Text != "Z" && label3.Text != "Z" && label4.Text != "Z" && label5.Text != "Z" && label6.Text != "Z" && label7.Text != "Z" && label9.Text != "Z" && label10.Text != "Z" && label11.Text != "Z")
                    {
                        Shake(this);

                        sec = sec - 10;

                        wrong.Play();
                        Waley.Visible = true; Pak.Visible = false;
                    }
                    else
                    {
                        correct.Play();
                        Pak.Visible = true;
                        Waley.Visible = false;

                    }
                    Z = 1;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int x=0;
            foreach (char d in guess)
            {
                char c = Char.ToUpper(d);
                x = x + 1;
                if (x == 1)
                {
                    label1.Text = "" + c;
                }
               else if (x == 2)
                {
                    label2.Text = "" + c;
                }
               else if (x == 3)
                {
                    label3.Text = "" + c;
                }
              else  if (x == 4)
                {
                    label4.Text = "" + c;
                }
              else if (x == 5)
                {
                    label5.Text = "" + c;
                }
                else if (x == 6)
                {
                    label6.Text = "" + c;
                }
                else if (x == 7)
                {
                    label7.Text = "" + c;
                }
                else if (x == 8)
                {
                    label9.Text = "" + c;
                }

                else if (x == 9)
                {
                    label10.Text = "" + c;
                }
                else if (x == 10)
                {
                    label11.Text = "" + c;
                }


            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            min = Convert.ToInt32(5);
            sec = Convert.ToInt32(0);
            Hint2.Text = "";
            Hint3.Text = "";
            Hint4.Text = "";
            levelnum.Text = "";
            levelnum.Text = ""+level;   
        }

        private void Timelimit_Tick(object sender, EventArgs e)
        {
            sec = sec - 1;
           
         if (min <= 0 && sec <= 0 )
            {
                Timelimit.Stop();
                EndGame end = new EndGame();
                end.ShowDialog();
            }
            if (sec < 0)
            {
                min = min - 1;
                sec = 59;
            }
            if (sec > 59)
            {
                min = min + 1;
                sec = sec - 60 ;
            }
            if (min < 0)
            {
                min = 59;
            }
         

            string mm = Convert.ToString(min);
            string ss;
            if(!(sec < 10)){
                ss = Convert.ToString(sec);
            }
            else
            {
                ss = "0" + sec.ToString();
            }

            

            Time.Text = mm + ":" + ss;
        }

        private void Hint1_Click(object sender, EventArgs e)
        {
            Hint1.Text = hint1;
        }

        private void Hint2_Click(object sender, EventArgs e)
        {
            Hint2.Text = hint2;
        }

        private void Hint3_Click(object sender, EventArgs e)
        {
            Hint3.Text = hint3;
        }

        private void Hint4_Click(object sender, EventArgs e)
        {
            Hint4.Text = hint4;
        }

        private void Gameflow_Tick(object sender, EventArgs e)
        {

            GuessWord();
            Hint1.Text = hint1;
            SoundPlayer success = new SoundPlayer(Properties.Resources.PAKGANERN);


            if (guess.Length == 2)
            {
                if (label1.Visible == true && label2.Visible == true)
                {

                    Pak.Visible = false;
                    Waley.Visible = false;
                    Timelimit.Stop();
                    Gameflow.Stop();
                    success.Play();
                    scoringsystem();
                   
                    //MJ code //add word to guessedWords
                    wr.GuessedWords.Add(guess);
           

                    sec = sec + 15;
                    correct += 1;
        

                    //show hints
                    showCorrectAnswer();
                    Next.Start();

                }
            }
            if (guess.Length == 3)
            {
                if (label1.Visible == true && label2.Visible == true && label3.Visible == true)
                {
                    Pak.Visible = false;
                    Waley.Visible = false;
                    Timelimit.Stop();
                    Gameflow.Stop();
                    success.Play();
                    scoringsystem();
            
                    //MJ code //add word to guessedWords
                    wr.GuessedWords.Add(guess);


                    sec = sec + 15;
                    correct += 1;

                    //show hints
                    showCorrectAnswer();
                    Next.Start();
                }
            }
            if (guess.Length == 4)
            {
                if (label1.Visible == true && label2.Visible == true && label3.Visible == true && label4.Visible == true)
                {
                    Pak.Visible = false;
                    Waley.Visible = false;
                    Timelimit.Stop();
                    Gameflow.Stop();
                    success.Play();
                    scoringsystem();
    
                    //MJ code //add word to guessedWords
                    wr.GuessedWords.Add(guess);
                  
                    sec = sec + 15;
                    correct += 1;

                    //show hints
                    showCorrectAnswer();
                    Next.Start();

                }
            }
            if (guess.Length == 5)
            {
                if (label1.Visible == true && label2.Visible == true && label3.Visible == true && label4.Visible == true && label5.Visible == true)
                {
                    Pak.Visible = false;
                    Waley.Visible = false;
                    Timelimit.Stop();
                    Gameflow.Stop();
                    success.Play();
                    scoringsystem();

                    //MJ code //add word to guessedWords
                    wr.GuessedWords.Add(guess);
       

                    sec = sec + 15;
                    correct += 1;

                    //show hints
                    showCorrectAnswer();
                    Next.Start();
                }
            }
            if (guess.Length == 6)
            {
                if (label1.Visible == true && label2.Visible == true && label3.Visible == true && label4.Visible == true && label5.Visible == true && label6.Visible == true)
                {
                    Pak.Visible = false;
                    Waley.Visible = false;
                    Timelimit.Stop();
                    Gameflow.Stop();
                    success.Play();
                    scoringsystem();
            
                    //MJ code //add word to guessedWords
                    wr.GuessedWords.Add(guess);



                    sec = sec + 15;
                    correct += 1;

                    //show hints
                    showCorrectAnswer();
                    Next.Start();

                }
            }
            if (guess.Length == 7)
            {
                if (label1.Visible == true && label2.Visible == true && label3.Visible == true && label4.Visible == true && label5.Visible == true && label6.Visible == true && label7.Visible == true)
                {
                    Pak.Visible = false;
                    Waley.Visible = false;
                    Timelimit.Stop();
                    Gameflow.Stop();
                    success.Play();
                    scoringsystem();
                  
                    //MJ code //add word to guessedWords
                    wr.GuessedWords.Add(guess);

                    correct += 1;

                    sec = sec + 15;

                    //show hints
                    showCorrectAnswer();
                    Next.Start();

                }
            }
                if (guess.Length == 8)
                {
                    if (label1.Visible == true && label2.Visible == true && label3.Visible == true && label4.Visible == true && label5.Visible == true && label6.Visible == true && label7.Visible == true && label9.Visible == true)
                    {
                        Pak.Visible = false;
                        Waley.Visible = false;
                        Timelimit.Stop();
                        Gameflow.Stop();
                        success.Play();
                        scoringsystem();
              
                        //MJ code //add word to guessedWords
                        wr.GuessedWords.Add(guess);
                        correct += 1;


                        sec = sec + 15;

                        //show hints
                        showCorrectAnswer();
                        Next.Start();

                    }
                }
                if (guess.Length == 9)
                  {
                    if (label1.Visible == true && label2.Visible == true && label3.Visible == true && label4.Visible == true && label5.Visible == true && label6.Visible == true && label7.Visible == true && label9.Visible == true && label10.Visible == true)
                    {
                        Pak.Visible = false;
                        Waley.Visible = false;
                        Timelimit.Stop();
                        Gameflow.Stop();
                        success.Play();
                        scoringsystem();
           
                        //MJ code //add word to guessedWords
                        wr.GuessedWords.Add(guess);

                        correct += 1;

                        sec = sec + 15;


                        //show hints
                        showCorrectAnswer();
                        Next.Start();

                    }
                }
                if (guess.Length == 10)
                {
                     if (label1.Visible == true && label2.Visible == true && label3.Visible == true && label4.Visible == true && label5.Visible == true && label6.Visible == true && label7.Visible == true && label9.Visible == true && label10.Visible == true && label11.Visible == true)
                    {
                        Pak.Visible = false;
                        Waley.Visible = false;
                        Timelimit.Stop();
                        Gameflow.Stop();
                        success.Play();
                        scoringsystem();

                        //MJ code //add word to guessedWords
                        wr.GuessedWords.Add(guess);


                        correct += 1;
                        sec = sec + 15;


                        //show hints
                        showCorrectAnswer();
                        Next.Start();

                    }
                }



            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PAKKK_Tick(object sender, EventArgs e)
        {

        }

        public int init = -197;
        public int x = 0;
        private void Next_Tick(object sender, EventArgs e)
        {
        
           
            x++;
            if (x >= 20) {   
             Btn_Nxt.Visible = true;
             init = init + 99;
            Btn_Nxt.Location = new System.Drawing.Point(init, 440);
            if (init == 100)
            {
                Next.Stop();
                
                init = -197;
                x = 0;
                Answerbox1.Visible = false;
                Answerbox2.Visible = false;
                Answerbox3.Visible = false;
                Answerbox4.Visible = false;
                Answerbox5.Visible = false;
                Answerbox6.Visible = false;
                Answerbox7.Visible = false;
                Answerbox8.Visible = false;
                Answerbox9.Visible = false;
                Answerbox10.Visible = false;

            }
            
            }
              
          

        }

        private void Btn_Nxt_Click(object sender, EventArgs e)
        {
            NextLevel();
            Timelimit.Start();
            level += 1;
            levelnum.Text = "" + level;   
        }

        private void label11_Click(object sender, EventArgs e)
        {
          
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
          
            
        }

        private void Answerbox3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Answerbox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Answerbox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void levelnum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {
          
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
          
            
        }

        private void OpenLetter_Click(object sender, EventArgs e)
        {


            if(openLetterCtr != 5){
                if (label1.Visible == true)
                {

                }
                else
                {
                    button1.Visible = true;
                    openLetterCtr++;
                }
                if (label2.Visible == true)
                {

                }
                else
                {
                    button2.Visible = true;
                    openLetterCtr++;
                }
                if (label3.Visible == true)
                {

                }
                else
                {
                    button3.Visible = true;
                    openLetterCtr++;
                }
                if (label4.Visible == true)
                {

                }
                else
                {
                    button4.Visible = true;
                    openLetterCtr++;
                }
                if (label5.Visible == true)
                {

                }
                else
                {
                    button5.Visible = true;
                    openLetterCtr++;
                }
                if (label6.Visible == true)
                {

                }
                else
                {
                    button6.Visible = true;
                    openLetterCtr++;
                }
                if (label7.Visible == true)
                {

                }
                else
                {
                    button7.Visible = true;
                    openLetterCtr++;
                }
                if (label9.Visible == true)
                {

                }
                else
                {
                    button8.Visible = true;
                    openLetterCtr++;
                }
                if (label10.Visible == true)
                {

                }
                else
                {
                    button9.Visible = true;
                    openLetterCtr++;
                }
                if (label11.Visible == true)
                {

                }
                else
                {
                    button10.Visible = true;
                    openLetterCtr++;
                }
            }
            else
            {
                MessageBox.Show("Open Letter already used 5 Times.");
            }
        }

        private void Answerbox4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Answerbox5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void Showans_Click(object sender, EventArgs e)
        {
            if(showAnsCtr != 5){
                showCorrectAnswer();
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
            }
            else
            {
                MessageBox.Show("Show Answer already used 5 Times.");
            }
            
        }

        private void Pass_Click(object sender, EventArgs e)
        {
            Pak.Visible = false;
            Waley.Visible = false;
            Timelimit.Stop();
            Gameflow.Stop();
            showCorrectAnswer();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            Next.Start();
            level -= 1;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Dispose();
            Timelimit.Dispose();
            Gameflow.Dispose();
            Next.Dispose();

            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void WALEYYY_Tick(object sender, EventArgs e)
        {

        }

        private void Pause_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Dispose();
            Timelimit.Dispose();
            Gameflow.Dispose();
            Next.Dispose();
            this.Dispose();
        }
    }
}
