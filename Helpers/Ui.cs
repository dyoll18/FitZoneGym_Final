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
        // ---- FitFlow dark theme palette ------------------------------------------------------
        public static readonly Color Navy = Color.FromArgb(31, 32, 42);        // sidebar / table header
        public static readonly Color NavyLight = Color.FromArgb(46, 47, 60);   // hover
        public static readonly Color Blue = Color.FromArgb(255, 106, 0);       // primary accent (FitFlow orange)
        public static readonly Color Accent = Blue;
        public static readonly Color AccentHover = Color.FromArgb(255, 136, 56);
        public static readonly Color Bg = Color.FromArgb(24, 25, 33);          // page background
        public static readonly Color Surface = Color.FromArgb(35, 36, 47);     // cards
        public static readonly Color InputBg = Color.FromArgb(46, 47, 60);       // text boxes / secondary buttons
        public static readonly Color Text = Color.FromArgb(244, 244, 248);
        public static readonly Color Muted = Color.FromArgb(152, 155, 172);
        public static readonly Color Green = Color.FromArgb(34, 197, 94);
        public static readonly Color Orange = Color.FromArgb(250, 176, 5);     // amber (used for "Frozen"/"Pending")
        public static readonly Color Red = Color.FromArgb(239, 68, 68);
        public static readonly Color Border = Color.FromArgb(58, 60, 76);

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
                ForeColor = back == InputBg ? Text : Color.White,
                Font = Bold(9.5f),
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 0, 8, 0),
                UseVisualStyleBackColor = false,
            };
            b.FlatAppearance.BorderColor = back == InputBg ? Border : back;
            b.FlatAppearance.MouseOverBackColor = back == Blue ? AccentHover : back == InputBg ? NavyLight : back;
            if (onClick != null) b.Click += onClick;
            return b;
        }

        public static Button Primary(string text, EventHandler click, int width = 120) => Button(text, Blue, click, width);
        public static Button Secondary(string text, EventHandler click, int width = 120) => Button(text, InputBg, click, width);
        public static Button Success(string text, EventHandler click, int width = 120) => Button(text, Green, click, width);
        public static Button Danger(string text, EventHandler click, int width = 120) => Button(text, Red, click, width);

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
                Value = value ?? DateTime.Today, CalendarMonthBackground = InputBg, CalendarForeColor = Text, CalendarTitleBackColor = Accent, CalendarTitleForeColor = Color.White, CalendarTrailingForeColor = Muted, Margin = new Padding(0, 3, 8, 3),
            };
        }

        public static NumericUpDown Number(decimal min, decimal max, decimal value, int decimals = 0, int width = 120)
        {
            return new NumericUpDown { Minimum = min, Maximum = max, Value = value, DecimalPlaces = decimals, Width = width, Font = Base, ThousandsSeparator = true, BackColor = InputBg, ForeColor = Text, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(0, 3, 8, 3) };
        }

        public static Panel Card(int padding = 14)
        {
            return new Panel { BackColor = Surface, Padding = new Padding(padding), Dock = DockStyle.Fill, Margin = new Padding(0, 0, 10, 10) };
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
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 38;
            g.RowTemplate.Height = 34;
            ThemeGrid(g);
            g.CellFormatting -= StatusColors;
            g.CellFormatting += StatusColors;
        }

        /// <summary>Colours only (no behaviour) - safe to call again on any DataGridView.</summary>
        public static void ThemeGrid(DataGridView g)
        {
            g.BackgroundColor = Surface;
            g.BorderStyle = BorderStyle.None;
            g.GridColor = Color.FromArgb(48, 50, 64);
            g.Font = Base;
            g.ForeColor = Text;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersDefaultCellStyle.BackColor = Surface;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Muted;
            g.ColumnHeadersDefaultCellStyle.Font = Bold(9f);
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Surface;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Muted;
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            g.DefaultCellStyle.BackColor = Surface;
            g.DefaultCellStyle.ForeColor = Text;
            g.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 255, 106, 0).Blend(Surface);
            g.DefaultCellStyle.SelectionForeColor = Color.White;
            g.AlternatingRowsDefaultCellStyle.BackColor = Surface;
            g.AlternatingRowsDefaultCellStyle.SelectionBackColor = g.DefaultCellStyle.SelectionBackColor;
            g.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
        }

        /// <summary>Composites a semi-transparent colour over a solid background.</summary>
        public static Color Blend(this Color top, Color under)
        {
            float a = top.A / 255f;
            return Color.FromArgb((int)(top.R * a + under.R * (1 - a)), (int)(top.G * a + under.G * (1 - a)), (int)(top.B * a + under.B * (1 - a)));
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
                MaximizeBox = false, MinimizeBox = false, ClientSize = new Size(420, 170), Font = Base, BackColor = Bg, ForeColor = Text,
            };
            var lbl = new Label { Text = message, Left = 16, Top = 14, Width = 388, Height = 36, ForeColor = Text };
            var txt = new TextBox { Left = 16, Top = 54, Width = 388, Multiline = true, Height = 56, BorderStyle = BorderStyle.FixedSingle, BackColor = InputBg, ForeColor = Text };
            var ok = Primary("OK", null, 90); ok.Left = 224; ok.Top = 122; ok.DialogResult = DialogResult.OK;
            var cancel = Secondary("Cancel", null, 90); cancel.Left = 320; cancel.Top = 122; cancel.DialogResult = DialogResult.Cancel;
            f.Controls.AddRange(new Control[] { lbl, txt, ok, cancel });
            f.AcceptButton = ok; f.CancelButton = cancel;
            Theme.Apply(f);
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
