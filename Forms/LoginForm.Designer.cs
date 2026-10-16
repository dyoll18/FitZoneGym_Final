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

        /// <summary>Designer generated: do not modify the contents of this method with the code editor.</summary>
        private void InitializeComponent()
        {
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblGym = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBrand
            // 
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Size = new System.Drawing.Size(340, 470);
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(15, 35, 66);
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Controls.Add(this.lblGym);
            this.pnlBrand.Controls.Add(this.lblTagline);
            this.pnlBrand.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.AutoSize = false;
            this.lblBrand.Text = "FITZONE";
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 30.0F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Size = new System.Drawing.Size(340, 60);
            this.lblBrand.Location = new System.Drawing.Point(0, 140);
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrand.TabIndex = 0;
            // 
            // lblGym
            // 
            this.lblGym.Name = "lblGym";
            this.lblGym.AutoSize = false;
            this.lblGym.Text = "G Y M";
            this.lblGym.ForeColor = System.Drawing.Color.FromArgb(120, 170, 255);
            this.lblGym.Font = new System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold);
            this.lblGym.Size = new System.Drawing.Size(340, 34);
            this.lblGym.Location = new System.Drawing.Point(0, 198);
            this.lblGym.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGym.TabIndex = 1;
            // 
            // lblTagline
            // 
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.AutoSize = false;
            this.lblTagline.Text = "STRONGER TODAY,\nHEALTHIER TOMORROW";
            this.lblTagline.ForeColor = System.Drawing.Color.White;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTagline.Size = new System.Drawing.Size(340, 50);
            this.lblTagline.Location = new System.Drawing.Point(0, 260);
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTagline.TabIndex = 2;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Text = "Login";
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(15, 35, 66);
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 20.0F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.Location = new System.Drawing.Point(400, 50);
            this.lblLoginTitle.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Text = "Welcome back! Please login to your account.";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.Location = new System.Drawing.Point(400, 96);
            this.lblSubtitle.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = true;
            this.lblUser.Text = "Username";
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(400, 140);
            this.lblUser.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Name = "txtUser";
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUser.Size = new System.Drawing.Size(300, 25);
            this.txtUser.Location = new System.Drawing.Point(400, 164);
            this.txtUser.TabIndex = 4;
            // 
            // lblPass
            // 
            this.lblPass.Name = "lblPass";
            this.lblPass.AutoSize = true;
            this.lblPass.Text = "Password";
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPass.Location = new System.Drawing.Point(400, 204);
            this.lblPass.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Name = "txtPass";
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPass.Size = new System.Drawing.Size(300, 25);
            this.txtPass.Location = new System.Drawing.Point(400, 228);
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TabIndex = 6;
            // 
            // chkShow
            // 
            this.chkShow.Name = "chkShow";
            this.chkShow.AutoSize = true;
            this.chkShow.Text = "Show";
            this.chkShow.Location = new System.Drawing.Point(706, 230);
            this.chkShow.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkShow.TabIndex = 7;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // chkRemember
            // 
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.AutoSize = true;
            this.chkRemember.Text = "Remember me";
            this.chkRemember.Location = new System.Drawing.Point(400, 268);
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkRemember.TabIndex = 8;
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.AutoSize = false;
            this.lblMessage.Text = "";
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMessage.Size = new System.Drawing.Size(300, 36);
            this.lblMessage.Location = new System.Drawing.Point(400, 296);
            this.lblMessage.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Text = "Login";
            this.btnLogin.Size = new System.Drawing.Size(300, 40);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 111, 240);
            this.btnLogin.Location = new System.Drawing.Point(400, 338);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Size = new System.Drawing.Size(300, 40);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(214, 221, 232);
            this.btnCancel.Location = new System.Drawing.Point(400, 386);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(820, 470);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Text = "FITZONE GYM - Login";
            this.AcceptButton = this.btnLogin;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.pnlBrand);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblGym;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}
