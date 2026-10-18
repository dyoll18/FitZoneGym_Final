using System.Drawing.Drawing2D;

namespace FitZoneGym
{
    /// <summary>Dark-themed replacements for MessageBox and the text prompt, so pop-ups match the rest of the app.</summary>
    internal static class MessageDialog
    {
        private static int S(float scale, int v) { return (int)Math.Round(v * scale); }

        private static Form Create(string title)
        {
            return new Form
            {
                Text = title,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                AutoScaleMode = AutoScaleMode.None,   // sizes below are scaled by hand
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Font = Ui.Base,
            };
        }

        private static DialogResult ShowForm(Form f)
        {
            var owner = Form.ActiveForm;
            return owner == null ? f.ShowDialog() : f.ShowDialog(owner);
        }

        private static TableLayoutPanel Root(float s, int columns, int rows)
        {
            var root = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = columns,
                RowCount = rows,
                Padding = new Padding(S(s, 26), S(s, 24), S(s, 26), S(s, 20)),
                BackColor = Color.Transparent,
            };
            for (int i = 0; i < columns; i++) root.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            for (int i = 0; i < rows; i++) root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            return root;
        }

        private static Button MakeButton(float s, string text, string kind, DialogResult result)
        {
            var b = Ui.Button(text, kind, null, 0);
            b.Size = new Size(S(s, 108), S(s, 36));
            b.Margin = new Padding(S(s, 10), 0, 0, 0);
            b.DialogResult = result;
            return b;
        }

        public static DialogResult Show(string message, string title, bool yesNo, string kind)
        {
            using (var f = Create(title))
            {
                float s = f.DeviceDpi / 96f;
                Color tone;
                string glyph;
                switch (kind)
                {
                    case "warn": tone = Ui.Gold; glyph = "!"; break;
                    case "error": tone = Color.FromArgb(220, 53, 69); glyph = "×"; break;
                    case "question": tone = Ui.Accent; glyph = "?"; break;
                    default: tone = Ui.Accent; glyph = "i"; break;
                }

                var root = Root(s, 2, 2);

                var badge = new Label
                {
                    AutoSize = false,
                    Size = new Size(S(s, 44), S(s, 44)),
                    Text = glyph,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    BackColor = tone,
                    Font = Ui.Display(18f),
                    Margin = new Padding(0, 0, S(s, 18), 0),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                };
                using (var gp = new GraphicsPath())
                {
                    gp.AddEllipse(0, 0, badge.Width - 1, badge.Height - 1);
                    badge.Region = new Region(gp);
                }

                var text = new Label
                {
                    AutoSize = true,
                    MaximumSize = new Size(S(s, 440), 0),
                    MinimumSize = new Size(S(s, 260), S(s, 44)),
                    Text = message,
                    TextAlign = ContentAlignment.MiddleLeft,
                    ForeColor = Ui.Text,
                    Anchor = AnchorStyles.Left | AnchorStyles.Top,
                    UseMnemonic = false,
                };

                var row = new FlowLayoutPanel
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    FlowDirection = FlowDirection.RightToLeft,
                    WrapContents = false,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0, S(s, 22), 0, 0),
                    BackColor = Color.Transparent,
                };

                if (yesNo)
                {
                    var yes = MakeButton(s, "Yes", "primary", DialogResult.Yes);
                    var no = MakeButton(s, "No", "secondary", DialogResult.No);
                    row.Controls.Add(yes);
                    row.Controls.Add(no);
                    f.AcceptButton = yes;
                    f.CancelButton = no;
                }
                else
                {
                    var ok = MakeButton(s, "OK", "primary", DialogResult.OK);
                    row.Controls.Add(ok);
                    f.AcceptButton = ok;
                    f.CancelButton = ok;
                }

                root.Controls.Add(badge, 0, 0);
                root.Controls.Add(text, 1, 0);
                root.Controls.Add(row, 0, 1);
                root.SetColumnSpan(row, 2);

                f.Controls.Add(root);
                Theme.Apply(f, true);
                return ShowForm(f);
            }
        }

        public static string Prompt(string title, string message, bool required)
        {
            while (true)
            {
                using (var f = Create(title))
                {
                    float s = f.DeviceDpi / 96f;
                    var root = Root(s, 1, 3);

                    var label = new Label
                    {
                        AutoSize = true,
                        MaximumSize = new Size(S(s, 420), 0),
                        Text = message,
                        ForeColor = Ui.Text,
                        Margin = new Padding(0, 0, 0, S(s, 10)),
                        UseMnemonic = false,
                    };
                    var box = new TextBox
                    {
                        Multiline = true,
                        Size = new Size(S(s, 420), S(s, 72)),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(0),
                    };
                    var row = new FlowLayoutPanel
                    {
                        AutoSize = true,
                        AutoSizeMode = AutoSizeMode.GrowAndShrink,
                        FlowDirection = FlowDirection.RightToLeft,
                        WrapContents = false,
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0, S(s, 18), 0, 0),
                        BackColor = Color.Transparent,
                    };
                    var ok = MakeButton(s, "OK", "primary", DialogResult.OK);
                    var cancel = MakeButton(s, "Cancel", "secondary", DialogResult.Cancel);
                    row.Controls.Add(ok);
                    row.Controls.Add(cancel);
                    f.AcceptButton = ok;
                    f.CancelButton = cancel;

                    root.Controls.Add(label, 0, 0);
                    root.Controls.Add(box, 0, 1);
                    root.Controls.Add(row, 0, 2);
                    f.Controls.Add(root);
                    Theme.Apply(f, true);

                    if (ShowForm(f) != DialogResult.OK) return null;
                    string value = box.Text.Trim();
                    if (!required || value.Length > 0) return value;
                }
                Ui.Warn("This field is required.");
            }
        }
    }
}
