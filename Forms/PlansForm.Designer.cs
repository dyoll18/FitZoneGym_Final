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
            dgvPlans = new FitZoneGym.Controls.ThemedGrid();
            footerPanel = new Panel();
            btnEdit = new FitZoneGym.Controls.ThemedButton();
            btnToggle = new FitZoneGym.Controls.ThemedButton();
            lblNote = new Label();
            btnAdd = new FitZoneGym.Controls.ThemedButton();
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
            mainLayout.BackColor = Color.FromArgb(24, 25, 33);
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
            footerPanel.BackColor = Color.FromArgb(24, 25, 33);
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
            btnEdit.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnEdit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEdit.Location = new Point(0, 8);
            btnEdit.Margin = new Padding(0, 0, 8, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 34);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnToggle
            // 
            btnToggle.Kind = FitZoneGym.Controls.ButtonKind.Secondary;
            btnToggle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnToggle.Location = new Point(110, 8);
            btnToggle.Margin = new Padding(0, 0, 8, 0);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(120, 34);
            btnToggle.TabIndex = 1;
            btnToggle.Text = "Deactivate";
            btnToggle.Click += btnToggle_Click;
            // 
            // lblNote
            // 
            lblNote.ForeColor = Color.FromArgb(152, 155, 172);
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 9F);
            lblNote.Location = new Point(250, 16);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(763, 25);
            lblNote.TabIndex = 2;
            lblNote.Text = "Plans used by existing memberships are deactivated rather than deleted, so history stays intact.";
            // 
            // btnAdd
            // 
            btnAdd.Kind = FitZoneGym.Controls.ButtonKind.Primary;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "+ Add Plan";
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
        private FitZoneGym.Controls.ThemedGrid dgvPlans;
        private System.Windows.Forms.Panel footerPanel;
        private FitZoneGym.Controls.ThemedButton btnEdit;
        private FitZoneGym.Controls.ThemedButton btnToggle;
        private System.Windows.Forms.Label lblNote;
        private FitZoneGym.Controls.ThemedButton btnAdd;
    }
}
