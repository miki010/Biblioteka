namespace DBBiblioteka
{
    partial class FormBibliotekar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBibliotekar));
            this.lblImeZaposlenog = new MetroFramework.Controls.MetroLabel();
            this.tileProfile = new MetroFramework.Controls.MetroTile();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.tileClanarina = new MetroFramework.Controls.MetroTile();
            this.tileRazduzivanje = new MetroFramework.Controls.MetroTile();
            this.tilePregledIznajmljivanja = new MetroFramework.Controls.MetroTile();
            this.tilePretraga = new MetroFramework.Controls.MetroTile();
            this.tileIznajmi = new MetroFramework.Controls.MetroTile();
            this.tileUnosClana = new MetroFramework.Controls.MetroTile();
            this.panelPromjenaLozinke = new MetroFramework.Controls.MetroPanel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lbPotvrdiLozinku = new MetroFramework.Controls.MetroLabel();
            this.txtPotvrdiLozinku = new MetroFramework.Controls.MetroTextBox();
            this.lblNovaLozinka = new MetroFramework.Controls.MetroLabel();
            this.lblTrenutnaLozinka = new MetroFramework.Controls.MetroLabel();
            this.txtNovaLozinka = new MetroFramework.Controls.MetroTextBox();
            this.txtTrenutnaLozinka = new MetroFramework.Controls.MetroTextBox();
            this.tileSacuvajIzmjene = new MetroFramework.Controls.MetroTile();
            this.pictureBoxBibliotekarPozadina = new System.Windows.Forms.PictureBox();
            this.panelUserName = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPromjenaLozinke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBibliotekarPozadina)).BeginInit();
            this.panelUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImeZaposlenog
            // 
            this.lblImeZaposlenog.AutoSize = true;
            this.lblImeZaposlenog.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblImeZaposlenog.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblImeZaposlenog.Location = new System.Drawing.Point(235, 0);
            this.lblImeZaposlenog.MaximumSize = new System.Drawing.Size(0, 25);
            this.lblImeZaposlenog.Name = "lblImeZaposlenog";
            this.lblImeZaposlenog.Size = new System.Drawing.Size(118, 25);
            this.lblImeZaposlenog.TabIndex = 9;
            this.lblImeZaposlenog.Text = "Ime i Prezime";
            this.lblImeZaposlenog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tileProfile
            // 
            this.tileProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileProfile.Location = new System.Drawing.Point(850, 11);
            this.tileProfile.Name = "tileProfile";
            this.tileProfile.Size = new System.Drawing.Size(47, 43);
            this.tileProfile.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileProfile.TabIndex = 10;
            this.tileProfile.TileImage = global::DBBiblioteka.Properties.Resources.edit_woman_profile;
            this.tileProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileProfile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileProfile.UseTileImage = true;
            this.tileProfile.Click += new System.EventHandler(this.tileProfile_Click);
            // 
            // tileLogout
            // 
            this.tileLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileLogout.Location = new System.Drawing.Point(903, 11);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(47, 43);
            this.tileLogout.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileLogout.TabIndex = 7;
            this.tileLogout.TileImage = ((System.Drawing.Image)(resources.GetObject("tileLogout.TileImage")));
            this.tileLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLogout.UseTileImage = true;
            this.tileLogout.Click += new System.EventHandler(this.tileLogout_Click);
            // 
            // tileClanarina
            // 
            this.tileClanarina.Location = new System.Drawing.Point(388, 284);
            this.tileClanarina.MaximumSize = new System.Drawing.Size(353, 190);
            this.tileClanarina.MinimumSize = new System.Drawing.Size(335, 175);
            this.tileClanarina.Name = "tileClanarina";
            this.tileClanarina.Size = new System.Drawing.Size(353, 190);
            this.tileClanarina.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileClanarina.TabIndex = 6;
            this.tileClanarina.Text = "PREGLED ČLANOVA SA ČLANARINOM";
            this.tileClanarina.TileImage = global::DBBiblioteka.Properties.Resources.searchusermemberships;
            this.tileClanarina.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileClanarina.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileClanarina.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileClanarina.UseTileImage = true;
            this.tileClanarina.Click += new System.EventHandler(this.tileClanarina_Click);
            this.tileClanarina.MouseLeave += new System.EventHandler(this.tileClanarina_MouseLeave);
            this.tileClanarina.MouseHover += new System.EventHandler(this.tileClanarina_MouseHover);
            // 
            // tileRazduzivanje
            // 
            this.tileRazduzivanje.Location = new System.Drawing.Point(194, 284);
            this.tileRazduzivanje.MaximumSize = new System.Drawing.Size(190, 190);
            this.tileRazduzivanje.MinimumSize = new System.Drawing.Size(175, 175);
            this.tileRazduzivanje.Name = "tileRazduzivanje";
            this.tileRazduzivanje.Size = new System.Drawing.Size(190, 190);
            this.tileRazduzivanje.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileRazduzivanje.TabIndex = 5;
            this.tileRazduzivanje.Text = "RAZDUŽIVANJE";
            this.tileRazduzivanje.TileImage = global::DBBiblioteka.Properties.Resources.returnedbooks;
            this.tileRazduzivanje.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileRazduzivanje.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileRazduzivanje.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileRazduzivanje.UseTileImage = true;
            this.tileRazduzivanje.Click += new System.EventHandler(this.tileRazduzivanje_Click);
            this.tileRazduzivanje.MouseLeave += new System.EventHandler(this.tileVracanje_MouseLeave);
            this.tileRazduzivanje.MouseHover += new System.EventHandler(this.tileVracanje_MouseHover);
            // 
            // tilePregledIznajmljivanja
            // 
            this.tilePregledIznajmljivanja.Location = new System.Drawing.Point(410, 83);
            this.tilePregledIznajmljivanja.MaximumSize = new System.Drawing.Size(330, 198);
            this.tilePregledIznajmljivanja.MinimumSize = new System.Drawing.Size(310, 183);
            this.tilePregledIznajmljivanja.Name = "tilePregledIznajmljivanja";
            this.tilePregledIznajmljivanja.Size = new System.Drawing.Size(330, 198);
            this.tilePregledIznajmljivanja.Style = MetroFramework.MetroColorStyle.Purple;
            this.tilePregledIznajmljivanja.TabIndex = 4;
            this.tilePregledIznajmljivanja.Text = "PREGLED SVIH IZNAJMLJIVANJA";
            this.tilePregledIznajmljivanja.TileImage = global::DBBiblioteka.Properties.Resources.searchissued;
            this.tilePregledIznajmljivanja.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePregledIznajmljivanja.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePregledIznajmljivanja.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePregledIznajmljivanja.UseTileImage = true;
            this.tilePregledIznajmljivanja.MouseLeave += new System.EventHandler(this.tilePregledIznajmljivanja_MouseLeave);
            this.tilePregledIznajmljivanja.MouseHover += new System.EventHandler(this.tilePregledIznajmljivanja_MouseHover);
            // 
            // tilePretraga
            // 
            this.tilePretraga.Location = new System.Drawing.Point(195, 83);
            this.tilePretraga.MaximumSize = new System.Drawing.Size(210, 198);
            this.tilePretraga.MinimumSize = new System.Drawing.Size(190, 183);
            this.tilePretraga.Name = "tilePretraga";
            this.tilePretraga.Size = new System.Drawing.Size(210, 198);
            this.tilePretraga.Style = MetroFramework.MetroColorStyle.Purple;
            this.tilePretraga.TabIndex = 3;
            this.tilePretraga.Text = "PRETRAGA KNJIGA";
            this.tilePretraga.TileImage = global::DBBiblioteka.Properties.Resources.searchbook;
            this.tilePretraga.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePretraga.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePretraga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePretraga.UseTileImage = true;
            this.tilePretraga.Click += new System.EventHandler(this.tilePretraga_Click);
            this.tilePretraga.MouseLeave += new System.EventHandler(this.tilePretraga_MouseLeave);
            this.tilePretraga.MouseHover += new System.EventHandler(this.tilePretraga_MouseHover);
            // 
            // tileIznajmi
            // 
            this.tileIznajmi.Location = new System.Drawing.Point(35, 240);
            this.tileIznajmi.MaximumSize = new System.Drawing.Size(155, 235);
            this.tileIznajmi.MinimumSize = new System.Drawing.Size(140, 215);
            this.tileIznajmi.Name = "tileIznajmi";
            this.tileIznajmi.Size = new System.Drawing.Size(155, 235);
            this.tileIznajmi.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileIznajmi.TabIndex = 1;
            this.tileIznajmi.Text = "IZNAJMI";
            this.tileIznajmi.TileImage = global::DBBiblioteka.Properties.Resources.takebook;
            this.tileIznajmi.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIznajmi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileIznajmi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileIznajmi.UseTileImage = true;
            this.tileIznajmi.Click += new System.EventHandler(this.tileIznajmi_Click);
            this.tileIznajmi.MouseLeave += new System.EventHandler(this.tileIznajmi_MouseLeave);
            this.tileIznajmi.MouseHover += new System.EventHandler(this.tileIznajmi_MouseHover);
            // 
            // tileUnosClana
            // 
            this.tileUnosClana.Location = new System.Drawing.Point(35, 83);
            this.tileUnosClana.MaximumSize = new System.Drawing.Size(155, 153);
            this.tileUnosClana.MinimumSize = new System.Drawing.Size(135, 132);
            this.tileUnosClana.Name = "tileUnosClana";
            this.tileUnosClana.Size = new System.Drawing.Size(155, 153);
            this.tileUnosClana.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileUnosClana.TabIndex = 0;
            this.tileUnosClana.Text = "UNOS ČLANA";
            this.tileUnosClana.TileImage = global::DBBiblioteka.Properties.Resources.addmember;
            this.tileUnosClana.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUnosClana.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileUnosClana.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileUnosClana.UseTileImage = true;
            this.tileUnosClana.Click += new System.EventHandler(this.tileUnosClana_Click);
            this.tileUnosClana.MouseLeave += new System.EventHandler(this.tileUnosClana_MouseLeave);
            this.tileUnosClana.MouseHover += new System.EventHandler(this.tileUnosClana_MouseHover);
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
            this.panelPromjenaLozinke.Location = new System.Drawing.Point(605, 60);
            this.panelPromjenaLozinke.Name = "panelPromjenaLozinke";
            this.panelPromjenaLozinke.Size = new System.Drawing.Size(345, 365);
            this.panelPromjenaLozinke.TabIndex = 11;
            this.panelPromjenaLozinke.VerticalScrollbarBarColor = true;
            this.panelPromjenaLozinke.VerticalScrollbarHighlightOnWheel = false;
            this.panelPromjenaLozinke.VerticalScrollbarSize = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(189, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 44);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnCancel.TabIndex = 10;
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
            this.tileSacuvajIzmjene.Location = new System.Drawing.Point(28, 236);
            this.tileSacuvajIzmjene.Name = "tileSacuvajIzmjene";
            this.tileSacuvajIzmjene.Size = new System.Drawing.Size(124, 44);
            this.tileSacuvajIzmjene.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileSacuvajIzmjene.TabIndex = 2;
            this.tileSacuvajIzmjene.Text = "Sačuvaj izmjene";
            this.tileSacuvajIzmjene.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSacuvajIzmjene.Click += new System.EventHandler(this.tileSacuvajIzmjene_Click);
            // 
            // pictureBoxBibliotekarPozadina
            // 
            this.pictureBoxBibliotekarPozadina.Image = global::DBBiblioteka.Properties.Resources.bibliotekarpozadina;
            this.pictureBoxBibliotekarPozadina.Location = new System.Drawing.Point(0, 60);
            this.pictureBoxBibliotekarPozadina.MaximumSize = new System.Drawing.Size(950, 440);
            this.pictureBoxBibliotekarPozadina.MinimumSize = new System.Drawing.Size(950, 440);
            this.pictureBoxBibliotekarPozadina.Name = "pictureBoxBibliotekarPozadina";
            this.pictureBoxBibliotekarPozadina.Size = new System.Drawing.Size(950, 440);
            this.pictureBoxBibliotekarPozadina.TabIndex = 7;
            this.pictureBoxBibliotekarPozadina.TabStop = false;
            // 
            // panelUserName
            // 
            this.panelUserName.Controls.Add(this.lblImeZaposlenog);
            this.panelUserName.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelUserName.Location = new System.Drawing.Point(488, 17);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(356, 34);
            this.panelUserName.TabIndex = 15;
            // 
            // FormBibliotekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.panelUserName);
            this.Controls.Add(this.panelPromjenaLozinke);
            this.Controls.Add(this.tileProfile);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.tileClanarina);
            this.Controls.Add(this.tileRazduzivanje);
            this.Controls.Add(this.tilePregledIznajmljivanja);
            this.Controls.Add(this.tilePretraga);
            this.Controls.Add(this.tileIznajmi);
            this.Controls.Add(this.tileUnosClana);
            this.Controls.Add(this.pictureBoxBibliotekarPozadina);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBibliotekar";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Bibliotekar";
            this.Load += new System.EventHandler(this.Bibliotekar_Load);
            this.panelPromjenaLozinke.ResumeLayout(false);
            this.panelPromjenaLozinke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBibliotekarPozadina)).EndInit();
            this.panelUserName.ResumeLayout(false);
            this.panelUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileUnosClana;
        private MetroFramework.Controls.MetroTile tileIznajmi;
        private MetroFramework.Controls.MetroTile tileRazduzivanje;
        private MetroFramework.Controls.MetroTile tilePregledIznajmljivanja;
        private MetroFramework.Controls.MetroTile tilePretraga;
        private MetroFramework.Controls.MetroTile tileClanarina;
        private MetroFramework.Controls.MetroTile tileLogout;
        private MetroFramework.Controls.MetroLabel lblImeZaposlenog;
        private MetroFramework.Controls.MetroTile tileProfile;
        private MetroFramework.Controls.MetroPanel panelPromjenaLozinke;
        private MetroFramework.Controls.MetroTile tileSacuvajIzmjene;
        private MetroFramework.Controls.MetroLabel lbPotvrdiLozinku;
        private MetroFramework.Controls.MetroTextBox txtPotvrdiLozinku;
        private MetroFramework.Controls.MetroLabel lblNovaLozinka;
        private MetroFramework.Controls.MetroLabel lblTrenutnaLozinka;
        private MetroFramework.Controls.MetroTextBox txtNovaLozinka;
        private MetroFramework.Controls.MetroTextBox txtTrenutnaLozinka;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.PictureBox pictureBoxBibliotekarPozadina;
        private System.Windows.Forms.FlowLayoutPanel panelUserName;
    }
}