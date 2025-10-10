using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLayer.StaffApplication.Forms
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvTodaysTrip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Dashboard parentDashboard = (Dashboard)this.ParentForm;

                parentDashboard.LoadFormInPanel(new TicketDetailsForm());
                parentDashboard.LoadFormInPanel(new TicketDetailsForm());
            }
        }

        private void dgvTodaysTrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {

        }
    }
}
