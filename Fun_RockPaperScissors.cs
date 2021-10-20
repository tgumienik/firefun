using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireFun
{
    public partial class Fun_RockPaperScissors : Form
    {
        Random rnd = new Random();

        Pick playerChoice, botChoice;

        long playerWins = 0, botWins = 0, ties = 0;
        public enum GameResult { PlayerWin, BotWin, Tie }

        public enum Pick { Rock, Paper, Scissors }

        private void Select(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            if (c.Tag.ToString() == "rock") playerChoice = Pick.Rock;
            if (c.Tag.ToString() == "paper") playerChoice = Pick.Paper;
            if (c.Tag.ToString() == "scissors") playerChoice = Pick.Scissors;
            setBotChoice();
            GameResult result = EvaluateWinner();

            string winner = "";
            Image img = null;
            Image img2 = null;

            if (result == GameResult.BotWin) { winner = "Robot wygrywa!"; botWins++; }
            else if (result == GameResult.PlayerWin) { winner = "Wygrywasz!"; playerWins++; }
            else if (result == GameResult.Tie) { winner = "Remis!"; ties++; }
            else winner = "Błąd.";

            if (playerChoice == Pick.Rock) img = Properties.Resources.rock;
            else if (playerChoice == Pick.Paper) img = Properties.Resources.paper;
            else if (playerChoice == Pick.Scissors) img = Properties.Resources.scissors;

            if (botChoice == Pick.Rock) img2 = Properties.Resources.rock;
            else if (botChoice == Pick.Paper) img2 = Properties.Resources.paper;
            else if (botChoice == Pick.Scissors) img2 = Properties.Resources.scissors;

            UpdateWins();

            lblGameResult.Text = winner;
            pbPlayer.Image = img;
            pbBot.Image = img2;

            pnlGame.SendToBack();
            pnlGame.Visible = false;
            pnlGameResults.BringToFront();
        }

        public GameResult EvaluateWinner()
        {
            if (playerChoice == Pick.Rock && botChoice == Pick.Paper) return GameResult.BotWin;
            if (playerChoice == Pick.Rock && botChoice == Pick.Scissors) return GameResult.PlayerWin;
            if (playerChoice == Pick.Paper && botChoice == Pick.Rock) return GameResult.PlayerWin;
            if (playerChoice == Pick.Paper && botChoice == Pick.Scissors) return GameResult.BotWin;
            if (playerChoice == Pick.Scissors && botChoice == Pick.Rock) return GameResult.BotWin;
            if (playerChoice == Pick.Scissors && botChoice == Pick.Paper) return GameResult.PlayerWin;
            return GameResult.Tie;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnlGame.BringToFront();
            pnlGame.Visible = true;
            pnlGameResults.SendToBack();
        }

        public void setBotChoice()
        {
            Array values = Enum.GetValues(typeof(Pick));
            botChoice = (Pick)values.GetValue(rnd.Next(values.Length));
        }

        public Fun_RockPaperScissors()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(pbPaper, "Papier");
            toolTip.SetToolTip(pbRock, "Kamień");
            toolTip.SetToolTip(pbScissors, "Nożyce");
        }

        public void UpdateWins()
        {
            label1.Text = "Gracz: " + playerWins + "\nRobot: " + botWins + "\nRemisy: " + ties;
        }
    }
}
