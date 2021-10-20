using System;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FireFun
{
    public partial class Fun_WhatsTheNumber : Form
    {
        DateTime gameStart;

        int min = 0, max = 0, number = 0, maxGuesses = 10;

        bool gameInProgress = false;

        Random rnd = new Random();

        List<int> incorrectGuesses = new List<int>();

        public Fun_WhatsTheNumber()
        {
            InitializeComponent();
            pnlGame.SendToBack();
        }

        public void StartGame(int min, int max)
        {
            this.min = Math.Min(min, 999);
            this.max = Math.Min(max, 1000);

            maxGuesses = (int)Math.Round((double)((this.max - this.min) + 1) / (double)2);
            if (maxGuesses < 1) maxGuesses = 1;

            gameInProgress = true;
            
            nudGuess.Minimum = this.min;
            nudGuess.Maximum = this.max;
            nudGuess.Value = this.min;

            incorrectGuesses = new List<int>();
            number = rnd.Next(this.min, this.max + 1);

            UpdateRange();
            UpdateIncorrectGuesses();

            gameStart = DateTime.Now;
            pnlGame.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (nudMin.Value > nudMax.Value)
            {
                decimal min = nudMin.Value;
                decimal max = nudMax.Value;

                nudMin.Value = max;
                nudMax.Value = min;
            }

            if (gameInProgress) return;

            StartGame(int.Parse(nudMin.Value.ToString()), int.Parse(nudMax.Value.ToString()));
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (incorrectGuesses.Contains((int)nudGuess.Value))
            {
                MessageBox.Show("Ten numer został zgadywany wcześniej!", "fireFun", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    synth.SetOutputToDefaultAudioDevice();

                    int num = (int)nudGuess.Value;   

                    string text = "Poprawnie!";
                    if (num > number) { text = "Numer o którym myślę jest mniejszy."; incorrectGuesses.Add((int)num); }
                    else if (num < number) { text = "Numer o którym myślę jest większy."; incorrectGuesses.Add((int)num); }

                    Invoke(new MethodInvoker(delegate
                    {
                        lblRange.Text = text;
                        btnGuess.Enabled = false;
                    }));

                    synth.Speak(text);

                    Invoke(new MethodInvoker(delegate {
                        UpdateRange();
                        UpdateIncorrectGuesses();
                        btnGuess.Enabled = true;

                        string gameStatus = "";
                        bool end = false;

                        if(num == number)
                        {
                            gameStatus = "Wygrana";
                            end = true;
                        } else if (incorrectGuesses.Count == maxGuesses)
                        {
                            gameStatus = "Przegrana";
                            end = true;
                        }

                        if (end)
                        {
                            gameInProgress = false;
                            pnlMenu.BringToFront();

                            TimeSpan ts = DateTime.Now - gameStart;

                            MessageBox.Show("- " + gameStatus + "! -" + "\n\nNumer: " + number + "\nNiepoprawne próby: " + incorrectGuesses.Count + "\nData: " + string.Format("{0}.{1}.{2}", DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year) + "\nCzas gry: " + ts.ToString(@"mm\:ss"), "fireFun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }));
                }
            }).Start();
        }

        public void UpdateIncorrectGuesses()
        {
            if(incorrectGuesses.Count == 0)
            {
                lblIncorrectAnswers.Text = "Niepoprawne odpowiedzi: Brak";
            } else
            {
                lblIncorrectAnswers.Text = "Niepoprawne odpowiedzi: " + string.Join(", ", incorrectGuesses);
            }
            lblIncorrectAnswers.Text = lblIncorrectAnswers.Text + "\nPróby: " + incorrectGuesses.Count + "/" + maxGuesses;
        }
        
        public void UpdateRange()
        {
            lblRange.Text = "Odgadnij numer od " + min + " do " + max + ".";
        }
    }
}
