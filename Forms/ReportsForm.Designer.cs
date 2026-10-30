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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            mainLayout = new TableLayoutPanel();
            toolbarPanel = new Panel();
            lblType = new Label();
            cboType = new ComboBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnGenerate = new FitZoneGym.Controls.ThemedButton();
            dgvReport = new FitZoneGym.Controls.ThemedGrid();
            summaryPanel = new Panel();
            lblSummary = new Label();
            contentPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(toolbarPanel);
            contentPanel.Controls.Add(mainLayout);
            contentPanel.Size = new Size(1030, 636);
            contentPanel.Paint += contentPanel_Paint;
            // 
            // headerPanel
            // 
            headerPanel.Size = new Size(1030, 56);
            // 
            // titleLabel
            // 
            titleLabel.Size = new Size(994, 48);
            titleLabel.Text = "Reports";
            titleLabel.Click += titleLabel_Click;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(24, 25, 33);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(dgvReport, 0, 1);
            mainLayout.Controls.Add(summaryPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(16, 16);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainLayout.Size = new Size(998, 604);
            mainLayout.TabIndex = 0;
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.FromArgb(24, 25, 33);
            toolbarPanel.Controls.Add(lblType);
            toolbarPanel.Controls.Add(cboType);
            toolbarPanel.Controls.Add(lblFrom);
            toolbarPanel.Controls.Add(dtpFrom);
            toolbarPanel.Controls.Add(lblTo);
            toolbarPanel.Controls.Add(dtpTo);
            toolbarPanel.Controls.Add(btnGenerate);
            toolbarPanel.Location = new Point(18, 6);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(992, 67);
            toolbarPanel.TabIndex = 0;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 8.5F);
            lblType.ForeColor = Color.FromArgb(152, 155, 172);
            lblType.Location = new Point(3, 5);
            lblType.Name = "lblType";
            lblType.Size = new Size(99, 23);
            lblType.TabIndex = 0;
            lblType.Text = "Report type";
            // 
            // cboType
            // 
            cboType.BackColor = Color.FromArgb(46, 47, 60);
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.FlatStyle = FlatStyle.Flat;
            cboType.Font = new Font("Segoe UI", 9.5F);
            cboType.ForeColor = Color.FromArgb(244, 244, 248);
            cboType.Items.AddRange(new object[] { "Revenue Report", "Payment Report", "Membership Report", "Renewal Report", "Freeze Report", "Unpaid Balances", "Reactivation Report", "Prorated Billing Report" });
            cboType.Location = new Point(3, 34);
            cboType.Name = "cboType";
            cboType.Size = new Size(240, 33);
            cboType.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 8.5F);
            lblFrom.ForeColor = Color.FromArgb(152, 155, 172);
            lblFrom.Location = new Point(260, 5);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(49, 23);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarForeColor = Color.FromArgb(244, 244, 248);
            dtpFrom.CalendarMonthBackground = Color.FromArgb(46, 47, 60);
            dtpFrom.CalendarTitleBackColor = Color.FromArgb(255, 106, 0);
            dtpFrom.CalendarTitleForeColor = Color.White;
            dtpFrom.CalendarTrailingForeColor = Color.FromArgb(152, 155, 172);
            dtpFrom.Font = new Font("Segoe UI", 9.5F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(260, 34);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(140, 33);
            dtpFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.BackColor = Color.Transparent;
            lblTo.Font = new Font("Segoe UI", 8.5F);
            lblTo.ForeColor = Color.FromArgb(152, 155, 172);
            lblTo.Location = new Point(420, 8);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(27, 23);
            lblTo.TabIndex = 4;
            lblTo.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.CalendarForeColor = Color.FromArgb(244, 244, 248);
            dtpTo.CalendarMonthBackground = Color.FromArgb(46, 47, 60);
            dtpTo.CalendarTitleBackColor = Color.FromArgb(255, 106, 0);
            dtpTo.CalendarTitleForeColor = Color.White;
            dtpTo.CalendarTrailingForeColor = Color.FromArgb(152, 155, 172);
            dtpTo.Font = new Font("Segoe UI", 9.5F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(420, 34);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(140, 33);
            dtpTo.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(255, 106, 0);
            btnGenerate.FlatAppearance.BorderColor = Color.FromArgb(255, 106, 0);
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 106, 0);
            btnGenerate.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 136, 56);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnGenerate.Location = new Point(588, 27);
            btnGenerate.Margin = new Padding(0, 0, 8, 0);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(135, 40);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.FromArgb(35, 36, 47);
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReport.ColumnHeadersHeight = 38;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(244, 244, 248);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.Font = new Font("Segoe UI", 9.5F);
            dgvReport.GridColor = Color.FromArgb(48, 50, 64);
            dgvReport.Location = new Point(3, 72);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowHeadersWidth = 62;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(992, 489);
            dgvReport.TabIndex = 1;
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.FromArgb(24, 25, 33);
            summaryPanel.Controls.Add(lblSummary);
            summaryPanel.Dock = DockStyle.Fill;
            summaryPanel.Location = new Point(3, 567);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(992, 34);
            summaryPanel.TabIndex = 2;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummary.ForeColor = Color.FromArgb(244, 244, 248);
            lblSummary.Location = new Point(0, 10);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(512, 28);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Choose a report and date range, then click Generate.";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            ClientSize = new Size(1280, 760);
            Name = "ReportsForm";
            PageTitle = "Reports";
            Text = "GYMORA - Reports";
            Load += ReportsForm_Load;
            contentPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainLayout.ResumeLayout(false);
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
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
        private FitZoneGym.Controls.ThemedButton btnGenerate;
        private FitZoneGym.Controls.ThemedGrid dgvReport;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label lblSummary;
    }
}
