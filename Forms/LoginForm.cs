using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Screen 1 - Login.</summary>
    public partial class LoginForm : Form
    {
        private readonly System.Windows.Forms.Timer _lock = new System.Windows.Forms.Timer { Interval = 1000 };
        private int _failures, _lockSeconds;

        private static string RememberFile
        {
            get
            {
                string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FitZoneGym");
                Directory.CreateDirectory(dir);
                return Path.Combine(dir, "last_user.txt");
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            if (Ui.IsDesignTime) return;
            Theme.Apply(this, true);

            _lock.Tick += (s, e) =>
            {
                _lockSeconds--;
                if (_lockSeconds <= 0) { _lock.Stop(); btnLogin.Enabled = true; lblMessage.Text = ""; _failures = 0; }
                else lblMessage.Text = "Too many failed attempts. Try again in " + _lockSeconds + "s.";
            };

            try
            {
                if (File.Exists(RememberFile))
                {
                    txtUser.Text = File.ReadAllText(RememberFile).Trim();
                    chkRemember.Checked = txtUser.Text.Length > 0;
                }
            }
            catch { }
            Shown += (s, e) => { if (txtUser.Text.Length > 0) txtPass.Focus(); else txtUser.Focus(); };
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                AuthService.Login(txtUser.Text, txtPass.Text);
                try
                {
                    if (chkRemember.Checked) File.WriteAllText(RememberFile, txtUser.Text.Trim());
                    else if (File.Exists(RememberFile)) File.Delete(RememberFile);
                }
                catch { }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ValidationException ex)
            {
                lblMessage.Text = ex.Message;
                txtPass.Clear();
                txtPass.Focus();
                if (++_failures >= 5) { _lockSeconds = 30; btnLogin.Enabled = false; _lock.Start(); }
            }
            catch (Exception ex)
            {
                Audit.Error("Error", ex.ToString());
                lblMessage.Text = "Could not sign in: " + ex.Message;
            }
        }
    }
}
