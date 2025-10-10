namespace UserInterfaceLayer.StaffApplication.Forms
{
    partial class StaffLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label5 = new Label();
            lblDateTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            label1 = new Label();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label7 = new Label();
            mainPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblBack = new Label();
            elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2ShadowPanel3.SuspendLayout();
            guna2GradientPanel1.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(1231, 70);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 38);
            label5.TabIndex = 5;
            label5.Text = "Exit";
            label5.Click += label5_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(128, 64, 0);
            lblDateTime.Location = new Point(361, 115);
            lblDateTime.Margin = new Padding(4, 0, 4, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(104, 38);
            lblDateTime.TabIndex = 1;
            lblDateTime.Text = "0:00:00";
            lblDateTime.Click += lblTime_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.FillColor = Color.FromArgb(255, 192, 128);
            guna2vSeparator1.FillThickness = 3;
            guna2vSeparator1.Location = new Point(342, 39);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(12, 144);
            guna2vSeparator1.TabIndex = 10016;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Fax", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(361, 63);
            label3.Name = "label3";
            label3.Size = new Size(237, 45);
            label3.TabIndex = 31;
            label3.Text = "Staff Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 39);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // guna2ShadowPanel3
            // 
            guna2ShadowPanel3.BackColor = Color.Transparent;
            guna2ShadowPanel3.Controls.Add(tbPassword);
            guna2ShadowPanel3.Controls.Add(btnLogin);
            guna2ShadowPanel3.Controls.Add(tbUsername);
            guna2ShadowPanel3.Controls.Add(label6);
            guna2ShadowPanel3.Controls.Add(label1);
            guna2ShadowPanel3.FillColor = Color.Linen;
            guna2ShadowPanel3.Location = new Point(102, 257);
            guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            guna2ShadowPanel3.Radius = 40;
            guna2ShadowPanel3.ShadowColor = Color.Black;
            guna2ShadowPanel3.ShadowDepth = 80;
            guna2ShadowPanel3.Size = new Size(909, 364);
            guna2ShadowPanel3.TabIndex = 7;
            // 
            // tbPassword
            // 
            tbPassword.AutoRoundedCorners = true;
            tbPassword.Cursor = Cursors.IBeam;
            tbPassword.CustomizableEdges = customizableEdges9;
            tbPassword.DefaultText = "1234";
            tbPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPassword.Font = new Font("Segoe UI Variable Text", 10.8F);
            tbPassword.ForeColor = Color.Black;
            tbPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPassword.IconLeft = (Image)resources.GetObject("tbPassword.IconLeft");
            tbPassword.IconLeftOffset = new Point(10, 0);
            tbPassword.IconLeftSize = new Size(30, 30);
            tbPassword.Location = new Point(321, 191);
            tbPassword.Margin = new Padding(5, 6, 5, 6);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "";
            tbPassword.SelectedText = "";
            tbPassword.ShadowDecoration.CustomizableEdges = customizableEdges10;
            tbPassword.Size = new Size(440, 49);
            tbPassword.TabIndex = 10111;
            tbPassword.TextOffset = new Point(10, 0);
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Animated = true;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderColor = Color.FromArgb(50, 255, 255, 255);
            btnLogin.BorderRadius = 15;
            btnLogin.BorderThickness = 1;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CustomizableEdges = customizableEdges11;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(255, 192, 128);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnLogin.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.HoverState.ForeColor = Color.White;
            btnLogin.ImageAlign = HorizontalAlignment.Left;
            btnLogin.ImageSize = new Size(35, 35);
            btnLogin.IndicateFocus = true;
            btnLogin.Location = new Point(433, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnLogin.PressedDepth = 6;
            btnLogin.ShadowDecoration.BorderRadius = 20;
            btnLogin.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnLogin.ShadowDecoration.Depth = 5;
            btnLogin.ShadowDecoration.Enabled = true;
            btnLogin.Size = new Size(200, 46);
            btnLogin.TabIndex = 10110;
            btnLogin.Text = "Login";
            btnLogin.UseTransparentBackground = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // tbUsername
            // 
            tbUsername.AutoRoundedCorners = true;
            tbUsername.Cursor = Cursors.IBeam;
            tbUsername.CustomizableEdges = customizableEdges13;
            tbUsername.DefaultText = "admin";
            tbUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbUsername.Font = new Font("Segoe UI Variable Text", 10.8F);
            tbUsername.ForeColor = Color.Black;
            tbUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbUsername.IconLeft = (Image)resources.GetObject("tbUsername.IconLeft");
            tbUsername.IconLeftOffset = new Point(10, 0);
            tbUsername.IconLeftSize = new Size(30, 30);
            tbUsername.Location = new Point(321, 107);
            tbUsername.Margin = new Padding(5, 6, 5, 6);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "";
            tbUsername.SelectedText = "";
            tbUsername.ShadowDecoration.CustomizableEdges = customizableEdges14;
            tbUsername.Size = new Size(440, 49);
            tbUsername.TabIndex = 10109;
            tbUsername.TextOffset = new Point(10, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(128, 64, 0);
            label6.Location = new Point(137, 203);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 37);
            label6.TabIndex = 10018;
            label6.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(130, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 10017;
            label1.Text = "Username:";
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.Controls.Add(label7);
            guna2GradientPanel1.Controls.Add(mainPanel);
            guna2GradientPanel1.CustomizableEdges = customizableEdges15;
            guna2GradientPanel1.FillColor = Color.FromArgb(255, 192, 128);
            guna2GradientPanel1.FillColor2 = Color.White;
            guna2GradientPanel1.Location = new Point(-4, 0);
            guna2GradientPanel1.Margin = new Padding(3, 4, 3, 4);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2GradientPanel1.Size = new Size(1155, 744);
            guna2GradientPanel1.TabIndex = 4;
            guna2GradientPanel1.UseTransparentBackground = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(58, 952);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 16;
            label7.Text = "Back";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Controls.Add(lblBack);
            mainPanel.Controls.Add(guna2ShadowPanel3);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(guna2vSeparator1);
            mainPanel.Controls.Add(lblDateTime);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(label5);
            mainPanel.FillColor = Color.White;
            mainPanel.Location = new Point(16, 13);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Radius = 15;
            mainPanel.ShadowColor = Color.Black;
            mainPanel.ShadowDepth = 200;
            mainPanel.Size = new Size(1124, 720);
            mainPanel.TabIndex = 0;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Cursor = Cursors.Hand;
            lblBack.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBack.ForeColor = Color.FromArgb(255, 192, 128);
            lblBack.Location = new Point(24, 671);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(55, 27);
            lblBack.TabIndex = 10017;
            lblBack.Text = "Back";
            lblBack.Click += lblBack_Click;
            // 
            // elipse
            // 
            elipse.BorderRadius = 50;
            elipse.TargetControl = this;
            // 
            // StaffLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1155, 744);
            Controls.Add(guna2GradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "StaffLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += userLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2ShadowPanel3.ResumeLayout(false);
            guna2ShadowPanel3.PerformLayout();
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateTime;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Label label3;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
        private Label label6;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2ShadowPanel mainPanel;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private Label lblBack;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
    }
}

