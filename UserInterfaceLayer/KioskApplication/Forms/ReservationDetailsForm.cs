
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaceLayer;
using UserInterfaceLayer.KioskApplication.Forms;


namespace UserInterfaceLayer.KioskApplication.Forms
{
    public partial class ReservationDetailsForm : Form
{
    private InputResIDForm previousForm;

    public ReservationDetailsForm(InputResIDForm previousForm)
    {
        InitializeComponent();

        this.previousForm = previousForm;

        lblSeats.AutoSize = true;
        lblSeats.AutoEllipsis = true;
        ToolTip seatTooltip = new ToolTip();
        seatTooltip.SetToolTip(lblSeats, lblSeats.Text);
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
            LandingForm landing = new LandingForm();
            landing.Show();

            (this.ParentForm as KioskBaseForm)?.Close();
        }

    private void btnPrint_Click_1(object sender, EventArgs e)
    {
        MessageBox.Show(
           "Printing feature will be enabled once database & receipt system are connected.",
           "Info",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information
       );
    }

    private void btnReschedule_Click_1(object sender, EventArgs e)
    {
        RescheduleForm reschedForm = new RescheduleForm(this);
        KioskBaseForm parent = GetKioskBaseForm();

        if (parent != null)
        {
            parent.LoadFormInPanel(reschedForm);
        }
        else
        {
            MessageBox.Show("Parent KioskBaseForm not found!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnRefund_Click(object sender, EventArgs e)
    {
        RefundForm refForm = new RefundForm(this);
        KioskBaseForm parent = GetKioskBaseForm();

        if (parent != null)
        {
            parent.LoadFormInPanel(refForm);
        }
        else
        {
            MessageBox.Show("Parent KioskBaseForm not found!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    protected KioskBaseForm GetKioskBaseForm()
    {
        Control current = this;
        while (current != null)
        {
            if (current is KioskBaseForm)
                return (KioskBaseForm)current;
            current = current.Parent;
        }
        return null;
    }

    private void btnConfirm_Click(object sender, EventArgs e) { }
    private void pnlCheckRes_Paint(object sender, PaintEventArgs e) { }
}
}