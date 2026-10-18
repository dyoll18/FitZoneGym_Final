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

        /// <summary>Designer generated.</summary>
        private void InitializeComponent()
        {
            this.bodyLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblMember = new System.Windows.Forms.Label();
            this.memberPicker = new FitZoneGym.Controls.MemberPicker();
            this.mainRow = new System.Windows.Forms.TableLayoutPanel();
            this.leftCard = new FitZoneGym.Controls.CardPanel();
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
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
            this.historyCard = new FitZoneGym.Controls.CardPanel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.bodyLayout.SuspendLayout();
            this.topLayout.SuspendLayout();
            this.mainRow.SuspendLayout();
            this.leftCard.SuspendLayout();
            this.formLayout.SuspendLayout();
            this.historyCard.SuspendLayout();
            this.SuspendLayout();
            this.contentPanel.SuspendLayout();
            // 
            // bodyLayout
            // 
            this.bodyLayout.ColumnCount = 1;
            this.bodyLayout.RowCount = 2;
            this.bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyLayout.Controls.Add(this.topLayout, 0, 0);
            this.bodyLayout.Controls.Add(this.mainRow, 0, 1);
            this.bodyLayout.Name = "bodyLayout";
            this.bodyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.bodyLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.bodyLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // topLayout
            // 
            this.topLayout.ColumnCount = 1;
            this.topLayout.RowCount = 2;
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.topLayout.Controls.Add(this.lblMember, 0, 0);
            this.topLayout.Controls.Add(this.memberPicker, 0, 1);
            this.topLayout.Name = "topLayout";
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.topLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.topLayout.AutoSize = true;
            this.topLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblMember
            // 
            this.lblMember.Name = "lblMember";
            this.lblMember.AutoSize = true;
            this.lblMember.Text = "MEMBER SEARCH";
            this.lblMember.Tag = "caption";
            this.lblMember.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMember.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // memberPicker
            // 
            this.memberPicker.Name = "memberPicker";
            this.memberPicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.memberPicker.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.memberPicker.MemberChanged += this.memberPicker_MemberChanged;
            // 
            // mainRow
            // 
            this.mainRow.ColumnCount = 2;
            this.mainRow.RowCount = 1;
            this.mainRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 520F));
            this.mainRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainRow.Controls.Add(this.leftCard, 0, 0);
            this.mainRow.Controls.Add(this.historyCard, 1, 0);
            this.mainRow.Name = "mainRow";
            this.mainRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainRow.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainRow.BackColor = System.Drawing.Color.Transparent;
            // 
            // leftCard
            // 
            this.leftCard.Controls.Add(this.formLayout);
            this.leftCard.Name = "leftCard";
            this.leftCard.Tag = "card";
            this.leftCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftCard.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.leftCard.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.leftCard.AutoScroll = true;
            this.leftCard.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // formLayout
            // 
            this.formLayout.ColumnCount = 2;
            this.formLayout.RowCount = 9;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.Controls.Add(this.lblInvoiceCap, 0, 0);
            this.formLayout.Controls.Add(this.cboInvoice, 1, 0);
            this.formLayout.Controls.Add(this.lblTotalCap, 0, 1);
            this.formLayout.Controls.Add(this.lblTotal, 1, 1);
            this.formLayout.Controls.Add(this.lblPrevCap, 0, 2);
            this.formLayout.Controls.Add(this.lblPrev, 1, 2);
            this.formLayout.Controls.Add(this.lblAmountCap, 0, 3);
            this.formLayout.Controls.Add(this.numAmount, 1, 3);
            this.formLayout.Controls.Add(this.lblMethodCap, 0, 4);
            this.formLayout.Controls.Add(this.cboMethod, 1, 4);
            this.formLayout.Controls.Add(this.lblDateCap, 0, 5);
            this.formLayout.Controls.Add(this.dtpDate, 1, 5);
            this.formLayout.Controls.Add(this.lblRefCap, 0, 6);
            this.formLayout.Controls.Add(this.txtRef, 1, 6);
            this.formLayout.Controls.Add(this.lblAfterCap, 0, 7);
            this.formLayout.Controls.Add(this.lblAfter, 1, 7);
            this.formLayout.Controls.Add(this.btnPay, 0, 8);
            this.formLayout.SetColumnSpan(this.btnPay, 2);
            this.formLayout.Name = "formLayout";
            this.formLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.formLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.formLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.formLayout.AutoSize = true;
            this.formLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblInvoiceCap
            // 
            this.lblInvoiceCap.Name = "lblInvoiceCap";
            this.lblInvoiceCap.AutoSize = true;
            this.lblInvoiceCap.Text = "Invoice";
            this.lblInvoiceCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInvoiceCap.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblInvoiceCap.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // cboInvoice
            // 
            this.cboInvoice.Name = "cboInvoice";
            this.cboInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoice.FormattingEnabled = true;
            this.cboInvoice.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboInvoice.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cboInvoice.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.cboInvoice.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.cboInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboInvoice.SelectedIndexChanged += this.cboInvoice_SelectedIndexChanged;
            // 
            // lblTotalCap
            // 
            this.lblTotalCap.Name = "lblTotalCap";
            this.lblTotalCap.AutoSize = true;
            this.lblTotalCap.Text = "Total amount";
            this.lblTotalCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalCap.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblTotalCap.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.AutoSize = true;
            this.lblTotal.Text = "-";
            this.lblTotal.Tag = "money";
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblTotal.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblPrevCap
            // 
            this.lblPrevCap.Name = "lblPrevCap";
            this.lblPrevCap.AutoSize = true;
            this.lblPrevCap.Text = "Previous balance";
            this.lblPrevCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrevCap.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblPrevCap.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblPrev
            // 
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.AutoSize = true;
            this.lblPrev.Text = "-";
            this.lblPrev.Tag = "money";
            this.lblPrev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrev.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblPrev.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrev.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblAmountCap
            // 
            this.lblAmountCap.Name = "lblAmountCap";
            this.lblAmountCap.AutoSize = true;
            this.lblAmountCap.Text = "Payment amount";
            this.lblAmountCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmountCap.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblAmountCap.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // numAmount
            // 
            this.numAmount.Name = "numAmount";
            this.numAmount.Minimum = 0M;
            this.numAmount.Maximum = 10000000M;
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.ThousandsSeparator = true;
            this.numAmount.Size = new System.Drawing.Size(150, 27);
            this.numAmount.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.numAmount.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.numAmount.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.numAmount.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.numAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAmount.ValueChanged += this.numAmount_ValueChanged;
            // 
            // lblMethodCap
            // 
            this.lblMethodCap.Name = "lblMethodCap";
            this.lblMethodCap.AutoSize = true;
            this.lblMethodCap.Text = "Payment method";
            this.lblMethodCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMethodCap.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblMethodCap.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // cboMethod
            // 
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethod.FormattingEnabled = true;
            this.cboMethod.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboMethod.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cboMethod.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.cboMethod.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.cboMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card", "Bank Transfer", "Other" });
            // 
            // lblDateCap
            // 
            this.lblDateCap.Name = "lblDateCap";
            this.lblDateCap.AutoSize = true;
            this.lblDateCap.Text = "Payment date";
            this.lblDateCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateCap.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblDateCap.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // dtpDate
            // 
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Size = new System.Drawing.Size(160, 27);
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpDate.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(36, 36, 43);
            this.dtpDate.CalendarForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dtpDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // lblRefCap
            // 
            this.lblRefCap.Name = "lblRefCap";
            this.lblRefCap.AutoSize = true;
            this.lblRefCap.Text = "Reference no.";
            this.lblRefCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRefCap.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblRefCap.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // txtRef
            // 
            this.txtRef.Name = "txtRef";
            this.txtRef.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtRef.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtRef.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.txtRef.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.txtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblAfterCap
            // 
            this.lblAfterCap.Name = "lblAfterCap";
            this.lblAfterCap.AutoSize = true;
            this.lblAfterCap.Text = "Remaining balance";
            this.lblAfterCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAfterCap.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblAfterCap.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblAfter
            // 
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.AutoSize = true;
            this.lblAfter.Text = "-";
            this.lblAfter.Tag = "money";
            this.lblAfter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAfter.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblAfter.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.lblAfter.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // btnPay
            // 
            this.btnPay.Name = "btnPay";
            this.btnPay.Text = "Process Payment";
            this.btnPay.Size = new System.Drawing.Size(100, 44);
            this.btnPay.Tag = "success";
            this.btnPay.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.Enabled = false;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPay.FlatAppearance.BorderSize = 1;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnPay.Click += this.btnPay_Click;
            // 
            // historyCard
            // 
            this.historyCard.Controls.Add(this.dgvHistory);
            this.historyCard.Controls.Add(this.lblHistoryTitle);
            this.historyCard.Name = "historyCard";
            this.historyCard.Tag = "card";
            this.historyCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyCard.Padding = new System.Windows.Forms.Padding(18, 14, 18, 14);
            this.historyCard.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // dgvHistory
            // 
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.DataGridViewCellStyle dgvHistoryHead = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHistoryHead.BackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvHistoryHead.ForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvHistoryHead.SelectionBackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvHistoryHead.SelectionForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvHistoryHead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHistoryHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            System.Windows.Forms.DataGridViewCellStyle dgvHistoryCell = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHistoryCell.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            dgvHistoryCell.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvHistoryCell.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvHistoryCell.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            System.Windows.Forms.DataGridViewCellStyle dgvHistoryAlt = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHistoryAlt.BackColor = System.Drawing.Color.FromArgb(29, 29, 35);
            dgvHistoryAlt.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvHistoryAlt.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvHistoryAlt.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvHistory.EnableHeadersVisualStyles = false;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dgvHistoryHead;
            this.dgvHistory.DefaultCellStyle = dgvHistoryCell;
            this.dgvHistory.AlternatingRowsDefaultCellStyle = dgvHistoryAlt;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 29);
            this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(44, 44, 52);
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.AutoSize = false;
            this.lblHistoryTitle.Size = new System.Drawing.Size(100, 32);
            this.lblHistoryTitle.Text = "Payment History (selected invoice)";
            this.lblHistoryTitle.Tag = "h2";
            this.lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Bahnschrift", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // PaymentsForm
            // 
            this.contentPanel.Controls.Add(this.bodyLayout);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BackColor = System.Drawing.Color.FromArgb(14, 14, 17);
            this.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Name = "PaymentsForm";
            this.PageTitle = "Payments";
            this.Text = "FITZONE GYM - Payments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.historyCard.ResumeLayout(false);
            this.formLayout.ResumeLayout(false);
            this.formLayout.PerformLayout();
            this.leftCard.ResumeLayout(false);
            this.mainRow.ResumeLayout(false);
            this.topLayout.ResumeLayout(false);
            this.topLayout.PerformLayout();
            this.bodyLayout.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel bodyLayout;
        private System.Windows.Forms.TableLayoutPanel topLayout;
        private System.Windows.Forms.Label lblMember;
        private FitZoneGym.Controls.MemberPicker memberPicker;
        private System.Windows.Forms.TableLayoutPanel mainRow;
        private FitZoneGym.Controls.CardPanel leftCard;
        private System.Windows.Forms.TableLayoutPanel formLayout;
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
        private FitZoneGym.Controls.CardPanel historyCard;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblHistoryTitle;
    }
}
