
namespace FireFun
{
    partial class Fun_TicTacToe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fun_TicTacToe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.grid9 = new System.Windows.Forms.Label();
            this.grid7 = new System.Windows.Forms.Label();
            this.grid6 = new System.Windows.Forms.Label();
            this.grid4 = new System.Windows.Forms.Label();
            this.grid8 = new System.Windows.Forms.Label();
            this.grid2 = new System.Windows.Forms.Label();
            this.grid5 = new System.Windows.Forms.Label();
            this.grid3 = new System.Windows.Forms.Label();
            this.grid1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tmrEndGame = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tmrBotChoice = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlGame.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlGame.Controls.Add(this.grid9);
            this.pnlGame.Controls.Add(this.grid7);
            this.pnlGame.Controls.Add(this.grid6);
            this.pnlGame.Controls.Add(this.grid4);
            this.pnlGame.Controls.Add(this.grid8);
            this.pnlGame.Controls.Add(this.grid2);
            this.pnlGame.Controls.Add(this.grid5);
            this.pnlGame.Controls.Add(this.grid3);
            this.pnlGame.Controls.Add(this.grid1);
            this.pnlGame.Controls.Add(this.pictureBox1);
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(370, 361);
            this.pnlGame.TabIndex = 1;
            // 
            // grid9
            // 
            this.grid9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grid9.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.grid9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grid9.Location = new System.Drawing.Point(251, 246);
            this.grid9.Name = "grid9";
            this.grid9.Size = new System.Drawing.Size(102, 102);
            this.grid9.TabIndex = 1;
            this.grid9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grid9.Click += new System.EventHandler(this.ClickBox);
            // 
            // grid7
            // 
            this.grid7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grid7.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.grid7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grid7.Location = new System.Drawing.Point(17, 246);
            this.grid7.Name = "grid7";
            this.grid7.Size = new System.Drawing.Size(102, 102);
            this.grid7.TabIndex = 1;
            this.grid7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grid7.Click += new System.EventHandler(this.ClickBox);
            // 
            // grid6
            // 
            this.grid6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grid6.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.grid6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grid6.Location = new System.Drawing.Point(251, 129);
            this.grid6.Name = "grid6";
            this.grid6.Size = new System.Drawing.Size(102, 102);
            this.grid6.TabIndex = 1;
            this.grid6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grid6.Click += new System.EventHandler(this.ClickBox);
            // 
            // grid4
            // 
            this.grid4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grid4.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.grid4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grid4.Location = new System.Drawing.Point(17, 129);
            this.grid4.Name = "grid4";
            this.grid4.Size = new System.Drawing.Size(102, 102);
            this.grid4.TabIndex = 1;
            this.grid4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grid4.Click += new System.EventHandler(this.ClickBox);
            // 
            // grid8
            // 
            this.grid8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grid8.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.grid8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grid8.Location = new System.Drawing.Point(134, 246);
            this.grid8.Name = "grid8";
            this.grid8.Size = new System.Drawing.Size(102, 102);
            this.grid8.TabIndex = 1;
            this.grid8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grid8.Click += new System.EventHandler(this.ClickBox);
            // 
            // grid2
            // 
            this.grid2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grid2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.grid2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grid2.Location = new System.Drawing.Point(134, 12);
            this.grid2.Name = "grid2";
            this.grid2.Size = new System.Drawing.Size(102, 102);
            this.grid2.TabIndex = 1;
            this.grid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grid2.Click += new System.EventHandler(this.ClickBox);
            // 
            // grid5
            // 
            this.grid5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grid5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.grid5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grid5.Location = new System.Drawing.Point(134, 129);
            this.grid5.Name = "grid5";
            this.grid5.Size = new System.Drawing.Size(102, 102);
            this.grid5.TabIndex = 1;
            this.grid5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grid5.Click += new System.EventHandler(this.ClickBox);
            // 
            // grid3
            // 
            this.grid3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grid3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.grid3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grid3.Location = new System.Drawing.Point(251, 12);
            this.grid3.Name = "grid3";
            this.grid3.Size = new System.Drawing.Size(102, 102);
            this.grid3.TabIndex = 1;
            this.grid3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grid3.Click += new System.EventHandler(this.ClickBox);
            // 
            // grid1
            // 
            this.grid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grid1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.grid1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grid1.Location = new System.Drawing.Point(17, 12);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(102, 102);
            this.grid1.TabIndex = 1;
            this.grid1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grid1.Click += new System.EventHandler(this.ClickBox);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlMenu.Controls.Add(this.guna2Button2);
            this.pnlMenu.Controls.Add(this.guna2Button1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(370, 361);
            this.pnlMenu.TabIndex = 2;
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(95, 183);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "Graj z przyjacielem";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(95, 132);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Graj z robotem";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tmrEndGame
            // 
            this.tmrEndGame.Interval = 3000;
            this.tmrEndGame.Tick += new System.EventHandler(this.tmrEndGame_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 62);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrBotChoice
            // 
            this.tmrBotChoice.Interval = 500;
            this.tmrBotChoice.Tick += new System.EventHandler(this.tmrBotChoice_Tick);
            // 
            // Fun_TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(370, 361);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fun_TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fireFun | Kółko i Krzyżyk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlGame.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label grid9;
        private System.Windows.Forms.Label grid7;
        private System.Windows.Forms.Label grid6;
        private System.Windows.Forms.Label grid4;
        private System.Windows.Forms.Label grid8;
        private System.Windows.Forms.Label grid2;
        private System.Windows.Forms.Label grid5;
        private System.Windows.Forms.Label grid3;
        private System.Windows.Forms.Label grid1;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Timer tmrEndGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrBotChoice;
    }
}