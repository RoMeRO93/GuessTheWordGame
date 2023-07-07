using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuessTheWordGame
{
    public partial class MainForm : Form
    {
        private string secretWord;
        private int guessesLeft;
        private int score;

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        public void InitializeGame()
        {
            List<string> words = new List<string>
            {
                "apple", "banana", "cherry", "dragon", "elephant", "flower", "grape", "honey", "island", "jungle",
                "koala", "lemon", "monkey", "nutmeg", "orange", "peach", "quilt", "rabbit", "strawberry", "turtle",
                "unicorn", "violet", "watermelon", "xylophone", "yacht", "zebra"
            };

            Random random = new Random();
            secretWord = words[random.Next(words.Count)];
            guessesLeft = 5;
            score = 0;

            lblGuessesLeft.Text = $"Guesses left: {guessesLeft}";
            lblScore.Text = $"Score: {score}";
            lblHint.Text = string.Empty;
            txtGuess.Text = string.Empty;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.ToLower();

            if (guess == secretWord)
            {
                MessageBox.Show("Congratulations! You guessed the word correctly!", "Guess the Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IncreaseScore();
                InitializeGame();
            }
            else
            {
                DecreaseGuessesLeft();
                if (guessesLeft == 0)
                {
                    MessageBox.Show($"Game over! The secret word was: {secretWord}", "Guess the Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetScore();
                    InitializeGame();
                }
                else
                {
                    MessageBox.Show("Incorrect guess! Try again.", "Guess the Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            txtGuess.Text = string.Empty;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            string hint = string.Empty;

            // Generate a hint based on the secret word
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (i == 0 || i == secretWord.Length - 1)
                {
                    hint += secretWord[i];
                }
                else
                {
                    hint += "_";
                }
            }

            lblHint.Text = $"Hint: {hint}";
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        public void IncreaseScore()
        {
            score++;
            lblScore.Text = $"Score: {score}";
        }

        public void DecreaseGuessesLeft()
        {
            guessesLeft--;
            lblGuessesLeft.Text = $"Guesses left: {guessesLeft}";
        }

        public void ResetScore()
        {
            score = 0;
            lblScore.Text = $"Score: {score}";
        }
    }
}
