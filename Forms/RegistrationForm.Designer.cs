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
            pnlBody = new Panel();
            pnlRight = new Panel();
            cardHistory = new Panel();
            dgvHistory = new DataGridView();
            lblHistoryTitle = new Label();
            pnlGap = new Panel();
            pnlInfo = new Panel();
            lblInfo = new Label();
            pnlLeft = new Panel();
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
            btnGo = new Button();
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
            // 
            // headerPanel
            // 
            // 
            // titleLabel
            // 
            titleLabel.Text = "Registration & Renewal";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(243, 246, 251);
            pnlBody.Controls.Add(pnlRight);
            pnlBody.Controls.Add(pnlLeft);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(16, 120);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1018, 534);
            pnlBody.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(243, 246, 251);
            pnlRight.Controls.Add(cardHistory);
            pnlRight.Controls.Add(pnlGap);
            pnlRight.Controls.Add(pnlInfo);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(480, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(12, 0, 0, 0);
            pnlRight.Size = new Size(538, 534);
            pnlRight.TabIndex = 0;
            // 
            // cardHistory
            // 
            cardHistory.BackColor = Color.White;
            cardHistory.Controls.Add(dgvHistory);
            cardHistory.Controls.Add(lblHistoryTitle);
            cardHistory.Dock = DockStyle.Fill;
            cardHistory.Location = new Point(12, 82);
            cardHistory.Name = "cardHistory";
            cardHistory.Padding = new Padding(14);
            cardHistory.Size = new Size(526, 452);
            cardHistory.TabIndex = 0;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeight = 34;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(14, 44);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.Size = new Size(498, 394);
            dgvHistory.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.Dock = DockStyle.Top;
            lblHistoryTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(15, 35, 66);
            lblHistoryTitle.Location = new Point(14, 14);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(498, 30);
            lblHistoryTitle.TabIndex = 1;
            lblHistoryTitle.Text = "Renewal History";
            // 
            // pnlGap
            // 
            pnlGap.BackColor = Color.FromArgb(243, 246, 251);
            pnlGap.Dock = DockStyle.Top;
            pnlGap.Location = new Point(12, 70);
            pnlGap.Name = "pnlGap";
            pnlGap.Size = new Size(526, 12);
            pnlGap.TabIndex = 1;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.White;
            pnlInfo.Controls.Add(lblInfo);
            pnlInfo.Dock = DockStyle.Top;
            pnlInfo.Location = new Point(12, 0);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Padding = new Padding(14, 8, 14, 4);
            pnlInfo.Size = new Size(526, 70);
            pnlInfo.TabIndex = 2;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Font = new Font("Segoe UI", 9.5F);
            lblInfo.ForeColor = Color.FromArgb(107, 114, 128);
            lblInfo.Location = new Point(14, 8);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(498, 58);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Search and select a member to begin.";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
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
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(480, 534);
            pnlLeft.TabIndex = 1;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 9.5F);
            lblPlan.ForeColor = Color.FromArgb(31, 41, 55);
            lblPlan.Location = new Point(14, 20);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(49, 25);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FlatStyle = FlatStyle.Flat;
            cboPlan.Font = new Font("Segoe UI", 9.5F);
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
            lblDateCaption.ForeColor = Color.FromArgb(31, 41, 55);
            lblDateCaption.Location = new Point(14, 58);
            lblDateCaption.Name = "lblDateCaption";
            lblDateCaption.Size = new Size(92, 25);
            lblDateCaption.TabIndex = 2;
            lblDateCaption.Text = "Start date";
            // 
            // dtpDate
            // 
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
            lblDateHint.ForeColor = Color.FromArgb(107, 114, 128);
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
            lblDiscount.ForeColor = Color.FromArgb(31, 41, 55);
            lblDiscount.Location = new Point(14, 96);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(119, 25);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Discount (%)";
            // 
            // numDiscount
            // 
            numDiscount.Font = new Font("Segoe UI", 9.5F);
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
            lblPay.ForeColor = Color.FromArgb(31, 41, 55);
            lblPay.Location = new Point(14, 134);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(137, 25);
            lblPay.TabIndex = 7;
            lblPay.Text = "Initial payment";
            // 
            // numPay
            // 
            numPay.DecimalPlaces = 2;
            numPay.Font = new Font("Segoe UI", 9.5F);
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
            lblMethod.ForeColor = Color.FromArgb(31, 41, 55);
            lblMethod.Location = new Point(14, 172);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(154, 25);
            lblMethod.TabIndex = 9;
            lblMethod.Text = "Payment method";
            // 
            // cboMethod
            // 
            cboMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMethod.FlatStyle = FlatStyle.Flat;
            cboMethod.Font = new Font("Segoe UI", 9.5F);
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
            lblRef.ForeColor = Color.FromArgb(31, 41, 55);
            lblRef.Location = new Point(14, 210);
            lblRef.Name = "lblRef";
            lblRef.Size = new Size(126, 25);
            lblRef.TabIndex = 11;
            lblRef.Text = "Reference no.";
            // 
            // txtRef
            // 
            txtRef.BorderStyle = BorderStyle.FixedSingle;
            txtRef.Font = new Font("Segoe UI", 9.5F);
            txtRef.Location = new Point(170, 206);
            txtRef.Name = "txtRef";
            txtRef.Size = new Size(160, 33);
            txtRef.TabIndex = 12;
            // 
            // lblSummary
            // 
            lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummary.ForeColor = Color.FromArgb(15, 35, 66);
            lblSummary.Location = new Point(14, 252);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(440, 76);
            lblSummary.TabIndex = 13;
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.FromArgb(22, 163, 74);
            btnGo.Cursor = Cursors.Hand;
            btnGo.FlatAppearance.BorderColor = Color.FromArgb(22, 163, 74);
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGo.ForeColor = Color.White;
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
            pnlTop.BackColor = Color.FromArgb(243, 246, 251);
            pnlTop.Controls.Add(rbNew);
            pnlTop.Controls.Add(rbRenew);
            pnlTop.Controls.Add(lblMemberSearch);
            pnlTop.Controls.Add(memberPicker);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(16, 16);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1018, 104);
            pnlTop.TabIndex = 1;
            // 
            // rbNew
            // 
            rbNew.Appearance = Appearance.Button;
            rbNew.Checked = true;
            rbNew.FlatAppearance.BorderColor = Color.FromArgb(214, 221, 232);
            rbNew.FlatStyle = FlatStyle.Flat;
            rbNew.Font = new Font("Segoe UI", 9.5F);
            rbNew.Location = new Point(0, 0);
            rbNew.Name = "rbNew";
            rbNew.Size = new Size(160, 32);
            rbNew.TabIndex = 0;
            rbNew.TabStop = true;
            rbNew.Text = "New Registration";
            rbNew.TextAlign = ContentAlignment.MiddleCenter;
            rbNew.CheckedChanged += rbMode_CheckedChanged;
            // 
            // rbRenew
            // 
            rbRenew.Appearance = Appearance.Button;
            rbRenew.FlatAppearance.BorderColor = Color.FromArgb(214, 221, 232);
            rbRenew.FlatStyle = FlatStyle.Flat;
            rbRenew.Font = new Font("Segoe UI", 9.5F);
            rbRenew.Location = new Point(170, 0);
            rbRenew.Name = "rbRenew";
            rbRenew.Size = new Size(160, 32);
            rbRenew.TabIndex = 1;
            rbRenew.TabStop = true;
            rbRenew.Text = "Renew Membership";
            rbRenew.TextAlign = ContentAlignment.MiddleCenter;
            rbRenew.CheckedChanged += rbMode_CheckedChanged;
            // 
            // lblMemberSearch
            // 
            lblMemberSearch.AutoSize = true;
            lblMemberSearch.Font = new Font("Segoe UI", 8.5F);
            lblMemberSearch.ForeColor = Color.FromArgb(107, 114, 128);
            lblMemberSearch.Location = new Point(0, 44);
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
        private System.Windows.Forms.Panel cardHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Panel pnlGap;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlLeft;
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
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbRenew;
        private System.Windows.Forms.Label lblMemberSearch;
        private FitZoneGym.Controls.MemberPicker memberPicker;
    }
}
