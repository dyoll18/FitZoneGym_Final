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

        /// <summary>Designer generated.</summary>
        private void InitializeComponent()
        {
            formLayout = new TableLayoutPanel();
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
            buttonFlow = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            formLayout.SuspendLayout();
            buttonFlow.SuspendLayout();
            SuspendLayout();
            // 
            // formLayout
            // 
            formLayout.AutoSize = true;
            formLayout.BackColor = Color.Transparent;
            formLayout.ColumnCount = 2;
            formLayout.ColumnStyles.Add(new ColumnStyle());
            formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            formLayout.Controls.Add(lblName, 0, 0);
            formLayout.Controls.Add(txtName, 1, 0);
            formLayout.Controls.Add(lblContact, 0, 1);
            formLayout.Controls.Add(txtContact, 1, 1);
            formLayout.Controls.Add(lblEmail, 0, 2);
            formLayout.Controls.Add(txtEmail, 1, 2);
            formLayout.Controls.Add(lblGender, 0, 3);
            formLayout.Controls.Add(cboGender, 1, 3);
            formLayout.Controls.Add(lblBirth, 0, 4);
            formLayout.Controls.Add(dtpBirth, 1, 4);
            formLayout.Controls.Add(lblAddress, 0, 5);
            formLayout.Controls.Add(txtAddress, 1, 5);
            formLayout.Controls.Add(lblNotes, 0, 6);
            formLayout.Controls.Add(txtNotes, 1, 6);
            formLayout.Controls.Add(lblStatus, 0, 7);
            formLayout.Controls.Add(cboStatus, 1, 7);
            formLayout.Controls.Add(lblPlan, 0, 8);
            formLayout.Controls.Add(cboPlan, 1, 8);
            formLayout.Controls.Add(lblStart, 0, 9);
            formLayout.Controls.Add(dtpStart, 1, 9);
            formLayout.Controls.Add(buttonFlow, 0, 10);
            formLayout.Location = new Point(0, 0);
            formLayout.Margin = new Padding(0);
            formLayout.Name = "formLayout";
            formLayout.Padding = new Padding(28, 24, 28, 22);
            formLayout.RowCount = 11;
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.RowStyles.Add(new RowStyle());
            formLayout.Size = new Size(561, 592);
            formLayout.TabIndex = 0;
            formLayout.Paint += formLayout_Paint;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(244, 244, 246);
            lblName.Location = new Point(28, 33);
            lblName.Margin = new Padding(0, 7, 14, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Full name *";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = Color.FromArgb(42, 42, 50);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.FromArgb(244, 244, 246);
            txtName.Location = new Point(203, 29);
            txtName.Margin = new Padding(0, 5, 0, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 33);
            txtName.TabIndex = 1;
            // 
            // lblContact
            // 
            lblContact.Anchor = AnchorStyles.Left;
            lblContact.AutoSize = true;
            lblContact.ForeColor = Color.FromArgb(244, 244, 246);
            lblContact.Location = new Point(28, 76);
            lblContact.Margin = new Padding(0, 7, 14, 7);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(161, 25);
            lblContact.TabIndex = 2;
            lblContact.Text = "Contact number *";
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtContact.BackColor = Color.FromArgb(42, 42, 50);
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.ForeColor = Color.FromArgb(244, 244, 246);
            txtContact.Location = new Point(203, 72);
            txtContact.Margin = new Padding(0, 5, 0, 5);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(330, 33);
            txtContact.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(244, 244, 246);
            lblEmail.Location = new Point(28, 119);
            lblEmail.Margin = new Padding(0, 7, 14, 7);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(42, 42, 50);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.FromArgb(244, 244, 246);
            txtEmail.Location = new Point(203, 115);
            txtEmail.Margin = new Padding(0, 5, 0, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 33);
            txtEmail.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Left;
            lblGender.AutoSize = true;
            lblGender.ForeColor = Color.FromArgb(244, 244, 246);
            lblGender.Location = new Point(28, 162);
            lblGender.Margin = new Padding(0, 7, 14, 7);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 25);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboGender.BackColor = Color.FromArgb(42, 42, 50);
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FlatStyle = FlatStyle.Flat;
            cboGender.ForeColor = Color.FromArgb(244, 244, 246);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "", "Male", "Female", "Other" });
            cboGender.Location = new Point(203, 158);
            cboGender.Margin = new Padding(0, 5, 0, 5);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(330, 33);
            cboGender.TabIndex = 7;
            // 
            // lblBirth
            // 
            lblBirth.Anchor = AnchorStyles.Left;
            lblBirth.AutoSize = true;
            lblBirth.ForeColor = Color.FromArgb(244, 244, 246);
            lblBirth.Location = new Point(28, 205);
            lblBirth.Margin = new Padding(0, 7, 14, 7);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(118, 25);
            lblBirth.TabIndex = 8;
            lblBirth.Text = "Date of birth";
            // 
            // dtpBirth
            // 
            dtpBirth.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpBirth.CalendarForeColor = Color.FromArgb(244, 244, 246);
            dtpBirth.CalendarMonthBackground = Color.FromArgb(36, 36, 43);
            dtpBirth.CalendarTitleBackColor = Color.FromArgb(255, 94, 26);
            dtpBirth.CalendarTitleForeColor = Color.FromArgb(255, 255, 255);
            dtpBirth.CalendarTrailingForeColor = Color.FromArgb(156, 156, 170);
            dtpBirth.Checked = false;
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(203, 201);
            dtpBirth.Margin = new Padding(0, 5, 0, 5);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.ShowCheckBox = true;
            dtpBirth.Size = new Size(330, 33);
            dtpBirth.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = Color.FromArgb(244, 244, 246);
            lblAddress.Location = new Point(28, 251);
            lblAddress.Margin = new Padding(0, 12, 14, 7);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 25);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BackColor = Color.FromArgb(42, 42, 50);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.ForeColor = Color.FromArgb(244, 244, 246);
            txtAddress.Location = new Point(203, 244);
            txtAddress.Margin = new Padding(0, 5, 0, 5);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(330, 64);
            txtAddress.TabIndex = 11;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.ForeColor = Color.FromArgb(244, 244, 246);
            lblNotes.Location = new Point(28, 325);
            lblNotes.Margin = new Padding(0, 12, 14, 7);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(61, 25);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.BackColor = Color.FromArgb(42, 42, 50);
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.ForeColor = Color.FromArgb(244, 244, 246);
            txtNotes.Location = new Point(203, 318);
            txtNotes.Margin = new Padding(0, 5, 0, 5);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(330, 64);
            txtNotes.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.FromArgb(244, 244, 246);
            lblStatus.Location = new Point(28, 396);
            lblStatus.Margin = new Padding(0, 7, 14, 7);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(135, 25);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Account status";
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.BackColor = Color.FromArgb(42, 42, 50);
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FlatStyle = FlatStyle.Flat;
            cboStatus.ForeColor = Color.FromArgb(244, 244, 246);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cboStatus.Location = new Point(203, 392);
            cboStatus.Margin = new Padding(0, 5, 0, 5);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(330, 33);
            cboStatus.TabIndex = 15;
            // 
            // lblPlan
            // 
            lblPlan.Anchor = AnchorStyles.Left;
            lblPlan.AutoSize = true;
            lblPlan.ForeColor = Color.FromArgb(244, 244, 246);
            lblPlan.Location = new Point(28, 439);
            lblPlan.Margin = new Padding(0, 7, 14, 7);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(160, 25);
            lblPlan.TabIndex = 16;
            lblPlan.Text = "Membership plan";
            // 
            // cboPlan
            // 
            cboPlan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboPlan.BackColor = Color.FromArgb(42, 42, 50);
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FlatStyle = FlatStyle.Flat;
            cboPlan.ForeColor = Color.FromArgb(244, 244, 246);
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new Point(203, 435);
            cboPlan.Margin = new Padding(0, 5, 0, 5);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(330, 33);
            cboPlan.TabIndex = 17;
            // 
            // lblStart
            // 
            lblStart.Anchor = AnchorStyles.Left;
            lblStart.AutoSize = true;
            lblStart.ForeColor = Color.FromArgb(244, 244, 246);
            lblStart.Location = new Point(28, 482);
            lblStart.Margin = new Padding(0, 7, 14, 7);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(92, 25);
            lblStart.TabIndex = 18;
            lblStart.Text = "Start date";
            // 
            // dtpStart
            // 
            dtpStart.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpStart.CalendarForeColor = Color.FromArgb(244, 244, 246);
            dtpStart.CalendarMonthBackground = Color.FromArgb(36, 36, 43);
            dtpStart.CalendarTitleBackColor = Color.FromArgb(255, 94, 26);
            dtpStart.CalendarTitleForeColor = Color.FromArgb(255, 255, 255);
            dtpStart.CalendarTrailingForeColor = Color.FromArgb(156, 156, 170);
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(203, 478);
            dtpStart.Margin = new Padding(0, 5, 0, 5);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(330, 33);
            dtpStart.TabIndex = 19;
            // 
            // buttonFlow
            // 
            buttonFlow.Anchor = AnchorStyles.Right;
            buttonFlow.AutoSize = true;
            buttonFlow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonFlow.BackColor = Color.Transparent;
            formLayout.SetColumnSpan(buttonFlow, 2);
            buttonFlow.Controls.Add(btnCancel);
            buttonFlow.Controls.Add(btnSave);
            buttonFlow.FlowDirection = FlowDirection.RightToLeft;
            buttonFlow.Location = new Point(291, 532);
            buttonFlow.Margin = new Padding(0, 16, 0, 0);
            buttonFlow.Name = "buttonFlow";
            buttonFlow.Size = new Size(242, 38);
            buttonFlow.TabIndex = 20;
            buttonFlow.WrapContents = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(36, 36, 43);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(54, 54, 63);
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 34);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 59);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(244, 244, 246);
            btnCancel.Location = new Point(126, 0);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 38);
            btnCancel.TabIndex = 0;
            btnCancel.Tag = "secondary";
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 94, 26);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(255, 94, 26);
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 60, 8);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 140, 66);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(255, 255, 255);
            btnSave.Location = new Point(0, 0);
            btnSave.Margin = new Padding(0, 0, 10, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 38);
            btnSave.TabIndex = 1;
            btnSave.Tag = "primary";
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // MemberEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(24, 24, 29);
            CancelButton = btnCancel;
            ClientSize = new Size(569, 591);
            Controls.Add(formLayout);
            Font = new Font("Segoe UI", 9.5F);
            ForeColor = Color.FromArgb(244, 244, 246);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MemberEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add / Edit Member";
            formLayout.ResumeLayout(false);
            formLayout.PerformLayout();
            buttonFlow.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formLayout;
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
        private System.Windows.Forms.FlowLayoutPanel buttonFlow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
