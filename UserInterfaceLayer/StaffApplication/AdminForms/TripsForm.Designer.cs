namespace UserInterfaceLayer.StaffApplication.Forms
{
    partial class TripsForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            label2 = new Label();
            tbSearch = new TextBox();
            panel2 = new Panel();
            dgvTrips = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvDepartureTime = new DataGridViewTextBoxColumn();
            dgvRoute = new DataGridViewTextBoxColumn();
            dgvDriver = new DataGridViewTextBoxColumn();
            dgvBusPlate = new DataGridViewTextBoxColumn();
            dgvSeatAvail = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnCompleted = new Guna.UI2.WinForms.Guna2Button();
            btnDeparted = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 29F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(43, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 57);
            label1.TabIndex = 4;
            label1.Text = "Trip's List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Linen;
            panel6.Controls.Add(label5);
            panel6.Controls.Add(btnEdit);
            panel6.Controls.Add(btnAdd);
            panel6.Controls.Add(btnDeparted);
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(btnCompleted);
            panel6.Location = new Point(970, 109);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(252, 376);
            panel6.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Maiandra GD", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 64, 0);
            label5.Location = new Point(62, 35);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 22);
            label5.TabIndex = 6;
            label5.Text = "Quick Actions";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(890, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 4;
            label2.Text = "Search:";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(997, 54);
            tbSearch.Margin = new Padding(4, 5, 4, 5);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(220, 34);
            tbSearch.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(dgvTrips);
            panel2.Location = new Point(13, 109);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 790);
            panel2.TabIndex = 1;
            // 
            // dgvTrips
            // 
            dgvTrips.AllowUserToAddRows = false;
            dgvTrips.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dgvTrips.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvTrips.BackgroundColor = Color.SeaShell;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvTrips.ColumnHeadersHeight = 29;
            dgvTrips.Columns.AddRange(new DataGridViewColumn[] { dgvDepartureTime, dgvRoute, dgvDriver, dgvBusPlate, dgvSeatAvail, dgvStatus });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvTrips.DefaultCellStyle = dataGridViewCellStyle7;
            dgvTrips.EnableHeadersVisualStyles = true;
            dgvTrips.GridColor = Color.PeachPuff;
            dgvTrips.Location = new Point(3, 3);
            dgvTrips.Name = "dgvTrips";
            dgvTrips.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle8.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvTrips.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvTrips.RowHeadersVisible = false;
            dgvTrips.RowHeadersWidth = 51;
            dgvTrips.Size = new Size(943, 784);
            dgvTrips.TabIndex = 10116;
            dgvTrips.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTrips.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTrips.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTrips.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTrips.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTrips.ThemeStyle.BackColor = Color.SeaShell;
            dgvTrips.ThemeStyle.GridColor = Color.PeachPuff;
            dgvTrips.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTrips.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTrips.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvTrips.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTrips.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTrips.ThemeStyle.HeaderStyle.Height = 29;
            dgvTrips.ThemeStyle.ReadOnly = true;
            dgvTrips.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTrips.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTrips.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTrips.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTrips.ThemeStyle.RowsStyle.Height = 29;
            dgvTrips.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTrips.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            // btnEdit
            // 
            btnEdit.Animated = true;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BorderColor = Color.FromArgb(255, 192, 128);
            btnEdit.BorderRadius = 15;
            btnEdit.BorderThickness = 1;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.CustomizableEdges = customizableEdges11;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.White;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(255, 192, 128);
            btnEdit.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnEdit.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.HoverState.ForeColor = Color.White;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(35, 35);
            btnEdit.IndicateFocus = true;
            btnEdit.Location = new Point(27, 124);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnEdit.PressedDepth = 6;
            btnEdit.ShadowDecoration.BorderRadius = 20;
            btnEdit.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnEdit.ShadowDecoration.Depth = 5;
            btnEdit.ShadowDecoration.Enabled = true;
            btnEdit.Size = new Size(200, 46);
            btnEdit.TabIndex = 10115;
            btnEdit.Text = "Edit Trip";
            btnEdit.UseTransparentBackground = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Animated = true;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BorderColor = Color.FromArgb(255, 192, 128);
            btnAdd.BorderRadius = 15;
            btnAdd.BorderThickness = 1;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.CustomizableEdges = customizableEdges13;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(255, 192, 128);
            btnAdd.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnAdd.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.HoverState.ForeColor = Color.White;
            btnAdd.ImageAlign = HorizontalAlignment.Left;
            btnAdd.ImageSize = new Size(35, 35);
            btnAdd.IndicateFocus = true;
            btnAdd.Location = new Point(27, 72);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnAdd.PressedDepth = 6;
            btnAdd.ShadowDecoration.BorderRadius = 20;
            btnAdd.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnAdd.ShadowDecoration.Depth = 5;
            btnAdd.ShadowDecoration.Enabled = true;
            btnAdd.Size = new Size(200, 46);
            btnAdd.TabIndex = 10114;
            btnAdd.Text = "Add Trip";
            btnAdd.UseTransparentBackground = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Animated = true;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.FromArgb(255, 192, 128);
            btnCancel.BorderRadius = 15;
            btnCancel.BorderThickness = 1;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CustomizableEdges = customizableEdges15;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(255, 192, 128);
            btnCancel.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnCancel.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.HoverState.ForeColor = Color.White;
            btnCancel.ImageAlign = HorizontalAlignment.Left;
            btnCancel.ImageSize = new Size(35, 35);
            btnCancel.IndicateFocus = true;
            btnCancel.Location = new Point(27, 176);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnCancel.PressedDepth = 6;
            btnCancel.ShadowDecoration.BorderRadius = 20;
            btnCancel.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnCancel.ShadowDecoration.Depth = 5;
            btnCancel.ShadowDecoration.Enabled = true;
            btnCancel.Size = new Size(200, 46);
            btnCancel.TabIndex = 10113;
            btnCancel.Text = "Cancel Trip";
            btnCancel.UseTransparentBackground = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCompleted
            // 
            btnCompleted.Animated = true;
            btnCompleted.BackColor = Color.Transparent;
            btnCompleted.BorderColor = Color.FromArgb(50, 255, 255, 255);
            btnCompleted.BorderRadius = 15;
            btnCompleted.BorderThickness = 1;
            btnCompleted.Cursor = Cursors.Hand;
            btnCompleted.CustomizableEdges = customizableEdges17;
            btnCompleted.DisabledState.BorderColor = Color.DarkGray;
            btnCompleted.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCompleted.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCompleted.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCompleted.FillColor = Color.FromArgb(255, 192, 128);
            btnCompleted.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleted.ForeColor = Color.White;
            btnCompleted.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnCompleted.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCompleted.HoverState.ForeColor = Color.White;
            btnCompleted.ImageAlign = HorizontalAlignment.Left;
            btnCompleted.ImageSize = new Size(35, 35);
            btnCompleted.IndicateFocus = true;
            btnCompleted.Location = new Point(27, 280);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnCompleted.PressedDepth = 6;
            btnCompleted.ShadowDecoration.BorderRadius = 20;
            btnCompleted.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnCompleted.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnCompleted.ShadowDecoration.Depth = 5;
            btnCompleted.ShadowDecoration.Enabled = true;
            btnCompleted.Size = new Size(200, 46);
            btnCompleted.TabIndex = 10112;
            btnCompleted.Text = "Completed";
            btnCompleted.UseTransparentBackground = true;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnDeparted
            // 
            btnDeparted.Animated = true;
            btnDeparted.BackColor = Color.Transparent;
            btnDeparted.BorderColor = Color.FromArgb(50, 255, 255, 255);
            btnDeparted.BorderRadius = 15;
            btnDeparted.BorderThickness = 1;
            btnDeparted.Cursor = Cursors.Hand;
            btnDeparted.CustomizableEdges = customizableEdges19;
            btnDeparted.DisabledState.BorderColor = Color.DarkGray;
            btnDeparted.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeparted.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeparted.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeparted.FillColor = Color.FromArgb(255, 192, 128);
            btnDeparted.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeparted.ForeColor = Color.White;
            btnDeparted.HoverState.FillColor = Color.FromArgb(110, 255, 235, 220);
            btnDeparted.HoverState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeparted.HoverState.ForeColor = Color.White;
            btnDeparted.ImageAlign = HorizontalAlignment.Left;
            btnDeparted.ImageSize = new Size(35, 35);
            btnDeparted.IndicateFocus = true;
            btnDeparted.Location = new Point(27, 228);
            btnDeparted.Name = "btnDeparted";
            btnDeparted.PressedColor = Color.FromArgb(130, 235, 200, 180);
            btnDeparted.PressedDepth = 6;
            btnDeparted.ShadowDecoration.BorderRadius = 20;
            btnDeparted.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            btnDeparted.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnDeparted.ShadowDecoration.Depth = 5;
            btnDeparted.ShadowDecoration.Enabled = true;
            btnDeparted.Size = new Size(200, 46);
            btnDeparted.TabIndex = 10111;
            btnDeparted.Text = "Departed";
            btnDeparted.UseTransparentBackground = true;
            btnDeparted.Click += btnDeparted_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = this;
            // 
            // TripsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1235, 913);
            Controls.Add(label1);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(tbSearch);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TripsForm";
            Text = "TripsForm";
            Load += TripsForm_Load;
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnCompleted;
        private Guna.UI2.WinForms.Guna2Button btnDeparted;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTrips;
        private DataGridViewTextBoxColumn dgvDepartureTime;
        private DataGridViewTextBoxColumn dgvRoute;
        private DataGridViewTextBoxColumn dgvDriver;
        private DataGridViewTextBoxColumn dgvBusPlate;
        private DataGridViewTextBoxColumn dgvSeatAvail;
        private DataGridViewTextBoxColumn dgvStatus;
    }
}