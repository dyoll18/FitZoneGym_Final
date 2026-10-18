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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.numMonths = new System.Windows.Forms.NumericUpDown();
            this.lblFee = new System.Windows.Forms.Label();
            this.numFee = new System.Windows.Forms.NumericUpDown();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Name = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Text = "Plan name *";
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblName.Location = new System.Drawing.Point(20, 22);
            this.lblName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Name = "txtName";
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtName.Size = new System.Drawing.Size(280, 25);
            this.txtName.Location = new System.Drawing.Point(160, 18);
            this.txtName.TabIndex = 1;
            // 
            // lblMonths
            // 
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.AutoSize = true;
            this.lblMonths.Text = "Duration (months) *";
            this.lblMonths.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblMonths.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMonths.Location = new System.Drawing.Point(20, 62);
            this.lblMonths.TabIndex = 2;
            // 
            // numMonths
            // 
            this.numMonths.Name = "numMonths";
            this.numMonths.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numMonths.Maximum = new decimal(new int[] {60, 0, 0, 0});
            this.numMonths.Value = new decimal(new int[] {1, 0, 0, 0});
            this.numMonths.DecimalPlaces = 0;
            this.numMonths.ThousandsSeparator = true;
            this.numMonths.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numMonths.Size = new System.Drawing.Size(120, 25);
            this.numMonths.Location = new System.Drawing.Point(160, 58);
            this.numMonths.TabIndex = 3;
            // 
            // lblFee
            // 
            this.lblFee.Name = "lblFee";
            this.lblFee.AutoSize = true;
            this.lblFee.Text = "Fee *";
            this.lblFee.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblFee.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFee.Location = new System.Drawing.Point(20, 102);
            this.lblFee.TabIndex = 4;
            // 
            // numFee
            // 
            this.numFee.Name = "numFee";
            this.numFee.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.numFee.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.numFee.Value = new decimal(new int[] {0, 0, 0, 0});
            this.numFee.DecimalPlaces = 2;
            this.numFee.ThousandsSeparator = true;
            this.numFee.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numFee.Size = new System.Drawing.Size(160, 25);
            this.numFee.Location = new System.Drawing.Point(160, 98);
            this.numFee.TabIndex = 5;
            // 
            // lblDesc
            // 
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.AutoSize = true;
            this.lblDesc.Text = "Description";
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDesc.Location = new System.Drawing.Point(20, 142);
            this.lblDesc.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDesc.Size = new System.Drawing.Size(280, 60);
            this.txtDesc.Multiline = true;
            this.txtDesc.Location = new System.Drawing.Point(160, 138);
            this.txtDesc.TabIndex = 7;
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
            this.btnSave.Location = new System.Drawing.Point(220, 216);
            this.btnSave.TabIndex = 8;
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
            this.btnCancel.Location = new System.Drawing.Point(340, 216);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 9;
            // 
            // PlanEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(460, 270);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Text = "Add Plan";
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.numMonths);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.numFee);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
