namespace GuessTheWordGame
{
    partial class Form1
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
            this.lblGuessesLeft = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGuessesLeft
            // 
            this.lblGuessesLeft.AutoSize = true;
            this.lblGuessesLeft.Location = new System.Drawing.Point(12, 9);
            this.lblGuessesLeft.Name = "lblGuessesLeft";
            this.lblGuessesLeft.Size = new System.Drawing.Size(82, 13);
            this.lblGuessesLeft.TabIndex = 0;
            this.lblGuessesLeft.Text = "Guesses left: 5";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 32);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(46, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(12, 55);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 13);
            this.lblHint.TabIndex = 2;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(15, 90);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 3;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(121, 88);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(202, 88);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(75, 23);
            this.btnHint.TabIndex = 5;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(283, 88);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGuessesLeft);
            this.Name = "Form1";
            this.Text = "Guess The Word Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
