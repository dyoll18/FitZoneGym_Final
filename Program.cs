using FitZoneGym.Data;
using FitZoneGym.Forms;
using FitZoneGym.Services;

namespace FitZoneGym
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            try
            {
                Schema.EnsureCreated();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The database could not be opened or created.\n\n" + ex.Message,
                    "FITZONE GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (true)
            {
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;
                }
                Nav.Run(new DashboardForm());
                if (!Nav.LoggedOut) break;
            }
        }
    }
}
