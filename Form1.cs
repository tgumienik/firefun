using FireFun.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FireFun
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lbFunApps.SelectedIndex = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Opacity = 0.0;
			t1.Start();
		}

		private void fadeIn(object sender, EventArgs e)
		{
			if (Opacity >= 1.0)
			{
				t1.Stop();
			}
			else
			{
				Opacity += 0.05;
			}
		}

		private void guna2ColorTransition1_ValueChanged(object sender, EventArgs e)
		{
			btnStartApp.FillColor = guna2ColorTransition1.Value;
		}

		private void icoInfo_Click(object sender, EventArgs e)
		{
			for (int num = Application.OpenForms.Count - 1; num >= 0; num--)
			{
				if (Application.OpenForms[num].Name == "InfoForm")
				{
					Application.OpenForms[num].Close();
				}
			}
			new InfoForm().Show();
		}

		private void back(object sender, EventArgs e)
		{
			pnlFunList.Hide();
		}

		private void lbFunApps_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string text = "";
				Image image = Resources.ico_tictactoe;
				Image image2 = Resources.preview_tictactoe;
				switch (lbFunApps.SelectedIndex)
				{
					case 0:
						text = "Klasyczne kółko i krzyżyk! Z prostym robotem, lub z drugą osobą.";
						image = Resources.ico_tictactoe;
						image2 = Resources.preview_tictactoe;
						break;
					case 1:
						text = "Pa-pier, ka-mień, no-ży-ce! Kto wygra?";
						image = Resources.ico_rockpaperscissors;
						image2 = Resources.preview_rockpaperscissors;
						break;
					case 2:
						text = "Czy zgadniesz liczbę, o której myśli komputer?";
						image = Resources.ico_whatsthenumber;
						image2 = Resources.preview_whatsthenumber;
						break;
					case 3:
						text = "Prosta gra quiz. Sprawdź, co potrafisz w różnych dziedzinach!";
						image = Resources.ico_quiz;
						image2 = Resources.preview_quiz;
						break;
					case 4:
						text = "Lubię pisać, a ty? Jak szybko klikasz klawisze na klawiaturze?";
						image = Resources.ico_typingspeedtest;
						image2 = Resources.preview_typingspeedtest;
						break;
					case 5:
						text = "Czy 7x7 to na pewno 49? A może jednak 48?";
						image = Resources.ico_multiplicationtableerror;
						image2 = Resources.preview_multiplicationtableerror;
						break;
					case 6:
						text = "Wypełnij siatkę jednym kolorem!";
						image = Resources.ico_floodit;
						image2 = Resources.preview_floodit;
						break;
					case 7:
						text = "Czy ludzik zostanie powieszony?";
						image = Resources.ico_hangman;
						image2 = Resources.preview_hangman;
						break;
				}
				lblAppName.Text = lbFunApps.SelectedItem.ToString();
				lblAppDescription.Text = text;
				pbAppIcon.Image = image;
				pbAppPreview.Image = image2;
			}
			catch {}
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			switch (lbFunApps.SelectedIndex)
			{
				case 0:
					new Fun_TicTacToe().Show();
					break;
				case 1:
					new Fun_RockPaperScissors().Show();
					break;
				case 2:
					new Fun_WhatsTheNumber().Show();
					break;
				case 3:
					new Fun_Quiz().Show();
					break;
				case 4:
					new Fun_TypingSpeedTest().Show();
					break;
				case 5:
					new Fun_MultiplicationTableError().Show();
					break;
				case 6:
					new Fun_FloodIt().Show();
					break;
				case 7:
					new Fun_Hangman().Show();
					break;
			}
		}
    }
}
