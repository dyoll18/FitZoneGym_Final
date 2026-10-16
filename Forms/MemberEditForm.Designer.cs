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
            lblName = new Label();
            txtName = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblGender = new Label();
            cboGender = new ComboBox();
            lblBirth = new Label();
            dtpBirth = new DateTimePicker();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblPlan = new Label();
            cboPlan = new ComboBox();
            lblStart = new Label();
            dtpStart = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F);
            lblName.ForeColor = Color.FromArgb(31, 41, 55);
            lblName.Location = new Point(20, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Full name *";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(170, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(360, 33);
            txtName.TabIndex = 1;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9.5F);
            lblContact.ForeColor = Color.FromArgb(31, 41, 55);
            lblContact.Location = new Point(20, 62);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(161, 25);
            lblContact.TabIndex = 2;
            lblContact.Text = "Contact number *";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 9.5F);
            txtContact.Location = new Point(170, 58);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(360, 33);
            txtContact.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F);
            lblEmail.ForeColor = Color.FromArgb(31, 41, 55);
            lblEmail.Location = new Point(20, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(170, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 33);
            txtEmail.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.5F);
            lblGender.ForeColor = Color.FromArgb(31, 41, 55);
            lblGender.Location = new Point(20, 138);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 25);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FlatStyle = FlatStyle.Flat;
            cboGender.Font = new Font("Segoe UI", 9.5F);
            cboGender.Items.AddRange(new object[] { "", "Male", "Female", "Other" });
            cboGender.Location = new Point(170, 134);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(160, 33);
            cboGender.TabIndex = 7;
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Font = new Font("Segoe UI", 9.5F);
            lblBirth.ForeColor = Color.FromArgb(31, 41, 55);
            lblBirth.Location = new Point(20, 176);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(118, 25);
            lblBirth.TabIndex = 8;
            lblBirth.Text = "Date of birth";
            // 
            // dtpBirth
            // 
            dtpBirth.Checked = false;
            dtpBirth.Font = new Font("Segoe UI", 9.5F);
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(170, 172);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.ShowCheckBox = true;
            dtpBirth.Size = new Size(160, 33);
            dtpBirth.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.5F);
            lblAddress.ForeColor = Color.FromArgb(31, 41, 55);
            lblAddress.Location = new Point(20, 214);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 25);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 9.5F);
            txtAddress.Location = new Point(170, 210);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(360, 60);
            txtAddress.TabIndex = 11;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9.5F);
            lblNotes.ForeColor = Color.FromArgb(31, 41, 55);
            lblNotes.Location = new Point(20, 286);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(61, 25);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Font = new Font("Segoe UI", 9.5F);
            txtNotes.Location = new Point(170, 282);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(360, 60);
            txtNotes.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.ForeColor = Color.FromArgb(31, 41, 55);
            lblStatus.Location = new Point(20, 362);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(135, 25);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Account status";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FlatStyle = FlatStyle.Flat;
            cboStatus.Font = new Font("Segoe UI", 9.5F);
            cboStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cboStatus.Location = new Point(170, 358);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(160, 33);
            cboStatus.TabIndex = 15;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 9.5F);
            lblPlan.ForeColor = Color.FromArgb(31, 41, 55);
            lblPlan.Location = new Point(20, 362);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(160, 25);
            lblPlan.TabIndex = 16;
            lblPlan.Text = "Membership plan";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FlatStyle = FlatStyle.Flat;
            cboPlan.Font = new Font("Segoe UI", 9.5F);
            cboPlan.Location = new Point(170, 358);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(360, 33);
            cboPlan.TabIndex = 17;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 9.5F);
            lblStart.ForeColor = Color.FromArgb(31, 41, 55);
            lblStart.Location = new Point(20, 400);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(92, 25);
            lblStart.TabIndex = 18;
            lblStart.Text = "Start date";
            // 
            // dtpStart
            // 
            dtpStart.Font = new Font("Segoe UI", 9.5F);
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(170, 396);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(160, 33);
            dtpStart.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(30, 111, 240);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(290, 466);
            btnSave.Margin = new Padding(0, 0, 8, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 34);
            btnSave.TabIndex = 20;
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
            btnCancel.Location = new Point(420, 466);
            btnCancel.Margin = new Padding(0, 0, 8, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 34);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // MemberEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(560, 520);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblGender);
            Controls.Add(cboGender);
            Controls.Add(lblBirth);
            Controls.Add(dtpBirth);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Controls.Add(lblStatus);
            Controls.Add(cboStatus);
            Controls.Add(lblPlan);
            Controls.Add(cboPlan);
            Controls.Add(lblStart);
            Controls.Add(dtpStart);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MemberEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add / Edit Member";
            ResumeLayout(false);
            PerformLayout();
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
