namespace DBBiblioteka
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.pictureBoxAdminPozadina = new System.Windows.Forms.PictureBox();
            this.tileAutor = new MetroFramework.Controls.MetroTile();
            this.tileIzdavac = new MetroFramework.Controls.MetroTile();
            this.tileNovaKnjiga = new MetroFramework.Controls.MetroTile();
            this.tileNoviRadnik = new MetroFramework.Controls.MetroTile();
            this.lblImeZaposlenog = new MetroFramework.Controls.MetroLabel();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.tileProfile = new MetroFramework.Controls.MetroTile();
            this.panelPromjenaLozinke = new MetroFramework.Controls.MetroPanel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lbPotvrdiLozinku = new MetroFramework.Controls.MetroLabel();
            this.txtPotvrdiLozinku = new MetroFramework.Controls.MetroTextBox();
            this.lblNovaLozinka = new MetroFramework.Controls.MetroLabel();
            this.lblTrenutnaLozinka = new MetroFramework.Controls.MetroLabel();
            this.txtNovaLozinka = new MetroFramework.Controls.MetroTextBox();
            this.txtTrenutnaLozinka = new MetroFramework.Controls.MetroTextBox();
            this.tileSacuvajIzmjene = new MetroFramework.Controls.MetroTile();
            this.panelUserName = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminPozadina)).BeginInit();
            this.panelPromjenaLozinke.SuspendLayout();
            this.panelUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAdminPozadina
            // 
            this.pictureBoxAdminPozadina.Image = global::DBBiblioteka.Properties.Resources.adminpozadina;
            this.pictureBoxAdminPozadina.Location = new System.Drawing.Point(0, 60);
            this.pictureBoxAdminPozadina.MaximumSize = new System.Drawing.Size(900, 440);
            this.pictureBoxAdminPozadina.MinimumSize = new System.Drawing.Size(900, 440);
            this.pictureBoxAdminPozadina.Name = "pictureBoxAdminPozadina";
            this.pictureBoxAdminPozadina.Size = new System.Drawing.Size(900, 440);
            this.pictureBoxAdminPozadina.TabIndex = 4;
            this.pictureBoxAdminPozadina.TabStop = false;
            // 
            // tileAutor
            // 
            this.tileAutor.Location = new System.Drawing.Point(360, 263);
            this.tileAutor.MaximumSize = new System.Drawing.Size(285, 185);
            this.tileAutor.MinimumSize = new System.Drawing.Size(265, 170);
            this.tileAutor.Name = "tileAutor";
            this.tileAutor.Size = new System.Drawing.Size(285, 185);
            this.tileAutor.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileAutor.TabIndex = 3;
            this.tileAutor.Text = "AUTOR";
            this.tileAutor.TileImage = global::DBBiblioteka.Properties.Resources.author;
            this.tileAutor.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAutor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileAutor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileAutor.UseTileImage = true;
            this.tileAutor.Click += new System.EventHandler(this.tileAutor_Click);
            this.tileAutor.MouseLeave += new System.EventHandler(this.tileAutor_MouseLeave);
            this.tileAutor.MouseHover += new System.EventHandler(this.tileAutor_MouseHover);
            // 
            // tileIzdavac
            // 
            this.tileIzdavac.Location = new System.Drawing.Point(35, 263);
            this.tileIzdavac.MaximumSize = new System.Drawing.Size(320, 185);
            this.tileIzdavac.MinimumSize = new System.Drawing.Size(300, 170);
            this.tileIzdavac.Name = "tileIzdavac";
            this.tileIzdavac.Size = new System.Drawing.Size(320, 185);
            this.tileIzdavac.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileIzdavac.TabIndex = 2;
            this.tileIzdavac.Text = "IZDAVAČ";
            this.tileIzdavac.TileImage = global::DBBiblioteka.Properties.Resources.publisher;
            this.tileIzdavac.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzdavac.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileIzdavac.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileIzdavac.UseTileImage = true;
            this.tileIzdavac.Click += new System.EventHandler(this.tileIzdavac_Click);
            this.tileIzdavac.MouseLeave += new System.EventHandler(this.tileIzdavac_MouseLeave);
            this.tileIzdavac.MouseHover += new System.EventHandler(this.tileIzdavac_MouseHover);
            // 
            // tileNovaKnjiga
            // 
            this.tileNovaKnjiga.Location = new System.Drawing.Point(320, 83);
            this.tileNovaKnjiga.MaximumSize = new System.Drawing.Size(325, 175);
            this.tileNovaKnjiga.MinimumSize = new System.Drawing.Size(305, 160);
            this.tileNovaKnjiga.Name = "tileNovaKnjiga";
            this.tileNovaKnjiga.Size = new System.Drawing.Size(325, 175);
            this.tileNovaKnjiga.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileNovaKnjiga.TabIndex = 1;
            this.tileNovaKnjiga.Text = "NOVA KNJIGA";
            this.tileNovaKnjiga.TileImage = global::DBBiblioteka.Properties.Resources.addbook;
            this.tileNovaKnjiga.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNovaKnjiga.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileNovaKnjiga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileNovaKnjiga.UseTileImage = true;
            this.tileNovaKnjiga.Click += new System.EventHandler(this.tileNovaKnjiga_Click);
            this.tileNovaKnjiga.MouseLeave += new System.EventHandler(this.tileNovaKnjiga_MouseLeave);
            this.tileNovaKnjiga.MouseHover += new System.EventHandler(this.tileNovaKnjiga_MouseHover);
            // 
            // tileNoviRadnik
            // 
            this.tileNoviRadnik.Location = new System.Drawing.Point(35, 83);
            this.tileNoviRadnik.MaximumSize = new System.Drawing.Size(280, 175);
            this.tileNoviRadnik.MinimumSize = new System.Drawing.Size(260, 160);
            this.tileNoviRadnik.Name = "tileNoviRadnik";
            this.tileNoviRadnik.Size = new System.Drawing.Size(280, 175);
            this.tileNoviRadnik.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileNoviRadnik.TabIndex = 0;
            this.tileNoviRadnik.Text = "NOVI RADNIK";
            this.tileNoviRadnik.TileImage = global::DBBiblioteka.Properties.Resources.adduser;
            this.tileNoviRadnik.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNoviRadnik.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileNoviRadnik.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileNoviRadnik.UseTileImage = true;
            this.tileNoviRadnik.Click += new System.EventHandler(this.tileNoviRadnik_Click);
            this.tileNoviRadnik.MouseLeave += new System.EventHandler(this.tileNoviRadnik_MouseLeave);
            this.tileNoviRadnik.MouseHover += new System.EventHandler(this.tileNoviRadnik_MouseHover);
            // 
            // lblImeZaposlenog
            // 
            this.lblImeZaposlenog.AutoSize = true;
            this.lblImeZaposlenog.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblImeZaposlenog.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblImeZaposlenog.Location = new System.Drawing.Point(232, 0);
            this.lblImeZaposlenog.MaximumSize = new System.Drawing.Size(0, 25);
            this.lblImeZaposlenog.Name = "lblImeZaposlenog";
            this.lblImeZaposlenog.Size = new System.Drawing.Size(119, 25);
            this.lblImeZaposlenog.TabIndex = 11;
            this.lblImeZaposlenog.Text = "Ime i prezime";
            this.lblImeZaposlenog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tileLogout
            // 
            this.tileLogout.BackColor = System.Drawing.Color.Teal;
            this.tileLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileLogout.CustomBackground = true;
            this.tileLogout.Location = new System.Drawing.Point(852, 9);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(47, 43);
            this.tileLogout.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileLogout.TabIndex = 10;
            this.tileLogout.TileImage = ((System.Drawing.Image)(resources.GetObject("tileLogout.TileImage")));
            this.tileLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLogout.UseTileImage = true;
            this.tileLogout.Click += new System.EventHandler(this.tileLogout_Click);
            // 
            // tileProfile
            // 
            this.tileProfile.BackColor = System.Drawing.Color.Teal;
            this.tileProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileProfile.CustomBackground = true;
            this.tileProfile.Location = new System.Drawing.Point(799, 10);
            this.tileProfile.Name = "tileProfile";
            this.tileProfile.Size = new System.Drawing.Size(47, 43);
            this.tileProfile.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileProfile.TabIndex = 12;
            this.tileProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileProfile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileProfile.UseTileImage = true;
            this.tileProfile.Click += new System.EventHandler(this.tileProfile_Click);
            // 
            // panelPromjenaLozinke
            // 
            this.panelPromjenaLozinke.Controls.Add(this.btnCancel);
            this.panelPromjenaLozinke.Controls.Add(this.lbPotvrdiLozinku);
            this.panelPromjenaLozinke.Controls.Add(this.txtPotvrdiLozinku);
            this.panelPromjenaLozinke.Controls.Add(this.lblNovaLozinka);
            this.panelPromjenaLozinke.Controls.Add(this.lblTrenutnaLozinka);
            this.panelPromjenaLozinke.Controls.Add(this.txtNovaLozinka);
            this.panelPromjenaLozinke.Controls.Add(this.txtTrenutnaLozinka);
            this.panelPromjenaLozinke.Controls.Add(this.tileSacuvajIzmjene);
            this.panelPromjenaLozinke.HorizontalScrollbarBarColor = true;
            this.panelPromjenaLozinke.HorizontalScrollbarHighlightOnWheel = false;
            this.panelPromjenaLozinke.HorizontalScrollbarSize = 10;
            this.panelPromjenaLozinke.Location = new System.Drawing.Point(555, 63);
            this.panelPromjenaLozinke.Name = "panelPromjenaLozinke";
            this.panelPromjenaLozinke.Size = new System.Drawing.Size(345, 329);
            this.panelPromjenaLozinke.TabIndex = 14;
            this.panelPromjenaLozinke.VerticalScrollbarBarColor = true;
            this.panelPromjenaLozinke.VerticalScrollbarHighlightOnWheel = false;
            this.panelPromjenaLozinke.VerticalScrollbarSize = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(168, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 44);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Izlaz";
            this.btnCancel.UseMnemonic = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbPotvrdiLozinku
            // 
            this.lbPotvrdiLozinku.AutoSize = true;
            this.lbPotvrdiLozinku.Location = new System.Drawing.Point(13, 155);
            this.lbPotvrdiLozinku.Name = "lbPotvrdiLozinku";
            this.lbPotvrdiLozinku.Size = new System.Drawing.Size(95, 19);
            this.lbPotvrdiLozinku.TabIndex = 8;
            this.lbPotvrdiLozinku.Text = "Potvrdi lozinku";
            // 
            // txtPotvrdiLozinku
            // 
            this.txtPotvrdiLozinku.Location = new System.Drawing.Point(148, 154);
            this.txtPotvrdiLozinku.Name = "txtPotvrdiLozinku";
            this.txtPotvrdiLozinku.PasswordChar = '*';
            this.txtPotvrdiLozinku.Size = new System.Drawing.Size(181, 23);
            this.txtPotvrdiLozinku.TabIndex = 7;
            // 
            // lblNovaLozinka
            // 
            this.lblNovaLozinka.AutoSize = true;
            this.lblNovaLozinka.Location = new System.Drawing.Point(13, 106);
            this.lblNovaLozinka.Name = "lblNovaLozinka";
            this.lblNovaLozinka.Size = new System.Drawing.Size(84, 19);
            this.lblNovaLozinka.TabIndex = 6;
            this.lblNovaLozinka.Text = "Nova lozinka";
            // 
            // lblTrenutnaLozinka
            // 
            this.lblTrenutnaLozinka.AutoSize = true;
            this.lblTrenutnaLozinka.Location = new System.Drawing.Point(12, 55);
            this.lblTrenutnaLozinka.Name = "lblTrenutnaLozinka";
            this.lblTrenutnaLozinka.Size = new System.Drawing.Size(104, 19);
            this.lblTrenutnaLozinka.TabIndex = 5;
            this.lblTrenutnaLozinka.Text = "Trenutna lozinka";
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Location = new System.Drawing.Point(148, 105);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.PasswordChar = '*';
            this.txtNovaLozinka.Size = new System.Drawing.Size(181, 23);
            this.txtNovaLozinka.TabIndex = 4;
            // 
            // txtTrenutnaLozinka
            // 
            this.txtTrenutnaLozinka.Location = new System.Drawing.Point(148, 55);
            this.txtTrenutnaLozinka.Name = "txtTrenutnaLozinka";
            this.txtTrenutnaLozinka.PasswordChar = '*';
            this.txtTrenutnaLozinka.Size = new System.Drawing.Size(181, 23);
            this.txtTrenutnaLozinka.TabIndex = 3;
            // 
            // tileSacuvajIzmjene
            // 
            this.tileSacuvajIzmjene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSacuvajIzmjene.Location = new System.Drawing.Point(34, 243);
            this.tileSacuvajIzmjene.Name = "tileSacuvajIzmjene";
            this.tileSacuvajIzmjene.Size = new System.Drawing.Size(113, 44);
            this.tileSacuvajIzmjene.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileSacuvajIzmjene.TabIndex = 2;
            this.tileSacuvajIzmjene.Text = "Sačuvaj izmjene";
            this.tileSacuvajIzmjene.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSacuvajIzmjene.Click += new System.EventHandler(this.tileSacuvajIzmjene_Click);
            // 
            // panelUserName
            // 
            this.panelUserName.Controls.Add(this.lblImeZaposlenog);
            this.panelUserName.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelUserName.Location = new System.Drawing.Point(442, 16);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(354, 36);
            this.panelUserName.TabIndex = 17;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 499);
            this.Controls.Add(this.panelUserName);
            this.Controls.Add(this.panelPromjenaLozinke);
            this.Controls.Add(this.tileProfile);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.tileAutor);
            this.Controls.Add(this.tileIzdavac);
            this.Controls.Add(this.tileNovaKnjiga);
            this.Controls.Add(this.tileNoviRadnik);
            this.Controls.Add(this.pictureBoxAdminPozadina);
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Panel: Administrator ";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminPozadina)).EndInit();
            this.panelPromjenaLozinke.ResumeLayout(false);
            this.panelPromjenaLozinke.PerformLayout();
            this.panelUserName.ResumeLayout(false);
            this.panelUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileNoviRadnik;
        private MetroFramework.Controls.MetroTile tileNovaKnjiga;
        private MetroFramework.Controls.MetroTile tileIzdavac;
        private MetroFramework.Controls.MetroTile tileAutor;
        private MetroFramework.Controls.MetroLabel lblImeZaposlenog;
        private MetroFramework.Controls.MetroTile tileLogout;
        private System.Windows.Forms.PictureBox pictureBoxAdminPozadina;
        private MetroFramework.Controls.MetroTile tileProfile;
        private MetroFramework.Controls.MetroPanel panelPromjenaLozinke;
        private MetroFramework.Controls.MetroLabel lbPotvrdiLozinku;
        private MetroFramework.Controls.MetroTextBox txtPotvrdiLozinku;
        private MetroFramework.Controls.MetroLabel lblNovaLozinka;
        private MetroFramework.Controls.MetroLabel lblTrenutnaLozinka;
        private MetroFramework.Controls.MetroTextBox txtNovaLozinka;
        private MetroFramework.Controls.MetroTextBox txtTrenutnaLozinka;
        private MetroFramework.Controls.MetroTile tileSacuvajIzmjene;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.FlowLayoutPanel panelUserName;
    }
}