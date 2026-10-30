namespace FitZoneGym.Forms
{
    partial class PlanEditForm
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
            lblMonths = new Label();
            numMonths = new NumericUpDown();
            lblFee = new Label();
            numFee = new NumericUpDown();
            lblDesc = new Label();
            txtDesc = new TextBox();
            btnSave = new FitZoneGym.Controls.ThemedButton();
            btnCancel = new FitZoneGym.Controls.ThemedButton();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.ForeColor = Color.FromArgb(244, 244, 248);
            lblName.Name = "lblName";
            lblName.AutoSize = true;
            lblName.Text = "Plan name *";
            lblName.Font = new Font("Segoe UI", 9.5F);
            lblName.Location = new Point(20, 22);
            lblName.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(46, 47, 60);
            txtName.ForeColor = Color.FromArgb(244, 244, 248);
            txtName.Name = "txtName";
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Size = new Size(280, 25);
            txtName.Location = new Point(160, 18);
            txtName.TabIndex = 1;
            // 
            // lblMonths
            // 
            lblMonths.ForeColor = Color.FromArgb(244, 244, 248);
            lblMonths.Name = "lblMonths";
            lblMonths.AutoSize = true;
            lblMonths.Text = "Duration (months) *";
            lblMonths.Font = new Font("Segoe UI", 9.5F);
            lblMonths.Location = new Point(20, 62);
            lblMonths.TabIndex = 2;
            // 
            // numMonths
            // 
            numMonths.BorderStyle = BorderStyle.FixedSingle;
            numMonths.BackColor = Color.FromArgb(46, 47, 60);
            numMonths.ForeColor = Color.FromArgb(244, 244, 248);
            numMonths.Name = "numMonths";
            numMonths.Minimum = new decimal(new int[] {1, 0, 0, 0});
            numMonths.Maximum = new decimal(new int[] {60, 0, 0, 0});
            numMonths.Value = new decimal(new int[] {1, 0, 0, 0});
            numMonths.DecimalPlaces = 0;
            numMonths.ThousandsSeparator = true;
            numMonths.Font = new Font("Segoe UI", 9.5F);
            numMonths.Size = new Size(120, 25);
            numMonths.Location = new Point(160, 58);
            numMonths.TabIndex = 3;
            // 
            // lblFee
            // 
            lblFee.ForeColor = Color.FromArgb(244, 244, 248);
            lblFee.Name = "lblFee";
            lblFee.AutoSize = true;
            lblFee.Text = "Fee *";
            lblFee.Font = new Font("Segoe UI", 9.5F);
            lblFee.Location = new Point(20, 102);
            lblFee.TabIndex = 4;
            // 
            // numFee
            // 
            numFee.BorderStyle = BorderStyle.FixedSingle;
            numFee.BackColor = Color.FromArgb(46, 47, 60);
            numFee.ForeColor = Color.FromArgb(244, 244, 248);
            numFee.Name = "numFee";
            numFee.Minimum = new decimal(new int[] {0, 0, 0, 0});
            numFee.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            numFee.Value = new decimal(new int[] {0, 0, 0, 0});
            numFee.DecimalPlaces = 2;
            numFee.ThousandsSeparator = true;
            numFee.Font = new Font("Segoe UI", 9.5F);
            numFee.Size = new Size(160, 25);
            numFee.Location = new Point(160, 98);
            numFee.TabIndex = 5;
            // 
            // lblDesc
            // 
            lblDesc.ForeColor = Color.FromArgb(244, 244, 248);
            lblDesc.Name = "lblDesc";
            lblDesc.AutoSize = true;
            lblDesc.Text = "Description";
            lblDesc.Font = new Font("Segoe UI", 9.5F);
            lblDesc.Location = new Point(20, 142);
            lblDesc.TabIndex = 6;
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.FromArgb(46, 47, 60);
            txtDesc.ForeColor = Color.FromArgb(244, 244, 248);
            txtDesc.Name = "txtDesc";
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Segoe UI", 9.5F);
            txtDesc.Size = new Size(280, 60);
            txtDesc.Multiline = true;
            txtDesc.Location = new Point(160, 138);
            txtDesc.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnSave.Name = "btnSave";
            btnSave.Text = "Save";
            btnSave.Size = new Size(110, 34);
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.Margin = new Padding(0, 0, 8, 0);
            btnSave.Location = new Point(220, 216);
            btnSave.TabIndex = 8;
            btnSave.Click += new System.EventHandler(btnSave_Click);
            // 
            // btnCancel
            // 
            btnCancel.Kind = FitZoneGym.Controls.ButtonKind.Secondary;
            btnCancel.Name = "btnCancel";
            btnCancel.Text = "Cancel";
            btnCancel.Size = new Size(110, 34);
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.Margin = new Padding(0, 0, 8, 0);
            btnCancel.Location = new Point(340, 216);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.TabIndex = 9;
            // 
            // PlanEditForm
            // 
            BackColor = Color.FromArgb(24, 25, 33);
            ForeColor = Color.FromArgb(244, 244, 248);
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(460, 270);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Font = new Font("Segoe UI", 9.5F);
            Text = "Add Plan";
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblMonths);
            Controls.Add(numMonths);
            Controls.Add(lblFee);
            Controls.Add(numFee);
            Controls.Add(lblDesc);
            Controls.Add(txtDesc);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.NumericUpDown numMonths;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.NumericUpDown numFee;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private FitZoneGym.Controls.ThemedButton btnSave;
        private FitZoneGym.Controls.ThemedButton btnCancel;
    }
}
