using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FireFun
{
    public partial class Fun_FloodIt : Form
    {
        private GridElement[,] grid;
        private Color currColor, origColor;
        private int rows, cols, clicks = 0;
        private DateTime gameStart;
        private int size = 25;

        public Fun_FloodIt()
        {
            InitializeComponent();
            GoToMenu();
            guna2ComboBox1.SelectedIndex = 1;
        }

        public void StartGame()
        {
            clicks = 0;
            pnlGameGrid.Controls.Clear();
            gameStart = DateTime.Now;
            populateGrid();
            GoToGame();
        }

        public void GoToMenu()
        {
            Utils.AdaptSize(new Size(467, 491), this);
            pnlGame.Hide();
            pnlMenu.Show();
            pnlMenu.BringToFront();
        }

        public void GoToGame()
        {
            Utils.AdaptSize(new Size(467, 586), this);
            pnlGame.Show();
            pnlMenu.Hide();
            pnlGame.BringToFront();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            currColor = ((Guna2CircleButton)sender).FillColor;
            origColor = grid[0, 0].BackColor;
            if (!origColor.Equals(currColor)) { floodFill(0, 0); clicks++; UpdateStats(); win(); }
        }

        public void win()
        {
            List<Color> colors = new List<Color>();
            foreach (GridElement c in grid)
            {
                colors.Add(c.BackColor);
            }
            if (colors.Distinct().Count() == 1)
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            GoToMenu();
            TimeSpan ts = DateTime.Now - gameStart;
            MessageBox.Show("- " + "Koniec gry" + "! -" + "\n\nRuchy: " + clicks + "\nData: " + string.Format("{0}.{1}.{2}", DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year) + "\nCzas gry: " + ts.ToString(@"mm\:ss"), "fireFun", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void populateGrid()
        {
            cols = pnlGameGrid.Height / size;
            rows = pnlGameGrid.Width / size;

            grid = new GridElement[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c] = new GridElement(size);
                    grid[r, c].row = r;
                    grid[r, c].col = c;

                    pnlGameGrid.Controls.Add(grid[r, c]);
                    grid[r, c].Location = new Point(r * GridElement.size, c * GridElement.size);
                }
            }
        }

        public void UpdateStats()
        {
            label1.Text = "Ruchy: " + clicks;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pnlMenu.Visible) return;

            if (guna2ComboBox1.SelectedIndex == 0) size = 35;
            else if (guna2ComboBox1.SelectedIndex == 1) size = 25;
            else if (guna2ComboBox1.SelectedIndex == 2) size = 15;
        }

        private void NEWGAME(object sender, EventArgs e)
        {
            pnlGameGrid.Controls.Clear();
            populateGrid();
        }

        private void floodFill(int r, int c)
        {
            if (isValid(r, c) && grid[r, c].BackColor.Equals(origColor))
            {
                grid[r, c].BackColor = currColor;
                floodFill(r + 1, c);
                floodFill(r - 1, c);
                floodFill(r, c + 1);
                floodFill(r, c - 1);
            }
        }

        private bool isValid(int r, int c)
        {
            if (r >= 0 && r < rows && c >= 0 && c < cols) return true;
            else return false;
        }

    }
}
