using UserInterfaceLayer.KioskApplication.Forms;
using UserInterfaceLayer.StaffApplication.Forms;

namespace UserInterfaceLayer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new LandingForm());
        }
    }
}