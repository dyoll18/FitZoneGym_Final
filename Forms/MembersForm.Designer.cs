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

        /// <summary>Designer generated.</summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.toolbarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cardGrid = new FitZoneGym.Controls.CardPanel();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.footerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.toolbarLayout.SuspendLayout();
            this.cardGrid.SuspendLayout();
            this.footerLayout.SuspendLayout();
            this.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.actionsFlow.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.RowCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainLayout.Controls.Add(this.toolbarLayout, 0, 0);
            this.mainLayout.Controls.Add(this.cardGrid, 0, 1);
            this.mainLayout.Controls.Add(this.footerLayout, 0, 2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // toolbarLayout
            // 
            this.toolbarLayout.ColumnCount = 3;
            this.toolbarLayout.RowCount = 2;
            this.toolbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.toolbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.toolbarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.toolbarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.toolbarLayout.Controls.Add(this.lblSearch, 0, 0);
            this.toolbarLayout.Controls.Add(this.lblFilter, 1, 0);
            this.toolbarLayout.Controls.Add(this.txtSearch, 0, 1);
            this.toolbarLayout.Controls.Add(this.cboFilter, 1, 1);
            this.toolbarLayout.Controls.Add(this.btnSearch, 2, 1);
            this.toolbarLayout.Name = "toolbarLayout";
            this.toolbarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbarLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.toolbarLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.toolbarLayout.AutoSize = true;
            this.toolbarLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblSearch
            // 
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.AutoSize = true;
            this.lblSearch.Text = "SEARCH";
            this.lblSearch.Tag = "caption";
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // lblFilter
            // 
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.AutoSize = true;
            this.lblFilter.Text = "MEMBERSHIP STATUS";
            this.lblFilter.Tag = "caption";
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFilter.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.txtSearch.PlaceholderText = "Name, member ID or contact number";
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.KeyDown += this.txtSearch_KeyDown;
            // 
            // cboFilter
            // 
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboFilter.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.cboFilter.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.cboFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilter.Items.AddRange(new object[] { "All", "Active", "Frozen", "Expired", "Pending", "No Membership", "Inactive Accounts" });
            this.cboFilter.SelectedIndexChanged += this.cboFilter_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Text = "Search";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.Tag = "primary";
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.FlatAppearance.BorderSize = 1;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(205, 60, 8);
            this.btnSearch.Click += this.btnSearch_Click;
            // 
            // cardGrid
            // 
            this.cardGrid.Controls.Add(this.dgvMembers);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Tag = "card";
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // dgvMembers
            // 
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.DataGridViewCellStyle dgvMembersHead = new System.Windows.Forms.DataGridViewCellStyle();
            dgvMembersHead.BackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvMembersHead.ForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvMembersHead.SelectionBackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvMembersHead.SelectionForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvMembersHead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvMembersHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            System.Windows.Forms.DataGridViewCellStyle dgvMembersCell = new System.Windows.Forms.DataGridViewCellStyle();
            dgvMembersCell.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            dgvMembersCell.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvMembersCell.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvMembersCell.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            System.Windows.Forms.DataGridViewCellStyle dgvMembersAlt = new System.Windows.Forms.DataGridViewCellStyle();
            dgvMembersAlt.BackColor = System.Drawing.Color.FromArgb(29, 29, 35);
            dgvMembersAlt.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvMembersAlt.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvMembersAlt.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvMembers.EnableHeadersVisualStyles = false;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dgvMembersHead;
            this.dgvMembers.DefaultCellStyle = dgvMembersCell;
            this.dgvMembers.AlternatingRowsDefaultCellStyle = dgvMembersAlt;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 29);
            this.dgvMembers.GridColor = System.Drawing.Color.FromArgb(44, 44, 52);
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.CellDoubleClick += this.dgvMembers_CellDoubleClick;
            this.dgvMembers.SelectionChanged += this.dgvMembers_SelectionChanged;
            // 
            // footerLayout
            // 
            this.footerLayout.ColumnCount = 4;
            this.footerLayout.RowCount = 1;
            this.footerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.footerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.footerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.footerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.footerLayout.Controls.Add(this.btnEdit, 0, 0);
            this.footerLayout.Controls.Add(this.btnToggle, 1, 0);
            this.footerLayout.Controls.Add(this.btnExport, 2, 0);
            this.footerLayout.Controls.Add(this.lblCount, 3, 0);
            this.footerLayout.Name = "footerLayout";
            this.footerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerLayout.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.footerLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.footerLayout.AutoSize = true;
            this.footerLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "View / Edit";
            this.btnEdit.Size = new System.Drawing.Size(130, 36);
            this.btnEdit.Tag = "primary";
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.FlatAppearance.BorderSize = 1;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(205, 60, 8);
            this.btnEdit.Click += this.btnEdit_Click;
            // 
            // btnToggle
            // 
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Text = "Deactivate";
            this.btnToggle.Size = new System.Drawing.Size(130, 36);
            this.btnToggle.Tag = "secondary";
            this.btnToggle.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(36, 36, 43);
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnToggle.FlatAppearance.BorderSize = 1;
            this.btnToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(54, 54, 63);
            this.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 59);
            this.btnToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(28, 28, 34);
            this.btnToggle.Click += this.btnToggle_Click;
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Text = "Export CSV";
            this.btnExport.Size = new System.Drawing.Size(130, 36);
            this.btnExport.Tag = "secondary";
            this.btnExport.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(36, 36, 43);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExport.FlatAppearance.BorderSize = 1;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(54, 54, 63);
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 59);
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(28, 28, 34);
            this.btnExport.Click += this.btnExport_Click;
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.AutoSize = true;
            this.lblCount.Text = "";
            this.lblCount.Tag = "muted";
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+ Add Member";
            this.btnAdd.Size = new System.Drawing.Size(140, 36);
            this.btnAdd.Tag = "primary";
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.FlatAppearance.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(205, 60, 8);
            this.btnAdd.Click += this.btnAdd_Click;
            // 
            // MembersForm
            // 
            this.contentPanel.Controls.Add(this.mainLayout);
            this.actionsFlow.Controls.Add(this.btnAdd);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BackColor = System.Drawing.Color.FromArgb(14, 14, 17);
            this.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Name = "MembersForm";
            this.PageTitle = "Members";
            this.Text = "FITZONE GYM - Members";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.footerLayout.ResumeLayout(false);
            this.footerLayout.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            this.toolbarLayout.ResumeLayout(false);
            this.toolbarLayout.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.actionsFlow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel toolbarLayout;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnSearch;
        private FitZoneGym.Controls.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.TableLayoutPanel footerLayout;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnAdd;
    }
}
