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
    public partial class TicketDetailsForm : Form
    {
        public TicketDetailsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTicket_Click(object sender, EventArgs e)
        {
            Dashboard parentDashboard = (Dashboard)this.ParentForm;
            parentDashboard.LoadFormInPanel(new TicketsForm());
        }
    }
}
