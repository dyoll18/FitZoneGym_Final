using System.Drawing.Printing;
using System.Text;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym
{
    /// <summary>Builds a plain-text invoice/receipt and prints, previews or saves it.</summary>
    public static class InvoicePrinter
    {
        public static string BuildText(BillingService.InvoiceDetail d)
        {
            var h = d.Header;
            var sb = new StringBuilder();
            string line = new string('-', 62);
            sb.AppendLine(Settings.Get("GymName", "FITZONE GYM"));
            sb.AppendLine(Settings.Get("GymAddress"));
            sb.AppendLine("Tel: " + Settings.Get("GymContact") + "   " + Settings.Get("GymEmail"));
            sb.AppendLine(line);
            sb.AppendLine("INVOICE " + Db.S(h["InvoiceNo"]) + (d.Status() == "Voided" ? "   *** VOIDED ***" : ""));
            sb.AppendLine("Date    : " + Ui.Date(Db.ToDate(h["InvoiceDate"])));
            sb.AppendLine("Member  : " + Db.S(h["FullName"]) + " (" + Db.S(h["MemberID"]) + ")");
            sb.AppendLine("Type    : " + Db.S(h["Kind"]));
            if (Db.S(h["BillingStart"]) != "")
                sb.AppendLine("Period  : " + Ui.Date(Db.ToDate(h["BillingStart"])) +
                              (Db.S(h["BillingEnd"]) != "" ? " to " + Ui.Date(Db.ToDate(h["BillingEnd"])) : ""));
            sb.AppendLine(line);
            sb.AppendLine("ITEMS");
            foreach (System.Data.DataRow r in d.Items.Rows)
            {
                sb.AppendLine("  " + Db.S(r["Description"]));
                sb.AppendLine("      " + Db.I(r["Quantity"]) + " x " + Ui.Money(Db.ToDec(r["UnitPrice"])) +
                              (Db.ToDec(r["Discount"]) > 0 ? "   discount -" + Ui.Money(Db.ToDec(r["Discount"])) : ""));
            }
            sb.AppendLine(line);
            sb.AppendLine(Pad("Base charges", Ui.Money(Db.ToDec(h["BaseCharge"]))));
            sb.AppendLine(Pad("Discount", "-" + Ui.Money(Db.ToDec(h["Discount"]))));
            sb.AppendLine(Pad("Additional fees", Ui.Money(Db.ToDec(h["AdditionalFees"]))));
            sb.AppendLine(Pad("TOTAL DUE", Ui.Money(d.Total)));
            sb.AppendLine(line);
            sb.AppendLine("PAYMENTS");
            if (d.Payments.Rows.Count == 0) sb.AppendLine("  (none)");
            foreach (System.Data.DataRow r in d.Payments.Rows)
                sb.AppendLine(Pad("  " + Ui.Date(Db.ToDate(r["PaymentDate"])) + "  " + Db.S(r["Method"]) +
                                  (Db.S(r["ReferenceNumber"]) != "" ? " #" + Db.S(r["ReferenceNumber"]) : ""), Ui.Money(Db.ToDec(r["Amount"]))));
            sb.AppendLine(Pad("Amount paid", Ui.Money(d.Paid)));
            sb.AppendLine(Pad("Remaining balance", Ui.Money(d.Balance)));
            sb.AppendLine("Status: " + d.Status());
            sb.AppendLine(line);
            sb.AppendLine("Thank you for choosing " + Settings.Get("GymName", "FITZONE GYM") + "!");
            return sb.ToString();
        }

        private static string Pad(string left, string right) => left.PadRight(62 - right.Length).Substring(0, Math.Max(0, 62 - right.Length)) + right;

        public static void Print(string text, bool preview)
        {
            using var doc = new PrintDocument();
            var lines = text.Replace("\r", "").Split('\n');
            int index = 0;
            doc.PrintPage += (s, e) =>
            {
                using var font = new Font("Consolas", 10f);
                float y = e.MarginBounds.Top, h = font.GetHeight(e.Graphics);
                while (index < lines.Length && y + h <= e.MarginBounds.Bottom)
                {
                    e.Graphics.DrawString(lines[index], font, Brushes.Black, e.MarginBounds.Left, y);
                    y += h; index++;
                }
                e.HasMorePages = index < lines.Length;
            };
            if (preview)
            {
                using var dlg = new PrintPreviewDialog { Document = doc, Width = 900, Height = 800 };
                dlg.ShowDialog();
            }
            else
            {
                using var dlg = new PrintDialog { Document = doc };
                if (dlg.ShowDialog() == DialogResult.OK) doc.Print();
            }
        }
    }
}
