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

        /// <summary>Designer generated.</summary>
        private void InitializeComponent()
        {
            this.bodyLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topLayout = new System.Windows.Forms.TableLayoutPanel();
            this.modeFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbRenew = new System.Windows.Forms.RadioButton();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.memberPicker = new FitZoneGym.Controls.MemberPicker();
            this.mainRow = new System.Windows.Forms.TableLayoutPanel();
            this.leftCard = new FitZoneGym.Controls.CardPanel();
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblDateCaption = new System.Windows.Forms.Label();
            this.dateRow = new System.Windows.Forms.TableLayoutPanel();
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
            this.rightColumn = new System.Windows.Forms.TableLayoutPanel();
            this.infoCard = new FitZoneGym.Controls.CardPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.historyCard = new FitZoneGym.Controls.CardPanel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.bodyLayout.SuspendLayout();
            this.topLayout.SuspendLayout();
            this.modeFlow.SuspendLayout();
            this.mainRow.SuspendLayout();
            this.leftCard.SuspendLayout();
            this.formLayout.SuspendLayout();
            this.dateRow.SuspendLayout();
            this.rightColumn.SuspendLayout();
            this.infoCard.SuspendLayout();
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
            this.topLayout.RowCount = 3;
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.topLayout.Controls.Add(this.modeFlow, 0, 0);
            this.topLayout.Controls.Add(this.lblMemberSearch, 0, 1);
            this.topLayout.Controls.Add(this.memberPicker, 0, 2);
            this.topLayout.Name = "topLayout";
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.topLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.topLayout.AutoSize = true;
            this.topLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // modeFlow
            // 
            this.modeFlow.Controls.Add(this.rbNew);
            this.modeFlow.Controls.Add(this.rbRenew);
            this.modeFlow.Name = "modeFlow";
            this.modeFlow.AutoSize = true;
            this.modeFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modeFlow.WrapContents = false;
            this.modeFlow.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.modeFlow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.modeFlow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modeFlow.BackColor = System.Drawing.Color.Transparent;
            // 
            // rbNew
            // 
            this.rbNew.Name = "rbNew";
            this.rbNew.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNew.AutoSize = false;
            this.rbNew.Size = new System.Drawing.Size(180, 38);
            this.rbNew.Text = "New Registration";
            this.rbNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNew.TabStop = true;
            this.rbNew.Checked = true;
            this.rbNew.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.rbNew.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            this.rbNew.BackColor = System.Drawing.Color.FromArgb(36, 36, 43);
            this.rbNew.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.rbNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(54, 54, 63);
            this.rbNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.rbNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 59);
            this.rbNew.CheckedChanged += this.rbMode_CheckedChanged;
            // 
            // rbRenew
            // 
            this.rbRenew.Name = "rbRenew";
            this.rbRenew.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRenew.AutoSize = false;
            this.rbRenew.Size = new System.Drawing.Size(180, 38);
            this.rbRenew.Text = "Renew Membership";
            this.rbRenew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRenew.TabStop = true;
            this.rbRenew.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.rbRenew.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            this.rbRenew.BackColor = System.Drawing.Color.FromArgb(36, 36, 43);
            this.rbRenew.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.rbRenew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRenew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(54, 54, 63);
            this.rbRenew.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.rbRenew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 59);
            this.rbRenew.CheckedChanged += this.rbMode_CheckedChanged;
            // 
            // lblMemberSearch
            // 
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Text = "MEMBER SEARCH";
            this.lblMemberSearch.Tag = "caption";
            this.lblMemberSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMemberSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblMemberSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMemberSearch.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
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
            this.mainRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.mainRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainRow.Controls.Add(this.leftCard, 0, 0);
            this.mainRow.Controls.Add(this.rightColumn, 1, 0);
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
            this.formLayout.RowCount = 8;
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
            this.formLayout.Controls.Add(this.lblPlan, 0, 0);
            this.formLayout.Controls.Add(this.cboPlan, 1, 0);
            this.formLayout.Controls.Add(this.lblDateCaption, 0, 1);
            this.formLayout.Controls.Add(this.dateRow, 1, 1);
            this.formLayout.Controls.Add(this.lblDiscount, 0, 2);
            this.formLayout.Controls.Add(this.numDiscount, 1, 2);
            this.formLayout.Controls.Add(this.lblPay, 0, 3);
            this.formLayout.Controls.Add(this.numPay, 1, 3);
            this.formLayout.Controls.Add(this.lblMethod, 0, 4);
            this.formLayout.Controls.Add(this.cboMethod, 1, 4);
            this.formLayout.Controls.Add(this.lblRef, 0, 5);
            this.formLayout.Controls.Add(this.txtRef, 1, 5);
            this.formLayout.Controls.Add(this.lblSummary, 0, 6);
            this.formLayout.SetColumnSpan(this.lblSummary, 2);
            this.formLayout.Controls.Add(this.btnGo, 0, 7);
            this.formLayout.SetColumnSpan(this.btnGo, 2);
            this.formLayout.Name = "formLayout";
            this.formLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.formLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.formLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.formLayout.AutoSize = true;
            this.formLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblPlan
            // 
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.AutoSize = true;
            this.lblPlan.Text = "Plan";
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlan.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // cboPlan
            // 
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboPlan.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cboPlan.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.cboPlan.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.cboPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlan.SelectedIndexChanged += this.Preview_Changed;
            // 
            // lblDateCaption
            // 
            this.lblDateCaption.Name = "lblDateCaption";
            this.lblDateCaption.AutoSize = true;
            this.lblDateCaption.Text = "Start date";
            this.lblDateCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateCaption.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblDateCaption.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // dateRow
            // 
            this.dateRow.ColumnCount = 2;
            this.dateRow.RowCount = 1;
            this.dateRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dateRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.dateRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.dateRow.Controls.Add(this.dtpDate, 0, 0);
            this.dateRow.Controls.Add(this.lblDateHint, 1, 0);
            this.dateRow.Name = "dateRow";
            this.dateRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateRow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.dateRow.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.dateRow.AutoSize = true;
            this.dateRow.BackColor = System.Drawing.Color.Transparent;
            // 
            // dtpDate
            // 
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Size = new System.Drawing.Size(160, 27);
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpDate.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(36, 36, 43);
            this.dtpDate.CalendarForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dtpDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            this.dtpDate.ValueChanged += this.Preview_Changed;
            // 
            // lblDateHint
            // 
            this.lblDateHint.Name = "lblDateHint";
            this.lblDateHint.AutoSize = true;
            this.lblDateHint.Text = "(start date)";
            this.lblDateHint.Tag = "muted";
            this.lblDateHint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateHint.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblDateHint.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Text = "Discount (%)";
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // numDiscount
            // 
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Minimum = 0M;
            this.numDiscount.Maximum = 100M;
            this.numDiscount.DecimalPlaces = 0;
            this.numDiscount.ThousandsSeparator = true;
            this.numDiscount.Size = new System.Drawing.Size(150, 27);
            this.numDiscount.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.numDiscount.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.numDiscount.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.numDiscount.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.numDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDiscount.ValueChanged += this.Preview_Changed;
            // 
            // lblPay
            // 
            this.lblPay.Name = "lblPay";
            this.lblPay.AutoSize = true;
            this.lblPay.Text = "Initial payment";
            this.lblPay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPay.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblPay.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // numPay
            // 
            this.numPay.Name = "numPay";
            this.numPay.Minimum = 0M;
            this.numPay.Maximum = 10000000M;
            this.numPay.DecimalPlaces = 2;
            this.numPay.ThousandsSeparator = true;
            this.numPay.Size = new System.Drawing.Size(150, 27);
            this.numPay.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.numPay.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.numPay.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.numPay.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.numPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblMethod
            // 
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.AutoSize = true;
            this.lblMethod.Text = "Payment method";
            this.lblMethod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMethod.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblMethod.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
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
            // lblRef
            // 
            this.lblRef.Name = "lblRef";
            this.lblRef.AutoSize = true;
            this.lblRef.Text = "Reference no.";
            this.lblRef.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRef.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblRef.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
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
            // lblSummary
            // 
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.AutoSize = false;
            this.lblSummary.Size = new System.Drawing.Size(100, 92);
            this.lblSummary.Text = "";
            this.lblSummary.Tag = "summary";
            this.lblSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSummary.Margin = new System.Windows.Forms.Padding(0, 12, 0, 8);
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // btnGo
            // 
            this.btnGo.Name = "btnGo";
            this.btnGo.Text = "Register Membership";
            this.btnGo.Size = new System.Drawing.Size(100, 44);
            this.btnGo.Tag = "success";
            this.btnGo.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnGo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGo.FlatAppearance.BorderSize = 1;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnGo.Click += this.btnGo_Click;
            // 
            // rightColumn
            // 
            this.rightColumn.ColumnCount = 1;
            this.rightColumn.RowCount = 2;
            this.rightColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.rightColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightColumn.Controls.Add(this.infoCard, 0, 0);
            this.rightColumn.Controls.Add(this.historyCard, 0, 1);
            this.rightColumn.Name = "rightColumn";
            this.rightColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightColumn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.rightColumn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.rightColumn.BackColor = System.Drawing.Color.Transparent;
            // 
            // infoCard
            // 
            this.infoCard.Controls.Add(this.lblInfo);
            this.infoCard.Name = "infoCard";
            this.infoCard.Tag = "card";
            this.infoCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoCard.Padding = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.infoCard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.infoCard.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.AutoSize = false;
            this.lblInfo.Size = new System.Drawing.Size(100, 40);
            this.lblInfo.Text = "Search and select a member to begin.";
            this.lblInfo.Tag = "muted";
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
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
            this.lblHistoryTitle.Text = "Renewal History";
            this.lblHistoryTitle.Tag = "h2";
            this.lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Bahnschrift", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // RegistrationForm
            // 
            this.contentPanel.Controls.Add(this.bodyLayout);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BackColor = System.Drawing.Color.FromArgb(14, 14, 17);
            this.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Name = "RegistrationForm";
            this.PageTitle = "Registration & Renewal";
            this.Text = "FITZONE GYM - Registration & Renewal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.historyCard.ResumeLayout(false);
            this.infoCard.ResumeLayout(false);
            this.rightColumn.ResumeLayout(false);
            this.dateRow.ResumeLayout(false);
            this.dateRow.PerformLayout();
            this.formLayout.ResumeLayout(false);
            this.formLayout.PerformLayout();
            this.leftCard.ResumeLayout(false);
            this.mainRow.ResumeLayout(false);
            this.modeFlow.ResumeLayout(false);
            this.modeFlow.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel modeFlow;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbRenew;
        private System.Windows.Forms.Label lblMemberSearch;
        private FitZoneGym.Controls.MemberPicker memberPicker;
        private System.Windows.Forms.TableLayoutPanel mainRow;
        private FitZoneGym.Controls.CardPanel leftCard;
        private System.Windows.Forms.TableLayoutPanel formLayout;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblDateCaption;
        private System.Windows.Forms.TableLayoutPanel dateRow;
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
        private System.Windows.Forms.TableLayoutPanel rightColumn;
        private FitZoneGym.Controls.CardPanel infoCard;
        private System.Windows.Forms.Label lblInfo;
        private FitZoneGym.Controls.CardPanel historyCard;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblHistoryTitle;
    }
}
