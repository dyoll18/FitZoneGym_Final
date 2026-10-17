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
            pnlBrand = new Panel();
            lblBrand = new Label();
            lblGym = new Label();
            lblTagline = new Label();
            lblLoginTitle = new Label();
            lblSubtitle = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            chkShow = new CheckBox();
            chkRemember = new CheckBox();
            lblMessage = new Label();
            btnLogin = new Button();
            btnCancel = new Button();
            pnlBrand.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(15, 35, 66);
            pnlBrand.Controls.Add(lblBrand);
            pnlBrand.Controls.Add(lblGym);
            pnlBrand.Controls.Add(lblTagline);
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(340, 470);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(0, 140);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(340, 60);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "FITZONE";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGym
            // 
            lblGym.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblGym.ForeColor = Color.FromArgb(120, 170, 255);
            lblGym.Location = new Point(0, 198);
            lblGym.Name = "lblGym";
            lblGym.Size = new Size(340, 34);
            lblGym.TabIndex = 1;
            lblGym.Text = "G Y M";
            lblGym.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagline
            // 
            lblTagline.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTagline.ForeColor = Color.White;
            lblTagline.Location = new Point(0, 260);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(340, 50);
            lblTagline.TabIndex = 2;
            lblTagline.Text = "STRONGER TODAY,\nHEALTHIER TOMORROW";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLoginTitle.ForeColor = Color.FromArgb(15, 35, 66);
            lblLoginTitle.Location = new Point(400, 50);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(229, 54);
            lblLoginTitle.TabIndex = 1;
            lblLoginTitle.Text = "LLoyd Pogi";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitle.Location = new Point(400, 96);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(387, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Welcome back! Please login to your account.";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(31, 41, 55);
            lblUser.Location = new Point(400, 140);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(101, 25);
            lblUser.TabIndex = 3;
            lblUser.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 9.5F);
            txtUser.Location = new Point(400, 164);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(300, 33);
            txtUser.TabIndex = 4;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPass.ForeColor = Color.FromArgb(31, 41, 55);
            lblPass.Location = new Point(400, 204);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(97, 25);
            lblPass.TabIndex = 5;
            lblPass.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 9.5F);
            txtPass.Location = new Point(400, 228);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(300, 33);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Font = new Font("Segoe UI", 9.5F);
            chkShow.Location = new Point(706, 230);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(84, 29);
            chkShow.TabIndex = 7;
            chkShow.Text = "Show";
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Segoe UI", 9.5F);
            chkRemember.Location = new Point(400, 268);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(159, 29);
            chkRemember.TabIndex = 8;
            chkRemember.Text = "Remember me";
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9.5F);
            lblMessage.ForeColor = Color.FromArgb(220, 38, 38);
            lblMessage.Location = new Point(400, 296);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(300, 36);
            lblMessage.TabIndex = 9;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(30, 111, 240);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(400, 338);
            btnLogin.Margin = new Padding(0, 0, 8, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 40);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(214, 221, 232);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(31, 41, 55);
            btnCancel.Location = new Point(400, 386);
            btnCancel.Margin = new Padding(0, 0, 8, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(300, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(820, 470);
            Controls.Add(pnlBrand);
            Controls.Add(lblLoginTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(chkShow);
            Controls.Add(chkRemember);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FITZONE GYM - Login";
            pnlBrand.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
