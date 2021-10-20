
namespace FireFun
{
    partial class Fun_WhatsTheNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fun_WhatsTheNumber));
            this.nudMin = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudMax = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.btnGuess = new Guna.UI2.WinForms.Guna2Button();
            this.nudGuess = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblIncorrectAnswers = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMin
            // 
            this.nudMin.AutoRoundedCorners = true;
            this.nudMin.BackColor = System.Drawing.Color.Transparent;
            this.nudMin.BorderRadius = 17;
            this.nudMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudMin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudMin.DisabledState.Parent = this.nudMin;
            this.nudMin.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudMin.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudMin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudMin.FocusedState.Parent = this.nudMin;
            this.nudMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudMin.Location = new System.Drawing.Point(146, 112);
            this.nudMin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.ShadowDecoration.Parent = this.nudMin;
            this.nudMin.Size = new System.Drawing.Size(159, 36);
            this.nudMin.TabIndex = 0;
            this.nudMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMax
            // 
            this.nudMax.AutoRoundedCorners = true;
            this.nudMax.BackColor = System.Drawing.Color.Transparent;
            this.nudMax.BorderRadius = 17;
            this.nudMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudMax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudMax.DisabledState.Parent = this.nudMax;
            this.nudMax.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudMax.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudMax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudMax.FocusedState.Parent = this.nudMax;
            this.nudMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudMax.Location = new System.Drawing.Point(146, 154);
            this.nudMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.ShadowDecoration.Parent = this.nudMax;
            this.nudMax.Size = new System.Drawing.Size(159, 36);
            this.nudMax.TabIndex = 0;
            this.nudMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max:";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.guna2Button1);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.nudMin);
            this.pnlMenu.Controls.Add(this.nudMax);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(388, 365);
            this.pnlMenu.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(104, 207);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Start";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.btnGuess);
            this.pnlGame.Controls.Add(this.nudGuess);
            this.pnlGame.Controls.Add(this.lblIncorrectAnswers);
            this.pnlGame.Controls.Add(this.lblRange);
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(388, 365);
            this.pnlGame.TabIndex = 3;
            // 
            // btnGuess
            // 
            this.btnGuess.Animated = true;
            this.btnGuess.AutoRoundedCorners = true;
            this.btnGuess.BorderRadius = 21;
            this.btnGuess.CheckedState.Parent = this.btnGuess;
            this.btnGuess.CustomImages.Parent = this.btnGuess;
            this.btnGuess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuess.ForeColor = System.Drawing.Color.White;
            this.btnGuess.HoverState.Parent = this.btnGuess;
            this.btnGuess.Location = new System.Drawing.Point(125, 187);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.ShadowDecoration.Parent = this.btnGuess;
            this.btnGuess.Size = new System.Drawing.Size(138, 45);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Zgadnij";
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // nudGuess
            // 
            this.nudGuess.AutoRoundedCorners = true;
            this.nudGuess.BackColor = System.Drawing.Color.Transparent;
            this.nudGuess.BorderRadius = 17;
            this.nudGuess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudGuess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudGuess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudGuess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudGuess.DisabledState.Parent = this.nudGuess;
            this.nudGuess.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudGuess.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudGuess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudGuess.FocusedState.Parent = this.nudGuess;
            this.nudGuess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudGuess.Location = new System.Drawing.Point(124, 133);
            this.nudGuess.Name = "nudGuess";
            this.nudGuess.ShadowDecoration.Parent = this.nudGuess;
            this.nudGuess.Size = new System.Drawing.Size(140, 36);
            this.nudGuess.TabIndex = 1;
            // 
            // lblIncorrectAnswers
            // 
            this.lblIncorrectAnswers.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblIncorrectAnswers.ForeColor = System.Drawing.Color.White;
            this.lblIncorrectAnswers.Location = new System.Drawing.Point(2, 173);
            this.lblIncorrectAnswers.Name = "lblIncorrectAnswers";
            this.lblIncorrectAnswers.Size = new System.Drawing.Size(385, 182);
            this.lblIncorrectAnswers.TabIndex = 0;
            this.lblIncorrectAnswers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblRange
            // 
            this.lblRange.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblRange.ForeColor = System.Drawing.Color.White;
            this.lblRange.Location = new System.Drawing.Point(0, 10);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(385, 182);
            this.lblRange.TabIndex = 0;
            this.lblRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Fun_WhatsTheNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 404);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 404);
            this.Name = "Fun_WhatsTheNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fireFun | Jaki to numer?";
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGuess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown nudMin;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblRange;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudGuess;
        private Guna.UI2.WinForms.Guna2Button btnGuess;
        private System.Windows.Forms.Label lblIncorrectAnswers;
    }
}