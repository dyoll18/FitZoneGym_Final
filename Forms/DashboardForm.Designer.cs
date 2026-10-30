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

        /// <summary>Designer generated: do not modify the contents of this method with the code editor.</summary>
        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            cardsLayout = new TableLayoutPanel();
            pnlTotal = new FitZoneGym.Controls.ThemedPanel();
            lblTotalValue = new Label();
            lblTotalCaption = new Label();
            pnlActive = new FitZoneGym.Controls.ThemedPanel();
            lblActiveValue = new Label();
            lblActiveCaption = new Label();
            pnlFrozen = new FitZoneGym.Controls.ThemedPanel();
            lblFrozenValue = new Label();
            lblFrozenCaption = new Label();
            pnlExpired = new FitZoneGym.Controls.ThemedPanel();
            lblExpiredValue = new Label();
            lblExpiredCaption = new Label();
            cardChart = new FitZoneGym.Controls.ThemedPanel();
            donutChart = new FitZoneGym.Controls.DonutChart();
            lblChartTitle = new Label();
            cardExpiring = new FitZoneGym.Controls.ThemedPanel();
            dgvExpiring = new FitZoneGym.Controls.ThemedGrid();
            lnkViewAll = new LinkLabel();
            lblExpiringTitle = new Label();
            cardActivity = new FitZoneGym.Controls.ThemedPanel();
            dgvActivity = new FitZoneGym.Controls.ThemedGrid();
            lblActivityTitle = new Label();
            contentPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            cardsLayout.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlActive.SuspendLayout();
            pnlFrozen.SuspendLayout();
            pnlExpired.SuspendLayout();
            cardChart.SuspendLayout();
            cardExpiring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpiring).BeginInit();
            cardActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivity).BeginInit();
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
            titleLabel.Size = new Size(1014, 48);
            titleLabel.Text = "Dashboard";
            titleLabel.Click += titleLabel_Click;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(24, 25, 33);
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            mainLayout.Controls.Add(cardsLayout, 0, 0);
            mainLayout.Controls.Add(cardChart, 0, 1);
            mainLayout.Controls.Add(cardExpiring, 1, 1);
            mainLayout.Controls.Add(cardActivity, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(16, 16);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            mainLayout.Size = new Size(1018, 638);
            mainLayout.TabIndex = 0;
            // 
            // cardsLayout
            // 
            cardsLayout.BackColor = Color.FromArgb(24, 25, 33);
            cardsLayout.ColumnCount = 4;
            mainLayout.SetColumnSpan(cardsLayout, 2);
            cardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cardsLayout.Controls.Add(pnlTotal, 0, 0);
            cardsLayout.Controls.Add(pnlActive, 1, 0);
            cardsLayout.Controls.Add(pnlFrozen, 2, 0);
            cardsLayout.Controls.Add(pnlExpired, 3, 0);
            cardsLayout.Dock = DockStyle.Fill;
            cardsLayout.Location = new Point(0, 0);
            cardsLayout.Margin = new Padding(0, 0, 0, 12);
            cardsLayout.Name = "cardsLayout";
            cardsLayout.RowCount = 1;
            cardsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cardsLayout.Size = new Size(1018, 100);
            cardsLayout.TabIndex = 0;
            // 
            // pnlTotal
            // 
            pnlTotal.CornerRadius = 14;
            pnlTotal.AccentBar = Color.FromArgb(255, 106, 0);
            pnlTotal.BackColor = Color.FromArgb(35, 36, 47);
            pnlTotal.Controls.Add(lblTotalValue);
            pnlTotal.Controls.Add(lblTotalCaption);
            pnlTotal.Dock = DockStyle.Fill;
            pnlTotal.Location = new Point(0, 0);
            pnlTotal.Margin = new Padding(0, 0, 12, 0);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Padding = new Padding(22, 14, 10, 10);
            pnlTotal.Size = new Size(242, 100);
            pnlTotal.TabIndex = 0;
            // 
            // lblTotalValue
            // 
            lblTotalValue.ForeColor = Color.FromArgb(244, 244, 248);
            lblTotalValue.Dock = DockStyle.Fill;
            lblTotalValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.Location = new Point(16, 36);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(218, 56);
            lblTotalValue.TabIndex = 0;
            lblTotalValue.Text = "0";
            lblTotalValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.ForeColor = Color.FromArgb(152, 155, 172);
            lblTotalCaption.Dock = DockStyle.Top;
            lblTotalCaption.Font = new Font("Segoe UI", 10F);
            lblTotalCaption.Location = new Point(16, 12);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(218, 24);
            lblTotalCaption.TabIndex = 1;
            lblTotalCaption.Text = "Total Members";
            // 
            // pnlActive
            // 
            pnlActive.CornerRadius = 14;
            pnlActive.AccentBar = Color.FromArgb(34, 197, 94);
            pnlActive.BackColor = Color.FromArgb(35, 36, 47);
            pnlActive.Controls.Add(lblActiveValue);
            pnlActive.Controls.Add(lblActiveCaption);
            pnlActive.Dock = DockStyle.Fill;
            pnlActive.Location = new Point(254, 0);
            pnlActive.Margin = new Padding(0, 0, 12, 0);
            pnlActive.Name = "pnlActive";
            pnlActive.Padding = new Padding(22, 14, 10, 10);
            pnlActive.Size = new Size(242, 100);
            pnlActive.TabIndex = 1;
            // 
            // lblActiveValue
            // 
            lblActiveValue.ForeColor = Color.FromArgb(244, 244, 248);
            lblActiveValue.Dock = DockStyle.Fill;
            lblActiveValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveValue.Location = new Point(16, 36);
            lblActiveValue.Name = "lblActiveValue";
            lblActiveValue.Size = new Size(218, 56);
            lblActiveValue.TabIndex = 0;
            lblActiveValue.Text = "0";
            lblActiveValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblActiveCaption
            // 
            lblActiveCaption.ForeColor = Color.FromArgb(152, 155, 172);
            lblActiveCaption.Dock = DockStyle.Top;
            lblActiveCaption.Font = new Font("Segoe UI", 10F);
            lblActiveCaption.Location = new Point(16, 12);
            lblActiveCaption.Name = "lblActiveCaption";
            lblActiveCaption.Size = new Size(218, 24);
            lblActiveCaption.TabIndex = 1;
            lblActiveCaption.Text = "Active";
            // 
            // pnlFrozen
            // 
            pnlFrozen.CornerRadius = 14;
            pnlFrozen.AccentBar = Color.FromArgb(250, 176, 5);
            pnlFrozen.BackColor = Color.FromArgb(35, 36, 47);
            pnlFrozen.Controls.Add(lblFrozenValue);
            pnlFrozen.Controls.Add(lblFrozenCaption);
            pnlFrozen.Dock = DockStyle.Fill;
            pnlFrozen.Location = new Point(508, 0);
            pnlFrozen.Margin = new Padding(0, 0, 12, 0);
            pnlFrozen.Name = "pnlFrozen";
            pnlFrozen.Padding = new Padding(22, 14, 10, 10);
            pnlFrozen.Size = new Size(242, 100);
            pnlFrozen.TabIndex = 2;
            // 
            // lblFrozenValue
            // 
            lblFrozenValue.ForeColor = Color.FromArgb(244, 244, 248);
            lblFrozenValue.Dock = DockStyle.Fill;
            lblFrozenValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrozenValue.Location = new Point(16, 36);
            lblFrozenValue.Name = "lblFrozenValue";
            lblFrozenValue.Size = new Size(218, 56);
            lblFrozenValue.TabIndex = 0;
            lblFrozenValue.Text = "0";
            lblFrozenValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFrozenCaption
            // 
            lblFrozenCaption.ForeColor = Color.FromArgb(152, 155, 172);
            lblFrozenCaption.Dock = DockStyle.Top;
            lblFrozenCaption.Font = new Font("Segoe UI", 10F);
            lblFrozenCaption.Location = new Point(16, 12);
            lblFrozenCaption.Name = "lblFrozenCaption";
            lblFrozenCaption.Size = new Size(218, 24);
            lblFrozenCaption.TabIndex = 1;
            lblFrozenCaption.Text = "Frozen";
            // 
            // pnlExpired
            // 
            pnlExpired.CornerRadius = 14;
            pnlExpired.AccentBar = Color.FromArgb(239, 68, 68);
            pnlExpired.BackColor = Color.FromArgb(35, 36, 47);
            pnlExpired.Controls.Add(lblExpiredValue);
            pnlExpired.Controls.Add(lblExpiredCaption);
            pnlExpired.Dock = DockStyle.Fill;
            pnlExpired.Location = new Point(762, 0);
            pnlExpired.Margin = new Padding(0, 0, 12, 0);
            pnlExpired.Name = "pnlExpired";
            pnlExpired.Padding = new Padding(22, 14, 10, 10);
            pnlExpired.Size = new Size(244, 100);
            pnlExpired.TabIndex = 3;
            // 
            // lblExpiredValue
            // 
            lblExpiredValue.ForeColor = Color.FromArgb(244, 244, 248);
            lblExpiredValue.Dock = DockStyle.Fill;
            lblExpiredValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpiredValue.Location = new Point(16, 36);
            lblExpiredValue.Name = "lblExpiredValue";
            lblExpiredValue.Size = new Size(220, 56);
            lblExpiredValue.TabIndex = 0;
            lblExpiredValue.Text = "0";
            lblExpiredValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpiredCaption
            // 
            lblExpiredCaption.ForeColor = Color.FromArgb(152, 155, 172);
            lblExpiredCaption.Dock = DockStyle.Top;
            lblExpiredCaption.Font = new Font("Segoe UI", 10F);
            lblExpiredCaption.Location = new Point(16, 12);
            lblExpiredCaption.Name = "lblExpiredCaption";
            lblExpiredCaption.Size = new Size(220, 24);
            lblExpiredCaption.TabIndex = 1;
            lblExpiredCaption.Text = "Expired";
            // 
            // cardChart
            // 
            cardChart.CornerRadius = 14;
            cardChart.BackColor = Color.FromArgb(35, 36, 47);
            cardChart.Controls.Add(donutChart);
            cardChart.Controls.Add(lblChartTitle);
            cardChart.Dock = DockStyle.Fill;
            cardChart.Location = new Point(0, 112);
            cardChart.Margin = new Padding(0, 0, 12, 12);
            cardChart.Name = "cardChart";
            cardChart.Padding = new Padding(14);
            cardChart.Size = new Size(374, 277);
            cardChart.TabIndex = 1;
            // 
            // donutChart
            // 
            donutChart.BackColor = Color.FromArgb(35, 36, 47);
            donutChart.Dock = DockStyle.Fill;
            donutChart.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            donutChart.Location = new Point(14, 44);
            donutChart.Name = "donutChart";
            donutChart.Size = new Size(346, 219);
            donutChart.TabIndex = 0;
            donutChart.Click += donutChart_Click;
            // 
            // lblChartTitle
            // 
            lblChartTitle.ForeColor = Color.FromArgb(244, 244, 248);
            lblChartTitle.Dock = DockStyle.Top;
            lblChartTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblChartTitle.Location = new Point(14, 14);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(346, 30);
            lblChartTitle.TabIndex = 1;
            lblChartTitle.Text = "Membership Status";
            // 
            // cardExpiring
            // 
            cardExpiring.CornerRadius = 14;
            cardExpiring.BackColor = Color.FromArgb(35, 36, 47);
            cardExpiring.Controls.Add(dgvExpiring);
            cardExpiring.Controls.Add(lnkViewAll);
            cardExpiring.Controls.Add(lblExpiringTitle);
            cardExpiring.Dock = DockStyle.Fill;
            cardExpiring.Location = new Point(386, 112);
            cardExpiring.Margin = new Padding(0, 0, 12, 12);
            cardExpiring.Name = "cardExpiring";
            cardExpiring.Padding = new Padding(14);
            cardExpiring.Size = new Size(620, 277);
            cardExpiring.TabIndex = 2;
            // 
            // dgvExpiring
            // 
            dgvExpiring.Dock = DockStyle.Fill;
            dgvExpiring.Location = new Point(14, 44);
            dgvExpiring.Name = "dgvExpiring";
            dgvExpiring.RowHeadersWidth = 62;
            dgvExpiring.Size = new Size(592, 197);
            dgvExpiring.TabIndex = 0;
            // 
            // lnkViewAll
            // 
            lnkViewAll.ForeColor = Color.FromArgb(244, 244, 248);
            lnkViewAll.LinkColor = Color.FromArgb(255, 106, 0);
            lnkViewAll.ActiveLinkColor = Color.FromArgb(255, 136, 56);
            lnkViewAll.VisitedLinkColor = Color.FromArgb(255, 106, 0);
            lnkViewAll.Dock = DockStyle.Bottom;
            lnkViewAll.Location = new Point(14, 241);
            lnkViewAll.Name = "lnkViewAll";
            lnkViewAll.Size = new Size(592, 22);
            lnkViewAll.TabIndex = 1;
            lnkViewAll.TabStop = true;
            lnkViewAll.Text = "View all members";
            lnkViewAll.TextAlign = ContentAlignment.MiddleRight;
            lnkViewAll.LinkClicked += lnkViewAll_LinkClicked;
            // 
            // lblExpiringTitle
            // 
            lblExpiringTitle.ForeColor = Color.FromArgb(244, 244, 248);
            lblExpiringTitle.Dock = DockStyle.Top;
            lblExpiringTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblExpiringTitle.Location = new Point(14, 14);
            lblExpiringTitle.Name = "lblExpiringTitle";
            lblExpiringTitle.Size = new Size(592, 30);
            lblExpiringTitle.TabIndex = 2;
            lblExpiringTitle.Text = "Upcoming Expirations";
            // 
            // cardActivity
            // 
            cardActivity.CornerRadius = 14;
            cardActivity.BackColor = Color.FromArgb(35, 36, 47);
            mainLayout.SetColumnSpan(cardActivity, 2);
            cardActivity.Controls.Add(dgvActivity);
            cardActivity.Controls.Add(lblActivityTitle);
            cardActivity.Dock = DockStyle.Fill;
            cardActivity.Location = new Point(0, 401);
            cardActivity.Margin = new Padding(0, 0, 12, 12);
            cardActivity.Name = "cardActivity";
            cardActivity.Padding = new Padding(14);
            cardActivity.Size = new Size(1006, 225);
            cardActivity.TabIndex = 3;
            // 
            // dgvActivity
            // 
            dgvActivity.Dock = DockStyle.Fill;
            dgvActivity.Location = new Point(14, 44);
            dgvActivity.Name = "dgvActivity";
            dgvActivity.RowHeadersWidth = 62;
            dgvActivity.Size = new Size(978, 167);
            dgvActivity.TabIndex = 0;
            // 
            // lblActivityTitle
            // 
            lblActivityTitle.ForeColor = Color.FromArgb(244, 244, 248);
            lblActivityTitle.Dock = DockStyle.Top;
            lblActivityTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblActivityTitle.Location = new Point(14, 14);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new Size(978, 30);
            lblActivityTitle.TabIndex = 1;
            lblActivityTitle.Text = "Recent Activity";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            ClientSize = new Size(1280, 760);
            Name = "DashboardForm";
            PageTitle = "Dashboard";
            Text = "GYMORA - Dashboard";
            contentPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainLayout.ResumeLayout(false);
            cardsLayout.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            pnlActive.ResumeLayout(false);
            pnlFrozen.ResumeLayout(false);
            pnlExpired.ResumeLayout(false);
            cardChart.ResumeLayout(false);
            cardExpiring.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExpiring).EndInit();
            cardActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel cardsLayout;
        private FitZoneGym.Controls.ThemedPanel pnlTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalCaption;
        private FitZoneGym.Controls.ThemedPanel pnlActive;
        private System.Windows.Forms.Label lblActiveValue;
        private System.Windows.Forms.Label lblActiveCaption;
        private FitZoneGym.Controls.ThemedPanel pnlFrozen;
        private System.Windows.Forms.Label lblFrozenValue;
        private System.Windows.Forms.Label lblFrozenCaption;
        private FitZoneGym.Controls.ThemedPanel pnlExpired;
        private System.Windows.Forms.Label lblExpiredValue;
        private System.Windows.Forms.Label lblExpiredCaption;
        private FitZoneGym.Controls.ThemedPanel cardChart;
        private FitZoneGym.Controls.DonutChart donutChart;
        private System.Windows.Forms.Label lblChartTitle;
        private FitZoneGym.Controls.ThemedPanel cardExpiring;
        private FitZoneGym.Controls.ThemedGrid dgvExpiring;
        private System.Windows.Forms.LinkLabel lnkViewAll;
        private System.Windows.Forms.Label lblExpiringTitle;
        private FitZoneGym.Controls.ThemedPanel cardActivity;
        private FitZoneGym.Controls.ThemedGrid dgvActivity;
        private System.Windows.Forms.Label lblActivityTitle;
    }
}
