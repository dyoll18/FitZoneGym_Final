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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = false;
            this.lblTitle.Text = "Confirm Logout";
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 35, 66);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.0F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Size = new System.Drawing.Size(380, 36);
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.AutoSize = false;
            this.lblMessage.Text = "Are you sure you want to logout?";
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMessage.Size = new System.Drawing.Size(380, 28);
            this.lblMessage.Location = new System.Drawing.Point(0, 76);
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.TabIndex = 1;
            // 
            // btnYes
            // 
            this.btnYes.Name = "btnYes";
            this.btnYes.Text = "Yes";
            this.btnYes.Size = new System.Drawing.Size(130, 40);
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnYes.Location = new System.Drawing.Point(50, 130);
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.TabIndex = 2;
            // 
            // btnNo
            // 
            this.btnNo.Name = "btnNo";
            this.btnNo.Text = "No";
            this.btnNo.Size = new System.Drawing.Size(130, 40);
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.BackColor = System.Drawing.Color.White;
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 221, 232);
            this.btnNo.Location = new System.Drawing.Point(200, 130);
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.TabIndex = 3;
            // 
            // LogoutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(380, 210);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Text = "Confirm Logout";
            this.AcceptButton = this.btnYes;
            this.CancelButton = this.btnNo;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}
