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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlBrand = new Panel();
            lblTagline = new Label();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.Black;
            pnlBrand.BackgroundImage = (Image)resources.GetObject("pnlBrand.BackgroundImage");
            pnlBrand.Controls.Add(lblTagline);
            pnlBrand.Controls.Add(pictureBox1);
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(356, 467);
            pnlBrand.TabIndex = 0;
            // 
            // lblTagline
            // 
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTagline.ForeColor = Color.White;
            lblTagline.Location = new Point(0, 349);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(353, 64);
            lblTagline.TabIndex = 2;
            lblTagline.Text = "STRONGER TODAY,\nHEALTHIER TOMORROW";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            lblTagline.Click += lblTagline_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLoginTitle.ForeColor = Color.White;
            lblLoginTitle.Location = new Point(378, 42);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(332, 54);
            lblLoginTitle.TabIndex = 1;
            lblLoginTitle.Text = "WELCOME BACK";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(224, 224, 224);
            lblSubtitle.Location = new Point(378, 96);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(253, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Sign in to manage your gym.";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUser.ForeColor = Color.Silver;
            lblUser.Location = new Point(378, 136);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(101, 25);
            lblUser.TabIndex = 3;
            lblUser.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.WindowFrame;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 9.5F);
            txtUser.Location = new Point(378, 164);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(390, 33);
            txtUser.TabIndex = 4;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPass.ForeColor = Color.Silver;
            lblPass.Location = new Point(378, 200);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(97, 25);
            lblPass.TabIndex = 5;
            lblPass.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.WindowFrame;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 9.5F);
            txtPass.Location = new Point(378, 228);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(300, 33);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Font = new Font("Segoe UI", 9.5F);
            chkShow.ForeColor = Color.White;
            chkShow.Location = new Point(684, 230);
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
            chkRemember.ForeColor = Color.White;
            chkRemember.Location = new Point(378, 268);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(159, 29);
            chkRemember.TabIndex = 8;
            chkRemember.Text = "Remember me";
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9.5F);
            lblMessage.ForeColor = Color.FromArgb(220, 38, 38);
            lblMessage.Location = new Point(378, 296);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(300, 36);
            lblMessage.TabIndex = 9;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(30, 111, 240);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(378, 332);
            btnLogin.Margin = new Padding(0, 0, 8, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(390, 40);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.WindowFrame;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(214, 221, 232);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(378, 386);
            btnCancel.Margin = new Padding(0, 0, 8, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(390, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Exit";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
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
            Load += LoginForm_Load;
            pnlBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlBrand;
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
        private PictureBox pictureBox1;
    }
}
