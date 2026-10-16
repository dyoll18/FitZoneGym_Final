namespace FitZoneGym.Forms
{
    partial class PaymentsForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblInvoiceCap = new System.Windows.Forms.Label();
            this.cboInvoice = new System.Windows.Forms.ComboBox();
            this.lblTotalCap = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrevCap = new System.Windows.Forms.Label();
            this.lblPrev = new System.Windows.Forms.Label();
            this.lblAmountCap = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.lblMethodCap = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.lblDateCap = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblRefCap = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblAfterCap = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMember = new System.Windows.Forms.Label();
            this.memberPicker = new FitZoneGym.Controls.MemberPicker();
            this.pnlBody.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.cardHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
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
            this.lblHistoryTitle.Text = "Payment History (selected invoice)";
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(15, 35, 66);
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.Size = new System.Drawing.Size(100, 30);
            this.lblHistoryTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistoryTitle.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 530;
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.lblInvoiceCap);
            this.pnlLeft.Controls.Add(this.cboInvoice);
            this.pnlLeft.Controls.Add(this.lblTotalCap);
            this.pnlLeft.Controls.Add(this.lblTotal);
            this.pnlLeft.Controls.Add(this.lblPrevCap);
            this.pnlLeft.Controls.Add(this.lblPrev);
            this.pnlLeft.Controls.Add(this.lblAmountCap);
            this.pnlLeft.Controls.Add(this.numAmount);
            this.pnlLeft.Controls.Add(this.lblMethodCap);
            this.pnlLeft.Controls.Add(this.cboMethod);
            this.pnlLeft.Controls.Add(this.lblDateCap);
            this.pnlLeft.Controls.Add(this.dtpDate);
            this.pnlLeft.Controls.Add(this.lblRefCap);
            this.pnlLeft.Controls.Add(this.txtRef);
            this.pnlLeft.Controls.Add(this.lblAfterCap);
            this.pnlLeft.Controls.Add(this.lblAfter);
            this.pnlLeft.Controls.Add(this.btnPay);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblInvoiceCap
            // 
            this.lblInvoiceCap.Name = "lblInvoiceCap";
            this.lblInvoiceCap.AutoSize = true;
            this.lblInvoiceCap.Text = "Invoice";
            this.lblInvoiceCap.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblInvoiceCap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInvoiceCap.Location = new System.Drawing.Point(16, 24);
            this.lblInvoiceCap.TabIndex = 0;
            // 
            // cboInvoice
            // 
            this.cboInvoice.Name = "cboInvoice";
            this.cboInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboInvoice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboInvoice.Size = new System.Drawing.Size(330, 25);
            this.cboInvoice.Location = new System.Drawing.Point(170, 20);
            this.cboInvoice.TabIndex = 1;
            this.cboInvoice.SelectedIndexChanged += new System.EventHandler(this.cboInvoice_SelectedIndexChanged);
            // 
            // lblTotalCap
            // 
            this.lblTotalCap.Name = "lblTotalCap";
            this.lblTotalCap.AutoSize = true;
            this.lblTotalCap.Text = "Total amount";
            this.lblTotalCap.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTotalCap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTotalCap.Location = new System.Drawing.Point(16, 62);
            this.lblTotalCap.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.AutoSize = true;
            this.lblTotal.Text = "-";
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(170, 62);
            this.lblTotal.TabIndex = 3;
            // 
            // lblPrevCap
            // 
            this.lblPrevCap.Name = "lblPrevCap";
            this.lblPrevCap.AutoSize = true;
            this.lblPrevCap.Text = "Previous balance";
            this.lblPrevCap.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPrevCap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPrevCap.Location = new System.Drawing.Point(16, 94);
            this.lblPrevCap.TabIndex = 4;
            // 
            // lblPrev
            // 
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.AutoSize = true;
            this.lblPrev.Text = "-";
            this.lblPrev.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPrev.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPrev.Location = new System.Drawing.Point(170, 94);
            this.lblPrev.TabIndex = 5;
            // 
            // lblAmountCap
            // 
            this.lblAmountCap.Name = "lblAmountCap";
            this.lblAmountCap.AutoSize = true;
            this.lblAmountCap.Text = "Payment amount";
            this.lblAmountCap.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblAmountCap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAmountCap.Location = new System.Drawing.Point(16, 128);
            this.lblAmountCap.TabIndex = 6;
            // 
            // numAmount
            // 
            this.numAmount.Name = "numAmount";
            this.numAmount.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.numAmount.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
            this.numAmount.Value = new decimal(new int[] {0, 0, 0, 0});
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.ThousandsSeparator = true;
            this.numAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numAmount.Size = new System.Drawing.Size(160, 25);
            this.numAmount.Location = new System.Drawing.Point(170, 124);
            this.numAmount.TabIndex = 7;
            this.numAmount.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            // 
            // lblMethodCap
            // 
            this.lblMethodCap.Name = "lblMethodCap";
            this.lblMethodCap.AutoSize = true;
            this.lblMethodCap.Text = "Payment method";
            this.lblMethodCap.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblMethodCap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMethodCap.Location = new System.Drawing.Point(16, 166);
            this.lblMethodCap.TabIndex = 8;
            // 
            // cboMethod
            // 
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboMethod.Size = new System.Drawing.Size(180, 25);
            this.cboMethod.Location = new System.Drawing.Point(170, 162);
            this.cboMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card", "Bank Transfer", "Other" });
            this.cboMethod.TabIndex = 9;
            // 
            // lblDateCap
            // 
            this.lblDateCap.Name = "lblDateCap";
            this.lblDateCap.AutoSize = true;
            this.lblDateCap.Text = "Payment date";
            this.lblDateCap.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDateCap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDateCap.Location = new System.Drawing.Point(16, 204);
            this.lblDateCap.TabIndex = 10;
            // 
            // dtpDate
            // 
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDate.Size = new System.Drawing.Size(160, 25);
            this.dtpDate.Location = new System.Drawing.Point(170, 200);
            this.dtpDate.TabIndex = 11;
            // 
            // lblRefCap
            // 
            this.lblRefCap.Name = "lblRefCap";
            this.lblRefCap.AutoSize = true;
            this.lblRefCap.Text = "Reference no.";
            this.lblRefCap.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblRefCap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRefCap.Location = new System.Drawing.Point(16, 242);
            this.lblRefCap.TabIndex = 12;
            // 
            // txtRef
            // 
            this.txtRef.Name = "txtRef";
            this.txtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRef.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRef.Size = new System.Drawing.Size(220, 25);
            this.txtRef.Location = new System.Drawing.Point(170, 238);
            this.txtRef.TabIndex = 13;
            // 
            // lblAfterCap
            // 
            this.lblAfterCap.Name = "lblAfterCap";
            this.lblAfterCap.AutoSize = true;
            this.lblAfterCap.Text = "Remaining balance";
            this.lblAfterCap.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblAfterCap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAfterCap.Location = new System.Drawing.Point(16, 282);
            this.lblAfterCap.TabIndex = 14;
            // 
            // lblAfter
            // 
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.AutoSize = true;
            this.lblAfter.Text = "-";
            this.lblAfter.ForeColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.lblAfter.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblAfter.Location = new System.Drawing.Point(170, 282);
            this.lblAfter.TabIndex = 15;
            // 
            // btnPay
            // 
            this.btnPay.Name = "btnPay";
            this.btnPay.Text = "Process Payment";
            this.btnPay.Size = new System.Drawing.Size(200, 40);
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnPay.Location = new System.Drawing.Point(170, 322);
            this.btnPay.Enabled = false;
            this.btnPay.TabIndex = 16;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 66;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.pnlTop.Controls.Add(this.lblMember);
            this.pnlTop.Controls.Add(this.memberPicker);
            this.pnlTop.TabIndex = 1;
            // 
            // lblMember
            // 
            this.lblMember.Name = "lblMember";
            this.lblMember.AutoSize = true;
            this.lblMember.Text = "Member search";
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMember.Location = new System.Drawing.Point(0, 0);
            this.lblMember.TabIndex = 0;
            // 
            // memberPicker
            // 
            this.memberPicker.Name = "memberPicker";
            this.memberPicker.Location = new System.Drawing.Point(0, 20);
            this.memberPicker.TabIndex = 1;
            this.memberPicker.MemberChanged += new System.EventHandler(this.memberPicker_MemberChanged);
            // 
            // PaymentsForm
            // 
            this.PageTitle = "Payments";
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.contentPanel.Controls.Add(this.pnlBody);
            this.contentPanel.Controls.Add(this.pnlTop);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
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
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblInvoiceCap;
        private System.Windows.Forms.ComboBox cboInvoice;
        private System.Windows.Forms.Label lblTotalCap;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrevCap;
        private System.Windows.Forms.Label lblPrev;
        private System.Windows.Forms.Label lblAmountCap;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblMethodCap;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label lblDateCap;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblRefCap;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblAfterCap;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMember;
        private FitZoneGym.Controls.MemberPicker memberPicker;
    }
}
