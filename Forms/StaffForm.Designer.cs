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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.pnlStaffBottom = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabPermissions = new System.Windows.Forms.TabPage();
            this.clbPerms = new System.Windows.Forms.CheckedListBox();
            this.pnlPermBottom = new System.Windows.Forms.Panel();
            this.btnSavePerms = new System.Windows.Forms.Button();
            this.pnlPermTop = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblPermNote = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.pnlStaffBottom.SuspendLayout();
            this.tabPermissions.SuspendLayout();
            this.pnlPermBottom.SuspendLayout();
            this.pnlPermTop.SuspendLayout();
            this.tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Name = "tabs";
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabs.TabPages.Add(this.tabAccounts);
            this.tabs.TabIndex = 0;
            // 
            // tabAccounts
            // 
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Text = "Staff Accounts";
            this.tabAccounts.BackColor = System.Drawing.Color.White;
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tabAccounts.UseVisualStyleBackColor = false;
            this.tabAccounts.Controls.Add(this.dgvStaff);
            this.tabAccounts.Controls.Add(this.pnlStaffBottom);
            this.tabAccounts.TabIndex = 0;
            // 
            // dgvStaff
            // 
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellDoubleClick);
            // 
            // pnlStaffBottom
            // 
            this.pnlStaffBottom.Name = "pnlStaffBottom";
            this.pnlStaffBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStaffBottom.Height = 48;
            this.pnlStaffBottom.BackColor = System.Drawing.Color.White;
            this.pnlStaffBottom.Controls.Add(this.btnEdit);
            this.pnlStaffBottom.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit / Reset Password";
            this.btnEdit.Size = new System.Drawing.Size(180, 34);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnEdit.Location = new System.Drawing.Point(0, 8);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabPermissions
            // 
            this.tabPermissions.Name = "tabPermissions";
            this.tabPermissions.Text = "Roles & Permissions";
            this.tabPermissions.BackColor = System.Drawing.Color.White;
            this.tabPermissions.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tabPermissions.UseVisualStyleBackColor = false;
            this.tabPermissions.Controls.Add(this.clbPerms);
            this.tabPermissions.Controls.Add(this.pnlPermBottom);
            this.tabPermissions.Controls.Add(this.pnlPermTop);
            this.tabPermissions.TabIndex = 1;
            // 
            // clbPerms
            // 
            this.clbPerms.Name = "clbPerms";
            this.clbPerms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbPerms.CheckOnClick = true;
            this.clbPerms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPerms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.clbPerms.FormattingEnabled = true;
            this.clbPerms.TabIndex = 0;
            // 
            // pnlPermBottom
            // 
            this.pnlPermBottom.Name = "pnlPermBottom";
            this.pnlPermBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPermBottom.Height = 48;
            this.pnlPermBottom.BackColor = System.Drawing.Color.White;
            this.pnlPermBottom.Controls.Add(this.btnSavePerms);
            this.pnlPermBottom.TabIndex = 1;
            // 
            // btnSavePerms
            // 
            this.btnSavePerms.Name = "btnSavePerms";
            this.btnSavePerms.Text = "Save Permissions";
            this.btnSavePerms.Size = new System.Drawing.Size(160, 34);
            this.btnSavePerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePerms.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnSavePerms.ForeColor = System.Drawing.Color.White;
            this.btnSavePerms.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSavePerms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePerms.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSavePerms.UseVisualStyleBackColor = false;
            this.btnSavePerms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnSavePerms.Location = new System.Drawing.Point(0, 8);
            this.btnSavePerms.TabIndex = 0;
            
            // 
            // pnlPermTop
            // 
            this.pnlPermTop.Name = "pnlPermTop";
            this.pnlPermTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPermTop.Height = 56;
            this.pnlPermTop.BackColor = System.Drawing.Color.White;
            this.pnlPermTop.Controls.Add(this.lblRole);
            this.pnlPermTop.Controls.Add(this.cboRole);
            this.pnlPermTop.Controls.Add(this.lblPermNote);
            this.pnlPermTop.TabIndex = 2;
            // 
            // lblRole
            // 
            this.lblRole.Name = "lblRole";
            this.lblRole.AutoSize = true;
            this.lblRole.Text = "Role";
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRole.Location = new System.Drawing.Point(0, 0);
            this.lblRole.TabIndex = 0;
            // 
            // cboRole
            // 
            this.cboRole.Name = "cboRole";
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboRole.Size = new System.Drawing.Size(180, 25);
            this.cboRole.Location = new System.Drawing.Point(0, 20);
            this.cboRole.Items.AddRange(new object[] { "Staff", "Cashier" });
            this.cboRole.TabIndex = 1;
            
            // lblPermNote
            // 
            this.lblPermNote.Name = "lblPermNote";
            this.lblPermNote.AutoSize = true;
            this.lblPermNote.Text = "Administrators always have every permission. Managing staff, settings, backup and restore are administrator-only.";
            this.lblPermNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblPermNote.Font = new System.Drawing.Font("Segoe UI", 9.0F);
            this.lblPermNote.Location = new System.Drawing.Point(200, 26);
            this.lblPermNote.TabIndex = 2;
            // 
            // tabLog
            // 
            this.tabLog.Name = "tabLog";
            this.tabLog.Text = "Activity Logs";
            this.tabLog.BackColor = System.Drawing.Color.White;
            this.tabLog.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tabLog.UseVisualStyleBackColor = false;
            this.tabLog.Controls.Add(this.dgvLog);
            this.tabLog.TabIndex = 2;
            // 
            // dgvLog
            // 
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+ Add Staff";
            this.btnAdd.Size = new System.Drawing.Size(120, 34);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // StaffForm
            // 
            this.PageTitle = "Users & Staff";
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.contentPanel.Controls.Add(this.tabs);
            this.actionsFlow.Controls.Add(this.btnAdd);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.tabLog.ResumeLayout(false);
            this.pnlPermTop.ResumeLayout(false);
            this.pnlPermTop.PerformLayout();
            this.pnlPermBottom.ResumeLayout(false);
            this.pnlPermBottom.PerformLayout();
            this.tabPermissions.ResumeLayout(false);
            this.pnlStaffBottom.ResumeLayout(false);
            this.pnlStaffBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.tabAccounts.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
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
