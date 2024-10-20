using Microsoft.VisualBasic;

namespace A1_Games
{
    public partial class Form1 : Form
    {

        //GameSetup
        //GamePlay
        //GameEnd
        //CheckLetter

        string word = "";
        string clue = "";
        int wordcount;

        List<string> secretWord = new List<string>();
        List<string> guessWord = new List<string>();

        int score;
        int lives;

        List<Words> wordList=new List<Words>();

        public Form1()
        {
            InitializeComponent();

            pageMenu.StartButtonClick += new EventHandler(pageMenu_StartButtonClick);
            
        }

        private void pageMenu_StartButtonClick (object sender, EventArgs e)
        {
            pageMenu.Hide();
            GameSetup();
        }


        private void GameSetup()
        {

            lives = 6;
            score = 0;

            lblLives.Text = $"Lives : {lives}";
            lblScore.Text = $"Score : {score}";

            wordList = Data.GetWord(); // get wordlist from data

            GamePlay();
        }

        private void LetterClick(object sender, EventArgs e)
        {
            string letter = (sender as Button).Text.ToLower();

            if (!CheckLetter(letter)) {
                lives--; // decrease live if the letter from user input is incorrect
            }
        
            lblLives.Text = $"Lives : {lives}";

            if (lives <= 0)
            {
                GamePlay();
            }
        }



        private void Guessword()
        {
            Random random = new Random();
            int index = random.Next(wordList.Count); // random number from number of wordlist

            word= wordList[index].word.ToString(); // set the word of game
            clue= wordList[index].clue.ToString(); // set the clue of game

            wordList.RemoveAt(index); // delete after use this word

            wordcount = word.Count(); // counting the characters of this word
        }

        private string BlankLine() // display the default blank line
        {
            int i = 0;
            string s = "";
            while (i<wordcount) {
                s += "_ ";
                i++;
            }
            return s.Trim();
        }

        private void GamePlay()
        {
            if (!GameEnd())
            {
                    Guessword(); // define word of level

                    secretWord = new List<string>(Array.ConvertAll(word.ToCharArray(), c => c.ToString()));
                    guessWord = new List<string>(new string[wordcount]);

                    lblClue.Text = clue;
                    lblResult.Text = BlankLine();
            }
            else
            {
                pageMenu.Show();
                
            }
        
            
        }

        private bool GameEnd()
        {
            if(lives > 0)
            {
                if (wordList.Count > 0)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show($"Congratulations, you passed all levels.\nYou got {score} rounds in a row!\nPlay new game?"); // finish all levels of game
                }
            }
            else
            {
                lblResult.Text = string.Join(" ", secretWord).Trim(); // reveal word that user lose
                MessageBox.Show($"Game over\nYou got {score} rounds in a row!");
            }
            return true;
           
        }

        private bool CheckLetter(string letter)
        {
            int i = 0;

            if (!secretWord.Contains(letter)) // Is letter contain in secret word list
            {
                return false;
            }

            while (i < wordcount)
            {
                if (letter == secretWord[i].ToString())
                {
                    guessWord[i] = letter; // assign the correct letter to guess word list
                }
                i++;
            }

            lblResult.Text = "";

            foreach (var w in guessWord) // display letter that user input
            {
                if (w != null)
                {
                    lblResult.Text += w.ToString() + " ";
                }
                else
                {
                    lblResult.Text += "_ ";
                }
            }
            lblResult.Text.Trim();

            if (string.Join("", secretWord) == string.Join("", guessWord)) // compare letters between secret word and user input 
            {
                if(wordList.Count > 0)
                {
                    MessageBox.Show($"Perfect! Go to next level");
                }
                
                score++;
                lblScore.Text = $"Score : {score}";


                GamePlay(); // start next level
            }

            return true;
        }
    }
}
