namespace GuessTheWordGame
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblGuessesLeft;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnNewGame;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblGuessesLeft = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();

            // Other initialization code for controls

            // lblGuessesLeft
            this.lblGuessesLeft.Name = "lblGuessesLeft";
            this.lblGuessesLeft.Text = "Guesses left: 0";

            // lblScore
            this.lblScore.Name = "lblScore";
            this.lblScore.Text = "Score: 0";

            // lblHint
            this.lblHint.Name = "lblHint";
            this.lblHint.Text = "Hint: ";

            // txtGuess
            this.txtGuess.Name = "txtGuess";

            // btnGuess
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Text = "Guess";
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);

            // btnHint
            this.btnHint.Name = "btnHint";
            this.btnHint.Text = "Hint";
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);

            // btnNewGame
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);

            // Other layout and positioning code for controls

            // MainForm
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblGuessesLeft);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnNewGame);

            this.Name = "MainForm";
            this.Text = "Guess the Word Game";

            // Other cleanup code for components
        }
    }
}
