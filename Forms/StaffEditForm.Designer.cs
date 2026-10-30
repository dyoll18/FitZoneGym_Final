namespace FitZoneGym.Forms
{
    partial class StaffEditForm
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
            lblUser = new Label();
            txtUser = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblRole = new Label();
            cboRole = new ComboBox();
            lblPass = new Label();
            txtPass = new TextBox();
            lblHint = new Label();
            chkActive = new CheckBox();
            btnSave = new FitZoneGym.Controls.ThemedButton();
            btnCancel = new FitZoneGym.Controls.ThemedButton();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.ForeColor = Color.FromArgb(244, 244, 248);
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.5F);
            lblUser.Location = new Point(20, 24);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(110, 25);
            lblUser.TabIndex = 0;
            lblUser.Text = "Username *";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(46, 47, 60);
            txtUser.ForeColor = Color.FromArgb(244, 244, 248);
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 9.5F);
            txtUser.Location = new Point(160, 20);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(260, 33);
            txtUser.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.ForeColor = Color.FromArgb(244, 244, 248);
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F);
            lblName.Location = new Point(20, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Full name *";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(46, 47, 60);
            txtName.ForeColor = Color.FromArgb(244, 244, 248);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(160, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 33);
            txtName.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.ForeColor = Color.FromArgb(244, 244, 248);
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9.5F);
            lblRole.Location = new Point(20, 100);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role *";
            // 
            // cboRole
            // 
            cboRole.BackColor = Color.FromArgb(46, 47, 60);
            cboRole.ForeColor = Color.FromArgb(244, 244, 248);
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FlatStyle = FlatStyle.Flat;
            cboRole.Font = new Font("Segoe UI", 9.5F);
            cboRole.Items.AddRange(new object[] { "Administrator", "Staff", "Cashier" });
            cboRole.Location = new Point(160, 96);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(260, 33);
            cboRole.TabIndex = 5;
            // 
            // lblPass
            // 
            lblPass.ForeColor = Color.FromArgb(244, 244, 248);
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.5F);
            lblPass.Location = new Point(20, 138);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(104, 25);
            lblPass.TabIndex = 6;
            lblPass.Text = "Password *";
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(46, 47, 60);
            txtPass.ForeColor = Color.FromArgb(244, 244, 248);
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 9.5F);
            txtPass.Location = new Point(160, 134);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(260, 33);
            txtPass.TabIndex = 7;
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblHint
            // 
            lblHint.ForeColor = Color.FromArgb(152, 155, 172);
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI", 9F);
            lblHint.Location = new Point(160, 170);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(354, 25);
            lblHint.TabIndex = 8;
            lblHint.Text = "Min. 8 characters, with letters and numbers.";
            // 
            // chkActive
            // 
            chkActive.ForeColor = Color.FromArgb(244, 244, 248);
            chkActive.AutoSize = true;
            chkActive.Checked = true;
            chkActive.CheckState = CheckState.Checked;
            chkActive.Font = new Font("Segoe UI", 9.5F);
            chkActive.Location = new Point(160, 200);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(179, 29);
            chkActive.TabIndex = 9;
            chkActive.Text = "Account is active";
            // 
            // btnSave
            // 
            btnSave.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.Location = new Point(160, 248);
            btnSave.Margin = new Padding(0, 0, 8, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Kind = FitZoneGym.Controls.ButtonKind.Secondary;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.Location = new Point(310, 248);
            btnCancel.Margin = new Padding(0, 0, 8, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            // 
            // StaffEditForm
            // 
            BackColor = Color.FromArgb(24, 25, 33);
            ForeColor = Color.FromArgb(244, 244, 248);
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = btnCancel;
            ClientSize = new Size(528, 310);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblRole);
            Controls.Add(cboRole);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(lblHint);
            Controls.Add(chkActive);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StaffEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Staff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.CheckBox chkActive;
        private FitZoneGym.Controls.ThemedButton btnSave;
        private FitZoneGym.Controls.ThemedButton btnCancel;
    }
}
