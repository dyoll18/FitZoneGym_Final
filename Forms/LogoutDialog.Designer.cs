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

        /// <summary>Designer generated: do not modify the contents of this method with the code editor.</summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblMessage = new Label();
            btnYes = new FitZoneGym.Controls.ThemedButton();
            btnNo = new FitZoneGym.Controls.ThemedButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(35, 36, 47);
            lblTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(23, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Confirm Logout";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9.5F);
            lblMessage.ForeColor = Color.FromArgb(244, 244, 248);
            lblMessage.Location = new Point(23, 101);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(380, 28);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Are you sure you want to logout?";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(255, 106, 0);
            btnYes.DialogResult = DialogResult.Yes;
            btnYes.FlatAppearance.BorderColor = Color.FromArgb(255, 106, 0);
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 106, 0);
            btnYes.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 136, 56);
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.ForeColor = Color.White;
            btnYes.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnYes.Location = new Point(60, 156);
            btnYes.Margin = new Padding(0, 0, 8, 0);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(129, 50);
            btnYes.TabIndex = 2;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(46, 47, 60);
            btnNo.DialogResult = DialogResult.No;
            btnNo.FlatAppearance.BorderColor = Color.FromArgb(58, 60, 76);
            btnNo.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 47, 60);
            btnNo.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 47, 60);
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.ForeColor = Color.FromArgb(244, 244, 248);
            btnNo.Location = new Point(236, 156);
            btnNo.Margin = new Padding(0, 0, 8, 0);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(137, 50);
            btnNo.TabIndex = 3;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            // 
            // LogoutDialog
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(24, 25, 33);
            CancelButton = btnNo;
            ClientSize = new Size(424, 235);
            Controls.Add(lblTitle);
            Controls.Add(lblMessage);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Font = new Font("Segoe UI", 9.5F);
            ForeColor = Color.FromArgb(244, 244, 248);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogoutDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirm Logout";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private FitZoneGym.Controls.ThemedButton btnYes;
        private FitZoneGym.Controls.ThemedButton btnNo;
    }
}
