namespace UserInterfaceLayer
{
    partial class KioskBaseForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KioskBaseForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            lblDateTime = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.Controls.Add(lblDateTime);
            guna2GradientPanel1.Controls.Add(pictureBox1);
            guna2GradientPanel1.Controls.Add(panel4);
            guna2GradientPanel1.CustomizableEdges = customizableEdges15;
            guna2GradientPanel1.FillColor = Color.FromArgb(255, 192, 128);
            guna2GradientPanel1.FillColor2 = Color.White;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2GradientPanel1.Size = new Size(1269, 741);
            guna2GradientPanel1.TabIndex = 2;
            guna2GradientPanel1.UseTransparentBackground = true;
            guna2GradientPanel1.Paint += guna2GradientPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Variable Display", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 705);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Cursor = Cursors.Hand;
            lblDateTime.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(255, 192, 128);
            lblDateTime.Location = new Point(956, 18);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(14, 21);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = ".";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(guna2Panel2);
            panel4.FillColor = Color.Linen;
            panel4.Location = new Point(114, 46);
            panel4.Name = "panel4";
            panel4.Radius = 15;
            panel4.ShadowColor = Color.Black;
            panel4.ShadowDepth = 200;
            panel4.Size = new Size(1144, 685);
            panel4.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.Controls.Add(guna2Button3);
            guna2Panel2.Controls.Add(guna2Button2);
            guna2Panel2.Controls.Add(btnDashboard);
            guna2Panel2.Controls.Add(guna2Button1);
            guna2Panel2.Controls.Add(guna2Button4);
            guna2Panel2.CustomizableEdges = customizableEdges27;
            guna2Panel2.Location = new Point(22, 12);
            guna2Panel2.Margin = new Padding(3, 2, 3, 2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.BorderRadius = 20;
            guna2Panel2.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2Panel2.ShadowDecoration.Depth = 15;
            guna2Panel2.ShadowDecoration.Enabled = true;
            guna2Panel2.Size = new Size(1104, 38);
            guna2Panel2.TabIndex = 10117;
            // 
            // guna2Button3
            // 
            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.BorderColor = Color.Empty;
            guna2Button3.BorderThickness = 1;
            guna2Button3.Cursor = Cursors.Hand;
            guna2Button3.CustomizableEdges = customizableEdges17;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Empty;
            guna2Button3.Font = new Font("Segoe UI Variable Display", 12F);
            guna2Button3.ForeColor = Color.FromArgb(128, 64, 0);
            guna2Button3.ImageOffset = new Point(10, 0);
            guna2Button3.ImageSize = new Size(35, 35);
            guna2Button3.IndicateFocus = true;
            guna2Button3.Location = new Point(928, 2);
            guna2Button3.Margin = new Padding(3, 2, 3, 2);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.PressedColor = Color.FromArgb(0, 0, 0, 0);
            guna2Button3.PressedDepth = 0;
            guna2Button3.ShadowDecoration.BorderRadius = 0;
            guna2Button3.ShadowDecoration.Color = Color.FromArgb(0, 0, 0, 0);
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Button3.ShadowDecoration.Depth = 5;
            guna2Button3.Size = new Size(172, 34);
            guna2Button3.TabIndex = 10114;
            guna2Button3.Text = "Confirm Payment";
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.Empty;
            guna2Button2.BorderThickness = 1;
            guna2Button2.Cursor = Cursors.Hand;
            guna2Button2.CustomizableEdges = customizableEdges19;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Empty;
            guna2Button2.Font = new Font("Segoe UI Variable Display", 12F);
            guna2Button2.ForeColor = Color.FromArgb(128, 64, 0);
            guna2Button2.ImageOffset = new Point(10, 0);
            guna2Button2.ImageSize = new Size(35, 35);
            guna2Button2.IndicateFocus = true;
            guna2Button2.Location = new Point(734, 2);
            guna2Button2.Margin = new Padding(3, 2, 3, 2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.PressedColor = Color.FromArgb(0, 0, 0, 0);
            guna2Button2.PressedDepth = 0;
            guna2Button2.ShadowDecoration.BorderRadius = 0;
            guna2Button2.ShadowDecoration.Color = Color.FromArgb(0, 0, 0, 0);
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Button2.ShadowDecoration.Depth = 5;
            guna2Button2.Size = new Size(194, 34);
            guna2Button2.TabIndex = 10113;
            guna2Button2.Text = "Passenger Details";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BorderColor = Color.Empty;
            btnDashboard.BorderThickness = 1;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.CustomizableEdges = customizableEdges21;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.FillColor = Color.Empty;
            btnDashboard.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(128, 64, 0);
            btnDashboard.ImageOffset = new Point(10, 0);
            btnDashboard.ImageSize = new Size(35, 35);
            btnDashboard.IndicateFocus = true;
            btnDashboard.Location = new Point(458, 2);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.PressedColor = Color.FromArgb(0, 0, 0, 0);
            btnDashboard.PressedDepth = 6;
            btnDashboard.ShadowDecoration.BorderRadius = 0;
            btnDashboard.ShadowDecoration.Color = Color.FromArgb(0, 0, 0, 0);
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnDashboard.ShadowDecoration.Depth = 5;
            btnDashboard.Size = new Size(138, 34);
            btnDashboard.TabIndex = 10111;
            btnDashboard.Text = "Select Trip";
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Empty;
            guna2Button1.BorderThickness = 1;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges23;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Empty;
            guna2Button1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.FromArgb(128, 64, 0);
            guna2Button1.ImageOffset = new Point(10, 0);
            guna2Button1.ImageSize = new Size(35, 35);
            guna2Button1.IndicateFocus = true;
            guna2Button1.Location = new Point(596, 2);
            guna2Button1.Margin = new Padding(3, 2, 3, 2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(0, 0, 0, 0);
            guna2Button1.PressedDepth = 0;
            guna2Button1.ShadowDecoration.BorderRadius = 0;
            guna2Button1.ShadowDecoration.Color = Color.FromArgb(0, 0, 0, 0);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2Button1.ShadowDecoration.Depth = 5;
            guna2Button1.Size = new Size(138, 34);
            guna2Button1.TabIndex = 10112;
            guna2Button1.Text = "Select Seats";
            // 
            // guna2Button4
            // 
            guna2Button4.Animated = true;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderColor = Color.Empty;
            guna2Button4.BorderThickness = 1;
            guna2Button4.Cursor = Cursors.Hand;
            guna2Button4.CustomizableEdges = customizableEdges25;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Empty;
            guna2Button4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button4.ForeColor = Color.FromArgb(128, 64, 0);
            guna2Button4.HoverState.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button4.HoverState.ForeColor = Color.FromArgb(128, 64, 0);
            guna2Button4.Image = (Image)resources.GetObject("guna2Button4.Image");
            guna2Button4.ImageAlign = HorizontalAlignment.Left;
            guna2Button4.ImageOffset = new Point(6, 0);
            guna2Button4.ImageSize = new Size(35, 35);
            guna2Button4.IndicateFocus = true;
            guna2Button4.Location = new Point(11, 2);
            guna2Button4.Margin = new Padding(3, 2, 3, 2);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.PressedColor = Color.FromArgb(130, 235, 200, 180);
            guna2Button4.PressedDepth = 6;
            guna2Button4.ShadowDecoration.BorderRadius = 0;
            guna2Button4.ShadowDecoration.Color = Color.FromArgb(0, 0, 0, 0);
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2Button4.ShadowDecoration.Depth = 5;
            guna2Button4.Size = new Size(108, 34);
            guna2Button4.TabIndex = 10110;
            guna2Button4.Text = "Back";
            guna2Button4.TextAlign = HorizontalAlignment.Left;
            guna2Button4.TextOffset = new Point(10, 0);
            guna2Button4.Click += guna2Button4_Click;
            // 
            // elipse
            // 
            elipse.BorderRadius = 50;
            elipse.TargetControl = this;
            // 
            // KioskBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1268, 740);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KioskBaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += KioskBaseForm_Load;
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel4;
        private Label lblDateTime;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}