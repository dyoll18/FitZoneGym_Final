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
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = true;
            this.lblUser.Text = "Username *";
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUser.Location = new System.Drawing.Point(20, 24);
            this.lblUser.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Name = "txtUser";
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUser.Size = new System.Drawing.Size(260, 25);
            this.txtUser.Location = new System.Drawing.Point(160, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Name = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Text = "Full name *";
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblName.Location = new System.Drawing.Point(20, 62);
            this.lblName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Name = "txtName";
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtName.Size = new System.Drawing.Size(260, 25);
            this.txtName.Location = new System.Drawing.Point(160, 58);
            this.txtName.TabIndex = 3;
            // 
            // lblRole
            // 
            this.lblRole.Name = "lblRole";
            this.lblRole.AutoSize = true;
            this.lblRole.Text = "Role *";
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRole.Location = new System.Drawing.Point(20, 100);
            this.lblRole.TabIndex = 4;
            // 
            // cboRole
            // 
            this.cboRole.Name = "cboRole";
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboRole.Size = new System.Drawing.Size(220, 25);
            this.cboRole.Location = new System.Drawing.Point(160, 96);
            this.cboRole.Items.AddRange(new object[] { "Administrator", "Staff", "Cashier" });
            this.cboRole.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.Name = "lblPass";
            this.lblPass.AutoSize = true;
            this.lblPass.Text = "Password *";
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPass.Location = new System.Drawing.Point(20, 100);
            this.lblPass.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Name = "txtPass";
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPass.Size = new System.Drawing.Size(260, 25);
            this.txtPass.Location = new System.Drawing.Point(160, 96);
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TabIndex = 7;
            // 
            // lblHint
            // 
            this.lblHint.Name = "lblHint";
            this.lblHint.AutoSize = true;
            this.lblHint.Text = "Min. 8 characters, with letters and numbers.";
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9.0F);
            this.lblHint.Location = new System.Drawing.Point(160, 130);
            this.lblHint.TabIndex = 8;
            // 
            // chkActive
            // 
            this.chkActive.Name = "chkActive";
            this.chkActive.AutoSize = true;
            this.chkActive.Text = "Account is active";
            this.chkActive.Checked = true;
            this.chkActive.Location = new System.Drawing.Point(160, 158);
            this.chkActive.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkActive.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnSave.Location = new System.Drawing.Point(220, 250);
            this.btnSave.TabIndex = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 34);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 221, 232);
            this.btnCancel.Location = new System.Drawing.Point(340, 250);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 11;
            // 
            // StaffEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Text = "Add Staff";
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ResumeLayout(false);
            this.PerformLayout();
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
