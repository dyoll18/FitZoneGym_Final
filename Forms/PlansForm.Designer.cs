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

        /// <summary>Designer generated.</summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new FitZoneGym.Controls.CardPanel();
            this.dgvPlans = new System.Windows.Forms.DataGridView();
            this.footerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.cardGrid.SuspendLayout();
            this.footerLayout.SuspendLayout();
            this.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.actionsFlow.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.RowCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.mainLayout.Controls.Add(this.cardGrid, 0, 0);
            this.mainLayout.Controls.Add(this.footerLayout, 0, 1);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.mainLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // cardGrid
            // 
            this.cardGrid.Controls.Add(this.dgvPlans);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Tag = "card";
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            // 
            // dgvPlans
            // 
            this.dgvPlans.Name = "dgvPlans";
            this.dgvPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Windows.Forms.DataGridViewCellStyle dgvPlansHead = new System.Windows.Forms.DataGridViewCellStyle();
            dgvPlansHead.BackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvPlansHead.ForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvPlansHead.SelectionBackColor = System.Drawing.Color.FromArgb(9, 9, 11);
            dgvPlansHead.SelectionForeColor = System.Drawing.Color.FromArgb(255, 140, 66);
            dgvPlansHead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvPlansHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            System.Windows.Forms.DataGridViewCellStyle dgvPlansCell = new System.Windows.Forms.DataGridViewCellStyle();
            dgvPlansCell.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            dgvPlansCell.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvPlansCell.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvPlansCell.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            System.Windows.Forms.DataGridViewCellStyle dgvPlansAlt = new System.Windows.Forms.DataGridViewCellStyle();
            dgvPlansAlt.BackColor = System.Drawing.Color.FromArgb(29, 29, 35);
            dgvPlansAlt.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvPlansAlt.SelectionBackColor = System.Drawing.Color.FromArgb(88, 42, 20);
            dgvPlansAlt.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvPlans.EnableHeadersVisualStyles = false;
            this.dgvPlans.ColumnHeadersDefaultCellStyle = dgvPlansHead;
            this.dgvPlans.DefaultCellStyle = dgvPlansCell;
            this.dgvPlans.AlternatingRowsDefaultCellStyle = dgvPlansAlt;
            this.dgvPlans.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 29);
            this.dgvPlans.GridColor = System.Drawing.Color.FromArgb(44, 44, 52);
            this.dgvPlans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlans.RowHeadersVisible = false;
            this.dgvPlans.AllowUserToAddRows = false;
            this.dgvPlans.AllowUserToDeleteRows = false;
            this.dgvPlans.ReadOnly = true;
            this.dgvPlans.MultiSelect = false;
            this.dgvPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlans.SelectionChanged += this.dgvPlans_SelectionChanged;
            this.dgvPlans.CellDoubleClick += this.dgvPlans_CellDoubleClick;
            // 
            // footerLayout
            // 
            this.footerLayout.ColumnCount = 3;
            this.footerLayout.RowCount = 1;
            this.footerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.footerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.footerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.footerLayout.Controls.Add(this.btnEdit, 0, 0);
            this.footerLayout.Controls.Add(this.btnToggle, 1, 0);
            this.footerLayout.Controls.Add(this.lblNote, 2, 0);
            this.footerLayout.Name = "footerLayout";
            this.footerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerLayout.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.footerLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.footerLayout.AutoSize = true;
            this.footerLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit";
            this.btnEdit.Size = new System.Drawing.Size(110, 36);
            this.btnEdit.Tag = "primary";
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.FlatAppearance.BorderSize = 1;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(205, 60, 8);
            this.btnEdit.Click += this.btnEdit_Click;
            // 
            // btnToggle
            // 
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Text = "Deactivate";
            this.btnToggle.Size = new System.Drawing.Size(130, 36);
            this.btnToggle.Tag = "secondary";
            this.btnToggle.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(36, 36, 43);
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnToggle.FlatAppearance.BorderSize = 1;
            this.btnToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(54, 54, 63);
            this.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 59);
            this.btnToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(28, 28, 34);
            this.btnToggle.Click += this.btnToggle_Click;
            // 
            // lblNote
            // 
            this.lblNote.Name = "lblNote";
            this.lblNote.AutoSize = false;
            this.lblNote.Size = new System.Drawing.Size(100, 36);
            this.lblNote.Text = "Plans used by existing memberships are deactivated rather than deleted, so history stays intact.";
            this.lblNote.Tag = "muted";
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNote.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+ Add Plan";
            this.btnAdd.Size = new System.Drawing.Size(130, 36);
            this.btnAdd.Tag = "primary";
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.FlatAppearance.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(205, 60, 8);
            this.btnAdd.Click += this.btnAdd_Click;
            // 
            // PlansForm
            // 
            this.contentPanel.Controls.Add(this.mainLayout);
            this.actionsFlow.Controls.Add(this.btnAdd);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BackColor = System.Drawing.Color.FromArgb(14, 14, 17);
            this.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Name = "PlansForm";
            this.PageTitle = "Membership Plans";
            this.Text = "FITZONE GYM - Membership Plans";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).EndInit();
            this.footerLayout.ResumeLayout(false);
            this.footerLayout.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.actionsFlow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private FitZoneGym.Controls.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView dgvPlans;
        private System.Windows.Forms.TableLayoutPanel footerLayout;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnAdd;
    }
}
