using System.Data;
using System.Globalization;
using System.Text;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym
{
    /// <summary>Theme, control factories and common dialogs so every screen looks and behaves the same.</summary>
    public static class Ui
    {
        public static readonly Color Navy = Color.FromArgb(15, 35, 66);
        public static readonly Color NavyLight = Color.FromArgb(27, 58, 102);
        public static readonly Color Blue = Color.FromArgb(30, 111, 240);
        public static readonly Color Bg = Color.FromArgb(243, 246, 251);
        public static readonly Color Text = Color.FromArgb(31, 41, 55);
        public static readonly Color Muted = Color.FromArgb(107, 114, 128);
        public static readonly Color Green = Color.FromArgb(22, 163, 74);
        public static readonly Color Orange = Color.FromArgb(245, 158, 11);
        public static readonly Color Red = Color.FromArgb(220, 38, 38);
        public static readonly Color Border = Color.FromArgb(214, 221, 232);

        public static Font Base => new Font("Segoe UI", 9.5f);
        public static Font Bold(float size = 9.5f) => new Font("Segoe UI", size, FontStyle.Bold);

        public static string Money(decimal v) => "₱" + v.ToString("N2", CultureInfo.InvariantCulture);
        public static string Date(DateTime d) => d.ToString("MMM d, yyyy", CultureInfo.InvariantCulture);
        public const string MoneyFormat = "₱#,##0.00";

        // ---- control factories --------------------------------------------------------------
        public static Label Label(string text, float size = 9.5f, bool bold = false, Color? color = null)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = bold ? Bold(size) : new Font("Segoe UI", size),
                ForeColor = color ?? Text,
                Margin = new Padding(0, 6, 8, 2),
                BackColor = Color.Transparent,
            };
        }

        public static Button Button(string text, Color back, EventHandler onClick, int width = 120)
        {
            var b = new Button
            {
                Text = text,
                Width = width,
                Height = 34,
                FlatStyle = FlatStyle.Flat,
                BackColor = back,
                ForeColor = back == Color.White ? Text : Color.White,
                Font = Bold(9.5f),
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 0, 8, 0),
                UseVisualStyleBackColor = false,
            };
            b.FlatAppearance.BorderColor = back == Color.White ? Border : back;
            if (onClick != null) b.Click += onClick;
            return b;
        }

        public static Button Primary(string text, EventHandler click, int width = 120) => Button(text, Blue, click, width);
        public static Button Secondary(string text, EventHandler click, int width = 120) => Button(text, Color.White, click, width);
        public static Button Success(string text, EventHandler click, int width = 120) => Button(text, Green, click, width);
        public static Button Danger(string text, EventHandler click, int width = 120) => Button(text, Red, click, width);

        public static TextBox Input(int width = 220)
        {
            return new TextBox { Width = width, Font = Base, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(0, 3, 8, 3) };
        }

        public static ComboBox Combo(int width = 220, params string[] items)
        {
            var c = new ComboBox { Width = width, Font = Base, DropDownStyle = ComboBoxStyle.DropDownList, FlatStyle = FlatStyle.Flat, Margin = new Padding(0, 3, 8, 3) };
            if (items.Length > 0) { c.Items.AddRange(items); c.SelectedIndex = 0; }
            return c;
        }

        public static DateTimePicker DatePicker(DateTime? value = null, int width = 160)
        {
            return new DateTimePicker
            {
                Width = width, Font = Base, Format = DateTimePickerFormat.Short,
                Value = value ?? DateTime.Today, Margin = new Padding(0, 3, 8, 3),
            };
        }

        public static NumericUpDown Number(decimal min, decimal max, decimal value, int decimals = 0, int width = 120)
        {
            return new NumericUpDown { Minimum = min, Maximum = max, Value = value, DecimalPlaces = decimals, Width = width, Font = Base, ThousandsSeparator = true, Margin = new Padding(0, 3, 8, 3) };
        }

        public static Panel Card(int padding = 14)
        {
            return new Panel { BackColor = Color.White, Padding = new Padding(padding), Dock = DockStyle.Fill, Margin = new Padding(0, 0, 10, 10) };
        }

        public static FlowLayoutPanel Row(params Control[] controls)
        {
            var f = new FlowLayoutPanel { AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, WrapContents = false, FlowDirection = FlowDirection.LeftToRight, Margin = new Padding(0), BackColor = Color.Transparent };
            f.Controls.AddRange(controls);
            return f;
        }

        public static FlowLayoutPanel Wrap(params Control[] controls)
        {
            var f = new FlowLayoutPanel { AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, WrapContents = true, FlowDirection = FlowDirection.LeftToRight, Dock = DockStyle.Fill, BackColor = Color.Transparent };
            f.Controls.AddRange(controls);
            return f;
        }

        /// <summary>A label + control pair stacked vertically, used in toolbars.</summary>
        public static FlowLayoutPanel Field(string caption, Control c)
        {
            var f = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, AutoSize = true, WrapContents = false, Margin = new Padding(0, 0, 10, 4), BackColor = Color.Transparent };
            var l = Label(caption, 8.5f, false, Muted);
            l.Margin = new Padding(0, 0, 0, 0);
            f.Controls.Add(l);
            f.Controls.Add(c);
            return f;
        }

        public static bool IsDesignTime => System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;

        public static DataGridView Grid()
        {
            var g = new DataGridView { Dock = DockStyle.Fill };
            StyleGrid(g);
            return g;
        }

        /// <summary>Applies the standard FITZONE table look to a DataGridView created in the Designer.</summary>
        public static void StyleGrid(DataGridView g)
        {
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.RowHeadersVisible = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = Color.FromArgb(230, 234, 242);
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 34;
            g.Font = Base;
            g.ColumnHeadersDefaultCellStyle.BackColor = Navy;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = Bold(9f);
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Navy;
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            g.DefaultCellStyle.SelectionForeColor = Text;
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 253);
            g.RowTemplate.Height = 30;
            g.CellFormatting -= StatusColors;
            g.CellFormatting += StatusColors;
        }

        private static void StatusColors(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var g = (DataGridView)sender;
            if (e.ColumnIndex < 0 || e.RowIndex < 0 || e.Value == null) return;
            string name = g.Columns[e.ColumnIndex].Name;
            if (name != "Status" && name != "MembershipStatus" && name != "AccountStatus") return;
            switch (Convert.ToString(e.Value))
            {
                case "Active": case "Paid": case "Approved": case "Completed": e.CellStyle.ForeColor = Green; break;
                case "Frozen": case "Partially Paid": case "Pending": e.CellStyle.ForeColor = Orange; break;
                case "Expired": case "Unpaid": case "Rejected": case "Inactive": case "Voided": e.CellStyle.ForeColor = Red; break;
            }
        }

        /// <summary>Binds data, hides technical id columns and formats money/date columns.</summary>
        public static void Bind(DataGridView g, DataTable table, string[] hide = null, string[] money = null, string[] dates = null)
        {
            if (dates != null) PrettyDates(table, dates);
            g.DataSource = table;
            if (hide != null) foreach (var h in hide) if (g.Columns.Contains(h)) g.Columns[h].Visible = false;
            if (money != null)
                foreach (var m in money)
                    if (g.Columns.Contains(m))
                    {
                        g.Columns[m].DefaultCellStyle.Format = MoneyFormat;
                        g.Columns[m].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
            foreach (DataGridViewColumn c in g.Columns) c.SortMode = DataGridViewColumnSortMode.Automatic;
        }

        public static void PrettyDates(DataTable t, params string[] columns)
        {
            foreach (var col in columns)
            {
                if (!t.Columns.Contains(col)) continue;
                foreach (DataRow r in t.Rows)
                {
                    string v = Db.S(r[col]);
                    if (v.Length >= 10 && DateTime.TryParseExact(v.Substring(0, 10), Db.DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var d))
                        r[col] = Date(d);
                }
            }
        }

        // ---- dialogs and safe execution -----------------------------------------------------
        public static void Info(string msg, string title = "FITZONE GYM") => MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        public static void Warn(string msg, string title = "Please check") => MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        public static void Error(string msg, string title = "Error") => MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        public static bool Confirm(string msg, string title = "Please confirm") =>
            MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        /// <summary>Runs an action and converts validation, permission and database errors into friendly messages. Returns true on success.</summary>
        public static bool Run(Action action)
        {
            try { action(); return true; }
            catch (ValidationException ex) { Audit.Error("Validation", ex.Message); Warn(ex.Message); }
            catch (PermissionException ex) { Audit.Error("Permission", ex.Message); Warn(ex.Message, "Access denied"); }
            catch (Exception ex)
            {
                Audit.Error("Error", ex.ToString());
                Error("The operation could not be completed and nothing was saved.\n\n" + ex.Message, "Database / system error");
            }
            return false;
        }

        public static string Prompt(string title, string message, bool required = true)
        {
            using var f = new Form
            {
                Text = title, StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false, MinimizeBox = false, ClientSize = new Size(420, 170), Font = Base, BackColor = Color.White,
            };
            var lbl = new Label { Text = message, Left = 16, Top = 14, Width = 388, Height = 36 };
            var txt = new TextBox { Left = 16, Top = 54, Width = 388, Multiline = true, Height = 56, BorderStyle = BorderStyle.FixedSingle };
            var ok = Primary("OK", null, 90); ok.Left = 224; ok.Top = 122; ok.DialogResult = DialogResult.OK;
            var cancel = Secondary("Cancel", null, 90); cancel.Left = 320; cancel.Top = 122; cancel.DialogResult = DialogResult.Cancel;
            f.Controls.AddRange(new Control[] { lbl, txt, ok, cancel });
            f.AcceptButton = ok; f.CancelButton = cancel;
            while (true)
            {
                if (f.ShowDialog() != DialogResult.OK) return null;
                if (!required || txt.Text.Trim().Length > 0) return txt.Text.Trim();
                Warn("This field is required.");
            }
        }

        // ---- export -------------------------------------------------------------------------
        public static void ExportCsv(DataGridView g, string defaultName)
        {
            if (g.Rows.Count == 0) { Info("There is nothing to export."); return; }
            using var dlg = new SaveFileDialog { Filter = "CSV file (*.csv)|*.csv", FileName = defaultName + ".csv" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            Run(() =>
            {
                var sb = new StringBuilder();
                var cols = g.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).ToList();
                sb.AppendLine(string.Join(",", cols.Select(c => Csv(c.HeaderText))));
                foreach (DataGridViewRow r in g.Rows)
                    sb.AppendLine(string.Join(",", cols.Select(c => Csv(Convert.ToString(r.Cells[c.Index].Value, CultureInfo.InvariantCulture)))));
                File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
                Info("Exported " + g.Rows.Count + " row(s) to\n" + dlg.FileName);
            });
        }

        private static string Csv(string v)
        {
            v ??= "";
            return v.Contains(',') || v.Contains('"') || v.Contains('\n') ? "\"" + v.Replace("\"", "\"\"") + "\"" : v;
        }
    }

    /// <summary>Two-column label/control layout used by dialogs and detail panels.</summary>
    public class FormPanel : TableLayoutPanel
    {
        public FormPanel(int labelWidth = 130)
        {
            ColumnCount = 2;
            ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, labelWidth));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            AutoSize = true;
            Dock = DockStyle.Top;
            BackColor = Color.Transparent;
        }

        public void AddRow(string label, Control c, int height = 0)
        {
            RowCount++;
            RowStyles.Add(height > 0 ? new RowStyle(SizeType.Absolute, height) : new RowStyle(SizeType.AutoSize));
            var l = Ui.Label(label, 9.5f, false, Ui.Text);
            l.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            l.Margin = new Padding(0, 8, 6, 4);
            Controls.Add(l, 0, RowCount - 1);
            c.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            if (c is Control && height > 0) c.Height = height - 6;
            c.Margin = new Padding(0, 4, 0, 4);
            Controls.Add(c, 1, RowCount - 1);
        }
    }
}
