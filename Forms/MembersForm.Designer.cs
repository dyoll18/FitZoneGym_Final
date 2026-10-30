
namespace FitZoneGym.Forms
{
    partial class MembersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            mainLayout = new TableLayoutPanel();
            toolbarPanel = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFilter = new Label();
            cboFilter = new ComboBox();
            btnSearch = new FitZoneGym.Controls.ThemedButton();
            dgvMembers = new FitZoneGym.Controls.ThemedGrid();
            footerPanel = new Panel();
            btnEdit = new FitZoneGym.Controls.ThemedButton();
            btnToggle = new FitZoneGym.Controls.ThemedButton();
            lblCount = new Label();
            btnAdd = new FitZoneGym.Controls.ThemedButton();
            contentPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(mainLayout);
            contentPanel.Size = new Size(1030, 636);
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(btnAdd);
            headerPanel.Size = new Size(1030, 56);
            headerPanel.Controls.SetChildIndex(titleLabel, 0);
            headerPanel.Controls.SetChildIndex(btnAdd, 0);
            // 
            // titleLabel
            // 
            titleLabel.Size = new Size(994, 48);
            titleLabel.Text = "Members";
            titleLabel.Click += titleLabel_Click;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(24, 25, 33);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(toolbarPanel, 0, 0);
            mainLayout.Controls.Add(dgvMembers, 0, 1);
            mainLayout.Controls.Add(footerPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(16, 16);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.Size = new Size(998, 604);
            mainLayout.TabIndex = 0;
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.FromArgb(24, 25, 33);
            toolbarPanel.Controls.Add(lblSearch);
            toolbarPanel.Controls.Add(txtSearch);
            toolbarPanel.Controls.Add(lblFilter);
            toolbarPanel.Controls.Add(cboFilter);
            toolbarPanel.Controls.Add(btnSearch);
            toolbarPanel.Location = new Point(3, 3);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(992, 61);
            toolbarPanel.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 8.5F);
            lblSearch.ForeColor = Color.FromArgb(152, 155, 172);
            lblSearch.Location = new Point(3, -3);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(46, 47, 60);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.ForeColor = Color.FromArgb(244, 244, 248);
            txtSearch.Location = new Point(0, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name, member ID, or contact number";
            txtSearch.Size = new Size(320, 33);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 8.5F);
            lblFilter.ForeColor = Color.FromArgb(152, 155, 172);
            lblFilter.Location = new Point(340, -3);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(155, 23);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Membership status";
            // 
            // cboFilter
            // 
            cboFilter.BackColor = Color.FromArgb(46, 47, 60);
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.FlatStyle = FlatStyle.Flat;
            cboFilter.Font = new Font("Segoe UI", 9.5F);
            cboFilter.ForeColor = Color.FromArgb(244, 244, 248);
            cboFilter.Items.AddRange(new object[] { "All", "Active", "Frozen", "Expired", "Pending", "No Membership", "Inactive Accounts" });
            cboFilter.Location = new Point(340, 28);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(170, 33);
            cboFilter.TabIndex = 3;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 106, 0);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(255, 106, 0);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 106, 0);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 136, 56);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnSearch.Location = new Point(547, 22);
            btnSearch.Margin = new Padding(0, 0, 8, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(119, 39);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.FromArgb(35, 36, 47);
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMembers.ColumnHeadersHeight = 38;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(244, 244, 248);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMembers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.Font = new Font("Segoe UI", 9.5F);
            dgvMembers.GridColor = Color.FromArgb(48, 50, 64);
            dgvMembers.Location = new Point(3, 79);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 62;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(992, 472);
            dgvMembers.TabIndex = 1;
            dgvMembers.CellContentClick += dgvMembers_CellContentClick;
            dgvMembers.CellDoubleClick += dgvMembers_CellDoubleClick;
            dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(24, 25, 33);
            footerPanel.Controls.Add(btnEdit);
            footerPanel.Controls.Add(btnToggle);
            footerPanel.Controls.Add(lblCount);
            footerPanel.Dock = DockStyle.Fill;
            footerPanel.Location = new Point(3, 557);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(992, 44);
            footerPanel.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 106, 0);
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(255, 106, 0);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 106, 0);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 136, 56);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnEdit.Location = new Point(0, 8);
            btnEdit.Margin = new Padding(0, 0, 8, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 34);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "View / Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.FromArgb(46, 47, 60);
            btnToggle.FlatAppearance.BorderColor = Color.FromArgb(58, 60, 76);
            btnToggle.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 47, 60);
            btnToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 47, 60);
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnToggle.ForeColor = Color.FromArgb(244, 244, 248);
            btnToggle.Location = new Point(130, 8);
            btnToggle.Margin = new Padding(0, 0, 8, 0);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(120, 34);
            btnToggle.TabIndex = 1;
            btnToggle.Text = "Deactivate";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9.5F);
            lblCount.ForeColor = Color.FromArgb(152, 155, 172);
            lblCount.Location = new Point(270, 16);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 25);
            lblCount.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 106, 0);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(255, 106, 0);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 106, 0);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 136, 56);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnAdd.Location = new Point(789, 9);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(205, 39);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+ Add Member";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            ClientSize = new Size(1280, 760);
            Name = "MembersForm";
            PageTitle = "Members";
            Text = "GYMORA - Members";
            contentPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainLayout.ResumeLayout(false);
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            footerPanel.ResumeLayout(false);
            footerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboFilter;
        private FitZoneGym.Controls.ThemedButton btnSearch;
        private FitZoneGym.Controls.ThemedGrid dgvMembers;
        private System.Windows.Forms.Panel footerPanel;
        private FitZoneGym.Controls.ThemedButton btnEdit;
        private FitZoneGym.Controls.ThemedButton btnToggle;
        private System.Windows.Forms.Label lblCount;
        private FitZoneGym.Controls.ThemedButton btnAdd;
    }
}
