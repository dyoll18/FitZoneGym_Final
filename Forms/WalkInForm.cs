using System.Data;
using System.Globalization;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym.Forms
{
    public class WalkInForm : ShellForm
    {
        private TextBox txtName = Ui.Input(240);
        private TextBox txtContact = Ui.Input(180);
        private DataGridView dgvInside = Ui.Grid();
        private DataGridView dgvToday = Ui.Grid();
        private Label lblRate = Ui.Label("", 9.5f, false, Ui.Muted);
        private Label lblTotal = Ui.Label("", 11f, true, Ui.Green);
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 30000 };
        private DataTable inside = new DataTable();

        protected override string NavKey { get { return "walkin"; } }

        public WalkInForm()
        {
            PageTitle = "Walk-In Clients";
            if (Ui.IsDesignTime) return;

            var top = Ui.Row(
                Ui.Field("Client name", txtName),
                Ui.Field("Contact number (optional)", txtContact),
                Ui.Primary("Check In", (s, e) => CheckIn(), 120));

            var buttons = Ui.Row(
                Ui.Success("Check Out && Pay", (s, e) => CheckOut(), 160),
                Ui.Danger("Void Visit", (s, e) => VoidVisit(), 120),
                lblRate);

            var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 7, BackColor = Ui.Bg };
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.Controls.Add(top, 0, 0);
            layout.Controls.Add(Ui.Label("Currently inside", 11f, true), 0, 1);
            layout.Controls.Add(dgvInside, 0, 2);
            layout.Controls.Add(buttons, 0, 3);
            layout.Controls.Add(Ui.Label("Today's walk-in visits", 11f, true), 0, 4);
            layout.Controls.Add(dgvToday, 0, 5);
            layout.Controls.Add(lblTotal, 0, 6);
            contentPanel.Controls.Add(layout);

            foreach (var g in new[] { dgvInside, dgvToday })
            {
                g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                g.MultiSelect = false;
            }

            timer.Tick += (s, e) => UpdateElapsed();
            FormClosed += (s, e) => timer.Dispose();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Ui.IsDesignTime) return;
            LoadData();
            timer.Start();
        }

        private int? SelectedId(DataGridView grid)
        {
            if (grid.CurrentRow == null) return null;
            return Db.I(grid.CurrentRow.Cells["VisitID"].Value);
        }

        private void LoadData()
        {
            Ui.Run(() =>
            {
                inside = WalkInService.Inside();
                inside.Columns.Add("Elapsed", typeof(string));
                inside.Columns.Add("Running Charge", typeof(string));
                UpdateElapsed();
                dgvInside.DataSource = inside;
                dgvInside.Columns["VisitID"].Visible = false;
                dgvInside.Columns["ClientName"].HeaderText = "Client";
                dgvInside.Columns["ContactNumber"].HeaderText = "Contact";
                dgvInside.Columns["TimeIn"].HeaderText = "Time In";
                dgvInside.Columns["RatePerHour"].HeaderText = "Rate / hr";
                dgvInside.Columns["RatePerHour"].DefaultCellStyle.Format = Ui.MoneyFormat;

                dgvToday.DataSource = WalkInService.Today();
                dgvToday.Columns["VisitID"].Visible = false;
                dgvToday.Columns["ClientName"].HeaderText = "Client";
                dgvToday.Columns["TimeIn"].HeaderText = "Time In";
                dgvToday.Columns["TimeOut"].HeaderText = "Time Out";
                dgvToday.Columns["HoursCharged"].HeaderText = "Hours";
                dgvToday.Columns["PaymentMethod"].HeaderText = "Method";
                dgvToday.Columns["Amount"].DefaultCellStyle.Format = Ui.MoneyFormat;

                lblRate.Text = "  Rate: " + Ui.Money(WalkInService.Rate) + " per hour (rounded up, minimum 1 hour)";
                lblTotal.Text = "Collected today: " + Ui.Money(WalkInService.TodayTotal());
            });
        }

        private void UpdateElapsed()
        {
            foreach (DataRow row in inside.Rows)
            {
                DateTime timeIn = DateTime.ParseExact(Db.S(row["TimeIn"]), WalkInService.StampFormat, CultureInfo.InvariantCulture);
                var bill = WalkInService.Compute(timeIn, DateTime.Now, Db.ToDec(row["RatePerHour"]));
                row["Elapsed"] = (int)bill.Elapsed.TotalHours + "h " + bill.Elapsed.Minutes + "m";
                row["Running Charge"] = Ui.Money(bill.Amount);
            }
            dgvInside.Invalidate();
        }

        private void CheckIn()
        {
            if (!Ui.Run(() => WalkInService.CheckIn(txtName.Text, txtContact.Text))) return;
            txtName.Clear();
            txtContact.Clear();
            LoadData();
            txtName.Focus();
        }

        private void CheckOut()
        {
            int? id = SelectedId(dgvInside);
            if (id == null) { Ui.Info("Select a client from the 'Currently inside' list."); return; }

            WalkInBill bill = null;
            if (!Ui.Run(() => bill = WalkInService.Preview(id.Value))) return;

            string name = Db.S(dgvInside.CurrentRow.Cells["ClientName"].Value);
            using (var form = new WalkInPaymentForm(id.Value, name, bill))
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;
            }
            LoadData();
        }

        private void VoidVisit()
        {
            int? id = SelectedId(dgvToday) ?? SelectedId(dgvInside);
            if (id == null) { Ui.Info("Select a visit to void."); return; }
            string reason = Ui.Prompt("Void visit", "Reason for voiding this visit:");
            if (string.IsNullOrWhiteSpace(reason)) return;
            if (Ui.Run(() => WalkInService.Void(id.Value, reason))) LoadData();
        }
    }
}
