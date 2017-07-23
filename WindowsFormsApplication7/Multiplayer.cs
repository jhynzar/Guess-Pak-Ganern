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
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApplication7
{
    public partial class Multiplayer : Form
    {
        WordsReader wr;
        private readonly RawInput _rawinput;
        /*
         * Scoring
         */
        int scoreP1 = 0;
        int scoreP2 = 0;
        //Life
        int lifeP1 = 5;
        int lifeP2 = 5;
        bool lifeIsUpdated = true;
        /*
         * Keyboard settings
         */
        public static string player1 = "";
        public static string player2 = "";
        public static string[] validKeys = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "ENTER","BACK"};

        public Multiplayer()
        {
            InitializeComponent();
            //For Keyboard
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            _rawinput = new RawInput(Handle, true);

            _rawinput.AddMessageFilter();   // Adding a message filter will cause keypresses to be handled
            Win32.DeviceAudit();            // Writes a file DeviceAudit.txt to the current directory

            _rawinput.KeyPressed += OnKeyPressed;
            //Keyboard End

            wr = new WordsReader();
            Timelimit.Start();
            Gameflow.Start();
            NextLevel();

            /*
             * THREAD TEST
             * 
             * 
             */
 
            
        }
        public void listen(string source,string key,string state)
        {
            
        }

       



        //check if valid input
        private static bool isKeyValid(string key)
        {
            foreach(string s in validKeys){
                if(s.Equals(key)){
                    return true;
                }
            }
            return false;
        }

        //Exception 
        private static void CurrentDomain_UnhandledException(Object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;

            if (null == ex) return;

            // Log this error. Logging the exception doesn't correct the problem but at least now
            // you may have more insight as to why the exception is being thrown.
            Debug.WriteLine("Unhandled Exception: " + ex.Message);
            Debug.WriteLine("Unhandled Exception: " + ex);
            MessageBox.Show(ex.Message);
        }

        //Key PRESSED ON KEYBOARD
        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            string source = e.KeyPressEvent.Source.ToString();
            string key = e.KeyPressEvent.VKeyName;
            string state = e.KeyPressEvent.KeyPressState.ToString();

            //lbHandle.Text = e.KeyPressEvent.DeviceHandle.ToString();
            //lbType.Text = e.KeyPressEvent.DeviceType;
            //lbName.Text = e.KeyPressEvent.DeviceName;
            //lbDescription.Text = e.KeyPressEvent.Name;
            // lbKey.Text = e.KeyPressEvent.VKey.ToString(CultureInfo.InvariantCulture);
            //lbNumKeyboards.Text = _rawinput.NumberOfKeyboards.ToString(CultureInfo.InvariantCulture);
            //label2.Text = e.KeyPressEvent.VKeyName;
            //label1.Text = e.KeyPressEvent.Source;

            /*
             * To check if the press event is onlick a "click" == Break or a "long press" == make
             * */

            /*
             * To Change visible once you start typing
             * 
             */
            if (source.Equals(player1))
            {
                Waley.Visible = false;
                Pak.Visible = false;
            }
            else if (source.Equals(player2))
            {
                Waley2.Visible = false;
                Pak2.Visible = false;
            }



            if (state.Equals("BREAK"))
            {
                //MessageBox.Show("Source: " + e.KeyPressEvent.Source + " Key: " + e.KeyPressEvent.VKeyName);


                //Check if the key pressed is valid
                if (!isKeyValid(key))
                {
                    return;
                }


                if (source.Equals(player1))
                {
                    if (key.Equals("ENTER"))
                    {
                        if (textBox1.Text.ToUpper().Equals(guess))
                        {
                            Pak.Visible = true;
                            wr.GuessedWords.Add(guess);
                            scoreP1++;
                            lblP1Score.Text = scoreP1.ToString();
                            NextLevel();
                        }
                        else if (!textBox1.Text.ToUpper().Equals(guess))
                        {
                            Waley.Visible = true;
                            lifeP1--;
                            lifeIsUpdated = false;
                        }
                        //Either correct or wrong it will clear
                        textBox1.Clear();
                    }
                    else if (key.Equals("BACK"))
                    {
                        textBox1.Clear();
                    }
                    else
                    {
                        textBox1.Text += key;
                    }
                }
                else if (source.Equals(player2))
                {
                    if (key.Equals("ENTER"))
                    {
                        if (textBox2.Text.ToUpper().Equals(guess))
                        {
                            Pak2.Visible = true;
                            wr.GuessedWords.Add(guess);
                            scoreP2++;
                            lblP2Score.Text = scoreP2.ToString();
                            NextLevel();
                        }
                        else if (!textBox2.Text.ToUpper().Equals(guess))
                        {
                            Waley2.Visible = true;
                            lifeP2--;
                            lifeIsUpdated = false;
                        }
                        //Either correct or wrong it will clear
                        textBox2.Clear();
                    }
                    else if (key.Equals("BACK"))
                    {
                        textBox2.Clear();
                    }
                    else
                    {
                        textBox2.Text += key;
                    }
                }
            }

            //lbKeyPressState.Text = e.KeyPressEvent.KeyPressState;
            //lbMessage.Text = string.Format("0x{0:X4} ({0})", e.KeyPressEvent.Message);

            //switch (e.KeyPressEvent.Message)
            //{
            //    case Win32.WM_KEYDOWN:
            //        Debug.WriteLine(e.KeyPressEvent.KeyPressState);
            //        break;
            //     case Win32.WM_KEYUP:
            //        Debug.WriteLine(e.KeyPressEvent.KeyPressState);
            //        break;
            //}
            
        }

        //END KEYBOARD


        public static string guess = "TA";
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
        public static int score = 0;
        private void Multiplayer_Load(object sender, EventArgs e)
        {
          
        }
        public void scoringsystem()
        {
        }
        public void NextLevel()
        {
            string[] wordAndHints = wr.getRandomWord();

            guess = wordAndHints[0].ToUpper();
            hint1 = wordAndHints[1].ToUpper();
            hint2 = wordAndHints[2].ToUpper();
            hint3 = wordAndHints[3].ToUpper();
            hint4 = wordAndHints[4].ToUpper();


            Hint1.Text = hint1;
            Hint2.Text = "";
            Hint3.Text = "";
            Hint4.Text = "";
           
            //to reset the hints
            hintCtr = 0;
            time = 6;

            //reset hearts
            lifeP1 = 5;
            lifeP2 = 5;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;

        }
        public void GuessWord()
        {

           
        }
        private void SettingWords_Tick(object sender, EventArgs e)
        {
         
        }


        private void Answerbox3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gameflow_Tick(object sender, EventArgs e)
        {
            if(lifeIsUpdated == false){
                switch(lifeP1){
                    case 4:
                        pictureBox5.Visible = false;
                        break;
                    case 3:
                        pictureBox4.Visible = false;
                        break;
                    case 2:
                        pictureBox3.Visible = false;
                        break;
                    case 1:
                        pictureBox2.Visible = false;
                        break;
                    case 0:
                        pictureBox1.Visible = false;
                        scoreP2++;
                        NextLevel();
                        break;
                }
                switch(lifeP2){
                    case 4:
                        pictureBox10.Visible = false;
                        break;
                    case 3:
                        pictureBox9.Visible = false;
                        break;
                    case 2:
                        pictureBox8.Visible = false;
                        break;
                    case 1:
                        pictureBox7.Visible = false;
                        break;
                    case 0:
                        pictureBox6.Visible = false;
                        scoreP1++;
                        NextLevel();
                        break;
                }
                lifeIsUpdated = true;
            }
        }

        private void Multiplayer_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        public int time=6;
        //mj code;
        public int hintCtr = 0;
        public bool isLevelEnd = false;
        private void Timelimit_Tick(object sender, EventArgs e)
        {
            if(time != 0){
                time = time - 1;
            }
            Time.Text = ""+time;
            if(time == 0){
                switch(hintCtr){
                    case 0:
                        Hint2.Text = hint2;
                        time = 6;
                        hintCtr++;
                        break;
                    case 1:
                        Hint3.Text = hint3;
                        time = 6;
                        hintCtr++;
                        break;
                    case 2:
                        Hint4.Text = hint4;
                        time = 11;
                        hintCtr++;
                        break;
                    case 3:
                        if(!isLevelEnd){
                            isLevelEnd = true; //to prevent timer from looping
                            MessageBox.Show("Times UP!");
                            textBox1.Clear();
                            textBox2.Clear();
                            Hint2.Text = "";
                            Hint3.Text = "";
                            Hint4.Text = "";
                            NextLevel();
                            isLevelEnd = false; //to reset again
                        }                      
                        break;
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Multiplayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
