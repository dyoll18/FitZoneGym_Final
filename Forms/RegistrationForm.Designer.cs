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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.cardHistory = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.pnlGap = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblDateCaption = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateHint = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblPay = new System.Windows.Forms.Label();
            this.numPay = new System.Windows.Forms.NumericUpDown();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbRenew = new System.Windows.Forms.RadioButton();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.memberPicker = new FitZoneGym.Controls.MemberPicker();
            this.pnlBody.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.cardHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.pnlGap.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.pnlBody.Controls.Add(this.pnlRight);
            this.pnlBody.Controls.Add(this.pnlLeft);
            this.pnlBody.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.pnlRight.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlRight.Controls.Add(this.cardHistory);
            this.pnlRight.Controls.Add(this.pnlGap);
            this.pnlRight.Controls.Add(this.pnlInfo);
            this.pnlRight.TabIndex = 0;
            // 
            // cardHistory
            // 
            this.cardHistory.Name = "cardHistory";
            this.cardHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHistory.BackColor = System.Drawing.Color.White;
            this.cardHistory.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.cardHistory.Controls.Add(this.dgvHistory);
            this.cardHistory.Controls.Add(this.lblHistoryTitle);
            this.cardHistory.TabIndex = 0;
            // 
            // dgvHistory
            // 
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.AutoSize = false;
            this.lblHistoryTitle.Text = "Renewal History";
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(15, 35, 66);
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.Size = new System.Drawing.Size(100, 30);
            this.lblHistoryTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistoryTitle.TabIndex = 1;
            // 
            // pnlGap
            // 
            this.pnlGap.Name = "pnlGap";
            this.pnlGap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGap.Height = 12;
            this.pnlGap.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.pnlGap.TabIndex = 1;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Height = 70;
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(14, 8, 14, 4);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.AutoSize = false;
            this.lblInfo.Text = "Search and select a member to begin.";
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInfo.Size = new System.Drawing.Size(470, 50);
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 480;
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.lblPlan);
            this.pnlLeft.Controls.Add(this.cboPlan);
            this.pnlLeft.Controls.Add(this.lblDateCaption);
            this.pnlLeft.Controls.Add(this.dtpDate);
            this.pnlLeft.Controls.Add(this.lblDateHint);
            this.pnlLeft.Controls.Add(this.lblDiscount);
            this.pnlLeft.Controls.Add(this.numDiscount);
            this.pnlLeft.Controls.Add(this.lblPay);
            this.pnlLeft.Controls.Add(this.numPay);
            this.pnlLeft.Controls.Add(this.lblMethod);
            this.pnlLeft.Controls.Add(this.cboMethod);
            this.pnlLeft.Controls.Add(this.lblRef);
            this.pnlLeft.Controls.Add(this.txtRef);
            this.pnlLeft.Controls.Add(this.lblSummary);
            this.pnlLeft.Controls.Add(this.btnGo);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblPlan
            // 
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.AutoSize = true;
            this.lblPlan.Text = "Plan";
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPlan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPlan.Location = new System.Drawing.Point(14, 20);
            this.lblPlan.TabIndex = 0;
            // 
            // cboPlan
            // 
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboPlan.Size = new System.Drawing.Size(280, 25);
            this.cboPlan.Location = new System.Drawing.Point(170, 16);
            this.cboPlan.TabIndex = 1;
            this.cboPlan.SelectedIndexChanged += new System.EventHandler(this.Preview_Changed);
            // 
            // lblDateCaption
            // 
            this.lblDateCaption.Name = "lblDateCaption";
            this.lblDateCaption.AutoSize = true;
            this.lblDateCaption.Text = "Start date";
            this.lblDateCaption.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDateCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDateCaption.Location = new System.Drawing.Point(14, 58);
            this.lblDateCaption.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDate.Size = new System.Drawing.Size(140, 25);
            this.dtpDate.Location = new System.Drawing.Point(170, 54);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.Preview_Changed);
            // 
            // lblDateHint
            // 
            this.lblDateHint.Name = "lblDateHint";
            this.lblDateHint.AutoSize = true;
            this.lblDateHint.Text = "(start date)";
            this.lblDateHint.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDateHint.Font = new System.Drawing.Font("Segoe UI", 9.0F);
            this.lblDateHint.Location = new System.Drawing.Point(320, 60);
            this.lblDateHint.TabIndex = 4;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Text = "Discount (%)";
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiscount.Location = new System.Drawing.Point(14, 96);
            this.lblDiscount.TabIndex = 5;
            // 
            // numDiscount
            // 
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.numDiscount.Maximum = new decimal(new int[] {100, 0, 0, 0});
            this.numDiscount.Value = new decimal(new int[] {0, 0, 0, 0});
            this.numDiscount.DecimalPlaces = 0;
            this.numDiscount.ThousandsSeparator = true;
            this.numDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numDiscount.Size = new System.Drawing.Size(90, 25);
            this.numDiscount.Location = new System.Drawing.Point(170, 92);
            this.numDiscount.TabIndex = 6;
            this.numDiscount.ValueChanged += new System.EventHandler(this.Preview_Changed);
            // 
            // lblPay
            // 
            this.lblPay.Name = "lblPay";
            this.lblPay.AutoSize = true;
            this.lblPay.Text = "Initial payment";
            this.lblPay.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPay.Location = new System.Drawing.Point(14, 134);
            this.lblPay.TabIndex = 7;
            // 
            // numPay
            // 
            this.numPay.Name = "numPay";
            this.numPay.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.numPay.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
            this.numPay.Value = new decimal(new int[] {0, 0, 0, 0});
            this.numPay.DecimalPlaces = 2;
            this.numPay.ThousandsSeparator = true;
            this.numPay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numPay.Size = new System.Drawing.Size(140, 25);
            this.numPay.Location = new System.Drawing.Point(170, 130);
            this.numPay.TabIndex = 8;
            // 
            // lblMethod
            // 
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.AutoSize = true;
            this.lblMethod.Text = "Payment method";
            this.lblMethod.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMethod.Location = new System.Drawing.Point(14, 172);
            this.lblMethod.TabIndex = 9;
            // 
            // cboMethod
            // 
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboMethod.Size = new System.Drawing.Size(160, 25);
            this.cboMethod.Location = new System.Drawing.Point(170, 168);
            this.cboMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card", "Bank Transfer", "Other" });
            this.cboMethod.TabIndex = 10;
            // 
            // lblRef
            // 
            this.lblRef.Name = "lblRef";
            this.lblRef.AutoSize = true;
            this.lblRef.Text = "Reference no.";
            this.lblRef.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblRef.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRef.Location = new System.Drawing.Point(14, 210);
            this.lblRef.TabIndex = 11;
            // 
            // txtRef
            // 
            this.txtRef.Name = "txtRef";
            this.txtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRef.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRef.Size = new System.Drawing.Size(160, 25);
            this.txtRef.Location = new System.Drawing.Point(170, 206);
            this.txtRef.TabIndex = 12;
            // 
            // lblSummary
            // 
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.AutoSize = false;
            this.lblSummary.Text = "";
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(15, 35, 66);
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold);
            this.lblSummary.Size = new System.Drawing.Size(440, 76);
            this.lblSummary.Location = new System.Drawing.Point(14, 252);
            this.lblSummary.TabIndex = 13;
            // 
            // btnGo
            // 
            this.btnGo.Name = "btnGo";
            this.btnGo.Text = "Register Membership";
            this.btnGo.Size = new System.Drawing.Size(220, 40);
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnGo.Location = new System.Drawing.Point(14, 336);
            this.btnGo.TabIndex = 14;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 104;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.pnlTop.Controls.Add(this.rbNew);
            this.pnlTop.Controls.Add(this.rbRenew);
            this.pnlTop.Controls.Add(this.lblMemberSearch);
            this.pnlTop.Controls.Add(this.memberPicker);
            this.pnlTop.TabIndex = 1;
            // 
            // rbNew
            // 
            this.rbNew.Name = "rbNew";
            this.rbNew.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNew.AutoSize = false;
            this.rbNew.Size = new System.Drawing.Size(160, 32);
            this.rbNew.Location = new System.Drawing.Point(0, 0);
            this.rbNew.Text = "New Registration";
            this.rbNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNew.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbNew.TabStop = true;
            this.rbNew.Checked = true;
            this.rbNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 221, 232);
            this.rbNew.TabIndex = 0;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);
            // 
            // rbRenew
            // 
            this.rbRenew.Name = "rbRenew";
            this.rbRenew.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRenew.AutoSize = false;
            this.rbRenew.Size = new System.Drawing.Size(160, 32);
            this.rbRenew.Location = new System.Drawing.Point(170, 0);
            this.rbRenew.Text = "Renew Membership";
            this.rbRenew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRenew.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbRenew.TabStop = true;
            this.rbRenew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 221, 232);
            this.rbRenew.TabIndex = 1;
            this.rbRenew.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);
            // 
            // lblMemberSearch
            // 
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Text = "Member search";
            this.lblMemberSearch.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblMemberSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMemberSearch.Location = new System.Drawing.Point(0, 44);
            this.lblMemberSearch.TabIndex = 2;
            // 
            // memberPicker
            // 
            this.memberPicker.Name = "memberPicker";
            this.memberPicker.Location = new System.Drawing.Point(0, 62);
            this.memberPicker.TabIndex = 3;
            this.memberPicker.MemberChanged += new System.EventHandler(this.memberPicker_MemberChanged);
            // 
            // RegistrationForm
            // 
            this.PageTitle = "Registration & Renewal";
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.contentPanel.Controls.Add(this.pnlBody);
            this.contentPanel.Controls.Add(this.pnlTop);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlGap.ResumeLayout(false);
            this.pnlGap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.cardHistory.ResumeLayout(false);
            this.cardHistory.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
