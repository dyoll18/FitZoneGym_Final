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

        /// <summary>Designer generated.</summary>
        private void InitializeComponent()
        {
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.numMonths = new System.Windows.Forms.NumericUpDown();
            this.lblFee = new System.Windows.Forms.Label();
            this.numFee = new System.Windows.Forms.NumericUpDown();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
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
            this.formLayout.RowCount = 5;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.Controls.Add(this.lblName, 0, 0);
            this.formLayout.Controls.Add(this.txtName, 1, 0);
            this.formLayout.Controls.Add(this.lblMonths, 0, 1);
            this.formLayout.Controls.Add(this.numMonths, 1, 1);
            this.formLayout.Controls.Add(this.lblFee, 0, 2);
            this.formLayout.Controls.Add(this.numFee, 1, 2);
            this.formLayout.Controls.Add(this.lblDesc, 0, 3);
            this.formLayout.Controls.Add(this.txtDesc, 1, 3);
            this.formLayout.Controls.Add(this.buttonFlow, 0, 4);
            this.formLayout.SetColumnSpan(this.buttonFlow, 2);
            this.formLayout.Name = "formLayout";
            this.formLayout.Dock = System.Windows.Forms.DockStyle.None;
            this.formLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.formLayout.Padding = new System.Windows.Forms.Padding(28, 24, 28, 22);
            this.formLayout.AutoSize = true;
            this.formLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblName
            // 
            this.lblName.Name = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Text = "Plan name *";
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
            // lblMonths
            // 
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.AutoSize = true;
            this.lblMonths.Text = "Duration (months) *";
            this.lblMonths.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMonths.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblMonths.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // numMonths
            // 
            this.numMonths.Name = "numMonths";
            this.numMonths.Minimum = 1M;
            this.numMonths.Maximum = 60M;
            this.numMonths.DecimalPlaces = 0;
            this.numMonths.ThousandsSeparator = true;
            this.numMonths.Size = new System.Drawing.Size(150, 27);
            this.numMonths.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.numMonths.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.numMonths.Value = 1M;
            this.numMonths.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.numMonths.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.numMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblFee
            // 
            this.lblFee.Name = "lblFee";
            this.lblFee.AutoSize = true;
            this.lblFee.Text = "Fee *";
            this.lblFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFee.Margin = new System.Windows.Forms.Padding(0, 7, 14, 7);
            this.lblFee.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // numFee
            // 
            this.numFee.Name = "numFee";
            this.numFee.Minimum = 0M;
            this.numFee.Maximum = 1000000M;
            this.numFee.DecimalPlaces = 2;
            this.numFee.ThousandsSeparator = true;
            this.numFee.Size = new System.Drawing.Size(150, 27);
            this.numFee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.numFee.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.numFee.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.numFee.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.numFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblDesc
            // 
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.AutoSize = true;
            this.lblDesc.Text = "Description";
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top;
            this.lblDesc.Margin = new System.Windows.Forms.Padding(0, 12, 14, 7);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // txtDesc
            // 
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDesc.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtDesc.Multiline = true;
            this.txtDesc.Size = new System.Drawing.Size(100, 72);
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // PlanEditForm
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
            this.Name = "PlanEditForm";
            this.Text = "Add Plan";
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.NumericUpDown numMonths;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.NumericUpDown numFee;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.FlowLayoutPanel buttonFlow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
