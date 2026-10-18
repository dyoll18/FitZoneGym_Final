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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPlans = new System.Windows.Forms.DataGridView();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.RowCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.Controls.Add(this.dgvPlans, 0, 0);
            this.mainLayout.Controls.Add(this.footerPanel, 0, 1);
            this.mainLayout.TabIndex = 0;
            // 
            // dgvPlans
            // 
            this.dgvPlans.Name = "dgvPlans";
            this.dgvPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlans.TabIndex = 0;
            this.dgvPlans.SelectionChanged += new System.EventHandler(this.dgvPlans_SelectionChanged);
            this.dgvPlans.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlans_CellDoubleClick);
            // 
            // footerPanel
            // 
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
            this.footerPanel.Controls.Add(this.btnEdit);
            this.footerPanel.Controls.Add(this.btnToggle);
            this.footerPanel.Controls.Add(this.lblNote);
            this.footerPanel.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit";
            this.btnEdit.Size = new System.Drawing.Size(100, 34);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnEdit.Location = new System.Drawing.Point(0, 8);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Text = "Deactivate";
            this.btnToggle.Size = new System.Drawing.Size(120, 34);
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.BackColor = System.Drawing.Color.White;
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 221, 232);
            this.btnToggle.Location = new System.Drawing.Point(110, 8);
            this.btnToggle.TabIndex = 1;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // lblNote
            // 
            this.lblNote.Name = "lblNote";
            this.lblNote.AutoSize = true;
            this.lblNote.Text = "Plans used by existing memberships are deactivated rather than deleted, so history stays intact.";
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9.0F);
            this.lblNote.Location = new System.Drawing.Point(250, 16);
            this.lblNote.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+ Add Plan";
            this.btnAdd.Size = new System.Drawing.Size(120, 34);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PlansForm
            // 
            this.PageTitle = "Membership Plans";
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.contentPanel.Controls.Add(this.mainLayout);
            this.actionsFlow.Controls.Add(this.btnAdd);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).EndInit();
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
