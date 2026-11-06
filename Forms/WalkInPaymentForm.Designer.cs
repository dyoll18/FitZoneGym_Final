namespace FitZoneGym.Forms
{
    partial class WalkInPaymentForm
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

        private void InitializeComponent()
        {
            lblClient = new Label();
            lblTime = new Label();
            lblAmount = new Label();
            lblMethod = new Label();
            cboMethod = new ComboBox();
            lblRef = new Label();
            txtRef = new TextBox();
            btnConfirm = new FitZoneGym.Controls.ThemedButton();
            btnCancel = new FitZoneGym.Controls.ThemedButton();
            SuspendLayout();
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblClient.ForeColor = Color.FromArgb(244, 244, 248);
            lblClient.Location = new Point(20, 16);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(160, 36);
            lblClient.TabIndex = 0;
            lblClient.Text = "Client name";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 10F);
            lblTime.ForeColor = Color.FromArgb(152, 155, 172);
            lblTime.Location = new Point(20, 50);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(302, 28);
            lblTime.TabIndex = 1;
            lblTime.Text = "0h 0m  ->  1 hr x ₱50.00 per hour";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(34, 197, 94);
            lblAmount.Location = new Point(20, 80);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(326, 45);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount due: ₱50.00";
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Font = new Font("Segoe UI", 9F);
            lblMethod.ForeColor = Color.FromArgb(152, 155, 172);
            lblMethod.Location = new Point(20, 125);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(148, 25);
            lblMethod.TabIndex = 3;
            lblMethod.Text = "Payment method";
            // 
            // cboMethod
            // 
            cboMethod.BackColor = Color.FromArgb(46, 47, 60);
            cboMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMethod.FlatStyle = FlatStyle.Flat;
            cboMethod.Font = new Font("Segoe UI", 9.5F);
            cboMethod.ForeColor = Color.FromArgb(244, 244, 248);
            cboMethod.Items.AddRange(new object[] { "Cash", "GCash", "Card", "Other" });
            cboMethod.Location = new Point(20, 154);
            cboMethod.Name = "cboMethod";
            cboMethod.Size = new Size(400, 33);
            cboMethod.TabIndex = 4;
            // 
            // lblRef
            // 
            lblRef.AutoSize = true;
            lblRef.Font = new Font("Segoe UI", 9F);
            lblRef.ForeColor = Color.FromArgb(152, 155, 172);
            lblRef.Location = new Point(17, 190);
            lblRef.Name = "lblRef";
            lblRef.Size = new Size(305, 25);
            lblRef.TabIndex = 5;
            lblRef.Text = "Reference no. (required for non-cash)";
            // 
            // txtRef
            // 
            txtRef.BackColor = Color.FromArgb(46, 47, 60);
            txtRef.BorderStyle = BorderStyle.FixedSingle;
            txtRef.Font = new Font("Segoe UI", 9.5F);
            txtRef.ForeColor = Color.FromArgb(244, 244, 248);
            txtRef.Location = new Point(20, 218);
            txtRef.Name = "txtRef";
            txtRef.Size = new Size(400, 33);
            txtRef.TabIndex = 6;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(34, 197, 94);
            btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(34, 197, 94);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 197, 94);
            btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 222, 128);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Kind = FitZoneGym.Controls.ButtonKind.Success;
            btnConfirm.Location = new Point(20, 274);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(170, 36);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirm Payment";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(46, 47, 60);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(58, 60, 76);
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 47, 60);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 47, 60);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(244, 244, 248);
            btnCancel.Location = new Point(200, 274);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // WalkInPaymentForm
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(24, 25, 33);
            CancelButton = btnCancel;
            ClientSize = new Size(440, 336);
            Controls.Add(lblClient);
            Controls.Add(lblTime);
            Controls.Add(lblAmount);
            Controls.Add(lblMethod);
            Controls.Add(cboMethod);
            Controls.Add(lblRef);
            Controls.Add(txtRef);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 9.5F);
            ForeColor = Color.FromArgb(244, 244, 248);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WalkInPaymentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Walk-In Payment";
            Load += WalkInPaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtRef;
        private FitZoneGym.Controls.ThemedButton btnConfirm;
        private FitZoneGym.Controls.ThemedButton btnCancel;
    }
}
