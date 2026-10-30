using System.Data;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Screen 6 - Registration &amp; Renewal.</summary>
    public partial class RegistrationForm : ShellForm
    {
        private DataTable _plans = new DataTable();
        private bool _canPay;

        protected override string NavKey { get { return "reg"; } }

        public RegistrationForm()
        {
            InitializeComponent();
            cboMethod.SelectedIndex = 0;
            Ui.StyleGrid(dgvHistory);
            if (Ui.IsDesignTime) return;

            _canPay = Session.Current.Can(Perm.RecordPayments);
            foreach (Control c in new Control[] { lblPay, numPay, lblMethod, cboMethod, lblRef, txtRef }) c.Visible = _canPay;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Ui.IsDesignTime) return;

            _plans = PlanService.List(true);
            foreach (DataRow r in _plans.Rows)
                cboPlan.Items.Add(Db.S(r["PlanName"]) + " (" + Db.I(r["DurationMonths"]) + " mo, " + Ui.Money(Db.ToDec(r["Fee"])) + ")");
            if (cboPlan.Items.Count > 0) cboPlan.SelectedIndex = 0;
            else Ui.Warn("There are no active membership plans. Add a plan first.");
            ModeChanged();
        }

        private bool IsRenew { get { return rbRenew.Checked; } }

        private void ModeChanged()
        {
            rbNew.BackColor = rbNew.Checked ? Ui.Accent : Ui.InputBg;
            rbNew.ForeColor = rbNew.Checked ? Color.White : Ui.Text;
            rbRenew.BackColor = rbRenew.Checked ? Ui.Accent : Ui.InputBg;
            rbRenew.ForeColor = rbRenew.Checked ? Color.White : Ui.Text;
            btnGo.Text = IsRenew ? "Process Renewal" : "Register Membership";
            lblDateCaption.Text = IsRenew ? "Renewal date" : "Start date";
            lblDateHint.Text = IsRenew ? "(renewal date)" : "(start date)";
            Preview();
        }

        private void rbMode_CheckedChanged(object sender, EventArgs e) { if (IsHandleCreated) ModeChanged(); }
        private void Preview_Changed(object sender, EventArgs e) { if (IsHandleCreated) Preview(); }

        private void memberPicker_MemberChanged(object sender, EventArgs e) { MemberChanged(); }

        private void MemberChanged()
        {
            string id = memberPicker.SelectedMemberId;
            dgvHistory.DataSource = null;
            if (id == null) { lblInfo.Text = "Search and select a member to begin."; lblSummary.Text = ""; return; }

            Ui.Run(() =>
            {
                var cur = MembershipService.Latest(id);
                if (cur == null)
                {
                    lblInfo.Text = "No membership yet - use New Registration.";
                    rbNew.Checked = true;
                }
                else
                {
                    var plan = PlanService.Get(cur.PlanId);
                    lblInfo.Text = "Current plan: " + plan.PlanName + "   |   Status: " + cur.State + "\nExpiration: " + Ui.Date(cur.ExpirationDate);
                    rbRenew.Checked = true;
                }
                var hist = MembershipService.RenewalHistory(id);
                Ui.Bind(dgvHistory, hist, null, new[] { "Charged", "Paid" }, new[] { "TransactionDate", "PreviousExpiration", "NewExpiration" });
                Preview();
            });
        }

        private int SelectedPlanId
        {
            get { return cboPlan.SelectedIndex < 0 || cboPlan.SelectedIndex >= _plans.Rows.Count ? 0 : Db.I(_plans.Rows[cboPlan.SelectedIndex]["PlanID"]); }
        }

        private void Preview()
        {
            if (cboPlan.SelectedIndex < 0 || cboPlan.SelectedIndex >= _plans.Rows.Count) { lblSummary.Text = ""; return; }
            try
            {
                var plan = PlanService.FromRow(_plans.Rows[cboPlan.SelectedIndex]);
                DateTime start, exp;
                string note = "";
                if (IsRenew && memberPicker.SelectedMemberId != null)
                {
                    var p = MembershipService.PreviewRenewal(memberPicker.SelectedMemberId, plan.PlanId, dtpDate.Value.Date);
                    start = p.NewStart;
                    exp = p.NewExpiration;
                    note = p.ExtendsFromPrevious ? "continues from previous expiry" : "starts on renewal date (grace period passed)";
                }
                else
                {
                    start = dtpDate.Value.Date;
                    exp = Membership.CalcExpiration(start, plan.DurationMonths);
                }
                decimal disc = BillingService.DiscountAmount(plan.Fee, numDiscount.Value);
                lblSummary.Text = "Term: " + Ui.Date(start) + " to " + Ui.Date(exp) + (note == "" ? "" : "  (" + note + ")") +
                                  "\nFee " + Ui.Money(plan.Fee) + "  -  Discount " + Ui.Money(disc) + "  =  Total " + Ui.Money(plan.Fee - disc);
            }
            catch (Exception ex) { lblSummary.Text = ex.Message; }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string id = memberPicker.SelectedMemberId;
            if (id == null) { Ui.Warn("Search for and select a member first."); return; }
            if (SelectedPlanId == 0) { Ui.Warn("Select a membership plan."); return; }

            decimal pay = _canPay ? numPay.Value : 0m;
            string method = Convert.ToString(cboMethod.SelectedItem), reference = txtRef.Text;
            string invoiceNo = null;
            bool ok = Ui.Run(() =>
            {
                invoiceNo = IsRenew
                    ? MembershipService.Renew(id, SelectedPlanId, dtpDate.Value.Date, numDiscount.Value, pay, method, reference)
                    : MembershipService.Register(id, SelectedPlanId, dtpDate.Value.Date, numDiscount.Value, pay, method, reference);
            });
            if (!ok) return;

            Ui.Info((IsRenew ? "Membership renewed." : "Membership registered.") + "\nInvoice " + invoiceNo + " was created" +
                    (pay > 0m ? " with an initial payment of " + Ui.Money(pay) + "." : " (unpaid)."));
            numPay.Value = 0;
            txtRef.Clear();
            memberPicker.Reload(id);
            MemberChanged();
        }
    }
}
