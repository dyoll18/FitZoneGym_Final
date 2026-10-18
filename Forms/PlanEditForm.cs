using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Add / edit a membership plan (dialog opened from the Plans screen).</summary>
    public partial class PlanEditForm : Form
    {
        private readonly MembershipPlan _plan;

        public PlanEditForm() : this(null) { }

        public PlanEditForm(MembershipPlan plan)
        {
            InitializeComponent();
            Theme.Apply(this, true);
            _plan = plan ?? new MembershipPlan();
            if (Ui.IsDesignTime) return;

            Text = plan == null ? "Add Plan" : "Edit Plan";
            if (plan != null)
            {
                txtName.Text = plan.PlanName;
                numMonths.Value = plan.DurationMonths;
                numFee.Value = plan.Fee;
                txtDesc.Text = plan.Description;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _plan.PlanName = txtName.Text;
            _plan.DurationMonths = (int)numMonths.Value;
            _plan.Fee = numFee.Value;
            _plan.Description = txtDesc.Text;
            if (Ui.Run(() => PlanService.Save(_plan))) { DialogResult = DialogResult.OK; Close(); }
        }
    }
}
