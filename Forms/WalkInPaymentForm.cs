using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    public partial class WalkInPaymentForm : Form
    {
        private readonly int _visitId;
        private bool _busy;

        public WalkInPaymentForm()
        {
            InitializeComponent();
            cboMethod.SelectedIndex = 0;
        }

        public WalkInPaymentForm(int visitId, string clientName, WalkInBill bill) : this()
        {
            _visitId = visitId;
            lblClient.Text = clientName;
            lblTime.Text = (int)bill.Elapsed.TotalHours + "h " + bill.Elapsed.Minutes + "m  ->  " + bill.Hours + " hr x " + Ui.Money(bill.Rate) + " per hour";
            lblAmount.Text = "Amount due: " + Ui.Money(bill.Amount);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_busy) return;
            _busy = true;
            btnConfirm.Enabled = false;
            try
            {
                string method = Convert.ToString(cboMethod.SelectedItem);
                if (!Ui.Run(() => WalkInService.CheckOut(_visitId, method, txtRef.Text))) return;
                DialogResult = DialogResult.OK;
            }
            finally
            {
                _busy = false;
                btnConfirm.Enabled = true;
            }
            Ui.Info("Payment successful! Amount paid: " + lblAmount.Text.Replace("Amount due: ", ""));
        }

        private void WalkInPaymentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
