using System.Data;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Screen 5 - Membership Plan Management.</summary>
    public partial class PlansForm : ShellForm
    {
        private bool _canManage;

        protected override string NavKey { get { return "plans"; } }

        public PlansForm()
        {
            InitializeComponent();
            Ui.StyleGrid(dgvPlans);
            if (Ui.IsDesignTime) return;

            _canManage = Session.Current.Can(Perm.ManagePlans);
            btnAdd.Visible = _canManage;
            btnEdit.Enabled = _canManage;
            btnToggle.Enabled = _canManage;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Ui.IsDesignTime) return;
            Reload();
        }

        private void Reload()
        {
            Ui.Run(() =>
            {
                var t = PlanService.List(false);
                t.Columns.Add("Status", typeof(string));
                foreach (DataRow r in t.Rows) r["Status"] = Db.I(r["IsActive"]) == 1 ? "Active" : "Inactive";
                dgvPlans.DataSource = t;
                foreach (var h in new[] { "PlanID", "IsActive" }) dgvPlans.Columns[h].Visible = false;
                dgvPlans.Columns["PlanName"].HeaderText = "Plan Name";
                dgvPlans.Columns["DurationMonths"].HeaderText = "Duration (months)";
                dgvPlans.Columns["Fee"].DefaultCellStyle.Format = Ui.MoneyFormat;
                UpdateToggleText();
            });
        }

        private void UpdateToggleText()
        {
            if (dgvPlans.CurrentRow != null)
                btnToggle.Text = Db.S(dgvPlans.CurrentRow.Cells["Status"].Value) == "Active" ? "Deactivate" : "Activate";
        }

        private MembershipPlan Selected()
        {
            return dgvPlans.CurrentRow == null ? null : PlanService.Get(Db.I(dgvPlans.CurrentRow.Cells["PlanID"].Value));
        }

        private void EditPlan(MembershipPlan plan)
        {
            using (var f = new PlanEditForm(plan))
                if (f.ShowDialog(this) == DialogResult.OK) Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e) { EditPlan(null); }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var p = Selected();
            if (p == null) { Ui.Info("Select a plan first."); return; }
            EditPlan(p);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            var p = Selected();
            if (p == null) { Ui.Info("Select a plan first."); return; }
            if (Ui.Run(() => PlanService.SetActive(p.PlanId, !p.IsActive))) Reload();
        }

        private void dgvPlans_SelectionChanged(object sender, EventArgs e) { UpdateToggleText(); }

        private void dgvPlans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _canManage) btnEdit_Click(sender, e);
        }
    }
}
