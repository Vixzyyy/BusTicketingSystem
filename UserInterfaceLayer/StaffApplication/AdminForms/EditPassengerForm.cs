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
    public partial class EditPassengerForm : Form
    {
        private PassengersForm parentForm;
        private string passengerId;

        public EditPassengerForm(string passengerId, PassengersForm parent)
        {
            InitializeComponent();
            this.passengerId = passengerId;
            this.parentForm = parent;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            parentForm.ShowPassengersGrid();
        }
    }
}
