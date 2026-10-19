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
            mainLayout = new TableLayoutPanel();
            toolbarPanel = new Panel();
            lblType = new Label();
            cboType = new ComboBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnGenerate = new Button();
            dgvReport = new DataGridView();
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
            contentPanel.Controls.Add(mainLayout);
            contentPanel.Size = new Size(1050, 670);
            // 
            // headerPanel
            // 
            headerPanel.Size = new Size(1050, 56);
            // 
            // titleLabel
            // 
            titleLabel.Size = new Size(772, 48);
            titleLabel.Text = "Reports";
            titleLabel.Click += titleLabel_Click;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(243, 246, 251);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(toolbarPanel, 0, 0);
            mainLayout.Controls.Add(dgvReport, 0, 1);
            mainLayout.Controls.Add(summaryPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(16, 16);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainLayout.Size = new Size(1018, 638);
            mainLayout.TabIndex = 0;
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.FromArgb(243, 246, 251);
            toolbarPanel.Controls.Add(lblType);
            toolbarPanel.Controls.Add(cboType);
            toolbarPanel.Controls.Add(lblFrom);
            toolbarPanel.Controls.Add(dtpFrom);
            toolbarPanel.Controls.Add(lblTo);
            toolbarPanel.Controls.Add(dtpTo);
            toolbarPanel.Controls.Add(btnGenerate);
            toolbarPanel.Dock = DockStyle.Fill;
            toolbarPanel.Location = new Point(3, 3);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(1012, 48);
            toolbarPanel.TabIndex = 0;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 8.5F);
            lblType.ForeColor = Color.FromArgb(107, 114, 128);
            lblType.Location = new Point(0, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(99, 23);
            lblType.TabIndex = 0;
            lblType.Text = "Report type";
            // 
            // cboType
            // 
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.FlatStyle = FlatStyle.Flat;
            cboType.Font = new Font("Segoe UI", 9.5F);
            cboType.Items.AddRange(new object[] { "Revenue Report", "Payment Report", "Membership Report", "Renewal Report", "Freeze Report", "Unpaid Balances", "Reactivation Report", "Prorated Billing Report" });
            cboType.Location = new Point(0, 20);
            cboType.Name = "cboType";
            cboType.Size = new Size(240, 33);
            cboType.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 8.5F);
            lblFrom.ForeColor = Color.FromArgb(107, 114, 128);
            lblFrom.Location = new Point(260, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(49, 23);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Segoe UI", 9.5F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(264, 20);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(140, 33);
            dtpFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.BackColor = Color.Transparent;
            lblTo.Font = new Font("Segoe UI", 8.5F);
            lblTo.ForeColor = Color.FromArgb(107, 114, 128);
            lblTo.Location = new Point(410, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(27, 23);
            lblTo.TabIndex = 4;
            lblTo.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Segoe UI", 9.5F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(410, 15);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(140, 33);
            dtpTo.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(30, 111, 240);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(563, 5);
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
            dgvReport.ColumnHeadersHeight = 34;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(3, 57);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(1012, 538);
            dgvReport.TabIndex = 1;
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.FromArgb(243, 246, 251);
            summaryPanel.Controls.Add(lblSummary);
            summaryPanel.Dock = DockStyle.Fill;
            summaryPanel.Location = new Point(3, 601);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(1012, 34);
            summaryPanel.TabIndex = 2;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummary.ForeColor = Color.FromArgb(15, 35, 66);
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
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label lblSummary;
    }
}
