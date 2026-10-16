using System.Data;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Staff account management.</summary>
    public partial class StaffForm : ShellForm
    {
        protected override string NavKey { get { return "staff"; } }

        public StaffForm()
        {
            InitializeComponent();
            Ui.StyleGrid(dgvStaff);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Ui.IsDesignTime) return;
            LoadStaff();
        }

        private DataGridViewRow SelectedRow { get { return dgvStaff.CurrentRow; } }

        private void LoadStaff()
        {
            Ui.Run(() =>
            {
                Ui.Bind(dgvStaff, StaffService.List(), new[] { "UserID" });
                dgvStaff.Columns["FullName"].HeaderText = "Name";
            });
        }

        private void btnAdd_Click(object sender, EventArgs e) { OpenEditor(null); }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedRow == null) { Ui.Info("Select an account first."); return; }
            OpenEditor(SelectedRow);
        }

        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) OpenEditor(SelectedRow);
        }

        private void OpenEditor(DataGridViewRow row)
        {
            StaffEditForm f = row == null
                ? new StaffEditForm()
                : new StaffEditForm(Db.I(row.Cells["UserID"].Value), Db.S(row.Cells["Username"].Value), Db.S(row.Cells["FullName"].Value),
                                    Db.S(row.Cells["Role"].Value), Db.S(row.Cells["Status"].Value) == "Active");
            using (f)
                if (f.ShowDialog(this) == DialogResult.OK) LoadStaff();
        }
    }
}
