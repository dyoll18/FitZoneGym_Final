namespace FitZoneGym.Forms
{
    partial class MemberEditForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Name = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Text = "Full name *";
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblName.Location = new System.Drawing.Point(20, 24);
            this.lblName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Name = "txtName";
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtName.Size = new System.Drawing.Size(360, 25);
            this.txtName.Location = new System.Drawing.Point(170, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblContact
            // 
            this.lblContact.Name = "lblContact";
            this.lblContact.AutoSize = true;
            this.lblContact.Text = "Contact number *";
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblContact.Location = new System.Drawing.Point(20, 62);
            this.lblContact.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.Name = "txtContact";
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtContact.Size = new System.Drawing.Size(360, 25);
            this.txtContact.Location = new System.Drawing.Point(170, 58);
            this.txtContact.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Text = "Email";
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmail.Location = new System.Drawing.Point(20, 100);
            this.lblEmail.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.Size = new System.Drawing.Size(360, 25);
            this.txtEmail.Location = new System.Drawing.Point(170, 96);
            this.txtEmail.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.Name = "lblGender";
            this.lblGender.AutoSize = true;
            this.lblGender.Text = "Gender";
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGender.Location = new System.Drawing.Point(20, 138);
            this.lblGender.TabIndex = 6;
            // 
            // cboGender
            // 
            this.cboGender.Name = "cboGender";
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboGender.Size = new System.Drawing.Size(160, 25);
            this.cboGender.Location = new System.Drawing.Point(170, 134);
            this.cboGender.Items.AddRange(new object[] { "", "Male", "Female", "Other" });
            this.cboGender.TabIndex = 7;
            // 
            // lblBirth
            // 
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.AutoSize = true;
            this.lblBirth.Text = "Date of birth";
            this.lblBirth.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblBirth.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBirth.Location = new System.Drawing.Point(20, 176);
            this.lblBirth.TabIndex = 8;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpBirth.Size = new System.Drawing.Size(160, 25);
            this.dtpBirth.Location = new System.Drawing.Point(170, 172);
            this.dtpBirth.ShowCheckBox = true;
            this.dtpBirth.Checked = false;
            this.dtpBirth.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.AutoSize = true;
            this.lblAddress.Text = "Address";
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAddress.Location = new System.Drawing.Point(20, 214);
            this.lblAddress.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAddress.Size = new System.Drawing.Size(360, 60);
            this.txtAddress.Multiline = true;
            this.txtAddress.Location = new System.Drawing.Point(170, 210);
            this.txtAddress.TabIndex = 11;
            // 
            // lblNotes
            // 
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.AutoSize = true;
            this.lblNotes.Text = "Notes";
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNotes.Location = new System.Drawing.Point(20, 286);
            this.lblNotes.TabIndex = 12;
            // 
            // txtNotes
            // 
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNotes.Size = new System.Drawing.Size(360, 60);
            this.txtNotes.Multiline = true;
            this.txtNotes.Location = new System.Drawing.Point(170, 282);
            this.txtNotes.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.AutoSize = true;
            this.lblStatus.Text = "Account status";
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStatus.Location = new System.Drawing.Point(20, 362);
            this.lblStatus.TabIndex = 14;
            // 
            // cboStatus
            // 
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboStatus.Size = new System.Drawing.Size(160, 25);
            this.cboStatus.Location = new System.Drawing.Point(170, 358);
            this.cboStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            this.cboStatus.TabIndex = 15;
            // 
            // lblPlan
            // 
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.AutoSize = true;
            this.lblPlan.Text = "Membership plan";
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPlan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPlan.Location = new System.Drawing.Point(20, 362);
            this.lblPlan.TabIndex = 16;
            // 
            // cboPlan
            // 
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboPlan.Size = new System.Drawing.Size(360, 25);
            this.cboPlan.Location = new System.Drawing.Point(170, 358);
            this.cboPlan.TabIndex = 17;
            // 
            // lblStart
            // 
            this.lblStart.Name = "lblStart";
            this.lblStart.AutoSize = true;
            this.lblStart.Text = "Start date";
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStart.Location = new System.Drawing.Point(20, 400);
            this.lblStart.TabIndex = 18;
            // 
            // dtpStart
            // 
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpStart.Size = new System.Drawing.Size(160, 25);
            this.dtpStart.Location = new System.Drawing.Point(170, 396);
            this.dtpStart.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.Size = new System.Drawing.Size(120, 34);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnSave.Location = new System.Drawing.Point(290, 466);
            this.btnSave.TabIndex = 20;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 34);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 221, 232);
            this.btnCancel.Location = new System.Drawing.Point(420, 466);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 21;
            // 
            // MemberEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(560, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Text = "Add / Edit Member";
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.cboPlan);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
