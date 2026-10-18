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

        /// <summary>Designer generated.</summary>
        private void InitializeComponent()
        {
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblSpacer1 = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblSpacer2 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.buttonFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.formLayout.SuspendLayout();
            this.buttonFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // formLayout
            // 
            this.formLayout.ColumnCount = 2;
            this.formLayout.RowCount = 6;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.Controls.Add(this.lblUser, 0, 0);
            this.formLayout.Controls.Add(this.txtUser, 1, 0);
            this.formLayout.Controls.Add(this.lblName, 0, 1);
            this.formLayout.Controls.Add(this.txtName, 1, 1);
            this.formLayout.Controls.Add(this.lblPass, 0, 2);
            this.formLayout.Controls.Add(this.txtPass, 1, 2);
            this.formLayout.Controls.Add(this.lblSpacer1, 0, 3);
            this.formLayout.Controls.Add(this.lblHint, 1, 3);
            this.formLayout.Controls.Add(this.lblSpacer2, 0, 4);
            this.formLayout.Controls.Add(this.chkActive, 1, 4);
            this.formLayout.Controls.Add(this.buttonFlow, 0, 5);
            this.formLayout.SetColumnSpan(this.buttonFlow, 2);
            this.formLayout.Name = "formLayout";
            this.formLayout.Dock = System.Windows.Forms.DockStyle.None;
            this.formLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.formLayout.Padding = new System.Windows.Forms.Padding(28, 24, 28, 22);
            this.formLayout.AutoSize = true;
            this.formLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = true;
            this.lblUser.Text = "Username *";
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // txtUser
            // 
            this.txtUser.Name = "txtUser";
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtUser.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblName
            // 
            this.lblName.Name = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Text = "Full name *";
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // txtName
            // 
            this.txtName.Name = "txtName";
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtName.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblPass
            // 
            this.lblPass.Name = "lblPass";
            this.lblPass.AutoSize = true;
            this.lblPass.Text = "Password *";
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPass.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // txtPass
            // 
            this.txtPass.Name = "txtPass";
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPass.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblSpacer1
            // 
            this.lblSpacer1.Name = "lblSpacer1";
            this.lblSpacer1.AutoSize = true;
            this.lblSpacer1.Text = "";
            this.lblSpacer1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblSpacer1.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblHint
            // 
            this.lblHint.Name = "lblHint";
            this.lblHint.AutoSize = true;
            this.lblHint.Text = "Min. 8 characters, with letters and numbers.";
            this.lblHint.Tag = "muted";
            this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHint.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblHint.MaximumSize = new System.Drawing.Size(330, 0);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // lblSpacer2
            // 
            this.lblSpacer2.Name = "lblSpacer2";
            this.lblSpacer2.AutoSize = true;
            this.lblSpacer2.Text = "";
            this.lblSpacer2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblSpacer2.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // chkActive
            // 
            this.chkActive.Name = "chkActive";
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.Text = "Account is active";
            this.chkActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkActive.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.chkActive.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // buttonFlow
            // 
            this.buttonFlow.Controls.Add(this.btnCancel);
            this.buttonFlow.Controls.Add(this.btnSave);
            this.buttonFlow.Name = "buttonFlow";
            this.buttonFlow.AutoSize = true;
            this.buttonFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFlow.WrapContents = false;
            this.buttonFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonFlow.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.buttonFlow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonFlow.BackColor = System.Drawing.Color.Transparent;
            // 
            // btnCancel
            // 
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 38);
            this.btnCancel.Tag = "secondary";
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(36, 36, 43);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(54, 54, 63);
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 59);
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(28, 28, 34);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.Size = new System.Drawing.Size(116, 38);
            this.btnSave.Tag = "primary";
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.FlatAppearance.BorderSize = 1;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(205, 60, 8);
            this.btnSave.Click += this.btnSave_Click;
            // 
            // StaffEditForm
            // 
            this.Controls.Add(this.formLayout);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            this.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "StaffEditForm";
            this.Text = "Add Staff";
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.buttonFlow.ResumeLayout(false);
            this.buttonFlow.PerformLayout();
            this.formLayout.ResumeLayout(false);
            this.formLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formLayout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblSpacer1;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblSpacer2;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.FlowLayoutPanel buttonFlow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
