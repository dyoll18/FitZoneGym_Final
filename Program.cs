using FitZoneGym.Data;
using FitZoneGym.Forms;

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

            // Login -> dashboard and the other screens -> (logout returns to login, closing the window exits).
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
