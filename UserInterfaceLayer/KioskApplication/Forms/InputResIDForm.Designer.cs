namespace UserInterfaceLayer.KioskApplication.Forms
{
    partial class InputResIDForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlCheckRes = new Panel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            tbInputResID = new Guna.UI2.WinForms.Guna2TextBox();
            elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlCheckRes.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCheckRes
            // 
            pnlCheckRes.BackColor = Color.White;
            pnlCheckRes.Controls.Add(guna2ShadowPanel1);
            pnlCheckRes.Location = new Point(0, 0);
            pnlCheckRes.Margin = new Padding(3, 4, 3, 4);
            pnlCheckRes.Name = "pnlCheckRes";
            pnlCheckRes.Size = new Size(1308, 913);
            pnlCheckRes.TabIndex = 10026;
            pnlCheckRes.Paint += pnlCheckRes_Paint;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnConfirm);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.Controls.Add(tbInputResID);
            guna2ShadowPanel1.FillColor = Color.Linen;
            guna2ShadowPanel1.Location = new Point(120, 354);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 20;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 80;
            guna2ShadowPanel1.Size = new Size(1064, 223);
            guna2ShadowPanel1.TabIndex = 10014;
            // 
            // btnConfirm
            // 
            btnConfirm.Animated = true;
            btnConfirm.BackColor = Color.Transparent;
            btnConfirm.BorderColor = Color.FromArgb(50, 255, 255, 255);
            btnConfirm.BorderRadius = 15;
            btnConfirm.BorderThickness = 1;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.CustomizableEdges = customizableEdges1;
            btnConfirm.DisabledState.BorderColor = Color.DarkGray;
            btnConfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirm.FillColor = Color.FromArgb(255, 192, 128);
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnConfirm.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirm.HoverState.ForeColor = Color.White;
            btnConfirm.ImageAlign = HorizontalAlignment.Left;
            btnConfirm.ImageSize = new Size(35, 35);
            btnConfirm.IndicateFocus = true;
            btnConfirm.Location = new Point(758, 89);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnConfirm.PressedDepth = 6;
            btnConfirm.ShadowDecoration.BorderRadius = 20;
            btnConfirm.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnConfirm.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnConfirm.ShadowDecoration.Depth = 5;
            btnConfirm.ShadowDecoration.Enabled = true;
            btnConfirm.Size = new Size(241, 72);
            btnConfirm.TabIndex = 10111;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseTransparentBackground = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(70, 44);
            label3.Name = "label3";
            label3.Size = new Size(269, 25);
            label3.TabIndex = 10014;
            label3.Text = "Input your Reservation ID below";
            // 
            // tbInputResID
            // 
            tbInputResID.BackColor = Color.Linen;
            tbInputResID.BorderColor = Color.FromArgb(128, 64, 0);
            tbInputResID.BorderRadius = 20;
            tbInputResID.CustomizableEdges = customizableEdges3;
            tbInputResID.DefaultText = "";
            tbInputResID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbInputResID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbInputResID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbInputResID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbInputResID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbInputResID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbInputResID.ForeColor = Color.Black;
            tbInputResID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbInputResID.Location = new Point(58, 77);
            tbInputResID.Margin = new Padding(5, 8, 5, 8);
            tbInputResID.Name = "tbInputResID";
            tbInputResID.PlaceholderText = "";
            tbInputResID.SelectedText = "";
            tbInputResID.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbInputResID.Size = new Size(668, 93);
            tbInputResID.TabIndex = 0;
            // 
            // elipse
            // 
            elipse.BorderRadius = 50;
            elipse.TargetControl = this;
            // 
            // InputResIDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 913);
            Controls.Add(pnlCheckRes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputResIDForm";
            Text = "InputResIDForm";
            Load += InputResIDForm_Load;
            pnlCheckRes.ResumeLayout(false);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCheckRes;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbInputResID;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
    }
}