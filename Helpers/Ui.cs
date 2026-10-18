using System.Data;
using System.Globalization;
using System.Text;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym
{
    /// <summary>
    /// FITZONE "iron & fire" theme (near-black surfaces, ember-orange accent), control factories and common dialogs,
    /// so every screen looks and behaves the same. Colours live only here - change them once, the whole app follows.
    /// </summary>
    public static class Ui
    {
        // ---- palette ------------------------------------------------------------------------
        public static readonly Color Bg = Color.FromArgb(14, 14, 17);          // page background
        public static readonly Color Navy = Color.FromArgb(9, 9, 11);          // sidebar / darkest (name kept for compatibility)
        public static readonly Color NavyLight = Color.FromArgb(32, 32, 38);   // hover
        public static readonly Color Surface = Color.FromArgb(24, 24, 29);     // cards & dialogs
        public static readonly Color Surface2 = Color.FromArgb(36, 36, 43);    // raised elements
        public static readonly Color InputBg = Color.FromArgb(42, 42, 50);     // text boxes
        public static readonly Color Accent = Color.FromArgb(255, 94, 26);     // ember orange
        public static readonly Color AccentSoft = Color.FromArgb(255, 140, 66);
        public static readonly Color AccentDark = Color.FromArgb(205, 60, 8);
        public static readonly Color Gold = Color.FromArgb(255, 184, 28);
        public static readonly Color Blue = Accent;                            // legacy alias (primary colour)
        public static readonly Color Text = Color.FromArgb(244, 244, 246);
        public static readonly Color Muted = Color.FromArgb(156, 156, 170);
        public static readonly Color Green = Color.FromArgb(34, 197, 94);
        public static readonly Color Orange = Color.FromArgb(251, 176, 36);
        public static readonly Color Red = Color.FromArgb(244, 76, 76);
        public static readonly Color Border = Color.FromArgb(54, 54, 63);

        // ---- fonts --------------------------------------------------------------------------
        public static Font Base => new Font("Segoe UI", 9.5f);
        public static Font Bold(float size = 9.5f) => new Font("Segoe UI", size, FontStyle.Bold);

        private static string _displayFamily;

        /// <summary>Condensed "athletic" heading font (Bahnschrift ships with Windows 10+); falls back to Segoe UI.</summary>
        public static string DisplayFamily
        {
            get
            {
                if (_displayFamily == null)
                {
                    _displayFamily = "Segoe UI";
                    try
                    {
                        foreach (var f in FontFamily.Families)
                            if (f.Name == "Bahnschrift") { _displayFamily = "Bahnschrift"; break; }
                    }
                    catch { }
                }
                return _displayFamily;
            }
        }

        public static Font Display(float size, FontStyle style = FontStyle.Bold) => new Font(DisplayFamily, size, style);

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

        /// <param name="kind">"primary", "secondary", "success", "danger" or "logout" (see Theme.StyleButton).</param>
        public static Button Button(string text, string kind, EventHandler onClick, int width = 120)
        {
            var b = new Button
            {
                Text = text,
                Width = width,
                Height = 34,
                Tag = kind,
                Margin = new Padding(0, 0, 8, 0),
            };
            Theme.StyleButton(b, kind);
            if (onClick != null) b.Click += onClick;
            return b;
        }

        public static Button Primary(string text, EventHandler click, int width = 120) => Button(text, "primary", click, width);
        public static Button Secondary(string text, EventHandler click, int width = 120) => Button(text, "secondary", click, width);
        public static Button Success(string text, EventHandler click, int width = 120) => Button(text, "success", click, width);
        public static Button Danger(string text, EventHandler click, int width = 120) => Button(text, "danger", click, width);

        public static TextBox Input(int width = 220)
        {
            return new TextBox { Width = width, Font = Base, BorderStyle = BorderStyle.FixedSingle, BackColor = InputBg, ForeColor = Text, Margin = new Padding(0, 3, 8, 3) };
        }

        public static ComboBox Combo(int width = 220, params string[] items)
        {
            var c = new ComboBox { Width = width, Font = Base, DropDownStyle = ComboBoxStyle.DropDownList, FlatStyle = FlatStyle.Flat, BackColor = InputBg, ForeColor = Text, Margin = new Padding(0, 3, 8, 3) };
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
            return new NumericUpDown { Minimum = min, Maximum = max, Value = value, DecimalPlaces = decimals, Width = width, Font = Base, ThousandsSeparator = true, BackColor = InputBg, ForeColor = Text, Margin = new Padding(0, 3, 8, 3) };
        }

        public static Panel Card(int padding = 14)
        {
            return new Panel { BackColor = Surface, Tag = "card", Padding = new Padding(padding), Dock = DockStyle.Fill, Margin = new Padding(0, 0, 10, 10) };
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
            float k = g.DeviceDpi / 96f;
            int pad = (int)Math.Round(8 * k);

            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.RowHeadersVisible = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.BackgroundColor = Surface;
            g.BorderStyle = BorderStyle.None;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.GridColor = Color.FromArgb(44, 44, 52);
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = (int)Math.Round(38 * k);
            g.Font = Base;

            var head = g.ColumnHeadersDefaultCellStyle;
            head.BackColor = Navy;
            head.ForeColor = AccentSoft;
            head.Font = Bold(9f);
            head.SelectionBackColor = Navy;
            head.SelectionForeColor = AccentSoft;
            head.Alignment = DataGridViewContentAlignment.MiddleLeft;
            head.Padding = new Padding(pad, 0, pad, 0);

            var cell = g.DefaultCellStyle;
            cell.BackColor = Surface;
            cell.ForeColor = Text;
            cell.SelectionBackColor = Color.FromArgb(88, 42, 20);
            cell.SelectionForeColor = Color.White;
            cell.Padding = new Padding(pad, 0, pad, 0);

            var alt = g.AlternatingRowsDefaultCellStyle;
            alt.BackColor = Color.FromArgb(29, 29, 35);
            alt.ForeColor = Text;
            alt.SelectionBackColor = Color.FromArgb(88, 42, 20);
            alt.SelectionForeColor = Color.White;

            g.RowTemplate.Height = (int)Math.Round(34 * k);
            g.CellFormatting -= StatusColors;
            g.CellFormatting += StatusColors;
        }

        private static void StatusColors(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var g = (DataGridView)sender;
            if (e.ColumnIndex < 0 || e.RowIndex < 0 || e.Value == null) return;
            string name = g.Columns[e.ColumnIndex].Name;
            if (name != "Status" && name != "MembershipStatus" && name != "AccountStatus") return;
            Color? c = null;
            switch (Convert.ToString(e.Value))
            {
                case "Active": case "Paid": case "Approved": case "Completed": c = Green; break;
                case "Frozen": case "Partially Paid": case "Pending": c = Orange; break;
                case "Expired": case "Unpaid": case "Rejected": case "Inactive": case "Voided": c = Red; break;
            }
            if (c.HasValue)
            {
                e.CellStyle.ForeColor = c.Value;
                e.CellStyle.SelectionForeColor = c.Value;
                e.CellStyle.Font = Bold(9.5f);
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
        public static void Info(string msg, string title = "FITZONE GYM") => MessageDialog.Show(msg, title, false, "info");
        public static void Warn(string msg, string title = "Please check") => MessageDialog.Show(msg, title, false, "warn");
        public static void Error(string msg, string title = "Error") => MessageDialog.Show(msg, title, false, "error");
        public static bool Confirm(string msg, string title = "Please confirm") =>
            MessageDialog.Show(msg, title, true, "question") == DialogResult.Yes;

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

        public static string Prompt(string title, string message, bool required = true) => MessageDialog.Prompt(title, message, required);

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
