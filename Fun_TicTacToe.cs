using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FireFun
{
    public partial class Fun_TicTacToe : Form
    {
        char[,] board = new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

        List<string> emptyBoxes = new List<string>();

        string playerChoice = "O", player2Choice = "X", botChoice = "X";
        bool playAgainstBot = false;

        CurrentTurn currentTurn = CurrentTurn.Player;
        Random rnd = new Random();

        enum CurrentTurn { Player, Player2, Bot }
        enum GameResult { PlayerWin, Player2Win, BotWin, Tie, Null }

        Color color = Color.FromArgb(240,15,25);

        public Fun_TicTacToe()
        {
            InitializeComponent();
        }

        public void GridToBoard()
        {
            board = new char[,] { { TextToChar(grid1.Text), TextToChar(grid2.Text), TextToChar(grid3.Text)}, { TextToChar(grid4.Text), TextToChar(grid5.Text), TextToChar(grid6.Text) }, { TextToChar(grid7.Text), TextToChar(grid8.Text), TextToChar(grid9.Text) } };
        }
        public void BoardToGrid()
        {
            grid1.Text = CharToText(board[0, 0]);
            grid2.Text = CharToText(board[0, 1]);
            grid3.Text = CharToText(board[0, 2]);
            grid4.Text = CharToText(board[1, 0]);
            grid5.Text = CharToText(board[1, 1]);
            grid6.Text = CharToText(board[1, 2]);
            grid7.Text = CharToText(board[2, 0]);
            grid8.Text = CharToText(board[2, 1]);
            grid9.Text = CharToText(board[2, 2]);
        }

        public char TextToChar(string str)
        {
            return string.IsNullOrEmpty(str) ? '-' : str[0];
        }
        public string CharToText(char c)
        {
            try
            {
                return (c == '-') ? "" : c.ToString();
            }
            catch { }
            return "";
        }

        public void StartGame()
        {
            label1.Text = String.Empty;
            GoToGame();
            CenterToScreen();
            emptyBoxes = new List<string>() { "grid1", "grid2", "grid3", "grid4", "grid5", "grid6", "grid7", "grid8", "grid9" };
            foreach(string z in emptyBoxes)
            {
                if(Controls.Find(z, true) != null)
                {
                    ((Label)Controls.Find(z, true)[0]).Text = "";
                    ((Label)Controls.Find(z, true)[0]).ForeColor = Color.FromArgb(102,102,102);
                }
            }
            currentTurn = CurrentTurn.Player;
            UpdateTurn();
        }

        public void GoToGame()
        {
            Utils.AdaptSize(new Size(390, 480), this);
            pnlGame.BringToFront();
        }
        
        public void GoToMenu()
        {
            Utils.AdaptSize(new Size(390, 404), this);
            pnlMenu.BringToFront();
        }

        public void UpdateTurn()
        {
            if (currentTurn == CurrentTurn.Bot) label1.Text = "Aktualny ruch: Bot";
            else if (currentTurn == CurrentTurn.Player) label1.Text = "Aktualny ruch: Gracz" + (playAgainstBot ? "" : " 1");
            else if (currentTurn == CurrentTurn.Player2) label1.Text = "Aktualny ruch: Gracz 2";
        }

        private void ClickBox(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (emptyBoxes.Contains(lbl.Name) && currentTurn != CurrentTurn.Bot && !tmrEndGame.Enabled && lbl.Text == String.Empty)
            {
                if (currentTurn == CurrentTurn.Player) lbl.Text = playerChoice;
                if (currentTurn == CurrentTurn.Player2) lbl.Text = player2Choice;
                if (currentTurn == CurrentTurn.Bot) lbl.Text = botChoice;

                emptyBoxes.Remove(lbl.Name);

                if ((EvaluateResult() != GameResult.Tie) || (emptyBoxes.Count == 0))
                {
                    if(EvaluateResult() != GameResult.Null)
                    {
                        HandleResult();
                        return;
                    }
                }

                if (playAgainstBot)
                {
                    GridToBoard();
                    currentTurn = CurrentTurn.Bot;
                    tmrBotChoice.Start();
                }
                else
                {
                    if (currentTurn == CurrentTurn.Player) currentTurn = CurrentTurn.Player2;
                    else if (currentTurn == CurrentTurn.Player2) currentTurn = CurrentTurn.Player;
                }
                UpdateTurn();
            }
        }

        public void LegacyBotChoice()
        {
            string box = emptyBoxes[rnd.Next(emptyBoxes.Count)];
            foreach (Control c in pnlGame.Controls)
            {
                if (c.Name == box)
                {
                    ((Label)c).Text = botChoice;
                    currentTurn = CurrentTurn.Player;
                    emptyBoxes.Remove(box);
                    UpdateTurn();

                    if ((EvaluateResult() != GameResult.Tie) || (emptyBoxes.Count == 0))
                    {
                        HandleResult();
                        return;
                    }
                    return;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            playAgainstBot = true;
            pnlMenu.SendToBack();
            pnlGame.BringToFront();
            StartGame();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            playAgainstBot = false;
            pnlMenu.SendToBack();
            pnlGame.BringToFront();
            StartGame();
        }

        private void tmrEndGame_Tick(object sender, EventArgs e)
        {
            tmrEndGame.Stop();
            GoToMenu();
            CenterToScreen();
        }

        private void tmrBotChoice_Tick(object sender, EventArgs e)
        {
            tmrBotChoice.Stop();
            LegacyBotChoice();
        }

        private GameResult EvaluateResult()
        {
            if (grid1.Text == playerChoice && grid2.Text == playerChoice && grid3.Text == playerChoice) { grid1.ForeColor = color; grid2.ForeColor = color; grid3.ForeColor = color; return GameResult.PlayerWin; }
            if (grid4.Text == playerChoice && grid5.Text == playerChoice && grid6.Text == playerChoice) { grid4.ForeColor = color; grid5.ForeColor = color; grid6.ForeColor = color; return GameResult.PlayerWin; }
            if (grid7.Text == playerChoice && grid8.Text == playerChoice && grid9.Text == playerChoice) { grid7.ForeColor = color; grid8.ForeColor = color; grid9.ForeColor = color; return GameResult.PlayerWin; }
            if (grid1.Text == playerChoice && grid5.Text == playerChoice && grid9.Text == playerChoice) { grid1.ForeColor = color; grid5.ForeColor = color; grid9.ForeColor = color; return GameResult.PlayerWin; }
            if (grid7.Text == playerChoice && grid5.Text == playerChoice && grid3.Text == playerChoice) { grid7.ForeColor = color; grid5.ForeColor = color; grid3.ForeColor = color; return GameResult.PlayerWin; }
            if (grid1.Text == playerChoice && grid4.Text == playerChoice && grid7.Text == playerChoice) { grid1.ForeColor = color; grid4.ForeColor = color; grid7.ForeColor = color; return GameResult.PlayerWin; }
            if (grid2.Text == playerChoice && grid5.Text == playerChoice && grid8.Text == playerChoice) { grid2.ForeColor = color; grid5.ForeColor = color; grid8.ForeColor = color; return GameResult.PlayerWin; }
            if (grid3.Text == playerChoice && grid6.Text == playerChoice && grid9.Text == playerChoice) { grid3.ForeColor = color; grid6.ForeColor = color; grid9.ForeColor = color; return GameResult.PlayerWin; }

            if (grid1.Text == player2Choice && grid2.Text == player2Choice && grid3.Text == player2Choice && !playAgainstBot) { grid1.ForeColor = color; grid2.ForeColor = color; grid3.ForeColor = color; return GameResult.Player2Win; }
            if (grid4.Text == player2Choice && grid5.Text == player2Choice && grid6.Text == player2Choice && !playAgainstBot) { grid4.ForeColor = color; grid5.ForeColor = color; grid6.ForeColor = color; return GameResult.Player2Win; }
            if (grid7.Text == player2Choice && grid8.Text == player2Choice && grid9.Text == player2Choice && !playAgainstBot) { grid7.ForeColor = color; grid8.ForeColor = color; grid9.ForeColor = color; return GameResult.Player2Win; }
            if (grid1.Text == player2Choice && grid5.Text == player2Choice && grid9.Text == player2Choice && !playAgainstBot) { grid1.ForeColor = color; grid5.ForeColor = color; grid9.ForeColor = color; return GameResult.Player2Win; }
            if (grid7.Text == player2Choice && grid5.Text == player2Choice && grid3.Text == player2Choice && !playAgainstBot) { grid7.ForeColor = color; grid5.ForeColor = color; grid3.ForeColor = color; return GameResult.Player2Win; }
            if (grid1.Text == player2Choice && grid4.Text == player2Choice && grid7.Text == player2Choice && !playAgainstBot) { grid1.ForeColor = color; grid4.ForeColor = color; grid7.ForeColor = color; return GameResult.Player2Win; }
            if (grid2.Text == player2Choice && grid5.Text == player2Choice && grid8.Text == player2Choice && !playAgainstBot) { grid2.ForeColor = color; grid5.ForeColor = color; grid8.ForeColor = color; return GameResult.Player2Win; }
            if (grid3.Text == player2Choice && grid6.Text == player2Choice && grid9.Text == player2Choice && !playAgainstBot) { grid3.ForeColor = color; grid6.ForeColor = color; grid9.ForeColor = color; return GameResult.Player2Win; }

            if (grid1.Text == botChoice && grid2.Text == botChoice && grid3.Text == botChoice && playAgainstBot) { grid1.ForeColor = color; grid2.ForeColor = color; grid3.ForeColor = color; return GameResult.BotWin; }
            if (grid4.Text == botChoice && grid5.Text == botChoice && grid6.Text == botChoice && playAgainstBot) { grid4.ForeColor = color; grid5.ForeColor = color; grid6.ForeColor = color; return GameResult.BotWin; }
            if (grid7.Text == botChoice && grid8.Text == botChoice && grid9.Text == botChoice && playAgainstBot) { grid7.ForeColor = color; grid8.ForeColor = color; grid9.ForeColor = color; return GameResult.BotWin; }
            if (grid1.Text == botChoice && grid5.Text == botChoice && grid9.Text == botChoice && playAgainstBot) { grid1.ForeColor = color; grid5.ForeColor = color; grid9.ForeColor = color; return GameResult.BotWin; }
            if (grid7.Text == botChoice && grid5.Text == botChoice && grid3.Text == botChoice && playAgainstBot) { grid7.ForeColor = color; grid5.ForeColor = color; grid3.ForeColor = color; return GameResult.BotWin; }
            if (grid1.Text == botChoice && grid4.Text == botChoice && grid7.Text == botChoice && playAgainstBot) { grid1.ForeColor = color; grid4.ForeColor = color; grid7.ForeColor = color; return GameResult.BotWin; }
            if (grid2.Text == botChoice && grid5.Text == botChoice && grid8.Text == botChoice && playAgainstBot) { grid2.ForeColor = color; grid5.ForeColor = color; grid8.ForeColor = color; return GameResult.BotWin; }
            if (grid3.Text == botChoice && grid6.Text == botChoice && grid9.Text == botChoice && playAgainstBot) { grid3.ForeColor = color; grid6.ForeColor = color; grid9.ForeColor = color; return GameResult.BotWin; }

            if(emptyBoxes.Count == 0)
            {
                return GameResult.Tie;
            }
            return GameResult.Null;
        }

        public void HandleResult()
        {
            GameResult result = EvaluateResult();

            string text = "";

            if (result == GameResult.BotWin) text = "Robot wygrywa!";
            else if (result == GameResult.PlayerWin) text = "Gracz" + (playAgainstBot ? "" : " 1") + " wygrywa!";
            else if (result == GameResult.Player2Win) text = "Gracz 2 wygrywa!";
            else if (result == GameResult.Tie) text = "Remis!";
            else return;

            label1.Text = text;

            CenterToScreen();
            tmrEndGame.Start();
        }

        int CheckWhoWins(char[,] board, char forWho)
        {
            if ((board[0, 0] == forWho && board[0, 1] == forWho && board[0, 2] == forWho)
                || (board[1, 0] == forWho && board[1, 1] == forWho && board[1, 2] == forWho)
                || (board[2, 0] == forWho && board[2, 1] == forWho && board[2, 2] == forWho)
                || (board[0, 0] == forWho && board[1, 0] == forWho && board[2, 0] == forWho)
                || (board[0, 1] == forWho && board[1, 1] == forWho && board[2, 1] == forWho)
                || (board[0, 2] == forWho && board[1, 2] == forWho && board[2, 2] == forWho)
                || (board[0, 0] == forWho && board[1, 1] == forWho && board[2, 2] == forWho)
                || (board[0, 2] == forWho && board[1, 1] == forWho && board[2, 0] == forWho))
            {
                var score = 1;
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (board[i, j] == '-')
                        {
                            score++;
                        }
                    }
                }
                return score;
            }
            else
                return 0;
        }

        private void hh(object sender, EventArgs e)
        {
        }

        void AIBotMove()
        {
            int bestScore = int.MinValue;
            int moveI = -1;
            int moveJ = -1;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (board[i, j] == '-')
                    {
                        board[i, j] = 'O';
                        var score = Minimax(board, 'O');
                        board[i, j] = '-';


                        if (score > bestScore)
                        {
                            bestScore = score;
                            moveI = i;
                            moveJ = j;
                        }
                    }
                }
            }
            board[moveI, moveJ] = 'X';
            currentTurn = CurrentTurn.Player;
            BoardToGrid();

            if ((EvaluateResult() != GameResult.Tie) || (emptyBoxes.Count == 0))
            {
                HandleResult();
                return;
            }

            UpdateTurn();
        }

        int Minimax(char[,] board, char forWho)
        {
            var score = CheckWhoWins(board, forWho);
            if (score != 0)
            {
                return score;
            }

            var bestScore = forWho == 'O' ? int.MinValue : int.MaxValue;

            int CalcBest(int x, int y) => (forWho == 'O' ? x > y : y > x) ? x : y;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (board[i, j] == '-')
                    {
                        board[i, j] = forWho;
                        var currentScore = Minimax(board, forWho == 'O' ? 'X' : 'O');
                        board[i, j] = '-';

                        bestScore = CalcBest(bestScore, currentScore);
                    }
                }
            }
            return bestScore;
        }
    }
}
