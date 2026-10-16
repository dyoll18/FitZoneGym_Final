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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.RowCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.Controls.Add(this.toolbarPanel, 0, 0);
            this.mainLayout.Controls.Add(this.dgvMembers, 0, 1);
            this.mainLayout.Controls.Add(this.footerPanel, 0, 2);
            this.mainLayout.TabIndex = 0;
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.toolbarPanel.Controls.Add(this.lblSearch);
            this.toolbarPanel.Controls.Add(this.txtSearch);
            this.toolbarPanel.Controls.Add(this.lblFilter);
            this.toolbarPanel.Controls.Add(this.cboFilter);
            this.toolbarPanel.Controls.Add(this.btnSearch);
            this.toolbarPanel.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.AutoSize = true;
            this.lblSearch.Text = "Search";
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Size = new System.Drawing.Size(320, 25);
            this.txtSearch.PlaceholderText = "Search by name, member ID, or contact number";
            this.txtSearch.Location = new System.Drawing.Point(0, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblFilter
            // 
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.AutoSize = true;
            this.lblFilter.Text = "Membership status";
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFilter.Location = new System.Drawing.Point(340, 0);
            this.lblFilter.TabIndex = 2;
            // 
            // cboFilter
            // 
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboFilter.Size = new System.Drawing.Size(170, 25);
            this.cboFilter.Location = new System.Drawing.Point(340, 20);
            this.cboFilter.Items.AddRange(new object[] { "All", "Active", "Frozen", "Expired", "Pending", "No Membership", "Inactive Accounts" });
            this.cboFilter.TabIndex = 3;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Text = "Search";
            this.btnSearch.Size = new System.Drawing.Size(100, 27);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnSearch.Location = new System.Drawing.Point(520, 19);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMembers
            // 
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.TabIndex = 1;
            this.dgvMembers.SelectionChanged += new System.EventHandler(this.dgvMembers_SelectionChanged);
            this.dgvMembers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellDoubleClick);
            // 
            // footerPanel
            // 
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.footerPanel.Controls.Add(this.btnEdit);
            this.footerPanel.Controls.Add(this.btnToggle);
            this.footerPanel.Controls.Add(this.lblCount);
            this.footerPanel.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "View / Edit";
            this.btnEdit.Size = new System.Drawing.Size(120, 34);
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
            // btnToggle
            // 
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Text = "Deactivate";
            this.btnToggle.Size = new System.Drawing.Size(120, 34);
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.BackColor = System.Drawing.Color.White;
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 221, 232);
            this.btnToggle.Location = new System.Drawing.Point(130, 8);
            this.btnToggle.TabIndex = 1;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.AutoSize = true;
            this.lblCount.Text = "";
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCount.Location = new System.Drawing.Point(270, 16);
            this.lblCount.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+ Add Member";
            this.btnAdd.Size = new System.Drawing.Size(130, 34);
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
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Text = "Export CSV";
            this.btnExport.Size = new System.Drawing.Size(110, 34);
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 221, 232);
            this.btnExport.TabIndex = 2;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MembersForm
            // 
            this.PageTitle = "Members";
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.contentPanel.Controls.Add(this.mainLayout);
            this.actionsFlow.Controls.Add(this.btnAdd);
            this.actionsFlow.Controls.Add(this.btnExport);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Button btnExport;
    }
}
