using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UserInterfaceLayer.StaffApplication.Forms
{
    public partial class AddPassengerForm : Form
    {
        private PassengersForm parentForm;
        public AddPassengerForm(PassengersForm parent)
        {
            InitializeComponent();
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
