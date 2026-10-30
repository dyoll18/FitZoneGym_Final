using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Screen 12 - Reports.</summary>
    public partial class ReportsForm : ShellForm
    {
        protected override string NavKey { get { return "reports"; } }

        public ReportsForm()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;
            Ui.StyleGrid(dgvReport);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Ui.Run(() =>
            {
                var r = ReportService.Generate((string)cboType.SelectedItem, dtpFrom.Value.Date, dtpTo.Value.Date);
                string[] dates = { "Date", "Start", "Expiration", "Previous Expiry", "New Expiry", "Requested", "From", "To" };
                string[] money = { "Amount", "Charged", "Paid", "Balance", "Total Due", "Fee", "Prorated", "Discount", "Fees", "Total" };
                Ui.Bind(dgvReport, r.Data, null, money, dates);
                lblSummary.Text = r.Summary + (r.Data.Rows.Count == 0 ? "   (no records in this period)" : "");
            });
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
