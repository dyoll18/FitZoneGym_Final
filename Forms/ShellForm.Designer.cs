namespace FitZoneGym.Forms
{
    partial class ShellForm
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
            rightPanel = new Panel();
            contentPanel = new Panel();
            headerPanel = new Panel();
            titleLabel = new Label();
            actionsFlow = new FlowLayoutPanel();
            userStrip = new Panel();
            whoLabel = new Label();
            sidebarPanel = new Panel();
            navFlow = new FlowLayoutPanel();
            logoutButton = new Button();
            logoLabel = new Label();
            rightPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            userStrip.SuspendLayout();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(contentPanel);
            rightPanel.Controls.Add(headerPanel);
            rightPanel.Controls.Add(userStrip);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(230, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1050, 760);
            rightPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(243, 246, 251);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 90);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(16);
            contentPanel.Size = new Size(1050, 670);
            contentPanel.TabIndex = 0;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(actionsFlow);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 34);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(18, 4, 18, 4);
            headerPanel.Size = new Size(1050, 56);
            headerPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(15, 35, 66);
            titleLabel.Location = new Point(18, 4);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1014, 48);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // actionsFlow
            // 
            actionsFlow.AutoSize = true;
            actionsFlow.BackColor = Color.White;
            actionsFlow.Dock = DockStyle.Right;
            actionsFlow.Location = new Point(1032, 4);
            actionsFlow.Name = "actionsFlow";
            actionsFlow.Padding = new Padding(0, 4, 0, 0);
            actionsFlow.Size = new Size(0, 48);
            actionsFlow.TabIndex = 1;
            actionsFlow.WrapContents = false;
            // 
            // userStrip
            // 
            userStrip.BackColor = Color.FromArgb(15, 35, 66);
            userStrip.Controls.Add(whoLabel);
            userStrip.Dock = DockStyle.Top;
            userStrip.Location = new Point(0, 0);
            userStrip.Name = "userStrip";
            userStrip.Size = new Size(1050, 34);
            userStrip.TabIndex = 2;
            // 
            // whoLabel
            // 
            whoLabel.Dock = DockStyle.Right;
            whoLabel.ForeColor = Color.White;
            whoLabel.Location = new Point(490, 0);
            whoLabel.Name = "whoLabel";
            whoLabel.Padding = new Padding(0, 0, 14, 0);
            whoLabel.Size = new Size(560, 34);
            whoLabel.TabIndex = 0;
            whoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(15, 35, 66);
            sidebarPanel.Controls.Add(navFlow);
            sidebarPanel.Controls.Add(logoutButton);
            sidebarPanel.Controls.Add(logoLabel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(230, 760);
            sidebarPanel.TabIndex = 1;
            // 
            // navFlow
            // 
            navFlow.AutoScroll = true;
            navFlow.BackColor = Color.FromArgb(15, 35, 66);
            navFlow.Dock = DockStyle.Fill;
            navFlow.FlowDirection = FlowDirection.TopDown;
            navFlow.Location = new Point(0, 64);
            navFlow.Name = "navFlow";
            navFlow.Padding = new Padding(0, 6, 0, 0);
            navFlow.Size = new Size(230, 650);
            navFlow.TabIndex = 0;
            navFlow.WrapContents = false;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(140, 30, 40);
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.Dock = DockStyle.Bottom;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(0, 714);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(230, 46);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "   Logout";
            logoutButton.TextAlign = ContentAlignment.MiddleLeft;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // logoLabel
            // 
            logoLabel.BackColor = Color.FromArgb(15, 35, 66);
            logoLabel.Dock = DockStyle.Top;
            logoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            logoLabel.ForeColor = Color.White;
            logoLabel.Location = new Point(0, 0);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(230, 64);
            logoLabel.TabIndex = 2;
            logoLabel.Text = "FITZONE GYM";
            logoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShellForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(243, 246, 251);
            ClientSize = new Size(1280, 760);
            Controls.Add(rightPanel);
            Controls.Add(sidebarPanel);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(1150, 700);
            Name = "ShellForm";
            Text = "FITZONE GYM";
            rightPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            userStrip.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel rightPanel;
        protected System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel headerPanel;
        protected System.Windows.Forms.Label titleLabel;
        protected System.Windows.Forms.FlowLayoutPanel actionsFlow;
        private System.Windows.Forms.Panel userStrip;
        private System.Windows.Forms.Label whoLabel;
        private System.Windows.Forms.Panel sidebarPanel;
        protected System.Windows.Forms.FlowLayoutPanel navFlow;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label logoLabel;
    }
}
