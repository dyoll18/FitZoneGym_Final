using System.Data;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    /// <summary>Screen 10 - Payment Management.</summary>
    public partial class PaymentsForm : ShellForm
    {
        private DataTable _open = new DataTable();
        private bool _busy;

        protected override string NavKey { get { return "pay"; } }

        public PaymentsForm()
        {
            InitializeComponent();
            cboMethod.SelectedIndex = 0;
            Ui.StyleGrid(dgvHistory);
        }

        private DataRow Current
        {
            get { return cboInvoice.SelectedIndex < 0 || cboInvoice.SelectedIndex >= _open.Rows.Count ? null : _open.Rows[cboInvoice.SelectedIndex]; }
        }

        private decimal Balance
        {
            get { return Current == null ? 0m : Db.ToDec(Current["TotalDue"]) - Db.ToDec(Current["Paid"]); }
        }

        private void memberPicker_MemberChanged(object sender, EventArgs e) { LoadInvoices(); }

        private void LoadInvoices()
        {
            cboInvoice.Items.Clear();
            _open = new DataTable();
            dgvHistory.DataSource = null;
            ShowInvoice();
            string id = memberPicker.SelectedMemberId;
            if (id == null) return;
            Ui.Run(() =>
            {
                _open = PaymentService.OpenInvoices(id);
                foreach (DataRow r in _open.Rows)
                {
                    decimal bal = Db.ToDec(r["TotalDue"]) - Db.ToDec(r["Paid"]);
                    cboInvoice.Items.Add(Db.S(r["InvoiceNo"]) + "  -  balance " + Ui.Money(bal) + "  (" + Db.S(r["Status"]) + ")");
                }
                if (_open.Rows.Count > 0) cboInvoice.SelectedIndex = 0;
                else Ui.Info("This member has no unpaid invoices.");
            });
        }

        private void cboInvoice_SelectedIndexChanged(object sender, EventArgs e) { ShowInvoice(); }

        private void ShowInvoice()
        {
            var r = Current;
            btnPay.Enabled = r != null;
            if (r == null)
            {
                lblTotal.Text = "-"; lblPrev.Text = "-"; lblAfter.Text = "-";
                dgvHistory.DataSource = null;
                return;
            }
            lblTotal.Text = Ui.Money(Db.ToDec(r["TotalDue"]));
            lblPrev.Text = Ui.Money(Balance);
            numAmount.Value = Math.Min(Balance, numAmount.Maximum);
            Ui.Run(() => Ui.Bind(dgvHistory, PaymentService.History(Db.I(r["InvoiceID"])), new[] { "PaymentID" }, new[] { "Amount" }, new[] { "PaymentDate" }));
            UpdateAfter();
        }

        private void numAmount_ValueChanged(object sender, EventArgs e) { UpdateAfter(); }

        private void UpdateAfter()
        {
            if (Current == null) return;
            decimal after = Balance - numAmount.Value;
            lblAfter.Text = after < 0 ? "Exceeds balance!" : Ui.Money(after);
            lblAfter.ForeColor = after < 0 ? Ui.Red : Ui.Accent;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_busy) return;      // guards against double-clicks / duplicate submissions
            var r = Current;
            if (r == null) { Ui.Warn("Select an invoice."); return; }
            var p = new Payment
            {
                InvoiceId = Db.I(r["InvoiceID"]),
                Amount = numAmount.Value,
                Method = Convert.ToString(cboMethod.SelectedItem),
                PaymentDate = dtpDate.Value.Date,
                ReferenceNumber = txtRef.Text,
            };
            if (!Ui.Confirm("Record a " + Ui.Money(p.Amount) + " payment (" + p.Method + ") for invoice " + Db.S(r["InvoiceNo"]) + "?")) return;

            _busy = true;
            btnPay.Enabled = false;
            try
            {
                decimal remaining = 0m;
                if (!Ui.Run(() => remaining = PaymentService.Record(p))) return;
                Ui.Info(remaining == 0m ? "Payment recorded. The invoice is now PAID in full." : "Payment recorded. Remaining balance: " + Ui.Money(remaining));
                txtRef.Clear();
                LoadInvoices();
            }
            finally
            {
                _busy = false;
                btnPay.Enabled = Current != null;
            }
        }
    }
}
