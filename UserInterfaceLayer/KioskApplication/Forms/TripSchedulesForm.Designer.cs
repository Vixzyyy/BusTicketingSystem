namespace UserInterfaceLayer.KioskApplication.Forms
{
    partial class TripSchedulesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlCheckRes = new Panel();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            dgvSched = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvDeparture = new DataGridViewTextBoxColumn();
            dgvArrival = new DataGridViewTextBoxColumn();
            dgvBusTypeClass = new DataGridViewTextBoxColumn();
            dgvFare = new DataGridViewTextBoxColumn();
            dgvSeatsAvail = new DataGridViewTextBoxColumn();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            cbDestination = new Guna.UI2.WinForms.Guna2ComboBox();
            cbOrigin = new Guna.UI2.WinForms.Guna2ComboBox();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlCheckRes.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSched).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCheckRes
            // 
            pnlCheckRes.BackColor = Color.White;
            pnlCheckRes.Controls.Add(btnBack);
            pnlCheckRes.Controls.Add(panel);
            pnlCheckRes.Controls.Add(guna2ShadowPanel1);
            pnlCheckRes.Location = new Point(0, 0);
            pnlCheckRes.Name = "pnlCheckRes";
            pnlCheckRes.Size = new Size(1144, 685);
            pnlCheckRes.TabIndex = 10026;
            pnlCheckRes.Paint += pnlCheckRes_Paint;
            // 
            // btnBack
            // 
            btnBack.Animated = true;
            btnBack.BackColor = Color.Transparent;
            btnBack.BorderColor = Color.FromArgb(255, 192, 128);
            btnBack.BorderRadius = 15;
            btnBack.BorderThickness = 1;
            btnBack.Cursor = Cursors.Hand;
            btnBack.CustomizableEdges = customizableEdges1;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.White;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(255, 192, 128);
            btnBack.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnBack.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.HoverState.ForeColor = Color.White;
            btnBack.ImageAlign = HorizontalAlignment.Left;
            btnBack.ImageSize = new Size(35, 35);
            btnBack.IndicateFocus = true;
            btnBack.Location = new Point(29, 16);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnBack.PressedDepth = 6;
            btnBack.ShadowDecoration.BorderRadius = 20;
            btnBack.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBack.ShadowDecoration.Depth = 5;
            btnBack.ShadowDecoration.Enabled = true;
            btnBack.Size = new Size(129, 34);
            btnBack.TabIndex = 10112;
            btnBack.Text = "Back";
            btnBack.UseTransparentBackground = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // panel
            // 
            panel.BackColor = Color.Transparent;
            panel.Controls.Add(dgvSched);
            panel.FillColor = Color.WhiteSmoke;
            panel.Location = new Point(10, 142);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Radius = 5;
            panel.ShadowColor = Color.FromArgb(255, 224, 192);
            panel.ShadowDepth = 50;
            panel.Size = new Size(1124, 533);
            panel.TabIndex = 1;
            // 
            // dgvSched
            // 
            dgvSched.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 216, 189);
            dgvSched.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(230, 126, 34);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSched.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSched.ColumnHeadersHeight = 22;
            dgvSched.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSched.Columns.AddRange(new DataGridViewColumn[] { dgvDeparture, dgvArrival, dgvBusTypeClass, dgvFare, dgvSeatsAvail });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(249, 229, 211);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(238, 169, 107);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSched.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSched.GridColor = Color.FromArgb(245, 209, 177);
            dgvSched.Location = new Point(18, 15);
            dgvSched.Margin = new Padding(3, 2, 3, 2);
            dgvSched.Name = "dgvSched";
            dgvSched.RowHeadersVisible = false;
            dgvSched.RowHeadersWidth = 51;
            dgvSched.RowTemplate.Height = 29;
            dgvSched.Size = new Size(1089, 507);
            dgvSched.TabIndex = 0;
            dgvSched.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            dgvSched.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(247, 216, 189);
            dgvSched.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvSched.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvSched.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvSched.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvSched.ThemeStyle.BackColor = Color.White;
            dgvSched.ThemeStyle.GridColor = Color.FromArgb(245, 209, 177);
            dgvSched.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(230, 126, 34);
            dgvSched.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSched.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvSched.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvSched.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSched.ThemeStyle.HeaderStyle.Height = 22;
            dgvSched.ThemeStyle.ReadOnly = false;
            dgvSched.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(249, 229, 211);
            dgvSched.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSched.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvSched.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvSched.ThemeStyle.RowsStyle.Height = 29;
            dgvSched.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(238, 169, 107);
            dgvSched.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // dgvDeparture
            // 
            dgvDeparture.HeaderText = "Departure";
            dgvDeparture.MinimumWidth = 6;
            dgvDeparture.Name = "dgvDeparture";
            dgvDeparture.ReadOnly = true;
            // 
            // dgvArrival
            // 
            dgvArrival.HeaderText = "Arrival";
            dgvArrival.MinimumWidth = 6;
            dgvArrival.Name = "dgvArrival";
            dgvArrival.ReadOnly = true;
            // 
            // dgvBusTypeClass
            // 
            dgvBusTypeClass.HeaderText = "Bus Type and Class";
            dgvBusTypeClass.MinimumWidth = 6;
            dgvBusTypeClass.Name = "dgvBusTypeClass";
            dgvBusTypeClass.ReadOnly = true;
            // 
            // dgvFare
            // 
            dgvFare.HeaderText = "Fare";
            dgvFare.MinimumWidth = 6;
            dgvFare.Name = "dgvFare";
            dgvFare.ReadOnly = true;
            // 
            // dgvSeatsAvail
            // 
            dgvSeatsAvail.HeaderText = "Seats Available";
            dgvSeatsAvail.MinimumWidth = 6;
            dgvSeatsAvail.Name = "dgvSeatsAvail";
            dgvSeatsAvail.ReadOnly = true;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnSearch);
            guna2ShadowPanel1.Controls.Add(dtpDate);
            guna2ShadowPanel1.Controls.Add(cbDestination);
            guna2ShadowPanel1.Controls.Add(cbOrigin);
            guna2ShadowPanel1.Controls.Add(label7);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.Controls.Add(label2);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(10, 68);
            guna2ShadowPanel1.Margin = new Padding(3, 2, 3, 2);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.FromArgb(255, 224, 192);
            guna2ShadowPanel1.ShadowDepth = 50;
            guna2ShadowPanel1.Size = new Size(1124, 70);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 20;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.CustomizableEdges = customizableEdges3;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(255, 192, 128);
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(979, 24);
            btnSearch.Margin = new Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearch.Size = new Size(129, 33);
            btnSearch.TabIndex = 10095;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpDate
            // 
            dtpDate.AutoRoundedCorners = true;
            dtpDate.BackColor = Color.Transparent;
            dtpDate.BorderRadius = 12;
            dtpDate.Checked = true;
            dtpDate.CustomizableEdges = customizableEdges5;
            dtpDate.FillColor = Color.WhiteSmoke;
            dtpDate.Font = new Font("Segoe UI", 10F);
            dtpDate.Format = DateTimePickerFormat.Long;
            dtpDate.Location = new Point(721, 27);
            dtpDate.Margin = new Padding(4, 4, 4, 4);
            dtpDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpDate.Size = new Size(248, 27);
            dtpDate.TabIndex = 10014;
            dtpDate.UseTransparentBackground = true;
            dtpDate.Value = new DateTime(2025, 9, 5, 22, 19, 27, 530);
            // 
            // cbDestination
            // 
            cbDestination.AutoRoundedCorners = true;
            cbDestination.BackColor = Color.Transparent;
            cbDestination.BorderRadius = 17;
            cbDestination.CustomizableEdges = customizableEdges7;
            cbDestination.DrawMode = DrawMode.OwnerDrawFixed;
            cbDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDestination.FillColor = Color.WhiteSmoke;
            cbDestination.FocusedColor = Color.FromArgb(94, 148, 255);
            cbDestination.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbDestination.Font = new Font("Segoe UI", 10F);
            cbDestination.ForeColor = Color.Black;
            cbDestination.ItemHeight = 30;
            cbDestination.Location = new Point(420, 24);
            cbDestination.Margin = new Padding(4, 4, 4, 4);
            cbDestination.Name = "cbDestination";
            cbDestination.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbDestination.Size = new Size(200, 36);
            cbDestination.TabIndex = 10027;
            // 
            // cbOrigin
            // 
            cbOrigin.AutoRoundedCorners = true;
            cbOrigin.BackColor = Color.Transparent;
            cbOrigin.BorderRadius = 17;
            cbOrigin.CustomizableEdges = customizableEdges9;
            cbOrigin.DrawMode = DrawMode.OwnerDrawFixed;
            cbOrigin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrigin.FillColor = Color.WhiteSmoke;
            cbOrigin.FocusedColor = Color.FromArgb(94, 148, 255);
            cbOrigin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbOrigin.Font = new Font("Segoe UI", 10F);
            cbOrigin.ForeColor = Color.Black;
            cbOrigin.ItemHeight = 30;
            cbOrigin.Location = new Point(80, 24);
            cbOrigin.Margin = new Padding(4, 4, 4, 4);
            cbOrigin.Name = "cbOrigin";
            cbOrigin.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbOrigin.Size = new Size(182, 36);
            cbOrigin.TabIndex = 10015;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(128, 64, 0);
            label7.Location = new Point(652, 28);
            label7.Name = "label7";
            label7.Size = new Size(45, 21);
            label7.TabIndex = 10026;
            label7.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(298, 28);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 10025;
            label3.Text = "Destination:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 10023;
            label2.Text = "Origin:";
            // 
            // elipse
            // 
            elipse.BorderRadius = 50;
            elipse.TargetControl = this;
            // 
            // TripSchedulesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 679);
            Controls.Add(pnlCheckRes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TripSchedulesForm";
            Text = "TripSchedulesForm";
            pnlCheckRes.ResumeLayout(false);
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSched).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCheckRes;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label label7;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSched;
        private DataGridViewTextBoxColumn dgvDeparture;
        private DataGridViewTextBoxColumn dgvArrival;
        private DataGridViewTextBoxColumn dgvBusTypeClass;
        private DataGridViewTextBoxColumn dgvFare;
        private DataGridViewTextBoxColumn dgvSeatsAvail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbDestination;
        private Guna.UI2.WinForms.Guna2ComboBox cbOrigin;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}