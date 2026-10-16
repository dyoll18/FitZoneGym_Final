namespace FitZoneGym.Forms
{
    partial class ReportsForm
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
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.summaryPanel.SuspendLayout();
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
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayout.Controls.Add(this.toolbarPanel, 0, 0);
            this.mainLayout.Controls.Add(this.dgvReport, 0, 1);
            this.mainLayout.Controls.Add(this.summaryPanel, 0, 2);
            this.mainLayout.TabIndex = 0;
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.toolbarPanel.Controls.Add(this.lblType);
            this.toolbarPanel.Controls.Add(this.cboType);
            this.toolbarPanel.Controls.Add(this.lblFrom);
            this.toolbarPanel.Controls.Add(this.dtpFrom);
            this.toolbarPanel.Controls.Add(this.lblTo);
            this.toolbarPanel.Controls.Add(this.dtpTo);
            this.toolbarPanel.Controls.Add(this.btnGenerate);
            this.toolbarPanel.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.Name = "lblType";
            this.lblType.AutoSize = true;
            this.lblType.Text = "Report type";
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblType.Location = new System.Drawing.Point(0, 0);
            this.lblType.TabIndex = 0;
            // 
            // cboType
            // 
            this.cboType.Name = "cboType";
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboType.Size = new System.Drawing.Size(240, 25);
            this.cboType.Location = new System.Drawing.Point(0, 20);
            this.cboType.Items.AddRange(new object[] { "Revenue Report", "Payment Report", "Membership Report", "Renewal Report", "Freeze Report", "Unpaid Balances", "Reactivation Report", "Prorated Billing Report" });
            this.cboType.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.AutoSize = true;
            this.lblFrom.Text = "From";
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFrom.Location = new System.Drawing.Point(260, 0);
            this.lblFrom.TabIndex = 2;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFrom.Size = new System.Drawing.Size(140, 25);
            this.dtpFrom.Location = new System.Drawing.Point(260, 20);
            this.dtpFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.Name = "lblTo";
            this.lblTo.AutoSize = true;
            this.lblTo.Text = "To";
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTo.Location = new System.Drawing.Point(410, 0);
            this.lblTo.TabIndex = 4;
            // 
            // dtpTo
            // 
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTo.Size = new System.Drawing.Size(140, 25);
            this.dtpTo.Location = new System.Drawing.Point(410, 20);
            this.dtpTo.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.Size = new System.Drawing.Size(150, 27);
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnGenerate.Location = new System.Drawing.Point(560, 19);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.TabIndex = 1;
            // 
            // summaryPanel
            // 
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryPanel.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.summaryPanel.Controls.Add(this.lblSummary);
            this.summaryPanel.TabIndex = 2;
            // 
            // lblSummary
            // 
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.AutoSize = true;
            this.lblSummary.Text = "Choose a report and date range, then click Generate.";
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(15, 35, 66);
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold);
            this.lblSummary.Location = new System.Drawing.Point(0, 10);
            this.lblSummary.TabIndex = 0;
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
            this.btnExport.TabIndex = 1;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ReportsForm
            // 
            this.PageTitle = "Reports";
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.contentPanel.Controls.Add(this.mainLayout);
            this.actionsFlow.Controls.Add(this.btnExport);
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
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
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnExport;
    }
}
