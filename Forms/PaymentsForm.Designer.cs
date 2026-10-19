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
            pnlBody = new Panel();
            pnlRight = new Panel();
            cardHistory = new Panel();
            dgvHistory = new DataGridView();
            lblHistoryTitle = new Label();
            pnlLeft = new Panel();
            lblInvoiceCap = new Label();
            cboInvoice = new ComboBox();
            lblTotalCap = new Label();
            lblTotal = new Label();
            lblPrevCap = new Label();
            lblPrev = new Label();
            lblAmountCap = new Label();
            numAmount = new NumericUpDown();
            lblMethodCap = new Label();
            cboMethod = new ComboBox();
            lblDateCap = new Label();
            dtpDate = new DateTimePicker();
            lblRefCap = new Label();
            txtRef = new TextBox();
            lblAfterCap = new Label();
            lblAfter = new Label();
            btnPay = new Button();
            pnlTop = new Panel();
            lblMember = new Label();
            memberPicker = new FitZoneGym.Controls.MemberPicker();
            contentPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlRight.SuspendLayout();
            cardHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(pnlBody);
            contentPanel.Controls.Add(pnlTop);
            contentPanel.Size = new Size(1050, 670);
            // 
            // headerPanel
            // 
            headerPanel.Size = new Size(1050, 56);
            // 
            // titleLabel
            // 
            titleLabel.Size = new Size(750, 48);
            titleLabel.Text = "Payments";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(243, 246, 251);
            pnlBody.Controls.Add(pnlRight);
            pnlBody.Controls.Add(pnlLeft);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(16, 82);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1018, 572);
            pnlBody.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(243, 246, 251);
            pnlRight.Controls.Add(cardHistory);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(530, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(12, 0, 0, 0);
            pnlRight.Size = new Size(488, 572);
            pnlRight.TabIndex = 0;
            // 
            // cardHistory
            // 
            cardHistory.BackColor = Color.White;
            cardHistory.Controls.Add(dgvHistory);
            cardHistory.Controls.Add(lblHistoryTitle);
            cardHistory.Dock = DockStyle.Fill;
            cardHistory.Location = new Point(12, 0);
            cardHistory.Name = "cardHistory";
            cardHistory.Padding = new Padding(14);
            cardHistory.Size = new Size(476, 572);
            cardHistory.TabIndex = 0;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeight = 34;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(14, 44);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.Size = new Size(448, 514);
            dgvHistory.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.Dock = DockStyle.Top;
            lblHistoryTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(15, 35, 66);
            lblHistoryTitle.Location = new Point(14, 14);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(448, 30);
            lblHistoryTitle.TabIndex = 1;
            lblHistoryTitle.Text = "Payment History (selected invoice)";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(lblInvoiceCap);
            pnlLeft.Controls.Add(cboInvoice);
            pnlLeft.Controls.Add(lblTotalCap);
            pnlLeft.Controls.Add(lblTotal);
            pnlLeft.Controls.Add(lblPrevCap);
            pnlLeft.Controls.Add(lblPrev);
            pnlLeft.Controls.Add(lblAmountCap);
            pnlLeft.Controls.Add(numAmount);
            pnlLeft.Controls.Add(lblMethodCap);
            pnlLeft.Controls.Add(cboMethod);
            pnlLeft.Controls.Add(lblDateCap);
            pnlLeft.Controls.Add(dtpDate);
            pnlLeft.Controls.Add(lblRefCap);
            pnlLeft.Controls.Add(txtRef);
            pnlLeft.Controls.Add(lblAfterCap);
            pnlLeft.Controls.Add(lblAfter);
            pnlLeft.Controls.Add(btnPay);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(530, 572);
            pnlLeft.TabIndex = 1;
            // 
            // lblInvoiceCap
            // 
            lblInvoiceCap.AutoSize = true;
            lblInvoiceCap.Font = new Font("Segoe UI", 9.5F);
            lblInvoiceCap.ForeColor = Color.FromArgb(31, 41, 55);
            lblInvoiceCap.Location = new Point(16, 24);
            lblInvoiceCap.Name = "lblInvoiceCap";
            lblInvoiceCap.Size = new Size(72, 25);
            lblInvoiceCap.TabIndex = 0;
            lblInvoiceCap.Text = "Invoice";
            // 
            // cboInvoice
            // 
            cboInvoice.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInvoice.FlatStyle = FlatStyle.Flat;
            cboInvoice.Font = new Font("Segoe UI", 9.5F);
            cboInvoice.Location = new Point(170, 20);
            cboInvoice.Name = "cboInvoice";
            cboInvoice.Size = new Size(330, 33);
            cboInvoice.TabIndex = 1;
            cboInvoice.SelectedIndexChanged += cboInvoice_SelectedIndexChanged;
            // 
            // lblTotalCap
            // 
            lblTotalCap.AutoSize = true;
            lblTotalCap.Font = new Font("Segoe UI", 9.5F);
            lblTotalCap.ForeColor = Color.FromArgb(31, 41, 55);
            lblTotalCap.Location = new Point(16, 62);
            lblTotalCap.Name = "lblTotalCap";
            lblTotalCap.Size = new Size(122, 25);
            lblTotalCap.TabIndex = 2;
            lblTotalCap.Text = "Total amount";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(31, 41, 55);
            lblTotal.Location = new Point(170, 62);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(21, 30);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "-";
            // 
            // lblPrevCap
            // 
            lblPrevCap.AutoSize = true;
            lblPrevCap.Font = new Font("Segoe UI", 9.5F);
            lblPrevCap.ForeColor = Color.FromArgb(31, 41, 55);
            lblPrevCap.Location = new Point(16, 94);
            lblPrevCap.Name = "lblPrevCap";
            lblPrevCap.Size = new Size(155, 25);
            lblPrevCap.TabIndex = 4;
            lblPrevCap.Text = "Previous balance";
            // 
            // lblPrev
            // 
            lblPrev.AutoSize = true;
            lblPrev.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblPrev.ForeColor = Color.FromArgb(31, 41, 55);
            lblPrev.Location = new Point(170, 94);
            lblPrev.Name = "lblPrev";
            lblPrev.Size = new Size(21, 30);
            lblPrev.TabIndex = 5;
            lblPrev.Text = "-";
            // 
            // lblAmountCap
            // 
            lblAmountCap.AutoSize = true;
            lblAmountCap.Font = new Font("Segoe UI", 9.5F);
            lblAmountCap.ForeColor = Color.FromArgb(31, 41, 55);
            lblAmountCap.Location = new Point(16, 128);
            lblAmountCap.Name = "lblAmountCap";
            lblAmountCap.Size = new Size(154, 25);
            lblAmountCap.TabIndex = 6;
            lblAmountCap.Text = "Payment amount";
            // 
            // numAmount
            // 
            numAmount.DecimalPlaces = 2;
            numAmount.Font = new Font("Segoe UI", 9.5F);
            numAmount.Location = new Point(170, 124);
            numAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(160, 33);
            numAmount.TabIndex = 7;
            numAmount.ThousandsSeparator = true;
            numAmount.ValueChanged += numAmount_ValueChanged;
            // 
            // lblMethodCap
            // 
            lblMethodCap.AutoSize = true;
            lblMethodCap.Font = new Font("Segoe UI", 9.5F);
            lblMethodCap.ForeColor = Color.FromArgb(31, 41, 55);
            lblMethodCap.Location = new Point(16, 166);
            lblMethodCap.Name = "lblMethodCap";
            lblMethodCap.Size = new Size(154, 25);
            lblMethodCap.TabIndex = 8;
            lblMethodCap.Text = "Payment method";
            // 
            // cboMethod
            // 
            cboMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMethod.FlatStyle = FlatStyle.Flat;
            cboMethod.Font = new Font("Segoe UI", 9.5F);
            cboMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card", "Bank Transfer", "Other" });
            cboMethod.Location = new Point(170, 162);
            cboMethod.Name = "cboMethod";
            cboMethod.Size = new Size(180, 33);
            cboMethod.TabIndex = 9;
            // 
            // lblDateCap
            // 
            lblDateCap.AutoSize = true;
            lblDateCap.Font = new Font("Segoe UI", 9.5F);
            lblDateCap.ForeColor = Color.FromArgb(31, 41, 55);
            lblDateCap.Location = new Point(16, 204);
            lblDateCap.Name = "lblDateCap";
            lblDateCap.Size = new Size(126, 25);
            lblDateCap.TabIndex = 10;
            lblDateCap.Text = "Payment date";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 9.5F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(170, 200);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(160, 33);
            dtpDate.TabIndex = 11;
            // 
            // lblRefCap
            // 
            lblRefCap.AutoSize = true;
            lblRefCap.Font = new Font("Segoe UI", 9.5F);
            lblRefCap.ForeColor = Color.FromArgb(31, 41, 55);
            lblRefCap.Location = new Point(16, 242);
            lblRefCap.Name = "lblRefCap";
            lblRefCap.Size = new Size(126, 25);
            lblRefCap.TabIndex = 12;
            lblRefCap.Text = "Reference no.";
            // 
            // txtRef
            // 
            txtRef.BorderStyle = BorderStyle.FixedSingle;
            txtRef.Font = new Font("Segoe UI", 9.5F);
            txtRef.Location = new Point(170, 238);
            txtRef.Name = "txtRef";
            txtRef.Size = new Size(220, 33);
            txtRef.TabIndex = 13;
            // 
            // lblAfterCap
            // 
            lblAfterCap.AutoSize = true;
            lblAfterCap.Font = new Font("Segoe UI", 9.5F);
            lblAfterCap.ForeColor = Color.FromArgb(31, 41, 55);
            lblAfterCap.Location = new Point(16, 282);
            lblAfterCap.Name = "lblAfterCap";
            lblAfterCap.Size = new Size(172, 25);
            lblAfterCap.TabIndex = 14;
            lblAfterCap.Text = "Remaining balance";
            // 
            // lblAfter
            // 
            lblAfter.AutoSize = true;
            lblAfter.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblAfter.ForeColor = Color.FromArgb(30, 111, 240);
            lblAfter.Location = new Point(170, 282);
            lblAfter.Name = "lblAfter";
            lblAfter.Size = new Size(21, 30);
            lblAfter.TabIndex = 15;
            lblAfter.Text = "-";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(22, 163, 74);
            btnPay.Cursor = Cursors.Hand;
            btnPay.Enabled = false;
            btnPay.FlatAppearance.BorderColor = Color.FromArgb(22, 163, 74);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(170, 322);
            btnPay.Margin = new Padding(0, 0, 8, 0);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(200, 40);
            btnPay.TabIndex = 16;
            btnPay.Text = "Process Payment";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(243, 246, 251);
            pnlTop.Controls.Add(lblMember);
            pnlTop.Controls.Add(memberPicker);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(16, 16);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1018, 66);
            pnlTop.TabIndex = 1;
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Font = new Font("Segoe UI", 8.5F);
            lblMember.ForeColor = Color.FromArgb(107, 114, 128);
            lblMember.Location = new Point(0, 0);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(128, 23);
            lblMember.TabIndex = 0;
            lblMember.Text = "Member search";
            // 
            // memberPicker
            // 
            memberPicker.AutoSize = true;
            memberPicker.BackColor = Color.Transparent;
            memberPicker.Location = new Point(0, 20);
            memberPicker.Name = "memberPicker";
            memberPicker.Size = new Size(714, 100);
            memberPicker.TabIndex = 1;
            memberPicker.WrapContents = false;
            memberPicker.MemberChanged += memberPicker_MemberChanged;
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            ClientSize = new Size(1280, 760);
            Name = "PaymentsForm";
            PageTitle = "Payments";
            Text = "GYMORA - Payments";
            contentPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            cardHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
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
