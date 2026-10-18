namespace FitZoneGym.Forms
{
    partial class DashboardForm
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
            this.cardsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTotal = new FitZoneGym.Controls.CardPanel();
            this.contentTotal = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.stripeTotal = new System.Windows.Forms.Panel();
            this.pnlActive = new FitZoneGym.Controls.CardPanel();
            this.contentActive = new System.Windows.Forms.Panel();
            this.lblActiveValue = new System.Windows.Forms.Label();
            this.lblActiveCaption = new System.Windows.Forms.Label();
            this.stripeActive = new System.Windows.Forms.Panel();
            this.pnlFrozen = new FitZoneGym.Controls.CardPanel();
            this.contentFrozen = new System.Windows.Forms.Panel();
            this.lblFrozenValue = new System.Windows.Forms.Label();
            this.lblFrozenCaption = new System.Windows.Forms.Label();
            this.stripeFrozen = new System.Windows.Forms.Panel();
            this.pnlExpired = new FitZoneGym.Controls.CardPanel();
            this.contentExpired = new System.Windows.Forms.Panel();
            this.lblExpiredValue = new System.Windows.Forms.Label();
            this.lblExpiredCaption = new System.Windows.Forms.Label();
            this.stripeExpired = new System.Windows.Forms.Panel();
            this.cardChart = new FitZoneGym.Controls.CardPanel();
            this.donutChart = new FitZoneGym.Controls.DonutChart();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.cardExpiring = new FitZoneGym.Controls.CardPanel();
            this.dgvExpiring = new System.Windows.Forms.DataGridView();
            this.lnkViewAll = new System.Windows.Forms.LinkLabel();
            this.lblExpiringTitle = new System.Windows.Forms.Label();
            this.cardActivity = new FitZoneGym.Controls.CardPanel();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.cardsLayout.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.contentTotal.SuspendLayout();
            this.stripeTotal.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.contentActive.SuspendLayout();
            this.stripeActive.SuspendLayout();
            this.pnlFrozen.SuspendLayout();
            this.contentFrozen.SuspendLayout();
            this.stripeFrozen.SuspendLayout();
            this.pnlExpired.SuspendLayout();
            this.contentExpired.SuspendLayout();
            this.stripeExpired.SuspendLayout();
            this.cardChart.SuspendLayout();
            this.cardExpiring.SuspendLayout();
            this.cardActivity.SuspendLayout();
            this.SuspendLayout();
            this.contentPanel.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.RowCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainLayout.Controls.Add(this.cardsLayout, 0, 0);
            this.mainLayout.SetColumnSpan(this.cardsLayout, 2);
            this.mainLayout.Controls.Add(this.cardChart, 0, 1);
            this.mainLayout.Controls.Add(this.cardExpiring, 1, 1);
            this.mainLayout.Controls.Add(this.cardActivity, 0, 2);
            this.mainLayout.SetColumnSpan(this.cardActivity, 2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // cardsLayout
            // 
            this.cardsLayout.ColumnCount = 4;
            this.cardsLayout.RowCount = 1;
            this.cardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardsLayout.Controls.Add(this.pnlTotal, 0, 0);
            this.cardsLayout.Controls.Add(this.pnlActive, 1, 0);
            this.cardsLayout.Controls.Add(this.pnlFrozen, 2, 0);
            this.cardsLayout.Controls.Add(this.pnlExpired, 3, 0);
            this.cardsLayout.Name = "cardsLayout";
            this.cardsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardsLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardsLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardsLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.contentTotal);
            this.pnlTotal.Controls.Add(this.stripeTotal);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Tag = "stat";
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // contentTotal
            // 
            this.contentTotal.Controls.Add(this.lblTotalValue);
            this.contentTotal.Controls.Add(this.lblTotalCaption);
            this.contentTotal.Name = "contentTotal";
            this.contentTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTotal.Padding = new System.Windows.Forms.Padding(18, 12, 10, 8);
            this.contentTotal.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.AutoSize = false;
            this.lblTotalValue.Text = "0";
            this.lblTotalValue.Tag = "value";
            this.lblTotalValue.Size = new System.Drawing.Size(100, 40);
            this.lblTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalValue.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.AutoSize = false;
            this.lblTotalCaption.Size = new System.Drawing.Size(100, 22);
            this.lblTotalCaption.Text = "TOTAL MEMBERS";
            this.lblTotalCaption.Tag = "caption";
            this.lblTotalCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // stripeTotal
            // 
            this.stripeTotal.Name = "stripeTotal";
            this.stripeTotal.Tag = "stripe";
            this.stripeTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.stripeTotal.Size = new System.Drawing.Size(6, 10);
            this.stripeTotal.BackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            // 
            // pnlActive
            // 
            this.pnlActive.Controls.Add(this.contentActive);
            this.pnlActive.Controls.Add(this.stripeActive);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Tag = "stat";
            this.pnlActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // contentActive
            // 
            this.contentActive.Controls.Add(this.lblActiveValue);
            this.contentActive.Controls.Add(this.lblActiveCaption);
            this.contentActive.Name = "contentActive";
            this.contentActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentActive.Padding = new System.Windows.Forms.Padding(18, 12, 10, 8);
            this.contentActive.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblActiveValue
            // 
            this.lblActiveValue.Name = "lblActiveValue";
            this.lblActiveValue.AutoSize = false;
            this.lblActiveValue.Text = "0";
            this.lblActiveValue.Tag = "value";
            this.lblActiveValue.Size = new System.Drawing.Size(100, 40);
            this.lblActiveValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActiveValue.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Bold);
            this.lblActiveValue.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblActiveCaption
            // 
            this.lblActiveCaption.Name = "lblActiveCaption";
            this.lblActiveCaption.AutoSize = false;
            this.lblActiveCaption.Size = new System.Drawing.Size(100, 22);
            this.lblActiveCaption.Text = "ACTIVE";
            this.lblActiveCaption.Tag = "caption";
            this.lblActiveCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActiveCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActiveCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblActiveCaption.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // stripeActive
            // 
            this.stripeActive.Name = "stripeActive";
            this.stripeActive.Tag = "stripe";
            this.stripeActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.stripeActive.Size = new System.Drawing.Size(6, 10);
            this.stripeActive.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            // 
            // pnlFrozen
            // 
            this.pnlFrozen.Controls.Add(this.contentFrozen);
            this.pnlFrozen.Controls.Add(this.stripeFrozen);
            this.pnlFrozen.Name = "pnlFrozen";
            this.pnlFrozen.Tag = "stat";
            this.pnlFrozen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrozen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlFrozen.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // contentFrozen
            // 
            this.contentFrozen.Controls.Add(this.lblFrozenValue);
            this.contentFrozen.Controls.Add(this.lblFrozenCaption);
            this.contentFrozen.Name = "contentFrozen";
            this.contentFrozen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentFrozen.Padding = new System.Windows.Forms.Padding(18, 12, 10, 8);
            this.contentFrozen.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblFrozenValue
            // 
            this.lblFrozenValue.Name = "lblFrozenValue";
            this.lblFrozenValue.AutoSize = false;
            this.lblFrozenValue.Text = "0";
            this.lblFrozenValue.Tag = "value";
            this.lblFrozenValue.Size = new System.Drawing.Size(100, 40);
            this.lblFrozenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFrozenValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFrozenValue.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Bold);
            this.lblFrozenValue.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblFrozenCaption
            // 
            this.lblFrozenCaption.Name = "lblFrozenCaption";
            this.lblFrozenCaption.AutoSize = false;
            this.lblFrozenCaption.Size = new System.Drawing.Size(100, 22);
            this.lblFrozenCaption.Text = "FROZEN";
            this.lblFrozenCaption.Tag = "caption";
            this.lblFrozenCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFrozenCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFrozenCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFrozenCaption.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // stripeFrozen
            // 
            this.stripeFrozen.Name = "stripeFrozen";
            this.stripeFrozen.Tag = "stripe";
            this.stripeFrozen.Dock = System.Windows.Forms.DockStyle.Left;
            this.stripeFrozen.Size = new System.Drawing.Size(6, 10);
            this.stripeFrozen.BackColor = System.Drawing.Color.FromArgb(251, 176, 36);
            // 
            // pnlExpired
            // 
            this.pnlExpired.Controls.Add(this.contentExpired);
            this.pnlExpired.Controls.Add(this.stripeExpired);
            this.pnlExpired.Name = "pnlExpired";
            this.pnlExpired.Tag = "stat";
            this.pnlExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExpired.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlExpired.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // contentExpired
            // 
            this.contentExpired.Controls.Add(this.lblExpiredValue);
            this.contentExpired.Controls.Add(this.lblExpiredCaption);
            this.contentExpired.Name = "contentExpired";
            this.contentExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentExpired.Padding = new System.Windows.Forms.Padding(18, 12, 10, 8);
            this.contentExpired.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblExpiredValue
            // 
            this.lblExpiredValue.Name = "lblExpiredValue";
            this.lblExpiredValue.AutoSize = false;
            this.lblExpiredValue.Text = "0";
            this.lblExpiredValue.Tag = "value";
            this.lblExpiredValue.Size = new System.Drawing.Size(100, 40);
            this.lblExpiredValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExpiredValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExpiredValue.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Bold);
            this.lblExpiredValue.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblExpiredCaption
            // 
            this.lblExpiredCaption.Name = "lblExpiredCaption";
            this.lblExpiredCaption.AutoSize = false;
            this.lblExpiredCaption.Size = new System.Drawing.Size(100, 22);
            this.lblExpiredCaption.Text = "EXPIRED";
            this.lblExpiredCaption.Tag = "caption";
            this.lblExpiredCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpiredCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExpiredCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblExpiredCaption.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // stripeExpired
            // 
            this.stripeExpired.Name = "stripeExpired";
            this.stripeExpired.Tag = "stripe";
            this.stripeExpired.Dock = System.Windows.Forms.DockStyle.Left;
            this.stripeExpired.Size = new System.Drawing.Size(6, 10);
            this.stripeExpired.BackColor = System.Drawing.Color.FromArgb(244, 76, 76);
            // 
            // cardChart
            // 
            this.cardChart.Controls.Add(this.donutChart);
            this.cardChart.Controls.Add(this.lblChartTitle);
            this.cardChart.Name = "cardChart";
            this.cardChart.Tag = "card";
            this.cardChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardChart.Padding = new System.Windows.Forms.Padding(18, 14, 18, 14);
            this.cardChart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cardChart.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // donutChart
            // 
            this.donutChart.Name = "donutChart";
            this.donutChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.AutoSize = false;
            this.lblChartTitle.Size = new System.Drawing.Size(100, 32);
            this.lblChartTitle.Text = "Membership Status";
            this.lblChartTitle.Tag = "h2";
            this.lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChartTitle.Font = new System.Drawing.Font("Bahnschrift", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // cardExpiring
            // 
            this.cardExpiring.Controls.Add(this.dgvExpiring);
            this.cardExpiring.Controls.Add(this.lnkViewAll);
            this.cardExpiring.Controls.Add(this.lblExpiringTitle);
            this.cardExpiring.Name = "cardExpiring";
            this.cardExpiring.Tag = "card";
            this.cardExpiring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardExpiring.Padding = new System.Windows.Forms.Padding(18, 14, 18, 14);
            this.cardExpiring.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cardExpiring.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // dgvExpiring
            // 
            this.dgvExpiring.Name = "dgvExpiring";
            this.dgvExpiring.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.DataGridViewCellStyle dgvExpiringHead = new System.Windows.Forms.DataGridViewCellStyle();
            dgvExpiringHead.BackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvExpiringHead.ForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvExpiringHead.SelectionBackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvExpiringHead.SelectionForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvExpiringHead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvExpiringHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            System.Windows.Forms.DataGridViewCellStyle dgvExpiringCell = new System.Windows.Forms.DataGridViewCellStyle();
            dgvExpiringCell.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            dgvExpiringCell.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvExpiringCell.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvExpiringCell.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            System.Windows.Forms.DataGridViewCellStyle dgvExpiringAlt = new System.Windows.Forms.DataGridViewCellStyle();
            dgvExpiringAlt.BackColor = System.Drawing.Color.FromArgb(29, 29, 35);
            dgvExpiringAlt.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvExpiringAlt.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvExpiringAlt.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvExpiring.EnableHeadersVisualStyles = false;
            this.dgvExpiring.ColumnHeadersDefaultCellStyle = dgvExpiringHead;
            this.dgvExpiring.DefaultCellStyle = dgvExpiringCell;
            this.dgvExpiring.AlternatingRowsDefaultCellStyle = dgvExpiringAlt;
            this.dgvExpiring.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 29);
            this.dgvExpiring.GridColor = System.Drawing.Color.FromArgb(44, 44, 52);
            this.dgvExpiring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpiring.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpiring.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExpiring.RowHeadersVisible = false;
            this.dgvExpiring.AllowUserToAddRows = false;
            this.dgvExpiring.AllowUserToDeleteRows = false;
            this.dgvExpiring.ReadOnly = true;
            this.dgvExpiring.MultiSelect = false;
            this.dgvExpiring.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpiring.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // lnkViewAll
            // 
            this.lnkViewAll.Name = "lnkViewAll";
            this.lnkViewAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnkViewAll.Size = new System.Drawing.Size(100, 28);
            this.lnkViewAll.TabStop = true;
            this.lnkViewAll.Text = "View all members";
            this.lnkViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkViewAll.LinkColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.lnkViewAll.ActiveLinkColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.lnkViewAll.VisitedLinkColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.lnkViewAll.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lnkViewAll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkViewAll.LinkClicked += this.lnkViewAll_LinkClicked;
            // 
            // lblExpiringTitle
            // 
            this.lblExpiringTitle.Name = "lblExpiringTitle";
            this.lblExpiringTitle.AutoSize = false;
            this.lblExpiringTitle.Size = new System.Drawing.Size(100, 32);
            this.lblExpiringTitle.Text = "Upcoming Expirations";
            this.lblExpiringTitle.Tag = "h2";
            this.lblExpiringTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpiringTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExpiringTitle.Font = new System.Drawing.Font("Bahnschrift", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblExpiringTitle.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // cardActivity
            // 
            this.cardActivity.Controls.Add(this.dgvActivity);
            this.cardActivity.Controls.Add(this.lblActivityTitle);
            this.cardActivity.Name = "cardActivity";
            this.cardActivity.Tag = "card";
            this.cardActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActivity.Padding = new System.Windows.Forms.Padding(18, 14, 18, 14);
            this.cardActivity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cardActivity.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // dgvActivity
            // 
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.DataGridViewCellStyle dgvActivityHead = new System.Windows.Forms.DataGridViewCellStyle();
            dgvActivityHead.BackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvActivityHead.ForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvActivityHead.SelectionBackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvActivityHead.SelectionForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvActivityHead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvActivityHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            System.Windows.Forms.DataGridViewCellStyle dgvActivityCell = new System.Windows.Forms.DataGridViewCellStyle();
            dgvActivityCell.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            dgvActivityCell.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvActivityCell.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvActivityCell.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            System.Windows.Forms.DataGridViewCellStyle dgvActivityAlt = new System.Windows.Forms.DataGridViewCellStyle();
            dgvActivityAlt.BackColor = System.Drawing.Color.FromArgb(29, 29, 35);
            dgvActivityAlt.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvActivityAlt.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvActivityAlt.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvActivity.EnableHeadersVisualStyles = false;
            this.dgvActivity.ColumnHeadersDefaultCellStyle = dgvActivityHead;
            this.dgvActivity.DefaultCellStyle = dgvActivityCell;
            this.dgvActivity.AlternatingRowsDefaultCellStyle = dgvActivityAlt;
            this.dgvActivity.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 29);
            this.dgvActivity.GridColor = System.Drawing.Color.FromArgb(44, 44, 52);
            this.dgvActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActivity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActivity.RowHeadersVisible = false;
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.MultiSelect = false;
            this.dgvActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // lblActivityTitle
            // 
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.AutoSize = false;
            this.lblActivityTitle.Size = new System.Drawing.Size(100, 32);
            this.lblActivityTitle.Text = "Recent Activity";
            this.lblActivityTitle.Tag = "h2";
            this.lblActivityTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActivityTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityTitle.Font = new System.Drawing.Font("Bahnschrift", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // DashboardForm
            // 
            this.contentPanel.Controls.Add(this.mainLayout);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BackColor = System.Drawing.Color.FromArgb(14, 14, 17);
            this.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Name = "DashboardForm";
            this.PageTitle = "Dashboard";
            this.Text = "FITZONE GYM - Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.cardActivity.ResumeLayout(false);
            this.cardExpiring.ResumeLayout(false);
            this.cardChart.ResumeLayout(false);
            this.stripeExpired.ResumeLayout(false);
            this.contentExpired.ResumeLayout(false);
            this.pnlExpired.ResumeLayout(false);
            this.stripeFrozen.ResumeLayout(false);
            this.contentFrozen.ResumeLayout(false);
            this.pnlFrozen.ResumeLayout(false);
            this.stripeActive.ResumeLayout(false);
            this.contentActive.ResumeLayout(false);
            this.pnlActive.ResumeLayout(false);
            this.stripeTotal.ResumeLayout(false);
            this.contentTotal.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.cardsLayout.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel cardsLayout;
        private FitZoneGym.Controls.CardPanel pnlTotal;
        private System.Windows.Forms.Panel contentTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Panel stripeTotal;
        private FitZoneGym.Controls.CardPanel pnlActive;
        private System.Windows.Forms.Panel contentActive;
        private System.Windows.Forms.Label lblActiveValue;
        private System.Windows.Forms.Label lblActiveCaption;
        private System.Windows.Forms.Panel stripeActive;
        private FitZoneGym.Controls.CardPanel pnlFrozen;
        private System.Windows.Forms.Panel contentFrozen;
        private System.Windows.Forms.Label lblFrozenValue;
        private System.Windows.Forms.Label lblFrozenCaption;
        private System.Windows.Forms.Panel stripeFrozen;
        private FitZoneGym.Controls.CardPanel pnlExpired;
        private System.Windows.Forms.Panel contentExpired;
        private System.Windows.Forms.Label lblExpiredValue;
        private System.Windows.Forms.Label lblExpiredCaption;
        private System.Windows.Forms.Panel stripeExpired;
        private FitZoneGym.Controls.CardPanel cardChart;
        private FitZoneGym.Controls.DonutChart donutChart;
        private System.Windows.Forms.Label lblChartTitle;
        private FitZoneGym.Controls.CardPanel cardExpiring;
        private System.Windows.Forms.DataGridView dgvExpiring;
        private System.Windows.Forms.LinkLabel lnkViewAll;
        private System.Windows.Forms.Label lblExpiringTitle;
        private FitZoneGym.Controls.CardPanel cardActivity;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.Label lblActivityTitle;
    }
}
