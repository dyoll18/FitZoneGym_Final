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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabs = new FitZoneGym.Controls.ThemedTabControl();
            tabAccounts = new TabPage();
            dgvStaff = new FitZoneGym.Controls.ThemedGrid();
            pnlStaffBottom = new Panel();
            btnEdit = new FitZoneGym.Controls.ThemedButton();
            tabPermissions = new TabPage();
            clbPerms = new CheckedListBox();
            pnlPermBottom = new Panel();
            btnSavePerms = new FitZoneGym.Controls.ThemedButton();
            pnlPermTop = new Panel();
            lblRole = new Label();
            cboRole = new ComboBox();
            lblPermNote = new Label();
            tabLog = new TabPage();
            dgvLog = new FitZoneGym.Controls.ThemedGrid();
            btnAdd = new FitZoneGym.Controls.ThemedButton();
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
            contentPanel.ForeColor = Color.White;
            contentPanel.Size = new Size(1030, 636);
            // 
            // headerPanel
            // 
            headerPanel.Size = new Size(1030, 56);
            headerPanel.Paint += headerPanel_Paint;
            // 
            // titleLabel
            // 
            titleLabel.Size = new Size(844, 48);
            titleLabel.Text = "Users & Staff";
            // 
            // tabs
            // 
            tabs.Controls.Add(tabAccounts);
            tabs.Dock = DockStyle.Fill;
            tabs.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabs.Font = new Font("Segoe UI", 9.5F);
            tabs.ItemSize = new Size(170, 38);
            tabs.Location = new Point(16, 16);
            tabs.Name = "tabs";
            tabs.Padding = new Point(14, 6);
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(998, 604);
            tabs.SizeMode = TabSizeMode.Fixed;
            tabs.TabIndex = 0;
            // 
            // tabAccounts
            // 
            tabAccounts.BackColor = Color.FromArgb(24, 25, 33);
            tabAccounts.BackgroundImageLayout = ImageLayout.None;
            tabAccounts.Controls.Add(dgvStaff);
            tabAccounts.Controls.Add(pnlStaffBottom);
            tabAccounts.ForeColor = Color.FromArgb(244, 244, 248);
            tabAccounts.Location = new Point(4, 42);
            tabAccounts.Name = "tabAccounts";
            tabAccounts.Padding = new Padding(10);
            tabAccounts.Size = new Size(990, 558);
            tabAccounts.TabIndex = 0;
            tabAccounts.Text = "Staff Accounts";
            tabAccounts.Click += tabAccounts_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AllowUserToDeleteRows = false;
            dgvStaff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.BackgroundColor = Color.FromArgb(35, 36, 47);
            dgvStaff.BorderStyle = BorderStyle.None;
            dgvStaff.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStaff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvStaff.ColumnHeadersHeight = 38;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(244, 244, 248);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
            dgvStaff.Dock = DockStyle.Fill;
            dgvStaff.EnableHeadersVisualStyles = false;
            dgvStaff.Font = new Font("Segoe UI", 9.5F);
            dgvStaff.GridColor = Color.FromArgb(48, 50, 64);
            dgvStaff.Location = new Point(10, 10);
            dgvStaff.MultiSelect = false;
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersVisible = false;
            dgvStaff.RowHeadersWidth = 62;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(970, 490);
            dgvStaff.TabIndex = 0;
            dgvStaff.CellContentClick += dgvStaff_CellContentClick;
            dgvStaff.CellDoubleClick += dgvStaff_CellDoubleClick;
            // 
            // pnlStaffBottom
            // 
            pnlStaffBottom.BackColor = Color.FromArgb(35, 36, 47);
            pnlStaffBottom.Controls.Add(btnEdit);
            pnlStaffBottom.Dock = DockStyle.Bottom;
            pnlStaffBottom.Location = new Point(10, 500);
            pnlStaffBottom.Name = "pnlStaffBottom";
            pnlStaffBottom.Size = new Size(970, 48);
            pnlStaffBottom.TabIndex = 1;
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
            btnEdit.Size = new Size(180, 34);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit / Reset Password";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // tabPermissions
            // 
            tabPermissions.BackColor = Color.FromArgb(24, 25, 33);
            tabPermissions.Controls.Add(clbPerms);
            tabPermissions.Controls.Add(pnlPermBottom);
            tabPermissions.Controls.Add(pnlPermTop);
            tabPermissions.ForeColor = Color.FromArgb(244, 244, 248);
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
            pnlPermBottom.BackColor = Color.FromArgb(35, 36, 47);
            pnlPermBottom.Controls.Add(btnSavePerms);
            pnlPermBottom.Dock = DockStyle.Bottom;
            pnlPermBottom.Location = new Point(10, 42);
            pnlPermBottom.Name = "pnlPermBottom";
            pnlPermBottom.Size = new Size(180, 48);
            pnlPermBottom.TabIndex = 1;
            // 
            // btnSavePerms
            // 
            btnSavePerms.BackColor = Color.FromArgb(255, 106, 0);
            btnSavePerms.FlatAppearance.BorderColor = Color.FromArgb(255, 106, 0);
            btnSavePerms.FlatAppearance.BorderSize = 0;
            btnSavePerms.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 106, 0);
            btnSavePerms.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 136, 56);
            btnSavePerms.FlatStyle = FlatStyle.Flat;
            btnSavePerms.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSavePerms.ForeColor = Color.White;
            btnSavePerms.Kind = FitZoneGym.Controls.ButtonKind.Primary;
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
            pnlPermTop.BackColor = Color.FromArgb(35, 36, 47);
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
            lblRole.ForeColor = Color.FromArgb(152, 155, 172);
            lblRole.Location = new Point(0, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(43, 23);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // cboRole
            // 
            cboRole.BackColor = Color.FromArgb(46, 47, 60);
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FlatStyle = FlatStyle.Flat;
            cboRole.Font = new Font("Segoe UI", 9.5F);
            cboRole.ForeColor = Color.FromArgb(244, 244, 248);
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
            lblPermNote.ForeColor = Color.FromArgb(152, 155, 172);
            lblPermNote.Location = new Point(200, 26);
            lblPermNote.Name = "lblPermNote";
            lblPermNote.Size = new Size(914, 25);
            lblPermNote.TabIndex = 2;
            lblPermNote.Text = "Administrators always have every permission. Managing staff, settings, backup and restore are administrator-only.";
            // 
            // tabLog
            // 
            tabLog.BackColor = Color.FromArgb(24, 25, 33);
            tabLog.Controls.Add(dgvLog);
            tabLog.ForeColor = Color.FromArgb(244, 244, 248);
            tabLog.Location = new Point(0, 0);
            tabLog.Name = "tabLog";
            tabLog.Padding = new Padding(10);
            tabLog.Size = new Size(200, 100);
            tabLog.TabIndex = 2;
            tabLog.Text = "Activity Logs";
            // 
            // dgvLog
            // 
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AllowUserToDeleteRows = false;
            dgvLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLog.BackgroundColor = Color.FromArgb(35, 36, 47);
            dgvLog.BorderStyle = BorderStyle.None;
            dgvLog.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvLog.ColumnHeadersHeight = 38;
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(244, 244, 248);
            dataGridViewCellStyle6.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvLog.DefaultCellStyle = dataGridViewCellStyle6;
            dgvLog.Dock = DockStyle.Fill;
            dgvLog.EnableHeadersVisualStyles = false;
            dgvLog.Font = new Font("Segoe UI", 9.5F);
            dgvLog.GridColor = Color.FromArgb(48, 50, 64);
            dgvLog.Location = new Point(10, 10);
            dgvLog.MultiSelect = false;
            dgvLog.Name = "dgvLog";
            dgvLog.ReadOnly = true;
            dgvLog.RowHeadersVisible = false;
            dgvLog.RowHeadersWidth = 62;
            dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLog.Size = new Size(180, 80);
            dgvLog.TabIndex = 0;
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
            btnAdd.Location = new Point(0, 6);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 36);
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

        private FitZoneGym.Controls.ThemedTabControl tabs;
        private System.Windows.Forms.TabPage tabAccounts;
        private FitZoneGym.Controls.ThemedGrid dgvStaff;
        private System.Windows.Forms.Panel pnlStaffBottom;
        private FitZoneGym.Controls.ThemedButton btnEdit;
        private System.Windows.Forms.TabPage tabPermissions;
        private System.Windows.Forms.CheckedListBox clbPerms;
        private System.Windows.Forms.Panel pnlPermBottom;
        private FitZoneGym.Controls.ThemedButton btnSavePerms;
        private System.Windows.Forms.Panel pnlPermTop;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblPermNote;
        private System.Windows.Forms.TabPage tabLog;
        private FitZoneGym.Controls.ThemedGrid dgvLog;
        private FitZoneGym.Controls.ThemedButton btnAdd;
    }
}
