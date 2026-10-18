using System.Data;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Screen 4 - Add / Edit Member.</summary>
    public partial class MemberEditForm : Form
    {
        private readonly string _memberId;       // null when adding
        private readonly ErrorProvider _err = new ErrorProvider();
        private DataTable _plans;

        public MemberEditForm() : this(null) { }

        public MemberEditForm(string memberId)
        {
            InitializeComponent();
            Theme.Apply(this, true);
            _memberId = memberId;
            cboGender.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            dtpBirth.Value = DateTime.Today.AddYears(-25);
            dtpBirth.Checked = false;
            if (Ui.IsDesignTime) return;

            Text = memberId == null ? "Add Member" : "Edit Member - " + memberId;
            if (memberId == null)
            {
                lblStatus.Visible = false;
                cboStatus.Visible = false;
                _plans = PlanService.List(true);
                cboPlan.Items.Add("(none - register membership later)");
                foreach (DataRow r in _plans.Rows)
                    cboPlan.Items.Add(Db.S(r["PlanName"]) + "  -  " + Ui.Money(Db.ToDec(r["Fee"])) + " / " + Db.I(r["DurationMonths"]) + " mo");
                cboPlan.SelectedIndex = 0;
            }
            else
            {
                lblPlan.Visible = false;
                cboPlan.Visible = false;
                lblStart.Visible = false;
                dtpStart.Visible = false;
                LoadMember();
            }
        }

        private void LoadMember()
        {
            var m = MemberService.Get(_memberId);
            if (m == null) { Ui.Warn("This member no longer exists."); DialogResult = DialogResult.Cancel; return; }
            txtName.Text = m.FullName;
            txtContact.Text = m.ContactNumber;
            txtEmail.Text = m.Email;
            cboGender.SelectedItem = string.IsNullOrEmpty(m.Gender) ? "" : m.Gender;
            if (m.BirthDate.HasValue) { dtpBirth.Value = m.BirthDate.Value; dtpBirth.Checked = true; }
            txtAddress.Text = m.Address;
            txtNotes.Text = m.Notes;
            cboStatus.SelectedItem = m.AccountStatus;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _err.Clear();
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtName.Text)) { _err.SetError(txtName, "Full name is required."); ok = false; }
            if (string.IsNullOrWhiteSpace(txtContact.Text)) { _err.SetError(txtContact, "Contact number is required."); ok = false; }
            if (!ok) return;

            var m = new Member
            {
                MemberId = _memberId,
                FullName = txtName.Text,
                ContactNumber = txtContact.Text,
                Email = txtEmail.Text,
                Gender = Convert.ToString(cboGender.SelectedItem),
                Address = txtAddress.Text,
                Notes = txtNotes.Text,
                BirthDate = dtpBirth.Checked ? dtpBirth.Value.Date : (DateTime?)null,
                AccountStatus = _memberId == null ? "Active" : Convert.ToString(cboStatus.SelectedItem),
            };

            bool saved = Ui.Run(() =>
            {
                if (_memberId == null)
                {
                    string id = MemberService.Add(m);
                    string msg = "Member saved with ID " + id + ".";
                    if (cboPlan.SelectedIndex > 0)
                    {
                        int planId = Db.I(_plans.Rows[cboPlan.SelectedIndex - 1]["PlanID"]);
                        string inv = MembershipService.Register(id, planId, dtpStart.Value.Date, 0m, 0m, "Cash", null);
                        msg += "\nMembership registered and invoice " + inv + " created (unpaid).";
                    }
                    Ui.Info(msg);
                }
                else
                {
                    MemberService.Update(m);
                    Ui.Info("Member updated.");
                }
            });
            if (saved) { DialogResult = DialogResult.OK; Close(); }
        }

        private void formLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
