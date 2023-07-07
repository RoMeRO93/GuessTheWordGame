using System;
using System.Windows.Forms;

namespace GuessTheWordGame
{
    public partial class Form1 : Form
    {
        private string secretWord;
        private int guessesLeft;
        private int score;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            Load += Form1_Load; // Adăugați această linie
        }

        private void InitializeGame()
        {
            secretWord = "apple";
            guessesLeft = 5;
            score = 0;

            lblGuessesLeft.Text = $"Guesses left: {guessesLeft}";
            lblScore.Text = $"Score: {score}";
            lblHint.Text = string.Empty;
            txtGuess.Text = string.Empty;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
