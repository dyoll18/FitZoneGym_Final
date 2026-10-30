
using System;
using System.Data;
using System.Windows.Forms;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>
    /// Screen 3 - Member Management.
    /// </summary>
    public partial class MembersForm : ShellForm
    {
        protected override string NavKey => "members";

        public MembersForm()
        {
            InitializeComponent();

            if (Ui.IsDesignTime)
                return;

            cboFilter.SelectedIndex = 0;
            Ui.StyleGrid(dgvMembers);

            bool canEdit = Session.Current != null &&
                           Session.Current.Can(Perm.RegisterMembers);

            btnAdd.Visible = canEdit;
            btnEdit.Enabled = canEdit;
            btnToggle.Enabled = canEdit;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Ui.IsDesignTime)
                return;

            Reload();
        }

        private string SelectedId
        {
            get
            {
                return dgvMembers.CurrentRow == null
                    ? null
                    : Db.S(dgvMembers.CurrentRow.Cells["MemberID"].Value);
            }
        }

        private void Reload()
        {
            string keep = SelectedId;

            Ui.Run(() =>
            {
                var t = MemberService.Search(
                    txtSearch.Text,
                    Convert.ToString(cboFilter.SelectedItem));

                Ui.PrettyDates(t, "ExpirationDate");
                dgvMembers.DataSource = t;

                foreach (var hide in new[] { "MembershipID", "StoredStatus", "StartDate" })
                {
                    if (dgvMembers.Columns.Contains(hide))
                        dgvMembers.Columns[hide].Visible = false;
                }

                Rename("MemberID", "Member ID");
                Rename("FullName", "Name");
                Rename("ContactNumber", "Contact");
                Rename("AccountStatus", "Account");
                Rename("PlanName", "Plan");
                Rename("ExpirationDate", "Expires");
                Rename("MembershipStatus", "Membership");

                lblCount.Text = "Total: " + t.Rows.Count + " member(s)";

                if (keep != null)
                {
                    foreach (DataGridViewRow row in dgvMembers.Rows)
                    {
                        if (Db.S(row.Cells["MemberID"].Value) == keep)
                        {
                            if (row.Cells.Count > 1)
                                dgvMembers.CurrentCell = row.Cells[1];

                            break;
                        }
                    }
                }

                UpdateToggleText();
            });
        }

        private void Rename(string col, string header)
        {
            if (dgvMembers.Columns.Contains(col))
                dgvMembers.Columns[col].HeaderText = header;
        }

        private void UpdateToggleText()
        {
            if (dgvMembers.CurrentRow == null ||
                !dgvMembers.Columns.Contains("AccountStatus"))
                return;

            btnToggle.Text =
                Db.S(dgvMembers.CurrentRow.Cells["AccountStatus"].Value) == "Active"
                    ? "Deactivate"
                    : "Activate";
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Reload();
            }
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated && !Ui.IsDesignTime)
                Reload();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (!Ui.IsDesignTime)
                UpdateToggleText();
        }

        private void dgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && btnEdit.Enabled)
                EditSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var f = new MemberEditForm())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                    Reload();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSelected();
        }

        private void EditSelected()
        {
            if (SelectedId == null)
            {
                Ui.Info("Select a member first.");
                return;
            }

            using (var f = new MemberEditForm(SelectedId))
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                    Reload();
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            string id = SelectedId;

            if (id == null)
            {
                Ui.Info("Select a member first.");
                return;
            }

            bool activate = btnToggle.Text == "Activate";

            if (!Ui.Confirm(
                (activate ? "Activate " : "Deactivate ") + id +
                "?\nMembership and billing history are kept."))
                return;

            if (Ui.Run(() => MemberService.SetAccountStatus(id, activate)))
                Reload();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Ui.ExportCsv(dgvMembers, "members");
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
