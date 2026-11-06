using FitZoneGym.Services;

namespace FitZoneGym.Forms
{

    public partial class StaffEditForm : Form
    {
        private readonly int _userId;

        public StaffEditForm()
        {
            InitializeComponent();
            Text = "Add Staff";
            cboRole.SelectedItem = "Staff";
        }

        public StaffEditForm(int userId, string username, string fullName, string role, bool active) : this()
        {
            _userId = userId;
            Text = "Edit Staff";
            txtUser.Text = username;
            txtUser.ReadOnly = true;
            txtName.Text = fullName;
            chkActive.Checked = active;
            cboRole.SelectedItem = role;
            lblPass.Text = "New password";
            lblHint.Text = "Leave the password blank to keep the current one.";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string role = cboRole.SelectedItem as string;
            if (string.IsNullOrEmpty(role)) { Ui.Info("Select a role."); return; }
            bool ok = Ui.Run(() =>
            {
                if (_userId == 0) StaffService.Add(txtUser.Text, txtName.Text, role, txtPass.Text, chkActive.Checked);
                else StaffService.Update(_userId, txtName.Text, role, chkActive.Checked, txtPass.Text);
            });
            if (ok) { DialogResult = DialogResult.OK; Close(); }
        }
    }
}
