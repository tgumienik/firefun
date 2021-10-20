
namespace FireFun
{
    partial class Fun_RockPaperScissors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fun_RockPaperScissors));
            this.label1 = new System.Windows.Forms.Label();
            this.pbPaper = new System.Windows.Forms.PictureBox();
            this.pbRock = new System.Windows.Forms.PictureBox();
            this.pbScissors = new System.Windows.Forms.PictureBox();
            this.pnlGameResults = new System.Windows.Forms.Panel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.lblBot = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbBot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).BeginInit();
            this.pnlGameResults.SuspendLayout();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 280);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gracz: 0\r\nRobot: 0\r\nRemisy: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbPaper
            // 
            this.pbPaper.Image = global::FireFun.Properties.Resources.paper;
            this.pbPaper.Location = new System.Drawing.Point(12, 99);
            this.pbPaper.Name = "pbPaper";
            this.pbPaper.Size = new System.Drawing.Size(200, 200);
            this.pbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPaper.TabIndex = 1;
            this.pbPaper.TabStop = false;
            this.pbPaper.Tag = "paper";
            this.pbPaper.Click += new System.EventHandler(this.Select);
            // 
            // pbRock
            // 
            this.pbRock.Image = global::FireFun.Properties.Resources.rock;
            this.pbRock.Location = new System.Drawing.Point(218, 99);
            this.pbRock.Name = "pbRock";
            this.pbRock.Size = new System.Drawing.Size(200, 200);
            this.pbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRock.TabIndex = 1;
            this.pbRock.TabStop = false;
            this.pbRock.Tag = "rock";
            this.pbRock.Click += new System.EventHandler(this.Select);
            // 
            // pbScissors
            // 
            this.pbScissors.Image = global::FireFun.Properties.Resources.scissors;
            this.pbScissors.Location = new System.Drawing.Point(424, 99);
            this.pbScissors.Name = "pbScissors";
            this.pbScissors.Size = new System.Drawing.Size(200, 200);
            this.pbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScissors.TabIndex = 1;
            this.pbScissors.TabStop = false;
            this.pbScissors.Tag = "scissors";
            this.pbScissors.Click += new System.EventHandler(this.Select);
            // 
            // pnlGameResults
            // 
            this.pnlGameResults.Controls.Add(this.pnlGame);
            this.pnlGameResults.Controls.Add(this.guna2Button1);
            this.pnlGameResults.Controls.Add(this.lblGameResult);
            this.pnlGameResults.Controls.Add(this.lblBot);
            this.pnlGameResults.Controls.Add(this.lblPlayer);
            this.pnlGameResults.Controls.Add(this.pbPlayer);
            this.pnlGameResults.Controls.Add(this.pbBot);
            this.pnlGameResults.Location = new System.Drawing.Point(0, 0);
            this.pnlGameResults.Name = "pnlGameResults";
            this.pnlGameResults.Size = new System.Drawing.Size(636, 311);
            this.pnlGameResults.TabIndex = 2;
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.pbRock);
            this.pnlGame.Controls.Add(this.pbScissors);
            this.pnlGame.Controls.Add(this.pbPaper);
            this.pnlGame.Controls.Add(this.label1);
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(636, 311);
            this.pnlGame.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(228, 267);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 31);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Powrót";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblGameResult
            // 
            this.lblGameResult.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblGameResult.ForeColor = System.Drawing.Color.White;
            this.lblGameResult.Location = new System.Drawing.Point(107, 221);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(422, 32);
            this.lblGameResult.TabIndex = 1;
            this.lblGameResult.Text = "Bot";
            this.lblGameResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBot
            // 
            this.lblBot.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblBot.ForeColor = System.Drawing.Color.White;
            this.lblBot.Location = new System.Drawing.Point(351, 15);
            this.lblBot.Name = "lblBot";
            this.lblBot.Size = new System.Drawing.Size(178, 30);
            this.lblBot.TabIndex = 1;
            this.lblBot.Text = "Bot";
            this.lblBot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(108, 15);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(178, 30);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Gracz";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(111, 48);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(175, 175);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbBot
            // 
            this.pbBot.Location = new System.Drawing.Point(354, 48);
            this.pbBot.Name = "pbBot";
            this.pbBot.Size = new System.Drawing.Size(175, 175);
            this.pbBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBot.TabIndex = 0;
            this.pbBot.TabStop = false;
            // 
            // Fun_RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(636, 311);
            this.Controls.Add(this.pnlGameResults);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(652, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 350);
            this.Name = "Fun_RockPaperScissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fireFun | Papier, Kamień, Nożyce!";
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).EndInit();
            this.pnlGameResults.ResumeLayout(false);
            this.pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPaper;
        private System.Windows.Forms.PictureBox pbRock;
        private System.Windows.Forms.PictureBox pbScissors;
        private System.Windows.Forms.Panel pnlGameResults;
        private System.Windows.Forms.Label lblBot;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbBot;
        private System.Windows.Forms.Label lblGameResult;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel pnlGame;
    }
}