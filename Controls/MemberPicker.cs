using System.Data;
using FitZoneGym.Data;
using FitZoneGym.Services;

namespace FitZoneGym.Controls
{
    /// <summary>Search box + results drop-down that lets the user pick one member by name, ID or contact number.</summary>
    public class MemberPicker : FlowLayoutPanel
    {
        private readonly TextBox _text = Ui.Input(220);
        private readonly ComboBox _results = Ui.Combo(380);
        private DataTable _table = new DataTable();

        public event EventHandler MemberChanged;

        public MemberPicker()
        {
            AutoSize = true; WrapContents = false; FlowDirection = FlowDirection.LeftToRight; BackColor = Color.Transparent;
            _text.PlaceholderText = "Name, member ID or contact";
            _text.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; Search(); } };
            _results.SelectedIndexChanged += (s, e) => MemberChanged?.Invoke(this, EventArgs.Empty);
            Controls.Add(_text);
            Controls.Add(Ui.Primary("Search", (s, e) => Search(), 90));
            Controls.Add(_results);
        }

        public string SelectedMemberId => _results.SelectedIndex < 0 || _results.SelectedIndex >= _table.Rows.Count
            ? null : Db.S(_table.Rows[_results.SelectedIndex]["MemberID"]);

        public DataRow SelectedRow => SelectedMemberId == null ? null : _table.Rows[_results.SelectedIndex];

        public void Search()
        {
            Ui.Run(() =>
            {
                _table = MemberService.Lookup(_text.Text);
                _results.Items.Clear();
                foreach (DataRow r in _table.Rows)
                    _results.Items.Add(Db.S(r["MemberID"]) + " - " + Db.S(r["FullName"]) + "  [" + Db.S(r["MembershipStatus"]) + "]");
                if (_table.Rows.Count == 0) { Ui.Info("No members match your search."); MemberChanged?.Invoke(this, EventArgs.Empty); }
                else _results.SelectedIndex = 0;
            });
        }

        /// <summary>Selects a member programmatically (used after a transaction to refresh the details).</summary>
        public void Reload(string memberId)
        {
            _text.Text = memberId;
            _table = MemberService.Lookup(memberId);
            _results.Items.Clear();
            foreach (DataRow r in _table.Rows)
                _results.Items.Add(Db.S(r["MemberID"]) + " - " + Db.S(r["FullName"]) + "  [" + Db.S(r["MembershipStatus"]) + "]");
            if (_table.Rows.Count > 0) _results.SelectedIndex = 0;
        }
    }
}
