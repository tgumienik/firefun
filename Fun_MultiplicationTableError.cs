using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FireFun
{
    public partial class Fun_MultiplicationTableError : Form
    {

        List<string> errorStrings = new List<string>();
        string errorString = "";
        bool hardCoreMode = false;
        DateTime gameStart;
        int score = 0;
        int timeLeft = 0;
        Difficulty dif = Difficulty.Medium;

        public enum Difficulty { Easy, Medium, Hard, Nightmare }

        Random rnd = new Random();

        public Fun_MultiplicationTableError()
        {
            InitializeComponent();
            ResetLabels();
            pnlCorrectIncorrect.Location = new Point(0, 0);
            guna2ComboBox1.SelectedIndex = 1;

            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            string hardcore = "Gra kończy się po popełnieniu jednego błędu.";
            toolTip.SetToolTip(guna2CheckBox1, hardcore);
            toolTip.SetToolTip(label26, hardcore);
        }

        public List<int> GetDifferenceInError()
        {
            if (dif == Difficulty.Easy) return new List<int>() { -10, -9, -8, -7, 7, 8, 9, 10 } ;
            else if (dif == Difficulty.Medium) return new List<int>() { -4, -5, 4, 5 };
            else if (dif == Difficulty.Hard) return new List<int>() { 2, 3, -2, -3 };
            else if (dif == Difficulty.Nightmare) return new List<int>() { 1, -1 };
            return new List<int>() { 5, -5 }; ;
        }

        public int GetDefaultTime()
        {
            if (dif == Difficulty.Easy) return 150 * 1000;
            else if (dif == Difficulty.Medium) return 120 * 1000;
            else if (dif == Difficulty.Hard) return 90 * 1000;
            else if (dif == Difficulty.Nightmare) return 60 * 1000;
            return 150 * 1000;
        }

        public string GetDifficultyName()
        {
            if (dif == Difficulty.Easy) return "Łatwy";
            else if (dif == Difficulty.Medium) return "Średni";
            else if (dif == Difficulty.Hard) return "Trudny";
            else if (dif == Difficulty.Nightmare) return "Koszmar";
            return "Błąd";
        }

        public string ProcessNums(string str)
        {
            str = str.Replace("one", "1");
            str = str.Replace("two", "2");
            str = str.Replace("three", "3");
            str = str.Replace("four", "4");
            str = str.Replace("five", "5");
            str = str.Replace("six", "6");
            str = str.Replace("seven", "7");
            str = str.Replace("eight", "8");
            str = str.Replace("nine", "9");
            str = str.Replace("zero", "0");
            str = str.Replace("ten", "10");

            return str;
        }

        public void StartGame()
        {
            tmrTime.Start();
            gameStart = DateTime.Now;
            score = 0;
            timeLeft = GetDefaultTime();
            ResetLabels();
            RefreshErrorStrings();
            PickNewError();
        }

        public void EndGame()
        {
            pnlMenu.Show();
            tmrTime.Stop();
            TimeSpan ts = DateTime.Now - gameStart;
            MessageBox.Show("- " + "Koniec gry" + "! -" + "\n\nWynik: " + score + "\nTryb Hardcore: " + (hardCoreMode ? "Tak" : "Nie") + "\nTryb gry: " + GetDifficultyName() + "\nData: " + string.Format("{0}.{1}.{2}", DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year) + "\nCzas gry: " + ts.ToString(@"mm\:ss"), "fireFun", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RefreshErrorStrings()
        {
            errorStrings.Clear();
            foreach(Control c in pnlGame.Controls)
            {
                if(c is Label && c.Tag != null)
                {
                    if(c.Tag.ToString() == "calc")
                    {
                        errorStrings.Add(c.Name.ToString());
                    }
                }
            }
        }
        public void PickNewError()
        {
            if (errorStrings.Count == 0) RefreshErrorStrings(); 

            errorString = errorStrings[rnd.Next(errorStrings.Count)];
            foreach (Control c in pnlGame.Controls)
            {
                if (c.Name == errorString)
                {
                    List<int> options = GetDifferenceInError();
                    int x = options[rnd.Next(options.Count)];
                    ((Label)c).Text = (CalculateByName(c.Name) + x).ToString();
                    errorStrings.Remove(c.Name);
                }
            }
        }

        public void ResetLabels()
        {
            foreach (Control c in pnlGame.Controls)
            {
                if (c is Label && c.Tag != null)
                {
                    string tag = c.Tag.ToString();
                    if ((tag == "calc" || tag == "calc-non") && c.Name.Contains("_x_"))
                    {
                        ((Label)c).Text = CalculateByName(c.Name).ToString();
                    }
                }
            }
        }

        public int CalculateByName(string name)
        {
            string one = ProcessNums(name.Split(new string[] { "_x_" }, StringSplitOptions.None)[0]);
            string two = ProcessNums(name.Split(new string[] { "_x_" }, StringSplitOptions.None)[1]);

            int oneInt = int.Parse(one);
            int twoInt = int.Parse(two);

            return oneInt * twoInt;
        }

        private void ErrorSelect(object sender, EventArgs e)
        {
            if (errorString == ((Label)sender).Name)
            {
                score += 15;
                tmrTime.Stop();
                pnlCorrectIncorrect.Show();
                ResetLabels();
                label1.Text = "Poprawnie!";
                tmrHidePnl.Start();
                PickNewError();

                UpdateScore();
            } else
            {
                WrongGuess();
            }
        }

        public void WrongGuess()
        {
            if (hardCoreMode)
            {
                EndGame();
            } else
            {
                score -= 15;
                timeLeft = timeLeft - (10 * 1000);
                tmrTime.Stop();
                pnlCorrectIncorrect.Show();
                label1.Text = "Źle!";
                UpdateScore();
                tmrHidePnl.Start();
            }
        }

        public void UpdateScore()
        {
            TimeSpan ts = TimeSpan.FromMilliseconds(timeLeft);
            label22.Text = "Czas: " + ts.ToString(@"mm\:ss");
            label23.Text = "Wynik: " + score;
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 250;
            UpdateScore();
            if (timeLeft <= 0)
            {
                EndGame();
            }
        }

        private void tmrHidePnl_Tick(object sender, EventArgs e)
        {
            tmrTime.Start();
            pnlCorrectIncorrect.Hide();
            tmrHidePnl.Stop();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            hardCoreMode = guna2CheckBox1.Checked;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StartGame();
            pnlMenu.Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0) dif = Difficulty.Easy;
            else if (guna2ComboBox1.SelectedIndex == 1) dif = Difficulty.Medium;
            else if (guna2ComboBox1.SelectedIndex == 2) dif = Difficulty.Hard;
            else if (guna2ComboBox1.SelectedIndex == 3) dif = Difficulty.Nightmare;
        }
    }
}
