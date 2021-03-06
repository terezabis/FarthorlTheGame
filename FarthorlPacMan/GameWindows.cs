﻿namespace FarthorlPacMan
{
    using System.Drawing;
    using System.Windows.Forms;
    public partial class GameWindows : Form
    {
        private Game game=new Game();
        public GameWindows()
        {
            InitializeComponent();
        }

        private void pacMan_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = pacMan.CreateGraphics();
            this.game.startDraw(graphics, this);
        }

        private void GameWindows_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.game.stopGame();
        }

        private void GameWindows_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==39) //If press right arrow
            {
                game.Direction("Right");
            }

            if (e.KeyValue==37)
            {
                game.Direction("Left"); //If press left arrow 
            }

            if (e.KeyValue == 38)
            {
                game.Direction("Up"); //If press up arrow
            }

            if (e.KeyValue == 40)
            {
                game.Direction("Down"); //If press down arrow
            }
        }

        public void updateScore(int score)
        {
            ScoreLabel.Text = $"Scores: {score}";
        }

        public void updateLeftScore(int leftScore)
        {
            LeftScore.Text = $"Left scores: {leftScore}";
        }
    }
}
