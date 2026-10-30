namespace FitZoneGym.Forms
{
    partial class RegistrationForm
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
            pnlBody = new Panel();
            pnlRight = new Panel();
            cardHistory = new FitZoneGym.Controls.ThemedPanel();
            dgvHistory = new FitZoneGym.Controls.ThemedGrid();
            lblHistoryTitle = new Label();
            pnlGap = new Panel();
            pnlInfo = new FitZoneGym.Controls.ThemedPanel();
            lblInfo = new Label();
            pnlLeft = new FitZoneGym.Controls.ThemedPanel();
            lblPlan = new Label();
            cboPlan = new ComboBox();
            lblDateCaption = new Label();
            dtpDate = new DateTimePicker();
            lblDateHint = new Label();
            lblDiscount = new Label();
            numDiscount = new NumericUpDown();
            lblPay = new Label();
            numPay = new NumericUpDown();
            lblMethod = new Label();
            cboMethod = new ComboBox();
            lblRef = new Label();
            txtRef = new TextBox();
            lblSummary = new Label();
            btnGo = new FitZoneGym.Controls.ThemedButton();
            pnlTop = new Panel();
            rbNew = new RadioButton();
            rbRenew = new RadioButton();
            lblMemberSearch = new Label();
            memberPicker = new FitZoneGym.Controls.MemberPicker();
            contentPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlRight.SuspendLayout();
            cardHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            pnlInfo.SuspendLayout();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPay).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(pnlBody);
            contentPanel.Controls.Add(pnlTop);
            contentPanel.Size = new Size(1030, 636);
            // 
            // headerPanel
            // 
            headerPanel.Size = new Size(1030, 56);
            // 
            // titleLabel
            // 
            titleLabel.Size = new Size(994, 48);
            titleLabel.Text = "Registration & Renewal";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(24, 25, 33);
            pnlBody.Controls.Add(pnlRight);
            pnlBody.Controls.Add(pnlLeft);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(16, 120);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(998, 500);
            pnlBody.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(24, 25, 33);
            pnlRight.Controls.Add(cardHistory);
            pnlRight.Controls.Add(pnlGap);
            pnlRight.Controls.Add(pnlInfo);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(480, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(12, 0, 0, 0);
            pnlRight.Size = new Size(518, 500);
            pnlRight.TabIndex = 0;
            // 
            // cardHistory
            // 
            cardHistory.BackColor = Color.FromArgb(35, 36, 47);
            cardHistory.Controls.Add(dgvHistory);
            cardHistory.Controls.Add(lblHistoryTitle);
            cardHistory.CornerRadius = 14;
            cardHistory.Dock = DockStyle.Fill;
            cardHistory.Location = new Point(12, 82);
            cardHistory.Name = "cardHistory";
            cardHistory.Padding = new Padding(14);
            cardHistory.Size = new Size(506, 418);
            cardHistory.TabIndex = 0;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.FromArgb(35, 36, 47);
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(152, 155, 172);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.ColumnHeadersHeight = 38;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 36, 47);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(244, 244, 248);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(95, 55, 34);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.Font = new Font("Segoe UI", 9.5F);
            dgvHistory.GridColor = Color.FromArgb(48, 50, 64);
            dgvHistory.Location = new Point(14, 44);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(478, 360);
            dgvHistory.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.Dock = DockStyle.Top;
            lblHistoryTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(244, 244, 248);
            lblHistoryTitle.Location = new Point(14, 14);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(478, 30);
            lblHistoryTitle.TabIndex = 1;
            lblHistoryTitle.Text = "Renewal History";
            // 
            // pnlGap
            // 
            pnlGap.BackColor = Color.FromArgb(24, 25, 33);
            pnlGap.Dock = DockStyle.Top;
            pnlGap.Location = new Point(12, 70);
            pnlGap.Name = "pnlGap";
            pnlGap.Size = new Size(506, 12);
            pnlGap.TabIndex = 1;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(35, 36, 47);
            pnlInfo.Controls.Add(lblInfo);
            pnlInfo.CornerRadius = 14;
            pnlInfo.Dock = DockStyle.Top;
            pnlInfo.Location = new Point(12, 0);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Padding = new Padding(14, 8, 14, 4);
            pnlInfo.Size = new Size(506, 70);
            pnlInfo.TabIndex = 2;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Font = new Font("Segoe UI", 9.5F);
            lblInfo.ForeColor = Color.FromArgb(152, 155, 172);
            lblInfo.Location = new Point(14, 8);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(478, 58);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Search and select a member to begin.";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(35, 36, 47);
            pnlLeft.Controls.Add(lblPlan);
            pnlLeft.Controls.Add(cboPlan);
            pnlLeft.Controls.Add(lblDateCaption);
            pnlLeft.Controls.Add(dtpDate);
            pnlLeft.Controls.Add(lblDateHint);
            pnlLeft.Controls.Add(lblDiscount);
            pnlLeft.Controls.Add(numDiscount);
            pnlLeft.Controls.Add(lblPay);
            pnlLeft.Controls.Add(numPay);
            pnlLeft.Controls.Add(lblMethod);
            pnlLeft.Controls.Add(cboMethod);
            pnlLeft.Controls.Add(lblRef);
            pnlLeft.Controls.Add(txtRef);
            pnlLeft.Controls.Add(lblSummary);
            pnlLeft.Controls.Add(btnGo);
            pnlLeft.CornerRadius = 14;
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(480, 500);
            pnlLeft.TabIndex = 1;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 9.5F);
            lblPlan.ForeColor = Color.FromArgb(244, 244, 248);
            lblPlan.Location = new Point(14, 20);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(49, 25);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            // 
            // cboPlan
            // 
            cboPlan.BackColor = Color.FromArgb(46, 47, 60);
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FlatStyle = FlatStyle.Flat;
            cboPlan.Font = new Font("Segoe UI", 9.5F);
            cboPlan.ForeColor = Color.FromArgb(244, 244, 248);
            cboPlan.Location = new Point(170, 16);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(280, 33);
            cboPlan.TabIndex = 1;
            cboPlan.SelectedIndexChanged += Preview_Changed;
            // 
            // lblDateCaption
            // 
            lblDateCaption.AutoSize = true;
            lblDateCaption.Font = new Font("Segoe UI", 9.5F);
            lblDateCaption.ForeColor = Color.FromArgb(244, 244, 248);
            lblDateCaption.Location = new Point(14, 58);
            lblDateCaption.Name = "lblDateCaption";
            lblDateCaption.Size = new Size(92, 25);
            lblDateCaption.TabIndex = 2;
            lblDateCaption.Text = "Start date";
            // 
            // dtpDate
            // 
            dtpDate.CalendarForeColor = Color.FromArgb(244, 244, 248);
            dtpDate.CalendarMonthBackground = Color.FromArgb(46, 47, 60);
            dtpDate.CalendarTitleBackColor = Color.FromArgb(255, 106, 0);
            dtpDate.CalendarTitleForeColor = Color.White;
            dtpDate.CalendarTrailingForeColor = Color.FromArgb(152, 155, 172);
            dtpDate.Font = new Font("Segoe UI", 9.5F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(170, 54);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(140, 33);
            dtpDate.TabIndex = 3;
            dtpDate.ValueChanged += Preview_Changed;
            // 
            // lblDateHint
            // 
            lblDateHint.AutoSize = true;
            lblDateHint.Font = new Font("Segoe UI", 9F);
            lblDateHint.ForeColor = Color.FromArgb(152, 155, 172);
            lblDateHint.Location = new Point(320, 60);
            lblDateHint.Name = "lblDateHint";
            lblDateHint.Size = new Size(97, 25);
            lblDateHint.TabIndex = 4;
            lblDateHint.Text = "(start date)";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 9.5F);
            lblDiscount.ForeColor = Color.FromArgb(244, 244, 248);
            lblDiscount.Location = new Point(14, 96);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(119, 25);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Discount (%)";
            // 
            // numDiscount
            // 
            numDiscount.BackColor = Color.FromArgb(46, 47, 60);
            numDiscount.BorderStyle = BorderStyle.FixedSingle;
            numDiscount.Font = new Font("Segoe UI", 9.5F);
            numDiscount.ForeColor = Color.FromArgb(244, 244, 248);
            numDiscount.Location = new Point(170, 92);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(90, 33);
            numDiscount.TabIndex = 6;
            numDiscount.ThousandsSeparator = true;
            numDiscount.ValueChanged += Preview_Changed;
            // 
            // lblPay
            // 
            lblPay.AutoSize = true;
            lblPay.Font = new Font("Segoe UI", 9.5F);
            lblPay.ForeColor = Color.FromArgb(244, 244, 248);
            lblPay.Location = new Point(14, 134);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(137, 25);
            lblPay.TabIndex = 7;
            lblPay.Text = "Initial payment";
            // 
            // numPay
            // 
            numPay.BackColor = Color.FromArgb(46, 47, 60);
            numPay.BorderStyle = BorderStyle.FixedSingle;
            numPay.DecimalPlaces = 2;
            numPay.Font = new Font("Segoe UI", 9.5F);
            numPay.ForeColor = Color.FromArgb(244, 244, 248);
            numPay.Location = new Point(170, 130);
            numPay.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPay.Name = "numPay";
            numPay.Size = new Size(140, 33);
            numPay.TabIndex = 8;
            numPay.ThousandsSeparator = true;
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Font = new Font("Segoe UI", 9.5F);
            lblMethod.ForeColor = Color.FromArgb(244, 244, 248);
            lblMethod.Location = new Point(14, 172);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(154, 25);
            lblMethod.TabIndex = 9;
            lblMethod.Text = "Payment method";
            // 
            // cboMethod
            // 
            cboMethod.BackColor = Color.FromArgb(46, 47, 60);
            cboMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMethod.FlatStyle = FlatStyle.Flat;
            cboMethod.Font = new Font("Segoe UI", 9.5F);
            cboMethod.ForeColor = Color.FromArgb(244, 244, 248);
            cboMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card", "Bank Transfer", "Other" });
            cboMethod.Location = new Point(170, 168);
            cboMethod.Name = "cboMethod";
            cboMethod.Size = new Size(160, 33);
            cboMethod.TabIndex = 10;
            // 
            // lblRef
            // 
            lblRef.AutoSize = true;
            lblRef.Font = new Font("Segoe UI", 9.5F);
            lblRef.ForeColor = Color.FromArgb(244, 244, 248);
            lblRef.Location = new Point(14, 210);
            lblRef.Name = "lblRef";
            lblRef.Size = new Size(126, 25);
            lblRef.TabIndex = 11;
            lblRef.Text = "Reference no.";
            // 
            // txtRef
            // 
            txtRef.BackColor = Color.FromArgb(46, 47, 60);
            txtRef.BorderStyle = BorderStyle.FixedSingle;
            txtRef.Font = new Font("Segoe UI", 9.5F);
            txtRef.ForeColor = Color.FromArgb(244, 244, 248);
            txtRef.Location = new Point(170, 206);
            txtRef.Name = "txtRef";
            txtRef.Size = new Size(160, 33);
            txtRef.TabIndex = 12;
            // 
            // lblSummary
            // 
            lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummary.ForeColor = Color.FromArgb(244, 244, 248);
            lblSummary.Location = new Point(14, 252);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(440, 76);
            lblSummary.TabIndex = 13;
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.FromArgb(34, 197, 94);
            btnGo.FlatAppearance.BorderColor = Color.FromArgb(34, 197, 94);
            btnGo.FlatAppearance.BorderSize = 0;
            btnGo.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 197, 94);
            btnGo.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 222, 128);
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGo.ForeColor = Color.White;
            btnGo.Kind = FitZoneGym.Controls.ButtonKind.Success;
            btnGo.Location = new Point(14, 336);
            btnGo.Margin = new Padding(0, 0, 8, 0);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(220, 40);
            btnGo.TabIndex = 14;
            btnGo.Text = "Register Membership";
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += btnGo_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(24, 25, 33);
            pnlTop.Controls.Add(rbNew);
            pnlTop.Controls.Add(rbRenew);
            pnlTop.Controls.Add(lblMemberSearch);
            pnlTop.Controls.Add(memberPicker);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(16, 16);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(998, 104);
            pnlTop.TabIndex = 1;
            // 
            // rbNew
            // 
            rbNew.Appearance = Appearance.Button;
            rbNew.BackColor = Color.FromArgb(255, 106, 0);
            rbNew.Checked = true;
            rbNew.FlatAppearance.BorderColor = Color.FromArgb(58, 60, 76);
            rbNew.FlatStyle = FlatStyle.Flat;
            rbNew.Font = new Font("Segoe UI", 9.5F);
            rbNew.ForeColor = Color.FromArgb(244, 244, 248);
            rbNew.Location = new Point(0, 0);
            rbNew.Name = "rbNew";
            rbNew.Size = new Size(160, 37);
            rbNew.TabIndex = 0;
            rbNew.TabStop = true;
            rbNew.Text = "New Registration";
            rbNew.TextAlign = ContentAlignment.MiddleCenter;
            rbNew.UseVisualStyleBackColor = false;
            rbNew.CheckedChanged += rbMode_CheckedChanged;
            // 
            // rbRenew
            // 
            rbRenew.Appearance = Appearance.Button;
            rbRenew.BackColor = Color.FromArgb(46, 47, 60);
            rbRenew.FlatAppearance.BorderColor = Color.FromArgb(58, 60, 76);
            rbRenew.FlatStyle = FlatStyle.Flat;
            rbRenew.Font = new Font("Segoe UI", 9.5F);
            rbRenew.ForeColor = Color.FromArgb(244, 244, 248);
            rbRenew.Location = new Point(170, 0);
            rbRenew.Name = "rbRenew";
            rbRenew.Size = new Size(160, 37);
            rbRenew.TabIndex = 1;
            rbRenew.TabStop = true;
            rbRenew.Text = "Renew Membership";
            rbRenew.TextAlign = ContentAlignment.MiddleCenter;
            rbRenew.UseVisualStyleBackColor = false;
            rbRenew.CheckedChanged += rbMode_CheckedChanged;
            // 
            // lblMemberSearch
            // 
            lblMemberSearch.AutoSize = true;
            lblMemberSearch.Font = new Font("Segoe UI", 8.5F);
            lblMemberSearch.ForeColor = Color.FromArgb(152, 155, 172);
            lblMemberSearch.Location = new Point(0, 40);
            lblMemberSearch.Name = "lblMemberSearch";
            lblMemberSearch.Size = new Size(128, 23);
            lblMemberSearch.TabIndex = 2;
            lblMemberSearch.Text = "Member search";
            // 
            // memberPicker
            // 
            memberPicker.AutoSize = true;
            memberPicker.BackColor = Color.Transparent;
            memberPicker.Location = new Point(0, 62);
            memberPicker.Name = "memberPicker";
            memberPicker.Size = new Size(714, 100);
            memberPicker.TabIndex = 3;
            memberPicker.WrapContents = false;
            memberPicker.MemberChanged += memberPicker_MemberChanged;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            ClientSize = new Size(1280, 760);
            Name = "RegistrationForm";
            PageTitle = "Registration & Renewal";
            Text = "GYMORA - Registration & Renewal";
            contentPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            cardHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlInfo.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPay).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlRight;
        private FitZoneGym.Controls.ThemedPanel cardHistory;
        private FitZoneGym.Controls.ThemedGrid dgvHistory;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Panel pnlGap;
        private FitZoneGym.Controls.ThemedPanel pnlInfo;
        private System.Windows.Forms.Label lblInfo;
        private FitZoneGym.Controls.ThemedPanel pnlLeft;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblDateCaption;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDateHint;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.NumericUpDown numPay;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblSummary;
        private FitZoneGym.Controls.ThemedButton btnGo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbRenew;
        private System.Windows.Forms.Label lblMemberSearch;
        private FitZoneGym.Controls.MemberPicker memberPicker;
    }
}
