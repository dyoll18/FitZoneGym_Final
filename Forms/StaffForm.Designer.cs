namespace FitZoneGym.Forms
{
    partial class StaffForm
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
            tabs = new TabControl();
            tabAccounts = new TabPage();
            dgvStaff = new DataGridView();
            pnlStaffBottom = new Panel();
            btnEdit = new Button();
            tabPermissions = new TabPage();
            clbPerms = new CheckedListBox();
            pnlPermBottom = new Panel();
            btnSavePerms = new Button();
            pnlPermTop = new Panel();
            lblRole = new Label();
            cboRole = new ComboBox();
            lblPermNote = new Label();
            tabLog = new TabPage();
            dgvLog = new DataGridView();
            btnAdd = new Button();
            contentPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            tabs.SuspendLayout();
            tabAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            pnlStaffBottom.SuspendLayout();
            tabPermissions.SuspendLayout();
            pnlPermBottom.SuspendLayout();
            pnlPermTop.SuspendLayout();
            tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(tabs);
            contentPanel.Size = new Size(1050, 670);
            // 
            // headerPanel
            // 
            headerPanel.Size = new Size(1050, 56);
            headerPanel.Paint += headerPanel_Paint;
            // 
            // titleLabel
            // 
            titleLabel.Size = new Size(794, 48);
            titleLabel.Text = "Users & Staff";
            // 
            // tabs
            // 
            tabs.Controls.Add(tabAccounts);
            tabs.Dock = DockStyle.Fill;
            tabs.Font = new Font("Segoe UI", 9.5F);
            tabs.Location = new Point(16, 16);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1018, 638);
            tabs.TabIndex = 0;
            // 
            // tabAccounts
            // 
            tabAccounts.BackColor = Color.White;
            tabAccounts.Controls.Add(dgvStaff);
            tabAccounts.Controls.Add(pnlStaffBottom);
            tabAccounts.Location = new Point(4, 34);
            tabAccounts.Name = "tabAccounts";
            tabAccounts.Padding = new Padding(10);
            tabAccounts.Size = new Size(1010, 600);
            tabAccounts.TabIndex = 0;
            tabAccounts.Text = "Staff Accounts";
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeight = 34;
            dgvStaff.Dock = DockStyle.Fill;
            dgvStaff.Location = new Point(10, 10);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 62;
            dgvStaff.Size = new Size(990, 532);
            dgvStaff.TabIndex = 0;
            dgvStaff.CellContentClick += dgvStaff_CellContentClick;
            dgvStaff.CellDoubleClick += dgvStaff_CellDoubleClick;
            // 
            // pnlStaffBottom
            // 
            pnlStaffBottom.BackColor = Color.White;
            pnlStaffBottom.Controls.Add(btnEdit);
            pnlStaffBottom.Dock = DockStyle.Bottom;
            pnlStaffBottom.Location = new Point(10, 542);
            pnlStaffBottom.Name = "pnlStaffBottom";
            pnlStaffBottom.Size = new Size(990, 48);
            pnlStaffBottom.TabIndex = 1;
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
            btnEdit.Size = new Size(180, 34);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit / Reset Password";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // tabPermissions
            // 
            tabPermissions.BackColor = Color.White;
            tabPermissions.Controls.Add(clbPerms);
            tabPermissions.Controls.Add(pnlPermBottom);
            tabPermissions.Controls.Add(pnlPermTop);
            tabPermissions.Location = new Point(0, 0);
            tabPermissions.Name = "tabPermissions";
            tabPermissions.Padding = new Padding(10);
            tabPermissions.Size = new Size(200, 100);
            tabPermissions.TabIndex = 1;
            tabPermissions.Text = "Roles & Permissions";
            // 
            // clbPerms
            // 
            clbPerms.BorderStyle = BorderStyle.None;
            clbPerms.CheckOnClick = true;
            clbPerms.Dock = DockStyle.Fill;
            clbPerms.Font = new Font("Segoe UI", 9.5F);
            clbPerms.FormattingEnabled = true;
            clbPerms.Location = new Point(10, 66);
            clbPerms.Name = "clbPerms";
            clbPerms.Size = new Size(180, -24);
            clbPerms.TabIndex = 0;
            // 
            // pnlPermBottom
            // 
            pnlPermBottom.BackColor = Color.White;
            pnlPermBottom.Controls.Add(btnSavePerms);
            pnlPermBottom.Dock = DockStyle.Bottom;
            pnlPermBottom.Location = new Point(10, 42);
            pnlPermBottom.Name = "pnlPermBottom";
            pnlPermBottom.Size = new Size(180, 48);
            pnlPermBottom.TabIndex = 1;
            // 
            // btnSavePerms
            // 
            btnSavePerms.BackColor = Color.FromArgb(30, 111, 240);
            btnSavePerms.Cursor = Cursors.Hand;
            btnSavePerms.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnSavePerms.FlatStyle = FlatStyle.Flat;
            btnSavePerms.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSavePerms.ForeColor = Color.White;
            btnSavePerms.Location = new Point(0, 8);
            btnSavePerms.Margin = new Padding(0, 0, 8, 0);
            btnSavePerms.Name = "btnSavePerms";
            btnSavePerms.Size = new Size(160, 34);
            btnSavePerms.TabIndex = 0;
            btnSavePerms.Text = "Save Permissions";
            btnSavePerms.UseVisualStyleBackColor = false;
            // 
            // pnlPermTop
            // 
            pnlPermTop.BackColor = Color.White;
            pnlPermTop.Controls.Add(lblRole);
            pnlPermTop.Controls.Add(cboRole);
            pnlPermTop.Controls.Add(lblPermNote);
            pnlPermTop.Dock = DockStyle.Top;
            pnlPermTop.Location = new Point(10, 10);
            pnlPermTop.Name = "pnlPermTop";
            pnlPermTop.Size = new Size(180, 56);
            pnlPermTop.TabIndex = 2;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 8.5F);
            lblRole.ForeColor = Color.FromArgb(107, 114, 128);
            lblRole.Location = new Point(0, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(43, 23);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FlatStyle = FlatStyle.Flat;
            cboRole.Font = new Font("Segoe UI", 9.5F);
            cboRole.Items.AddRange(new object[] { "Staff", "Cashier" });
            cboRole.Location = new Point(0, 20);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(180, 33);
            cboRole.TabIndex = 1;
            // 
            // lblPermNote
            // 
            lblPermNote.AutoSize = true;
            lblPermNote.Font = new Font("Segoe UI", 9F);
            lblPermNote.ForeColor = Color.FromArgb(107, 114, 128);
            lblPermNote.Location = new Point(200, 26);
            lblPermNote.Name = "lblPermNote";
            lblPermNote.Size = new Size(914, 25);
            lblPermNote.TabIndex = 2;
            lblPermNote.Text = "Administrators always have every permission. Managing staff, settings, backup and restore are administrator-only.";
            // 
            // tabLog
            // 
            tabLog.BackColor = Color.White;
            tabLog.Controls.Add(dgvLog);
            tabLog.Location = new Point(0, 0);
            tabLog.Name = "tabLog";
            tabLog.Padding = new Padding(10);
            tabLog.Size = new Size(200, 100);
            tabLog.TabIndex = 2;
            tabLog.Text = "Activity Logs";
            // 
            // dgvLog
            // 
            dgvLog.ColumnHeadersHeight = 34;
            dgvLog.Dock = DockStyle.Fill;
            dgvLog.Location = new Point(10, 10);
            dgvLog.Name = "dgvLog";
            dgvLog.RowHeadersWidth = 62;
            dgvLog.Size = new Size(180, 80);
            dgvLog.TabIndex = 0;
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
            btnAdd.Size = new Size(120, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+ Add Staff";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            ClientSize = new Size(1280, 760);
            Name = "StaffForm";
            PageTitle = "Users & Staff";
            Text = "GYMORA - Users & Staff";
            contentPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            tabs.ResumeLayout(false);
            tabAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            pnlStaffBottom.ResumeLayout(false);
            tabPermissions.ResumeLayout(false);
            pnlPermBottom.ResumeLayout(false);
            pnlPermTop.ResumeLayout(false);
            pnlPermTop.PerformLayout();
            tabLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabAccounts;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel pnlStaffBottom;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabPage tabPermissions;
        private System.Windows.Forms.CheckedListBox clbPerms;
        private System.Windows.Forms.Panel pnlPermBottom;
        private System.Windows.Forms.Button btnSavePerms;
        private System.Windows.Forms.Panel pnlPermTop;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblPermNote;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Button btnAdd;
    }
}
