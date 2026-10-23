namespace FitZoneGym.Forms
{
    partial class PlansForm
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
            mainLayout = new TableLayoutPanel();
            dgvPlans = new DataGridView();
            footerPanel = new Panel();
            btnEdit = new Button();
            btnToggle = new Button();
            lblNote = new Label();
            btnAdd = new Button();
            contentPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            actionsFlow.SuspendLayout();
            mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).BeginInit();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(mainLayout);
            // 
            // actionsFlow
            // 
            actionsFlow.Controls.Add(btnAdd);
            // 
            // headerPanel
            // 
            // 
            // titleLabel
            // 
            titleLabel.Text = "Membership Plans";
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.FromArgb(243, 246, 251);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(dgvPlans, 0, 0);
            mainLayout.Controls.Add(footerPanel, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(16, 16);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.Size = new Size(1018, 638);
            mainLayout.TabIndex = 0;
            // 
            // dgvPlans
            // 
            dgvPlans.ColumnHeadersHeight = 34;
            dgvPlans.Dock = DockStyle.Fill;
            dgvPlans.Location = new Point(3, 3);
            dgvPlans.Name = "dgvPlans";
            dgvPlans.RowHeadersWidth = 62;
            dgvPlans.Size = new Size(1012, 582);
            dgvPlans.TabIndex = 0;
            dgvPlans.CellDoubleClick += dgvPlans_CellDoubleClick;
            dgvPlans.SelectionChanged += dgvPlans_SelectionChanged;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(243, 246, 251);
            footerPanel.Controls.Add(btnEdit);
            footerPanel.Controls.Add(btnToggle);
            footerPanel.Controls.Add(lblNote);
            footerPanel.Dock = DockStyle.Fill;
            footerPanel.Location = new Point(3, 591);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(1012, 44);
            footerPanel.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(30, 111, 240);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(0, 8);
            btnEdit.Margin = new Padding(0, 0, 8, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 34);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.White;
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.FlatAppearance.BorderColor = Color.FromArgb(214, 221, 232);
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnToggle.ForeColor = Color.FromArgb(31, 41, 55);
            btnToggle.Location = new Point(110, 8);
            btnToggle.Margin = new Padding(0, 0, 8, 0);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(120, 34);
            btnToggle.TabIndex = 1;
            btnToggle.Text = "Deactivate";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 9F);
            lblNote.ForeColor = Color.FromArgb(107, 114, 128);
            lblNote.Location = new Point(250, 16);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(763, 25);
            lblNote.TabIndex = 2;
            lblNote.Text = "Plans used by existing memberships are deactivated rather than deleted, so history stays intact.";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(30, 111, 240);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+ Add Plan";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // PlansForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            ClientSize = new Size(1280, 760);
            Name = "PlansForm";
            PageTitle = "Membership Plans";
            Text = "GYMORA - Membership Plans";
            contentPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            actionsFlow.ResumeLayout(false);
            actionsFlow.PerformLayout();
            mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlans).EndInit();
            footerPanel.ResumeLayout(false);
            footerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.DataGridView dgvPlans;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnAdd;
    }
}
