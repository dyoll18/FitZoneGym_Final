namespace FitZoneGym.Forms
{
    partial class LogoutDialog
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
            rootLayout = new TableLayoutPanel();
            lblTitle = new Label();
            lblMessage = new Label();
            btnYes = new Button();
            btnNo = new Button();
            rootLayout.SuspendLayout();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.AutoSize = true;
            rootLayout.BackColor = Color.Transparent;
            rootLayout.ColumnCount = 2;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            rootLayout.Controls.Add(lblTitle, 0, 0);
            rootLayout.Controls.Add(lblMessage, 0, 1);
            rootLayout.Controls.Add(btnYes, 0, 2);
            rootLayout.Controls.Add(btnNo, 1, 2);
            rootLayout.Location = new Point(0, 0);
            rootLayout.Margin = new Padding(0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(34, 30, 34, 26);
            rootLayout.RowCount = 3;
            rootLayout.RowStyles.Add(new RowStyle());
            rootLayout.RowStyles.Add(new RowStyle());
            rootLayout.RowStyles.Add(new RowStyle());
            rootLayout.Size = new Size(388, 259);
            rootLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            rootLayout.SetColumnSpan(lblTitle, 2);
            lblTitle.Font = new Font("Bahnschrift", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(244, 244, 246);
            lblTitle.Location = new Point(97, 30);
            lblTitle.Margin = new Padding(0, 0, 0, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 106);
            lblTitle.TabIndex = 0;
            lblTitle.Tag = "h1";
            lblTitle.Text = "Confirm Logout";
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.None;
            lblMessage.AutoSize = true;
            rootLayout.SetColumnSpan(lblMessage, 2);
            lblMessage.ForeColor = Color.FromArgb(156, 156, 170);
            lblMessage.Location = new Point(46, 142);
            lblMessage.Margin = new Padding(0, 0, 0, 24);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(296, 25);
            lblMessage.TabIndex = 1;
            lblMessage.Tag = "muted";
            lblMessage.Text = "Are you sure you want to log out?";
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(255, 94, 26);
            btnYes.Cursor = Cursors.Hand;
            btnYes.DialogResult = DialogResult.Yes;
            btnYes.Dock = DockStyle.Fill;
            btnYes.FlatAppearance.BorderColor = Color.FromArgb(255, 94, 26);
            btnYes.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 60, 8);
            btnYes.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 140, 66);
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnYes.ForeColor = Color.FromArgb(255, 255, 255);
            btnYes.Location = new Point(34, 191);
            btnYes.Margin = new Padding(0, 0, 6, 0);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(154, 42);
            btnYes.TabIndex = 2;
            btnYes.Tag = "primary";
            btnYes.Text = "Yes, log out";
            btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(36, 36, 43);
            btnNo.Cursor = Cursors.Hand;
            btnNo.DialogResult = DialogResult.No;
            btnNo.Dock = DockStyle.Fill;
            btnNo.FlatAppearance.BorderColor = Color.FromArgb(54, 54, 63);
            btnNo.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 34);
            btnNo.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 59);
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNo.ForeColor = Color.FromArgb(244, 244, 246);
            btnNo.Location = new Point(200, 191);
            btnNo.Margin = new Padding(6, 0, 0, 0);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(154, 42);
            btnNo.TabIndex = 3;
            btnNo.Tag = "secondary";
            btnNo.Text = "No, stay";
            btnNo.UseVisualStyleBackColor = false;
            // 
            // LogoutDialog
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(24, 24, 29);
            CancelButton = btnNo;
            ClientSize = new Size(406, 257);
            Controls.Add(rootLayout);
            Font = new Font("Segoe UI", 9.5F);
            ForeColor = Color.FromArgb(244, 244, 246);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogoutDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirm Logout";
            rootLayout.ResumeLayout(false);
            rootLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}
