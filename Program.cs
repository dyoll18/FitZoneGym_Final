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

            // DEBUG lang: i-set sa false kapag gusto mong dumaan ulit sa login screen.
            const bool AutoLogin = true;
            const string AutoUser = "admin", AutoPass = "Admin@123";   // palitan ng "cashier1" / "Cashier@123" para i-test ang cashier
            bool firstRun = true;

            while (true)
            {
                bool signedIn = false;
#if DEBUG
                if (AutoLogin && firstRun)
                {
                    AuthService.Login(AutoUser, AutoPass);
                    signedIn = true;
                }
#endif
                firstRun = false;

                if (!signedIn)
                {
                    using (var login = new LoginForm())
                    {
                        if (login.ShowDialog() != DialogResult.OK) break;
                    }
                }

                Nav.Run(new DashboardForm());
                if (!Nav.LoggedOut) break;
            }
            //// Login -> dashboard and the other screens -> (logout returns to login, closing the window exits).
            //while (true)
            //{
            //    using (var login = new LoginForm())
            //    {
            //        if (login.ShowDialog() != DialogResult.OK) break;
            //    }
            //    Nav.Run(new DashboardForm());
            //    if (!Nav.LoggedOut) break;
            //}
        }
    }
}
