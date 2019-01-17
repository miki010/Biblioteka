namespace DBBiblioteka
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblInvalid = new MetroFramework.Controls.MetroLabel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.lblUName = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxLoginbg = new System.Windows.Forms.PictureBox();
            this.pictureBoxELSALogo = new System.Windows.Forms.PictureBox();
            this.lblVerzija = new MetroFramework.Controls.MetroLabel();
            this.lblSeePass = new MetroFramework.Controls.MetroLabel();
            this.togglePassword = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginbg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxELSALogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(36, 404);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(352, 25);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(36, 461);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(352, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Highlight = true;
            this.btnLogin.Location = new System.Drawing.Point(66, 550);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 42);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseMnemonic = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(214, 550);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 42);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Izlaz";
            this.btnCancel.UseMnemonic = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(36, 382);
            this.lblUsername.MaximumSize = new System.Drawing.Size(0, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 19);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 439);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 19);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Lozinka:";
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(87, 439);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(112, 19);
            this.lblInvalid.Style = MetroFramework.MetroColorStyle.Red;
            this.lblInvalid.TabIndex = 12;
            this.lblInvalid.Text = "Pogrešna lozinka!";
            this.lblInvalid.UseStyleColors = true;
            this.lblInvalid.Visible = false;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitle1.Location = new System.Drawing.Point(119, 34);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(170, 37);
            this.lblTitle1.TabIndex = 14;
            this.lblTitle1.Text = "Dobrodošli!";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(424, 652);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(43, 19);
            this.lblVersion.TabIndex = 16;
            this.lblVersion.Text = "v 1.10";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.BackColor = System.Drawing.Color.Transparent;
            this.lblUName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblUName.ForeColor = System.Drawing.Color.Red;
            this.lblUName.Location = new System.Drawing.Point(126, 382);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(211, 19);
            this.lblUName.Style = MetroFramework.MetroColorStyle.Red;
            this.lblUName.TabIndex = 18;
            this.lblUName.Text = "Unešeno korisničko ime ne postoji!";
            this.lblUName.UseStyleColors = true;
            this.lblUName.UseWaitCursor = true;
            this.lblUName.Visible = false;
            // 
            // pictureBoxLoginbg
            // 
            this.pictureBoxLoginbg.Image = global::DBBiblioteka.Properties.Resources.loginimage;
            this.pictureBoxLoginbg.Location = new System.Drawing.Point(463, 5);
            this.pictureBoxLoginbg.Name = "pictureBoxLoginbg";
            this.pictureBoxLoginbg.Size = new System.Drawing.Size(463, 618);
            this.pictureBoxLoginbg.TabIndex = 20;
            this.pictureBoxLoginbg.TabStop = false;
            // 
            // pictureBoxELSALogo
            // 
            this.pictureBoxELSALogo.Image = global::DBBiblioteka.Properties.Resources.elsalogofinal;
            this.pictureBoxELSALogo.Location = new System.Drawing.Point(97, 93);
            this.pictureBoxELSALogo.Name = "pictureBoxELSALogo";
            this.pictureBoxELSALogo.Size = new System.Drawing.Size(222, 212);
            this.pictureBoxELSALogo.TabIndex = 19;
            this.pictureBoxELSALogo.TabStop = false;
            // 
            // lblVerzija
            // 
            this.lblVerzija.AutoSize = true;
            this.lblVerzija.Location = new System.Drawing.Point(190, 600);
            this.lblVerzija.Name = "lblVerzija";
            this.lblVerzija.Size = new System.Drawing.Size(43, 19);
            this.lblVerzija.TabIndex = 21;
            this.lblVerzija.Text = "v 1.10";
            // 
            // lblSeePass
            // 
            this.lblSeePass.AutoSize = true;
            this.lblSeePass.Location = new System.Drawing.Point(36, 496);
            this.lblSeePass.Name = "lblSeePass";
            this.lblSeePass.Size = new System.Drawing.Size(94, 19);
            this.lblSeePass.TabIndex = 22;
            this.lblSeePass.Text = "Prikaži lozinku:";
            // 
            // togglePassword
            // 
            this.togglePassword.AutoSize = true;
            this.togglePassword.Location = new System.Drawing.Point(130, 499);
            this.togglePassword.MaximumSize = new System.Drawing.Size(60, 15);
            this.togglePassword.MinimumSize = new System.Drawing.Size(60, 15);
            this.togglePassword.Name = "togglePassword";
            this.togglePassword.Size = new System.Drawing.Size(60, 15);
            this.togglePassword.Style = MetroFramework.MetroColorStyle.Purple;
            this.togglePassword.TabIndex = 23;
            this.togglePassword.Text = "Off";
            this.togglePassword.UseVisualStyleBackColor = true;
            this.togglePassword.CheckedChanged += new System.EventHandler(this.togglePassword_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(925, 620);
            this.Controls.Add(this.togglePassword);
            this.Controls.Add(this.lblSeePass);
            this.Controls.Add(this.lblVerzija);
            this.Controls.Add(this.pictureBoxLoginbg);
            this.Controls.Add(this.pictureBoxELSALogo);
            this.Controls.Add(this.lblUName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(925, 625);
            this.MinimumSize = new System.Drawing.Size(925, 620);
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(54, 171, 54, 57);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginbg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxELSALogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblInvalid;
        private System.Windows.Forms.Label lblTitle1;
        private MetroFramework.Controls.MetroLabel lblVersion;
        private MetroFramework.Controls.MetroLabel lblUName;
        private System.Windows.Forms.PictureBox pictureBoxELSALogo;
        private System.Windows.Forms.PictureBox pictureBoxLoginbg;
        private MetroFramework.Controls.MetroLabel lblVerzija;
        private MetroFramework.Controls.MetroLabel lblSeePass;
        private MetroFramework.Controls.MetroToggle togglePassword;
    }
}

