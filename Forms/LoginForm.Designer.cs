namespace FitZoneGym.Forms
{
    partial class LoginForm
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
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBrand = new FitZoneGym.Controls.GradientPanel();
            this.brandLayout = new System.Windows.Forms.TableLayoutPanel();
            this.logoMark = new FitZoneGym.Controls.LogoMark();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblGym = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblMotto = new System.Windows.Forms.Label();
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.passRow = new System.Windows.Forms.TableLayoutPanel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rootLayout.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.brandLayout.SuspendLayout();
            this.formLayout.SuspendLayout();
            this.passRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.ColumnCount = 2;
            this.rootLayout.RowCount = 1;
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.Controls.Add(this.pnlBrand, 0, 0);
            this.rootLayout.Controls.Add(this.formLayout, 1, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.rootLayout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.rootLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // pnlBrand
            // 
            this.pnlBrand.Controls.Add(this.brandLayout);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrand.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            // 
            // brandLayout
            // 
            this.brandLayout.ColumnCount = 1;
            this.brandLayout.RowCount = 7;
            this.brandLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.brandLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.brandLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.brandLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.brandLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.brandLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.brandLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.brandLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.brandLayout.Controls.Add(this.logoMark, 0, 1);
            this.brandLayout.Controls.Add(this.lblBrand, 0, 2);
            this.brandLayout.Controls.Add(this.lblGym, 0, 3);
            this.brandLayout.Controls.Add(this.lblTagline, 0, 4);
            this.brandLayout.Controls.Add(this.lblMotto, 0, 5);
            this.brandLayout.Name = "brandLayout";
            this.brandLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.brandLayout.Padding = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.brandLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // logoMark
            // 
            this.logoMark.Name = "logoMark";
            this.logoMark.Size = new System.Drawing.Size(112, 112);
            this.logoMark.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // lblBrand
            // 
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.AutoSize = true;
            this.lblBrand.Text = "FITZONE";
            this.lblBrand.Tag = "brand";
            this.lblBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrand.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.lblBrand.Font = new System.Drawing.Font("Bahnschrift", 40F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            // 
            // lblGym
            // 
            this.lblGym.Name = "lblGym";
            this.lblGym.AutoSize = true;
            this.lblGym.Text = "G Y M";
            this.lblGym.Tag = "brandsub";
            this.lblGym.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGym.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblGym.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold);
            this.lblGym.ForeColor = System.Drawing.Color.FromArgb(255, 94, 26);
            // 
            // lblTagline
            // 
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.AutoSize = true;
            this.lblTagline.Text = "STRONGER TODAY,\nHEALTHIER TOMORROW";
            this.lblTagline.Tag = "tagline";
            this.lblTagline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTagline.Margin = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(214, 214, 222);
            // 
            // lblMotto
            // 
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.AutoSize = true;
            this.lblMotto.Text = "NO EXCUSES. JUST RESULTS.";
            this.lblMotto.Tag = "accent";
            this.lblMotto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotto.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblMotto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMotto.ForeColor = System.Drawing.Color.FromArgb(255, 94, 26);
            // 
            // formLayout
            // 
            this.formLayout.ColumnCount = 1;
            this.formLayout.RowCount = 12;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formLayout.Controls.Add(this.lblLoginTitle, 0, 1);
            this.formLayout.Controls.Add(this.lblSubtitle, 0, 2);
            this.formLayout.Controls.Add(this.lblUser, 0, 3);
            this.formLayout.Controls.Add(this.txtUser, 0, 4);
            this.formLayout.Controls.Add(this.lblPass, 0, 5);
            this.formLayout.Controls.Add(this.passRow, 0, 6);
            this.formLayout.Controls.Add(this.chkRemember, 0, 7);
            this.formLayout.Controls.Add(this.lblMessage, 0, 8);
            this.formLayout.Controls.Add(this.btnLogin, 0, 9);
            this.formLayout.Controls.Add(this.btnCancel, 0, 10);
            this.formLayout.Name = "formLayout";
            this.formLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.formLayout.Padding = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.formLayout.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Text = "WELCOME BACK";
            this.lblLoginTitle.Tag = "h1";
            this.lblLoginTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblLoginTitle.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Text = "Sign in to manage your gym.";
            this.lblSubtitle.Tag = "muted";
            this.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(0, 2, 0, 24);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = true;
            this.lblUser.Text = "USERNAME";
            this.lblUser.Tag = "caption";
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUser.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // txtUser
            // 
            this.txtUser.Name = "txtUser";
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtUser.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblPass
            // 
            this.lblPass.Name = "lblPass";
            this.lblPass.AutoSize = true;
            this.lblPass.Text = "PASSWORD";
            this.lblPass.Tag = "caption";
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPass.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(156, 156, 170);
            // 
            // passRow
            // 
            this.passRow.ColumnCount = 2;
            this.passRow.RowCount = 1;
            this.passRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.passRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.passRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.passRow.Controls.Add(this.txtPass, 0, 0);
            this.passRow.Controls.Add(this.chkShow, 1, 0);
            this.passRow.Name = "passRow";
            this.passRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passRow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.passRow.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.passRow.AutoSize = true;
            this.passRow.BackColor = System.Drawing.Color.Transparent;
            // 
            // txtPass
            // 
            this.txtPass.Name = "txtPass";
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPass.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(42, 42, 50);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // chkShow
            // 
            this.chkShow.Name = "chkShow";
            this.chkShow.AutoSize = true;
            this.chkShow.Text = "Show";
            this.chkShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkShow.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.chkShow.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.chkShow.CheckedChanged += this.chkShow_CheckedChanged;
            // 
            // chkRemember
            // 
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.AutoSize = true;
            this.chkRemember.Text = "Remember me";
            this.chkRemember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRemember.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.chkRemember.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.AutoSize = false;
            this.lblMessage.Size = new System.Drawing.Size(100, 40);
            this.lblMessage.Text = "";
            this.lblMessage.Tag = "error";
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
            // 
            // btnLogin
            // 
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Size = new System.Drawing.Size(100, 46);
            this.btnLogin.Tag = "primary";
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0, 4, 0, 10);
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 1;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 94, 26);
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(205, 60, 8);
            this.btnLogin.Click += this.btnLogin_Click;
            // 
            // btnCancel
            // 
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Exit";
            this.btnCancel.Size = new System.Drawing.Size(100, 42);
            this.btnCancel.Tag = "secondary";
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(36, 36, 43);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(54, 54, 63);
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 59);
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(28, 28, 34);
            this.btnCancel.Click += this.btnCancel_Click;
            // 
            // LoginForm
            // 
            this.Controls.Add(this.rootLayout);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 29);
            this.ForeColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "LoginForm";
            this.Text = "FITZONE GYM - Login";
            this.AcceptButton = this.btnLogin;
            this.CancelButton = this.btnCancel;
            this.passRow.ResumeLayout(false);
            this.passRow.PerformLayout();
            this.formLayout.ResumeLayout(false);
            this.brandLayout.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.rootLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private FitZoneGym.Controls.GradientPanel pnlBrand;
        private System.Windows.Forms.TableLayoutPanel brandLayout;
        private FitZoneGym.Controls.LogoMark logoMark;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblGym;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.TableLayoutPanel formLayout;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TableLayoutPanel passRow;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}
