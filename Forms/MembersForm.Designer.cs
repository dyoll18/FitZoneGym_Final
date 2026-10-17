namespace FitZoneGym.Forms
{
    partial class MembersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>Designer generated: do not modify the contents of this method with the code editor.</summary>
        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            toolbarPanel = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFilter = new Label();
            cboFilter = new ComboBox();
            btnSearch = new Button();
            dgvMembers = new DataGridView();
            footerPanel = new Panel();
            btnEdit = new Button();
            btnToggle = new Button();
            lblCount = new Label();
            btnAdd = new Button();
            contentPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(mainLayout);
            contentPanel.Size = new Size(1050, 670);
            // 
            // titleLabel
            // 
            titleLabel.Size = new Size(876, 48);
            titleLabel.Text = "Members";
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(243, 246, 251);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(toolbarPanel, 0, 0);
            mainLayout.Controls.Add(dgvMembers, 0, 1);
            mainLayout.Controls.Add(footerPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(16, 16);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.Size = new Size(1018, 638);
            mainLayout.TabIndex = 0;
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.FromArgb(243, 246, 251);
            toolbarPanel.Controls.Add(lblSearch);
            toolbarPanel.Controls.Add(txtSearch);
            toolbarPanel.Controls.Add(lblFilter);
            toolbarPanel.Controls.Add(cboFilter);
            toolbarPanel.Controls.Add(btnSearch);
            toolbarPanel.Dock = DockStyle.Fill;
            toolbarPanel.Location = new Point(3, 3);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(1012, 48);
            toolbarPanel.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 8.5F);
            lblSearch.ForeColor = Color.FromArgb(107, 114, 128);
            lblSearch.Location = new Point(0, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(0, 20);
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
            lblFilter.ForeColor = Color.FromArgb(107, 114, 128);
            lblFilter.Location = new Point(340, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(155, 23);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Membership status";
            // 
            // cboFilter
            // 
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.FlatStyle = FlatStyle.Flat;
            cboFilter.Font = new Font("Segoe UI", 9.5F);
            cboFilter.Items.AddRange(new object[] { "All", "Active", "Frozen", "Expired", "Pending", "No Membership", "Inactive Accounts" });
            cboFilter.Location = new Point(340, 20);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(170, 33);
            cboFilter.TabIndex = 3;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(30, 111, 240);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(520, 19);
            btnSearch.Margin = new Padding(0, 0, 8, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 27);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeight = 34;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.Location = new Point(3, 57);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 62;
            dgvMembers.Size = new Size(1012, 528);
            dgvMembers.TabIndex = 1;
            dgvMembers.CellDoubleClick += dgvMembers_CellDoubleClick;
            dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(243, 246, 251);
            footerPanel.Controls.Add(btnEdit);
            footerPanel.Controls.Add(btnToggle);
            footerPanel.Controls.Add(lblCount);
            footerPanel.Dock = DockStyle.Fill;
            footerPanel.Location = new Point(3, 591);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(1012, 44);
            footerPanel.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(30, 111, 240);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
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
            btnToggle.BackColor = Color.White;
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.FlatAppearance.BorderColor = Color.FromArgb(214, 221, 232);
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnToggle.ForeColor = Color.FromArgb(31, 41, 55);
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
            lblCount.ForeColor = Color.FromArgb(107, 114, 128);
            lblCount.Location = new Point(270, 16);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 25);
            lblCount.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(30, 111, 240);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 4);
            btnAdd.Margin = new Padding(0, 0, 8, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 34);
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
            Text = "FITZONE GYM - Members";
            contentPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnAdd;
    }
}
