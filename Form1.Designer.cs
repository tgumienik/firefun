
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace FireFun
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

		private Label label1;

		private PictureBox icoInfo;

		private Guna2ColorTransition guna2ColorTransition1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.icoInfo = new System.Windows.Forms.PictureBox();
            this.lbFunApps = new System.Windows.Forms.ListBox();
            this.pbAppIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppDescription = new System.Windows.Forms.Label();
            this.btnStartApp = new Guna.UI2.WinForms.Guna2Button();
            this.pbAppPreview = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlFunList = new System.Windows.Forms.Panel();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icoInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppPreview)).BeginInit();
            this.pnlFunList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proste i pomocne matematyczne aplikacje!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.AutoTransition = true;
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Green,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DarkBlue};
            this.guna2ColorTransition1.EndColor = System.Drawing.Color.DarkBlue;
            this.guna2ColorTransition1.Interval = 1;
            this.guna2ColorTransition1.ValueChanged += new System.EventHandler(this.guna2ColorTransition1_ValueChanged);
            // 
            // icoInfo
            // 
            this.icoInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.icoInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.icoInfo.Image = ((System.Drawing.Image)(resources.GetObject("icoInfo.Image")));
            this.icoInfo.Location = new System.Drawing.Point(401, 463);
            this.icoInfo.Name = "icoInfo";
            this.icoInfo.Size = new System.Drawing.Size(51, 48);
            this.icoInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoInfo.TabIndex = 0;
            this.icoInfo.TabStop = false;
            this.icoInfo.Click += new System.EventHandler(this.icoInfo_Click);
            // 
            // lbFunApps
            // 
            this.lbFunApps.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbFunApps.FormattingEnabled = true;
            this.lbFunApps.Items.AddRange(new object[] {
            "Kółko i Krzyżyk",
            "Papier, Kamień, Nożyce!",
            "Jaki to numer?",
            "Quiz",
            "Jak szybko piszesz?",
            "Błąd w tabliczce mnożenia",
            "Flood It!",
            "Wisielec"});
            this.lbFunApps.Location = new System.Drawing.Point(9, 9);
            this.lbFunApps.Name = "lbFunApps";
            this.lbFunApps.Size = new System.Drawing.Size(162, 433);
            this.lbFunApps.TabIndex = 1;
            this.lbFunApps.SelectedIndexChanged += new System.EventHandler(this.lbFunApps_SelectedIndexChanged);
            // 
            // pbAppIcon
            // 
            this.pbAppIcon.Location = new System.Drawing.Point(212, 22);
            this.pbAppIcon.Name = "pbAppIcon";
            this.pbAppIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbAppIcon.ShadowDecoration.Parent = this.pbAppIcon;
            this.pbAppIcon.Size = new System.Drawing.Size(157, 158);
            this.pbAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppIcon.TabIndex = 2;
            this.pbAppIcon.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 24.25F);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(399, 35);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(118, 45);
            this.lblAppName.TabIndex = 3;
            this.lblAppName.Text = "Nazwa";
            // 
            // lblAppDescription
            // 
            this.lblAppDescription.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.lblAppDescription.ForeColor = System.Drawing.Color.White;
            this.lblAppDescription.Location = new System.Drawing.Point(403, 80);
            this.lblAppDescription.Name = "lblAppDescription";
            this.lblAppDescription.Size = new System.Drawing.Size(437, 55);
            this.lblAppDescription.TabIndex = 3;
            this.lblAppDescription.Text = "Opis";
            // 
            // btnStartApp
            // 
            this.btnStartApp.Animated = true;
            this.btnStartApp.AutoRoundedCorners = true;
            this.btnStartApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnStartApp.BorderRadius = 20;
            this.btnStartApp.CheckedState.Parent = this.btnStartApp;
            this.btnStartApp.CustomImages.Parent = this.btnStartApp;
            this.btnStartApp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartApp.ForeColor = System.Drawing.Color.White;
            this.btnStartApp.HoverState.Parent = this.btnStartApp;
            this.btnStartApp.Location = new System.Drawing.Point(407, 138);
            this.btnStartApp.Name = "btnStartApp";
            this.btnStartApp.ShadowDecoration.Parent = this.btnStartApp;
            this.btnStartApp.Size = new System.Drawing.Size(318, 42);
            this.btnStartApp.TabIndex = 5;
            this.btnStartApp.Text = "Uruchom";
            this.btnStartApp.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pbAppPreview
            // 
            this.pbAppPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbAppPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pbAppPreview.Location = new System.Drawing.Point(188, 200);
            this.pbAppPreview.Name = "pbAppPreview";
            this.pbAppPreview.ShadowDecoration.BorderRadius = 5;
            this.pbAppPreview.ShadowDecoration.Depth = 3;
            this.pbAppPreview.ShadowDecoration.Parent = this.pbAppPreview;
            this.pbAppPreview.Size = new System.Drawing.Size(652, 242);
            this.pbAppPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppPreview.TabIndex = 6;
            this.pbAppPreview.TabStop = false;
            this.pbAppPreview.UseTransparentBackground = true;
            this.pbAppPreview.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pnlFunList
            // 
            this.pnlFunList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlFunList.Controls.Add(this.pbAppPreview);
            this.pnlFunList.Controls.Add(this.btnStartApp);
            this.pnlFunList.Controls.Add(this.lblAppDescription);
            this.pnlFunList.Controls.Add(this.lblAppName);
            this.pnlFunList.Controls.Add(this.pbAppIcon);
            this.pnlFunList.Controls.Add(this.lbFunApps);
            this.pnlFunList.Location = new System.Drawing.Point(1, 0);
            this.pnlFunList.Name = "pnlFunList";
            this.pnlFunList.Size = new System.Drawing.Size(854, 451);
            this.pnlFunList.TabIndex = 7;
            // 
            // t1
            // 
            this.t1.Interval = 20;
            this.t1.Tick += new System.EventHandler(this.fadeIn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(853, 521);
            this.Controls.Add(this.pnlFunList);
            this.Controls.Add(this.icoInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fireFun";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icoInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppPreview)).EndInit();
            this.pnlFunList.ResumeLayout(false);
            this.pnlFunList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox lbFunApps;
        private Guna2CirclePictureBox pbAppIcon;
        private Label lblAppName;
        private Label lblAppDescription;
        private Guna2Button btnStartApp;
        private Guna2PictureBox pbAppPreview;
        private Panel pnlFunList;
        private Timer t1;
    }
}

