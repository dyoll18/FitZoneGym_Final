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
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.5F);
            lblUser.ForeColor = Color.FromArgb(31, 41, 55);
            lblUser.Location = new Point(20, 24);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(110, 25);
            lblUser.TabIndex = 0;
            lblUser.Text = "Username *";
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 9.5F);
            txtUser.Location = new Point(160, 20);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(260, 33);
            txtUser.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F);
            lblName.ForeColor = Color.FromArgb(31, 41, 55);
            lblName.Location = new Point(20, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Full name *";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(160, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 33);
            txtName.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9.5F);
            lblRole.ForeColor = Color.FromArgb(31, 41, 55);
            lblRole.Location = new Point(20, 100);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role *";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FlatStyle = FlatStyle.Flat;
            cboRole.Font = new Font("Segoe UI", 9.5F);
            cboRole.Items.AddRange(new object[] { "Administrator", "Staff", "Cashier" });
            cboRole.Location = new Point(160, 96);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(220, 33);
            cboRole.TabIndex = 5;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.5F);
            lblPass.ForeColor = Color.FromArgb(31, 41, 55);
            lblPass.Location = new Point(20, 100);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(104, 25);
            lblPass.TabIndex = 6;
            lblPass.Text = "Password *";
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 9.5F);
            txtPass.Location = new Point(160, 96);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(260, 33);
            txtPass.TabIndex = 7;
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI", 9F);
            lblHint.ForeColor = Color.FromArgb(107, 114, 128);
            lblHint.Location = new Point(160, 130);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(354, 25);
            lblHint.TabIndex = 8;
            lblHint.Text = "Min. 8 characters, with letters and numbers.";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Checked = true;
            chkActive.CheckState = CheckState.Checked;
            chkActive.Font = new Font("Segoe UI", 9.5F);
            chkActive.Location = new Point(160, 158);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(179, 29);
            chkActive.TabIndex = 9;
            chkActive.Text = "Account is active";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(30, 111, 240);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(160, 205);
            btnSave.Margin = new Padding(0, 0, 8, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(214, 221, 232);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(31, 41, 55);
            btnCancel.Location = new Point(310, 205);
            btnCancel.Margin = new Padding(0, 0, 8, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // StaffEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(528, 271);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblName);
            Controls.Add(txtName);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
