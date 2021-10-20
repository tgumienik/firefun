
namespace FireFun
{
    partial class Fun_Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fun_Quiz));
            this.tmrNextQuestion = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.imgPytanie = new System.Windows.Forms.PictureBox();
            this.btnAnswer4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswer3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswer2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswer1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblPytanie = new System.Windows.Forms.Label();
            this.lblPytanieIndex = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPytanie)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrNextQuestion
            // 
            this.tmrNextQuestion.Interval = 1500;
            this.tmrNextQuestion.Tick += new System.EventHandler(this.tmrNextQuestion_Tick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.guna2Button1);
            this.pnlMenu.Controls.Add(this.comboBox1);
            this.pnlMenu.Controls.Add(this.label25);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(395, 357);
            this.pnlMenu.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(127, 186);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(141, 46);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Zacznij";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Animated = true;
            this.comboBox1.AutoRoundedCorners = true;
            this.comboBox1.BackColor = System.Drawing.Color.Transparent;
            this.comboBox1.BorderRadius = 17;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox1.FocusedState.Parent = this.comboBox1;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox1.HoverState.Parent = this.comboBox1;
            this.comboBox1.ItemHeight = 30;
            this.comboBox1.Items.AddRange(new object[] {
            "Matematyka",
            "Ortografia",
            "Geografia"});
            this.comboBox1.ItemsAppearance.Parent = this.comboBox1;
            this.comboBox1.Location = new System.Drawing.Point(203, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ShadowDecoration.Parent = this.comboBox1;
            this.comboBox1.Size = new System.Drawing.Size(140, 36);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(52, 129);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(141, 25);
            this.label25.TabIndex = 10;
            this.label25.Text = "Kategoria pytań:";
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.imgPytanie);
            this.pnlGame.Controls.Add(this.btnAnswer4);
            this.pnlGame.Controls.Add(this.btnAnswer3);
            this.pnlGame.Controls.Add(this.btnAnswer2);
            this.pnlGame.Controls.Add(this.btnAnswer1);
            this.pnlGame.Controls.Add(this.lblPytanie);
            this.pnlGame.Controls.Add(this.lblPytanieIndex);
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(395, 656);
            this.pnlGame.TabIndex = 13;
            // 
            // imgPytanie
            // 
            this.imgPytanie.Image = ((System.Drawing.Image)(resources.GetObject("imgPytanie.Image")));
            this.imgPytanie.Location = new System.Drawing.Point(22, 22);
            this.imgPytanie.Name = "imgPytanie";
            this.imgPytanie.Size = new System.Drawing.Size(350, 350);
            this.imgPytanie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPytanie.TabIndex = 14;
            this.imgPytanie.TabStop = false;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Animated = true;
            this.btnAnswer4.AutoRoundedCorners = true;
            this.btnAnswer4.BorderRadius = 22;
            this.btnAnswer4.CheckedState.Parent = this.btnAnswer4;
            this.btnAnswer4.CustomImages.Parent = this.btnAnswer4;
            this.btnAnswer4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnswer4.ForeColor = System.Drawing.Color.White;
            this.btnAnswer4.HoverState.Parent = this.btnAnswer4;
            this.btnAnswer4.Location = new System.Drawing.Point(200, 540);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.ShadowDecoration.Parent = this.btnAnswer4;
            this.btnAnswer4.Size = new System.Drawing.Size(178, 46);
            this.btnAnswer4.TabIndex = 12;
            this.btnAnswer4.Click += new System.EventHandler(this.answerQuestion);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Animated = true;
            this.btnAnswer3.AutoRoundedCorners = true;
            this.btnAnswer3.BorderRadius = 22;
            this.btnAnswer3.CheckedState.Parent = this.btnAnswer3;
            this.btnAnswer3.CustomImages.Parent = this.btnAnswer3;
            this.btnAnswer3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnswer3.ForeColor = System.Drawing.Color.White;
            this.btnAnswer3.HoverState.Parent = this.btnAnswer3;
            this.btnAnswer3.Location = new System.Drawing.Point(16, 540);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.ShadowDecoration.Parent = this.btnAnswer3;
            this.btnAnswer3.Size = new System.Drawing.Size(178, 46);
            this.btnAnswer3.TabIndex = 12;
            this.btnAnswer3.Click += new System.EventHandler(this.answerQuestion);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Animated = true;
            this.btnAnswer2.AutoRoundedCorners = true;
            this.btnAnswer2.BorderRadius = 22;
            this.btnAnswer2.CheckedState.Parent = this.btnAnswer2;
            this.btnAnswer2.CustomImages.Parent = this.btnAnswer2;
            this.btnAnswer2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnswer2.ForeColor = System.Drawing.Color.White;
            this.btnAnswer2.HoverState.Parent = this.btnAnswer2;
            this.btnAnswer2.Location = new System.Drawing.Point(200, 592);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.ShadowDecoration.Parent = this.btnAnswer2;
            this.btnAnswer2.Size = new System.Drawing.Size(178, 46);
            this.btnAnswer2.TabIndex = 12;
            this.btnAnswer2.Click += new System.EventHandler(this.answerQuestion);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Animated = true;
            this.btnAnswer1.AutoRoundedCorners = true;
            this.btnAnswer1.BorderRadius = 22;
            this.btnAnswer1.CheckedState.Parent = this.btnAnswer1;
            this.btnAnswer1.CustomImages.Parent = this.btnAnswer1;
            this.btnAnswer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnswer1.ForeColor = System.Drawing.Color.White;
            this.btnAnswer1.HoverState.Parent = this.btnAnswer1;
            this.btnAnswer1.Location = new System.Drawing.Point(16, 592);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.ShadowDecoration.Parent = this.btnAnswer1;
            this.btnAnswer1.Size = new System.Drawing.Size(178, 46);
            this.btnAnswer1.TabIndex = 12;
            this.btnAnswer1.Click += new System.EventHandler(this.answerQuestion);
            // 
            // lblPytanie
            // 
            this.lblPytanie.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblPytanie.ForeColor = System.Drawing.Color.White;
            this.lblPytanie.Location = new System.Drawing.Point(13, 413);
            this.lblPytanie.Name = "lblPytanie";
            this.lblPytanie.Size = new System.Drawing.Size(369, 124);
            this.lblPytanie.TabIndex = 13;
            this.lblPytanie.Text = "Pytanie 1";
            this.lblPytanie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPytanieIndex
            // 
            this.lblPytanieIndex.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPytanieIndex.ForeColor = System.Drawing.Color.White;
            this.lblPytanieIndex.Location = new System.Drawing.Point(12, 397);
            this.lblPytanieIndex.Name = "lblPytanieIndex";
            this.lblPytanieIndex.Size = new System.Drawing.Size(370, 32);
            this.lblPytanieIndex.TabIndex = 13;
            this.lblPytanieIndex.Text = "Pytanie 1";
            this.lblPytanieIndex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Fun_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(394, 356);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fun_Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fireFun | Quiz";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPytanie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrNextQuestion;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox1;
        private System.Windows.Forms.Label label25;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel pnlGame;
        private Guna.UI2.WinForms.Guna2Button btnAnswer4;
        private Guna.UI2.WinForms.Guna2Button btnAnswer3;
        private Guna.UI2.WinForms.Guna2Button btnAnswer2;
        private Guna.UI2.WinForms.Guna2Button btnAnswer1;
        private System.Windows.Forms.Label lblPytanie;
        private System.Windows.Forms.Label lblPytanieIndex;
        private System.Windows.Forms.PictureBox imgPytanie;
    }
}