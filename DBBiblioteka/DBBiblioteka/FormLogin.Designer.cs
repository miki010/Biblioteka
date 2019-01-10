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
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.lblSee = new MetroFramework.Controls.MetroLabel();
            this.lblInvalid = new MetroFramework.Controls.MetroLabel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblIme = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(57, 395);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(352, 25);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(57, 458);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(352, 25);
            this.txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Highlight = true;
            this.btnLogin.Location = new System.Drawing.Point(157, 541);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 39);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseMnemonic = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(157, 596);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 39);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Izlaz";
            this.btnCancel.UseMnemonic = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(57, 373);
            this.lblUsername.MaximumSize = new System.Drawing.Size(0, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 19);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(57, 436);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 19);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Lozinka:";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(157, 493);
            this.metroToggle1.MaximumSize = new System.Drawing.Size(60, 15);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(60, 15);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroToggle1.TabIndex = 10;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseVisualStyleBackColor = true;
            // 
            // lblSee
            // 
            this.lblSee.AutoSize = true;
            this.lblSee.Location = new System.Drawing.Point(57, 489);
            this.lblSee.Name = "lblSee";
            this.lblSee.Size = new System.Drawing.Size(94, 19);
            this.lblSee.TabIndex = 11;
            this.lblSee.Text = "Prikaži lozinku:";
            // 
            // lblInvalid
            // 
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(118, 436);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(111, 19);
            this.lblInvalid.Style = MetroFramework.MetroColorStyle.Red;
            this.lblInvalid.TabIndex = 12;
            this.lblInvalid.Text = "Pogrešna lozinka!";
            this.lblInvalid.UseStyleColors = true;
            this.lblInvalid.Visible = false;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.Black;
            this.lblTitle1.Location = new System.Drawing.Point(129, 249);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(170, 37);
            this.lblTitle1.TabIndex = 14;
            this.lblTitle1.Text = "Dobrodošli!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DBBiblioteka.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(118, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 176);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(424, 652);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(39, 19);
            this.lblVersion.TabIndex = 16;
            this.lblVersion.Text = "v 1.10";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Location = new System.Drawing.Point(170, 212);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(77, 37);
            this.lblTitle3.TabIndex = 17;
            this.lblTitle3.Text = "ELSA";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.Color.Red;
            this.lblIme.Location = new System.Drawing.Point(159, 373);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(23, 19);
            this.lblIme.TabIndex = 18;
            this.lblIme.Text = "lbl";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 678);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.lblSee);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(54, 171, 54, 57);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel lblSee;
        private MetroFramework.Controls.MetroLabel lblInvalid;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel lblVersion;
        private System.Windows.Forms.Label lblTitle3;
        private MetroFramework.Controls.MetroLabel lblIme;
    }
}

