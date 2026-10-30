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
            btnSave = new FitZoneGym.Controls.ThemedButton();
            btnCancel = new FitZoneGym.Controls.ThemedButton();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.ForeColor = Color.FromArgb(244, 244, 248);
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.5F);
            lblName.Location = new Point(20, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Full name *";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(46, 47, 60);
            txtName.ForeColor = Color.FromArgb(244, 244, 248);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(170, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(360, 33);
            txtName.TabIndex = 1;
            // 
            // lblContact
            // 
            lblContact.ForeColor = Color.FromArgb(244, 244, 248);
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9.5F);
            lblContact.Location = new Point(20, 62);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(161, 25);
            lblContact.TabIndex = 2;
            lblContact.Text = "Contact number *";
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.FromArgb(46, 47, 60);
            txtContact.ForeColor = Color.FromArgb(244, 244, 248);
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 9.5F);
            txtContact.Location = new Point(170, 58);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(360, 33);
            txtContact.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.ForeColor = Color.FromArgb(244, 244, 248);
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.5F);
            lblEmail.Location = new Point(20, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(46, 47, 60);
            txtEmail.ForeColor = Color.FromArgb(244, 244, 248);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(170, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 33);
            txtEmail.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.ForeColor = Color.FromArgb(244, 244, 248);
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.5F);
            lblGender.Location = new Point(20, 138);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 25);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.BackColor = Color.FromArgb(46, 47, 60);
            cboGender.ForeColor = Color.FromArgb(244, 244, 248);
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
            lblBirth.ForeColor = Color.FromArgb(244, 244, 248);
            lblBirth.AutoSize = true;
            lblBirth.Font = new Font("Segoe UI", 9.5F);
            lblBirth.Location = new Point(20, 176);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(118, 25);
            lblBirth.TabIndex = 8;
            lblBirth.Text = "Date of birth";
            // 
            // dtpBirth
            // 
            dtpBirth.CalendarMonthBackground = Color.FromArgb(46, 47, 60);
            dtpBirth.CalendarForeColor = Color.FromArgb(244, 244, 248);
            dtpBirth.CalendarTitleBackColor = Color.FromArgb(255, 106, 0);
            dtpBirth.CalendarTitleForeColor = Color.White;
            dtpBirth.CalendarTrailingForeColor = Color.FromArgb(152, 155, 172);
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
            lblAddress.ForeColor = Color.FromArgb(244, 244, 248);
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.5F);
            lblAddress.Location = new Point(20, 214);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 25);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(46, 47, 60);
            txtAddress.ForeColor = Color.FromArgb(244, 244, 248);
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
            lblNotes.ForeColor = Color.FromArgb(244, 244, 248);
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9.5F);
            lblNotes.Location = new Point(20, 286);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(61, 25);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.FromArgb(46, 47, 60);
            txtNotes.ForeColor = Color.FromArgb(244, 244, 248);
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
            lblStatus.ForeColor = Color.FromArgb(244, 244, 248);
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.Location = new Point(20, 362);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(135, 25);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Account status";
            // 
            // cboStatus
            // 
            cboStatus.BackColor = Color.FromArgb(46, 47, 60);
            cboStatus.ForeColor = Color.FromArgb(244, 244, 248);
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
            lblPlan.ForeColor = Color.FromArgb(244, 244, 248);
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Segoe UI", 9.5F);
            lblPlan.Location = new Point(20, 362);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(160, 25);
            lblPlan.TabIndex = 16;
            lblPlan.Text = "Membership plan";
            // 
            // cboPlan
            // 
            cboPlan.BackColor = Color.FromArgb(46, 47, 60);
            cboPlan.ForeColor = Color.FromArgb(244, 244, 248);
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
            lblStart.ForeColor = Color.FromArgb(244, 244, 248);
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 9.5F);
            lblStart.Location = new Point(20, 400);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(92, 25);
            lblStart.TabIndex = 18;
            lblStart.Text = "Start date";
            // 
            // dtpStart
            // 
            dtpStart.CalendarMonthBackground = Color.FromArgb(46, 47, 60);
            dtpStart.CalendarForeColor = Color.FromArgb(244, 244, 248);
            dtpStart.CalendarTitleBackColor = Color.FromArgb(255, 106, 0);
            dtpStart.CalendarTitleForeColor = Color.White;
            dtpStart.CalendarTrailingForeColor = Color.FromArgb(152, 155, 172);
            dtpStart.Font = new Font("Segoe UI", 9.5F);
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(170, 396);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(160, 33);
            dtpStart.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.Location = new Point(290, 466);
            btnSave.Margin = new Padding(0, 0, 8, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 34);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Kind = FitZoneGym.Controls.ButtonKind.Secondary;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.Location = new Point(420, 466);
            btnCancel.Margin = new Padding(0, 0, 8, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 34);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            // 
            // MemberEditForm
            // 
            BackColor = Color.FromArgb(24, 25, 33);
            ForeColor = Color.FromArgb(244, 244, 248);
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
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
            MaximizeBox = true;
            MinimizeBox = false;
            Name = "MemberEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add / Edit Member";
            Load += MemberEditForm_Load;
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
        private FitZoneGym.Controls.ThemedButton btnSave;
        private FitZoneGym.Controls.ThemedButton btnCancel;
    }
}
