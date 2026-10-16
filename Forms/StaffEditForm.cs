using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Add / edit a staff account (dialog opened from the Users &amp; Staff screen).</summary>
    public partial class StaffEditForm : Form
    {
        private readonly int _userId;

        /// <summary>Add mode.</summary>
        public StaffEditForm()
        {
            InitializeComponent();
            Text = "Add Staff";
        }

        /// <summary>Edit mode.</summary>
        public StaffEditForm(int userId, string username, string fullName, string role, bool active) : this()
        {
            _userId = userId;
            Text = "Edit Staff";
            txtUser.Text = username;
            txtUser.ReadOnly = true;
            txtName.Text = fullName;
            chkActive.Checked = active;
            lblPass.Text = "New password";
            lblHint.Text = "Leave the password blank to keep the current one.";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            const string role = "Staff";
            bool ok = Ui.Run(() =>
            {
                if (_userId == 0) StaffService.Add(txtUser.Text, txtName.Text, role, txtPass.Text, chkActive.Checked);
                else StaffService.Update(_userId, txtName.Text, role, chkActive.Checked, txtPass.Text);
            });
            if (ok) { DialogResult = DialogResult.OK; Close(); }
        }
    }
}
