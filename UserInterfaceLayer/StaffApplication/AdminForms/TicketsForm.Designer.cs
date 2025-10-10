namespace UserInterfaceLayer.StaffApplication.Forms
{
    partial class TicketsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvDepartureTime = new DataGridViewTextBoxColumn();
            dgvRoute = new DataGridViewTextBoxColumn();
            dgvDriver = new DataGridViewTextBoxColumn();
            dgvBusPlate = new DataGridViewTextBoxColumn();
            dgvSeatAvail = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            btnCreateTicket = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            tbSearch = new TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(guna2Separator1);
            panel1.Controls.Add(guna2DataGridView1);
            panel1.Controls.Add(btnCreateTicket);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbSearch);
            panel1.Location = new Point(13, 16);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 883);
            panel1.TabIndex = 4;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.FromArgb(255, 192, 128);
            guna2Separator1.Location = new Point(19, 82);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1170, 12);
            guna2Separator1.TabIndex = 34;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BackgroundColor = Color.SeaShell;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 29;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvDepartureTime, dgvRoute, dgvDriver, dgvBusPlate, dgvSeatAvail, dgvStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.EnableHeadersVisualStyles = true;
            guna2DataGridView1.GridColor = Color.PeachPuff;
            guna2DataGridView1.Location = new Point(28, 159);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle4.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(1153, 712);
            guna2DataGridView1.TabIndex = 5;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.SeaShell;
            guna2DataGridView1.ThemeStyle.GridColor = Color.PeachPuff;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // dgvDepartureTime
            // 
            dgvDepartureTime.HeaderText = "Departure Time";
            dgvDepartureTime.MinimumWidth = 6;
            dgvDepartureTime.Name = "dgvDepartureTime";
            dgvDepartureTime.ReadOnly = true;
            // 
            // dgvRoute
            // 
            dgvRoute.HeaderText = "Route";
            dgvRoute.MinimumWidth = 6;
            dgvRoute.Name = "dgvRoute";
            dgvRoute.ReadOnly = true;
            // 
            // dgvDriver
            // 
            dgvDriver.HeaderText = "Driver";
            dgvDriver.MinimumWidth = 6;
            dgvDriver.Name = "dgvDriver";
            dgvDriver.ReadOnly = true;
            // 
            // dgvBusPlate
            // 
            dgvBusPlate.HeaderText = "Plate";
            dgvBusPlate.MinimumWidth = 6;
            dgvBusPlate.Name = "dgvBusPlate";
            dgvBusPlate.ReadOnly = true;
            // 
            // dgvSeatAvail
            // 
            dgvSeatAvail.HeaderText = "Seat Available";
            dgvSeatAvail.MinimumWidth = 6;
            dgvSeatAvail.Name = "dgvSeatAvail";
            dgvSeatAvail.ReadOnly = true;
            // 
            // dgvStatus
            // 
            dgvStatus.HeaderText = "Status";
            dgvStatus.MinimumWidth = 6;
            dgvStatus.Name = "dgvStatus";
            dgvStatus.ReadOnly = true;
            // 
            // btnCreateTicket
            // 
            btnCreateTicket.Animated = true;
            btnCreateTicket.BackColor = Color.Transparent;
            btnCreateTicket.BorderColor = Color.FromArgb(50, 255, 255, 255);
            btnCreateTicket.BorderRadius = 15;
            btnCreateTicket.BorderThickness = 1;
            btnCreateTicket.Cursor = Cursors.Hand;
            btnCreateTicket.CustomizableEdges = customizableEdges1;
            btnCreateTicket.DisabledState.BorderColor = Color.DarkGray;
            btnCreateTicket.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreateTicket.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreateTicket.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreateTicket.FillColor = Color.FromArgb(255, 192, 128);
            btnCreateTicket.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateTicket.ForeColor = Color.White;
            btnCreateTicket.HoverState.FillColor = Color.FromArgb(110, 230, 210, 200);
            btnCreateTicket.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateTicket.HoverState.ForeColor = Color.White;
            btnCreateTicket.ImageOffset = new Point(10, 0);
            btnCreateTicket.ImageSize = new Size(35, 35);
            btnCreateTicket.IndicateFocus = true;
            btnCreateTicket.Location = new Point(1016, 20);
            btnCreateTicket.Name = "btnCreateTicket";
            btnCreateTicket.PressedColor = Color.FromArgb(130, 245, 210, 190);
            btnCreateTicket.PressedDepth = 6;
            btnCreateTicket.ShadowDecoration.BorderRadius = 20;
            btnCreateTicket.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnCreateTicket.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCreateTicket.ShadowDecoration.Depth = 5;
            btnCreateTicket.ShadowDecoration.Enabled = true;
            btnCreateTicket.Size = new Size(165, 49);
            btnCreateTicket.TabIndex = 33;
            btnCreateTicket.Text = "Create Ticket";
            btnCreateTicket.UseTransparentBackground = true;
            btnCreateTicket.Click += btnCreateTicket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 29F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(28, 99);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 57);
            label1.TabIndex = 4;
            label1.Text = "Ticket's List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(41, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 4;
            label2.Text = "Search:";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI Variable Small", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(120, 27);
            tbSearch.Margin = new Padding(4, 5, 4, 5);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(392, 38);
            tbSearch.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = this;
            // 
            // TicketsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1235, 913);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TicketsForm";
            Text = "TicketsForm";
            Load += TicketsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnCreateTicket;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn dgvDepartureTime;
        private DataGridViewTextBoxColumn dgvRoute;
        private DataGridViewTextBoxColumn dgvDriver;
        private DataGridViewTextBoxColumn dgvBusPlate;
        private DataGridViewTextBoxColumn dgvSeatAvail;
        private DataGridViewTextBoxColumn dgvStatus;
    }
}