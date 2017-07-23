using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--- using
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    class WordsReader
    {
        //---FileName
        static string fileName = AppDomain.CurrentDomain.BaseDirectory + @"\"+"WordGuess.txt";
        //---List for Words
        List<string>[] wordsAndHints;
        //---List of Guessed Words
        private List<string> guessedWords;
        //---Random Variable
        Random rand;

        public List<string> GuessedWords
        {
            get { return guessedWords; }
            set { guessedWords = value; }
        }
        public List<string>[] WordsAndHints
        {
            get { return wordsAndHints; }
            set { wordsAndHints = value; }
        }
        //---Constructor
        public WordsReader()
        {
            //---Initialize wordsAndHints
            wordsAndHints = new List<string>[5];
            wordsAndHints[0] = new List<string>();
            wordsAndHints[1] = new List<string>();
            wordsAndHints[2] = new List<string>();
            wordsAndHints[3] = new List<string>();
            wordsAndHints[4] = new List<string>();
            //---Initialize guessedWords
            guessedWords = new List<string>();
            //---Initialize rand
            rand = new Random();

            //---Check if File exists
            if(!File.Exists(fileName)){
                MessageBox.Show("Words to guess file: " + fileName + ", does not exist!");
            }
            refreshWordGuess();
        }

        public void refreshWordGuess(){
            using(StreamReader sr = File.OpenText(fileName)){
                string lineString = "";
                while((lineString = sr.ReadLine()) != null){
                    string[] arr = new string[5];
                    arr = lineString.Split(',');
                    wordsAndHints[0].Add(arr[0]);
                    wordsAndHints[1].Add(arr[1]);
                    wordsAndHints[2].Add(arr[2]);
                    wordsAndHints[3].Add(arr[3]);
                    wordsAndHints[4].Add(arr[4]);
                }
            }
        }
        public string[] getRandomWord()
        {
            string[] wordAndHintsToReturn = new string[5];

            bool isGuessed;
            int randCtr = 0;
            int index;
            do{
                isGuessed = false;
                index = rand.Next(wordsAndHints[0].Count);
                foreach(string s in guessedWords){
                    if(s.Equals(wordsAndHints[0].ElementAt(index))){
                        isGuessed = true;
                        break;
                    }
                }
                //---Check if all words are already guessed
                if (randCtr == wordsAndHints[0].Count)
                {
                    MessageBox.Show("Congratulations! All words are already guessed.");
                    break;
                }
                randCtr++;
            }while(isGuessed);

            //---Get the word
            wordAndHintsToReturn[0] = wordsAndHints[0].ElementAt(index);
            wordAndHintsToReturn[1] = wordsAndHints[1].ElementAt(index);
            wordAndHintsToReturn[2] = wordsAndHints[2].ElementAt(index);
            wordAndHintsToReturn[3] = wordsAndHints[3].ElementAt(index);
            wordAndHintsToReturn[4] = wordsAndHints[4].ElementAt(index);

            return wordAndHintsToReturn;
        }
    }
}
