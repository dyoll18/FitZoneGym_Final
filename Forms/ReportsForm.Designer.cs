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

        /// <summary>Designer generated.</summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.toolbarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cardGrid = new FitZoneGym.Controls.CardPanel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblSummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.toolbarLayout.SuspendLayout();
            this.cardGrid.SuspendLayout();
            this.SuspendLayout();
            this.contentPanel.SuspendLayout();
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
            this.mainLayout.Controls.Add(this.lblSummary, 0, 2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // toolbarLayout
            // 
            this.toolbarLayout.ColumnCount = 6;
            this.toolbarLayout.RowCount = 2;
            this.toolbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.toolbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.toolbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.toolbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.toolbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.toolbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.toolbarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.toolbarLayout.Controls.Add(this.lblType, 0, 0);
            this.toolbarLayout.Controls.Add(this.lblFrom, 1, 0);
            this.toolbarLayout.Controls.Add(this.lblTo, 2, 0);
            this.toolbarLayout.Controls.Add(this.cboType, 0, 1);
            this.toolbarLayout.Controls.Add(this.dtpFrom, 1, 1);
            this.toolbarLayout.Controls.Add(this.dtpTo, 2, 1);
            this.toolbarLayout.Controls.Add(this.btnGenerate, 3, 1);
            this.toolbarLayout.Controls.Add(this.btnExport, 4, 1);
            this.toolbarLayout.Name = "toolbarLayout";
            this.toolbarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbarLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.toolbarLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.toolbarLayout.AutoSize = true;
            this.toolbarLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblType
            // 
            this.lblType.Name = "lblType";
            this.lblType.AutoSize = true;
            this.lblType.Text = "REPORT TYPE";
            this.lblType.Tag = "caption";
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.lblType.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // lblFrom
            // 
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.AutoSize = true;
            this.lblFrom.Text = "FROM";
            this.lblFrom.Tag = "caption";
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFrom.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // lblTo
            // 
            this.lblTo.Name = "lblTo";
            this.lblTo.AutoSize = true;
            this.lblTo.Text = "TO";
            this.lblTo.Tag = "caption";
            this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // cboType
            // 
            this.cboType.Name = "cboType";
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboType.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.cboType.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.Items.AddRange(new object[] { "Revenue Report", "Payment Report", "Membership Report", "Renewal Report", "Freeze Report", "Unpaid Balances", "Reactivation Report", "Prorated Billing Report" });
            // 
            // dtpFrom
            // 
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Size = new System.Drawing.Size(140, 27);
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(36, 36, 43);
            this.dtpFrom.CalendarForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dtpFrom.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // dtpTo
            // 
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Size = new System.Drawing.Size(140, 27);
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpTo.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.dtpTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(36, 36, 43);
            this.dtpTo.CalendarForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.dtpTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.dtpTo.CalendarTitleForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dtpTo.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.Size = new System.Drawing.Size(160, 34);
            this.btnGenerate.Tag = "primary";
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.FlatAppearance.BorderSize = 1;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(205, 60, 8);
            this.btnGenerate.Click += this.btnGenerate_Click;
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Text = "Export CSV";
            this.btnExport.Size = new System.Drawing.Size(120, 34);
            this.btnExport.Tag = "secondary";
            this.btnExport.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
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
            // cardGrid
            // 
            this.cardGrid.Controls.Add(this.dgvReport);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Tag = "card";
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // dgvReport
            // 
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.DataGridViewCellStyle dgvReportHead = new System.Windows.Forms.DataGridViewCellStyle();
            dgvReportHead.BackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvReportHead.ForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvReportHead.SelectionBackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvReportHead.SelectionForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvReportHead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvReportHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            System.Windows.Forms.DataGridViewCellStyle dgvReportCell = new System.Windows.Forms.DataGridViewCellStyle();
            dgvReportCell.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            dgvReportCell.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvReportCell.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvReportCell.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            System.Windows.Forms.DataGridViewCellStyle dgvReportAlt = new System.Windows.Forms.DataGridViewCellStyle();
            dgvReportAlt.BackColor = System.Drawing.Color.FromArgb(29, 29, 35);
            dgvReportAlt.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvReportAlt.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvReportAlt.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dgvReportHead;
            this.dgvReport.DefaultCellStyle = dgvReportCell;
            this.dgvReport.AlternatingRowsDefaultCellStyle = dgvReportAlt;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 29);
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(44, 44, 52);
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.ReadOnly = true;
            this.dgvReport.MultiSelect = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // lblSummary
            // 
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.AutoSize = true;
            this.lblSummary.Text = "Choose a report and date range, then click Generate.";
            this.lblSummary.Tag = "summary";
            this.lblSummary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSummary.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // ReportsForm
            // 
            this.contentPanel.Controls.Add(this.mainLayout);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BackColor = System.Drawing.Color.FromArgb(14, 14, 17);
            this.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Name = "ReportsForm";
            this.PageTitle = "Reports";
            this.Text = "FITZONE GYM - Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.cardGrid.ResumeLayout(false);
            this.toolbarLayout.ResumeLayout(false);
            this.toolbarLayout.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel toolbarLayout;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExport;
        private FitZoneGym.Controls.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblSummary;
    }
}
