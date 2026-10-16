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
            pnlTotal = new Panel();
            lblTotalValue = new Label();
            lblTotalCaption = new Label();
            pnlActive = new Panel();
            lblActiveValue = new Label();
            lblActiveCaption = new Label();
            pnlFrozen = new Panel();
            lblFrozenValue = new Label();
            lblFrozenCaption = new Label();
            pnlExpired = new Panel();
            lblExpiredValue = new Label();
            lblExpiredCaption = new Label();
            cardChart = new Panel();
            donutChart = new FitZoneGym.Controls.DonutChart();
            lblChartTitle = new Label();
            cardExpiring = new Panel();
            dgvExpiring = new DataGridView();
            lnkViewAll = new LinkLabel();
            lblExpiringTitle = new Label();
            cardActivity = new Panel();
            dgvActivity = new DataGridView();
            lblActivityTitle = new Label();
            contentPanel.SuspendLayout();
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
            contentPanel.Size = new Size(1035, 682);
            contentPanel.Paint += contentPanel_Paint;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.None;
            titleLabel.Size = new Size(1014, 48);
            titleLabel.Text = "Dashboard";
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(243, 246, 251);
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
            mainLayout.Size = new Size(1003, 650);
            mainLayout.TabIndex = 0;
            // 
            // cardsLayout
            // 
            cardsLayout.BackColor = Color.FromArgb(243, 246, 251);
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
            cardsLayout.Size = new Size(1003, 100);
            cardsLayout.TabIndex = 0;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.FromArgb(30, 111, 240);
            pnlTotal.Controls.Add(lblTotalValue);
            pnlTotal.Controls.Add(lblTotalCaption);
            pnlTotal.Dock = DockStyle.Fill;
            pnlTotal.Location = new Point(0, 0);
            pnlTotal.Margin = new Padding(0, 0, 12, 0);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Padding = new Padding(16, 12, 8, 8);
            pnlTotal.Size = new Size(238, 100);
            pnlTotal.TabIndex = 0;
            // 
            // lblTotalValue
            // 
            lblTotalValue.Dock = DockStyle.Fill;
            lblTotalValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.White;
            lblTotalValue.Location = new Point(16, 36);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(214, 56);
            lblTotalValue.TabIndex = 0;
            lblTotalValue.Text = "0";
            lblTotalValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.Dock = DockStyle.Top;
            lblTotalCaption.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTotalCaption.ForeColor = Color.White;
            lblTotalCaption.Location = new Point(16, 12);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(214, 24);
            lblTotalCaption.TabIndex = 1;
            lblTotalCaption.Text = "Total Members";
            // 
            // pnlActive
            // 
            pnlActive.BackColor = Color.FromArgb(22, 163, 74);
            pnlActive.Controls.Add(lblActiveValue);
            pnlActive.Controls.Add(lblActiveCaption);
            pnlActive.Dock = DockStyle.Fill;
            pnlActive.Location = new Point(250, 0);
            pnlActive.Margin = new Padding(0, 0, 12, 0);
            pnlActive.Name = "pnlActive";
            pnlActive.Padding = new Padding(16, 12, 8, 8);
            pnlActive.Size = new Size(238, 100);
            pnlActive.TabIndex = 1;
            // 
            // lblActiveValue
            // 
            lblActiveValue.Dock = DockStyle.Fill;
            lblActiveValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblActiveValue.ForeColor = Color.White;
            lblActiveValue.Location = new Point(16, 36);
            lblActiveValue.Name = "lblActiveValue";
            lblActiveValue.Size = new Size(214, 56);
            lblActiveValue.TabIndex = 0;
            lblActiveValue.Text = "0";
            lblActiveValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblActiveCaption
            // 
            lblActiveCaption.Dock = DockStyle.Top;
            lblActiveCaption.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblActiveCaption.ForeColor = Color.White;
            lblActiveCaption.Location = new Point(16, 12);
            lblActiveCaption.Name = "lblActiveCaption";
            lblActiveCaption.Size = new Size(214, 24);
            lblActiveCaption.TabIndex = 1;
            lblActiveCaption.Text = "Active";
            // 
            // pnlFrozen
            // 
            pnlFrozen.BackColor = Color.FromArgb(245, 158, 11);
            pnlFrozen.Controls.Add(lblFrozenValue);
            pnlFrozen.Controls.Add(lblFrozenCaption);
            pnlFrozen.Dock = DockStyle.Fill;
            pnlFrozen.Location = new Point(500, 0);
            pnlFrozen.Margin = new Padding(0, 0, 12, 0);
            pnlFrozen.Name = "pnlFrozen";
            pnlFrozen.Padding = new Padding(16, 12, 8, 8);
            pnlFrozen.Size = new Size(238, 100);
            pnlFrozen.TabIndex = 2;
            // 
            // lblFrozenValue
            // 
            lblFrozenValue.Dock = DockStyle.Fill;
            lblFrozenValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblFrozenValue.ForeColor = Color.White;
            lblFrozenValue.Location = new Point(16, 36);
            lblFrozenValue.Name = "lblFrozenValue";
            lblFrozenValue.Size = new Size(214, 56);
            lblFrozenValue.TabIndex = 0;
            lblFrozenValue.Text = "0";
            lblFrozenValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFrozenCaption
            // 
            lblFrozenCaption.Dock = DockStyle.Top;
            lblFrozenCaption.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFrozenCaption.ForeColor = Color.White;
            lblFrozenCaption.Location = new Point(16, 12);
            lblFrozenCaption.Name = "lblFrozenCaption";
            lblFrozenCaption.Size = new Size(214, 24);
            lblFrozenCaption.TabIndex = 1;
            lblFrozenCaption.Text = "Frozen";
            // 
            // pnlExpired
            // 
            pnlExpired.BackColor = Color.FromArgb(220, 38, 38);
            pnlExpired.Controls.Add(lblExpiredValue);
            pnlExpired.Controls.Add(lblExpiredCaption);
            pnlExpired.Location = new Point(750, 0);
            pnlExpired.Margin = new Padding(0, 0, 12, 0);
            pnlExpired.Name = "pnlExpired";
            pnlExpired.Padding = new Padding(16, 12, 8, 8);
            pnlExpired.Size = new Size(241, 100);
            pnlExpired.TabIndex = 3;
            // 
            // lblExpiredValue
            // 
            lblExpiredValue.Dock = DockStyle.Fill;
            lblExpiredValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblExpiredValue.ForeColor = Color.White;
            lblExpiredValue.Location = new Point(16, 36);
            lblExpiredValue.Name = "lblExpiredValue";
            lblExpiredValue.Size = new Size(217, 56);
            lblExpiredValue.TabIndex = 0;
            lblExpiredValue.Text = "0";
            lblExpiredValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpiredCaption
            // 
            lblExpiredCaption.Dock = DockStyle.Top;
            lblExpiredCaption.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblExpiredCaption.ForeColor = Color.White;
            lblExpiredCaption.Location = new Point(16, 12);
            lblExpiredCaption.Name = "lblExpiredCaption";
            lblExpiredCaption.Size = new Size(217, 24);
            lblExpiredCaption.TabIndex = 1;
            lblExpiredCaption.Text = "Expired";
            // 
            // cardChart
            // 
            cardChart.BackColor = Color.White;
            cardChart.Controls.Add(donutChart);
            cardChart.Controls.Add(lblChartTitle);
            cardChart.Dock = DockStyle.Fill;
            cardChart.Location = new Point(0, 112);
            cardChart.Margin = new Padding(0, 0, 12, 12);
            cardChart.Name = "cardChart";
            cardChart.Padding = new Padding(14);
            cardChart.Size = new Size(369, 283);
            cardChart.TabIndex = 1;
            // 
            // donutChart
            // 
            donutChart.BackColor = Color.White;
            donutChart.Dock = DockStyle.Fill;
            donutChart.Location = new Point(14, 44);
            donutChart.Name = "donutChart";
            donutChart.Size = new Size(341, 225);
            donutChart.TabIndex = 0;
            // 
            // lblChartTitle
            // 
            lblChartTitle.Dock = DockStyle.Top;
            lblChartTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(15, 35, 66);
            lblChartTitle.Location = new Point(14, 14);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(341, 30);
            lblChartTitle.TabIndex = 1;
            lblChartTitle.Text = "Membership Status";
            // 
            // cardExpiring
            // 
            cardExpiring.BackColor = Color.White;
            cardExpiring.Controls.Add(dgvExpiring);
            cardExpiring.Controls.Add(lnkViewAll);
            cardExpiring.Controls.Add(lblExpiringTitle);
            cardExpiring.Dock = DockStyle.Fill;
            cardExpiring.Location = new Point(381, 112);
            cardExpiring.Margin = new Padding(0, 0, 12, 12);
            cardExpiring.Name = "cardExpiring";
            cardExpiring.Padding = new Padding(14);
            cardExpiring.Size = new Size(610, 283);
            cardExpiring.TabIndex = 2;
            // 
            // dgvExpiring
            // 
            dgvExpiring.ColumnHeadersHeight = 34;
            dgvExpiring.Dock = DockStyle.Fill;
            dgvExpiring.Location = new Point(14, 44);
            dgvExpiring.Name = "dgvExpiring";
            dgvExpiring.RowHeadersWidth = 62;
            dgvExpiring.Size = new Size(582, 203);
            dgvExpiring.TabIndex = 0;
            // 
            // lnkViewAll
            // 
            lnkViewAll.Dock = DockStyle.Bottom;
            lnkViewAll.Location = new Point(14, 247);
            lnkViewAll.Name = "lnkViewAll";
            lnkViewAll.Size = new Size(582, 22);
            lnkViewAll.TabIndex = 1;
            lnkViewAll.TabStop = true;
            lnkViewAll.Text = "View all members";
            lnkViewAll.TextAlign = ContentAlignment.MiddleRight;
            lnkViewAll.LinkClicked += lnkViewAll_LinkClicked;
            // 
            // lblExpiringTitle
            // 
            lblExpiringTitle.Dock = DockStyle.Top;
            lblExpiringTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblExpiringTitle.ForeColor = Color.FromArgb(15, 35, 66);
            lblExpiringTitle.Location = new Point(14, 14);
            lblExpiringTitle.Name = "lblExpiringTitle";
            lblExpiringTitle.Size = new Size(582, 30);
            lblExpiringTitle.TabIndex = 2;
            lblExpiringTitle.Text = "Upcoming Expirations";
            // 
            // cardActivity
            // 
            cardActivity.BackColor = Color.White;
            mainLayout.SetColumnSpan(cardActivity, 2);
            cardActivity.Controls.Add(dgvActivity);
            cardActivity.Controls.Add(lblActivityTitle);
            cardActivity.Dock = DockStyle.Fill;
            cardActivity.Location = new Point(0, 407);
            cardActivity.Margin = new Padding(0, 0, 12, 12);
            cardActivity.Name = "cardActivity";
            cardActivity.Padding = new Padding(14);
            cardActivity.Size = new Size(991, 231);
            cardActivity.TabIndex = 3;
            // 
            // dgvActivity
            // 
            dgvActivity.ColumnHeadersHeight = 34;
            dgvActivity.Dock = DockStyle.Fill;
            dgvActivity.Location = new Point(14, 44);
            dgvActivity.Name = "dgvActivity";
            dgvActivity.RowHeadersWidth = 62;
            dgvActivity.Size = new Size(963, 173);
            dgvActivity.TabIndex = 0;
            // 
            // lblActivityTitle
            // 
            lblActivityTitle.Dock = DockStyle.Top;
            lblActivityTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblActivityTitle.ForeColor = Color.FromArgb(15, 35, 66);
            lblActivityTitle.Location = new Point(14, 14);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new Size(963, 30);
            lblActivityTitle.TabIndex = 1;
            lblActivityTitle.Text = "Recent Activity";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            ClientSize = new Size(1265, 772);
            Name = "DashboardForm";
            PageTitle = "Dashboard";
            Text = "FITZONE GYM - Dashboard";
            contentPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Label lblActiveValue;
        private System.Windows.Forms.Label lblActiveCaption;
        private System.Windows.Forms.Panel pnlFrozen;
        private System.Windows.Forms.Label lblFrozenValue;
        private System.Windows.Forms.Label lblFrozenCaption;
        private System.Windows.Forms.Panel pnlExpired;
        private System.Windows.Forms.Label lblExpiredValue;
        private System.Windows.Forms.Label lblExpiredCaption;
        private System.Windows.Forms.Panel cardChart;
        private FitZoneGym.Controls.DonutChart donutChart;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel cardExpiring;
        private System.Windows.Forms.DataGridView dgvExpiring;
        private System.Windows.Forms.LinkLabel lnkViewAll;
        private System.Windows.Forms.Label lblExpiringTitle;
        private System.Windows.Forms.Panel cardActivity;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.Label lblActivityTitle;
    }
}
