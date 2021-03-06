﻿namespace DBBiblioteka
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
            this.panelPromjenaLozinke = new MetroFramework.Controls.MetroPanel();
            this.lblUpozorenje = new System.Windows.Forms.Label();
            this.lblPogresnaStara = new System.Windows.Forms.Label();
            this.tilePasswordChange = new MetroFramework.Controls.MetroTile();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lbPotvrdiLozinku = new MetroFramework.Controls.MetroLabel();
            this.txtPotvrdiLozinku = new MetroFramework.Controls.MetroTextBox();
            this.lblNovaLozinka = new MetroFramework.Controls.MetroLabel();
            this.lblTrenutnaLozinka = new MetroFramework.Controls.MetroLabel();
            this.txtNovaLozinka = new MetroFramework.Controls.MetroTextBox();
            this.txtTrenutnaLozinka = new MetroFramework.Controls.MetroTextBox();
            this.tileSacuvajIzmjene = new MetroFramework.Controls.MetroTile();
            this.tilePretraga = new MetroFramework.Controls.MetroTile();
            this.panelUserName = new System.Windows.Forms.FlowLayoutPanel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroToolTip2 = new MetroFramework.Components.MetroToolTip();
            this.tileRazduzivanje = new MetroFramework.Controls.MetroTile();
            this.tileProfile = new MetroFramework.Controls.MetroTile();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.tileClanarina = new MetroFramework.Controls.MetroTile();
            this.tilePregledIznajmljivanja = new MetroFramework.Controls.MetroTile();
            this.tileIznajmi = new MetroFramework.Controls.MetroTile();
            this.tileUnosClana = new MetroFramework.Controls.MetroTile();
            this.pictureBoxBibliotekarPozadina = new System.Windows.Forms.PictureBox();
            this.panelPromjenaLozinke.SuspendLayout();
            this.panelUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBibliotekarPozadina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImeZaposlenog
            // 
            this.lblImeZaposlenog.AutoSize = true;
            this.lblImeZaposlenog.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblImeZaposlenog.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblImeZaposlenog.Location = new System.Drawing.Point(264, 0);
            this.lblImeZaposlenog.MaximumSize = new System.Drawing.Size(0, 25);
            this.lblImeZaposlenog.Name = "lblImeZaposlenog";
            this.lblImeZaposlenog.Size = new System.Drawing.Size(118, 25);
            this.lblImeZaposlenog.TabIndex = 9;
            this.lblImeZaposlenog.Text = "Ime i Prezime";
            this.lblImeZaposlenog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPromjenaLozinke
            // 
            this.panelPromjenaLozinke.Controls.Add(this.lblUpozorenje);
            this.panelPromjenaLozinke.Controls.Add(this.lblPogresnaStara);
            this.panelPromjenaLozinke.Controls.Add(this.tilePasswordChange);
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
            this.panelPromjenaLozinke.Location = new System.Drawing.Point(605, 61);
            this.panelPromjenaLozinke.Name = "panelPromjenaLozinke";
            this.panelPromjenaLozinke.Size = new System.Drawing.Size(345, 330);
            this.panelPromjenaLozinke.TabIndex = 11;
            this.panelPromjenaLozinke.VerticalScrollbarBarColor = true;
            this.panelPromjenaLozinke.VerticalScrollbarHighlightOnWheel = false;
            this.panelPromjenaLozinke.VerticalScrollbarSize = 10;
            this.panelPromjenaLozinke.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPromjenaLozinke_Paint);
            // 
            // lblUpozorenje
            // 
            this.lblUpozorenje.AutoSize = true;
            this.lblUpozorenje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUpozorenje.Location = new System.Drawing.Point(115, 247);
            this.lblUpozorenje.Name = "lblUpozorenje";
            this.lblUpozorenje.Size = new System.Drawing.Size(35, 13);
            this.lblUpozorenje.TabIndex = 13;
            this.lblUpozorenje.Text = "label1";
            // 
            // lblPogresnaStara
            // 
            this.lblPogresnaStara.AutoSize = true;
            this.lblPogresnaStara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPogresnaStara.Location = new System.Drawing.Point(115, 149);
            this.lblPogresnaStara.Name = "lblPogresnaStara";
            this.lblPogresnaStara.Size = new System.Drawing.Size(35, 13);
            this.lblPogresnaStara.TabIndex = 12;
            this.lblPogresnaStara.Text = "label1";
            // 
            // tilePasswordChange
            // 
            this.tilePasswordChange.Location = new System.Drawing.Point(0, 0);
            this.tilePasswordChange.Name = "tilePasswordChange";
            this.tilePasswordChange.Size = new System.Drawing.Size(345, 80);
            this.tilePasswordChange.Style = MetroFramework.MetroColorStyle.Purple;
            this.tilePasswordChange.TabIndex = 11;
            this.tilePasswordChange.Text = "Podešavanja lozinke";
            this.tilePasswordChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePasswordChange.TileImage = global::DBBiblioteka.Properties.Resources.resetpasswordfinal2;
            this.tilePasswordChange.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePasswordChange.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tilePasswordChange.UseTileImage = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(178, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 45);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Izlaz";
            this.btnCancel.UseMnemonic = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbPotvrdiLozinku
            // 
            this.lbPotvrdiLozinku.AutoSize = true;
            this.lbPotvrdiLozinku.Location = new System.Drawing.Point(7, 226);
            this.lbPotvrdiLozinku.Name = "lbPotvrdiLozinku";
            this.lbPotvrdiLozinku.Size = new System.Drawing.Size(98, 19);
            this.lbPotvrdiLozinku.TabIndex = 8;
            this.lbPotvrdiLozinku.Text = "Potvrdi lozinku:";
            // 
            // txtPotvrdiLozinku
            // 
            this.txtPotvrdiLozinku.Location = new System.Drawing.Point(118, 221);
            this.txtPotvrdiLozinku.Name = "txtPotvrdiLozinku";
            this.txtPotvrdiLozinku.PasswordChar = '●';
            this.txtPotvrdiLozinku.Size = new System.Drawing.Size(211, 23);
            this.txtPotvrdiLozinku.TabIndex = 7;
            this.txtPotvrdiLozinku.UseSystemPasswordChar = true;
            this.txtPotvrdiLozinku.TextChanged += new System.EventHandler(this.txtPotvrdiLozinku_TextChanged);
            // 
            // lblNovaLozinka
            // 
            this.lblNovaLozinka.AutoSize = true;
            this.lblNovaLozinka.Location = new System.Drawing.Point(7, 176);
            this.lblNovaLozinka.Name = "lblNovaLozinka";
            this.lblNovaLozinka.Size = new System.Drawing.Size(87, 19);
            this.lblNovaLozinka.TabIndex = 6;
            this.lblNovaLozinka.Text = "Nova lozinka:";
            // 
            // lblTrenutnaLozinka
            // 
            this.lblTrenutnaLozinka.AutoSize = true;
            this.lblTrenutnaLozinka.Location = new System.Drawing.Point(7, 126);
            this.lblTrenutnaLozinka.Name = "lblTrenutnaLozinka";
            this.lblTrenutnaLozinka.Size = new System.Drawing.Size(107, 19);
            this.lblTrenutnaLozinka.TabIndex = 5;
            this.lblTrenutnaLozinka.Text = "Trenutna lozinka:";
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Location = new System.Drawing.Point(118, 172);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.PasswordChar = '●';
            this.txtNovaLozinka.Size = new System.Drawing.Size(211, 23);
            this.txtNovaLozinka.TabIndex = 4;
            this.txtNovaLozinka.UseSystemPasswordChar = true;
            this.txtNovaLozinka.TextChanged += new System.EventHandler(this.txtNovaLozinka_TextChanged);
            // 
            // txtTrenutnaLozinka
            // 
            this.txtTrenutnaLozinka.Location = new System.Drawing.Point(118, 123);
            this.txtTrenutnaLozinka.Name = "txtTrenutnaLozinka";
            this.txtTrenutnaLozinka.PasswordChar = '●';
            this.txtTrenutnaLozinka.Size = new System.Drawing.Size(211, 23);
            this.txtTrenutnaLozinka.TabIndex = 3;
            this.txtTrenutnaLozinka.UseSystemPasswordChar = true;
            this.txtTrenutnaLozinka.TextChanged += new System.EventHandler(this.txtTrenutnaLozinka_TextChanged);
            // 
            // tileSacuvajIzmjene
            // 
            this.tileSacuvajIzmjene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSacuvajIzmjene.Location = new System.Drawing.Point(47, 275);
            this.tileSacuvajIzmjene.Name = "tileSacuvajIzmjene";
            this.tileSacuvajIzmjene.Size = new System.Drawing.Size(125, 45);
            this.tileSacuvajIzmjene.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileSacuvajIzmjene.TabIndex = 2;
            this.tileSacuvajIzmjene.Text = "Sačuvaj izmjene";
            this.tileSacuvajIzmjene.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSacuvajIzmjene.Click += new System.EventHandler(this.tileSacuvajIzmjene_Click);
            // 
            // tilePretraga
            // 
            this.tilePretraga.Location = new System.Drawing.Point(511, 92);
            this.tilePretraga.MaximumSize = new System.Drawing.Size(240, 190);
            this.tilePretraga.MinimumSize = new System.Drawing.Size(210, 180);
            this.tilePretraga.Name = "tilePretraga";
            this.tilePretraga.Size = new System.Drawing.Size(240, 190);
            this.tilePretraga.Style = MetroFramework.MetroColorStyle.Purple;
            this.tilePretraga.TabIndex = 3;
            this.tilePretraga.Text = "PRETRAGA KNJIGA";
            this.tilePretraga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePretraga.TileImage = global::DBBiblioteka.Properties.Resources.searchbook;
            this.tilePretraga.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePretraga.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePretraga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePretraga.UseTileImage = true;
            this.tilePretraga.Click += new System.EventHandler(this.tilePretraga_Click);
            this.tilePretraga.MouseLeave += new System.EventHandler(this.tilePretraga_MouseLeave);
            this.tilePretraga.MouseHover += new System.EventHandler(this.tilePretraga_MouseHover);
            // 
            // panelUserName
            // 
            this.panelUserName.Controls.Add(this.lblImeZaposlenog);
            this.panelUserName.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelUserName.Location = new System.Drawing.Point(449, 15);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(385, 35);
            this.panelUserName.TabIndex = 15;
            // 
            // tileRazduzivanje
            // 
            this.tileRazduzivanje.Location = new System.Drawing.Point(267, 92);
            this.tileRazduzivanje.MaximumSize = new System.Drawing.Size(240, 190);
            this.tileRazduzivanje.MinimumSize = new System.Drawing.Size(210, 180);
            this.tileRazduzivanje.Name = "tileRazduzivanje";
            this.tileRazduzivanje.Size = new System.Drawing.Size(240, 190);
            this.tileRazduzivanje.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileRazduzivanje.TabIndex = 5;
            this.tileRazduzivanje.Text = "RAZDUŽIVANJE";
            this.tileRazduzivanje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileRazduzivanje.TileImage = global::DBBiblioteka.Properties.Resources.returnedbooks;
            this.tileRazduzivanje.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileRazduzivanje.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileRazduzivanje.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileRazduzivanje.UseTileImage = true;
            this.tileRazduzivanje.Click += new System.EventHandler(this.tileRazduzivanje_Click);
            this.tileRazduzivanje.MouseLeave += new System.EventHandler(this.tileVracanje_MouseLeave);
            this.tileRazduzivanje.MouseHover += new System.EventHandler(this.tileVracanje_MouseHover);
            // 
            // tileProfile
            // 
            this.tileProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileProfile.Location = new System.Drawing.Point(840, 10);
            this.tileProfile.Name = "tileProfile";
            this.tileProfile.Size = new System.Drawing.Size(47, 43);
            this.tileProfile.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileProfile.TabIndex = 10;
            this.tileProfile.TileImage = global::DBBiblioteka.Properties.Resources.resetpasswordfinal;
            this.tileProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileProfile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileProfile.UseTileImage = true;
            this.tileProfile.Click += new System.EventHandler(this.tileProfile_Click);
            this.tileProfile.MouseHover += new System.EventHandler(this.tileProfile_MouseHover);
            // 
            // tileLogout
            // 
            this.tileLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileLogout.Location = new System.Drawing.Point(895, 10);
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
            this.tileLogout.MouseHover += new System.EventHandler(this.tileLogout_MouseHover);
            // 
            // tileClanarina
            // 
            this.tileClanarina.Location = new System.Drawing.Point(511, 287);
            this.tileClanarina.MaximumSize = new System.Drawing.Size(240, 190);
            this.tileClanarina.MinimumSize = new System.Drawing.Size(210, 180);
            this.tileClanarina.Name = "tileClanarina";
            this.tileClanarina.Size = new System.Drawing.Size(240, 190);
            this.tileClanarina.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileClanarina.TabIndex = 6;
            this.tileClanarina.Text = "PREGLED KNJIGA PO ŽANROVIMA";
            this.tileClanarina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileClanarina.TileImage = global::DBBiblioteka.Properties.Resources.searchusermemberships;
            this.tileClanarina.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileClanarina.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileClanarina.UseTileImage = true;
            this.tileClanarina.Click += new System.EventHandler(this.tileClanarina_Click);
            this.tileClanarina.MouseLeave += new System.EventHandler(this.tileClanarina_MouseLeave);
            this.tileClanarina.MouseHover += new System.EventHandler(this.tileClanarina_MouseHover);
            // 
            // tilePregledIznajmljivanja
            // 
            this.tilePregledIznajmljivanja.Location = new System.Drawing.Point(267, 287);
            this.tilePregledIznajmljivanja.MaximumSize = new System.Drawing.Size(240, 190);
            this.tilePregledIznajmljivanja.MinimumSize = new System.Drawing.Size(210, 180);
            this.tilePregledIznajmljivanja.Name = "tilePregledIznajmljivanja";
            this.tilePregledIznajmljivanja.Size = new System.Drawing.Size(240, 190);
            this.tilePregledIznajmljivanja.Style = MetroFramework.MetroColorStyle.Purple;
            this.tilePregledIznajmljivanja.TabIndex = 4;
            this.tilePregledIznajmljivanja.Text = "PREGLED IZNAJMLJIVANJA";
            this.tilePregledIznajmljivanja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePregledIznajmljivanja.TileImage = global::DBBiblioteka.Properties.Resources.searchissued;
            this.tilePregledIznajmljivanja.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePregledIznajmljivanja.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePregledIznajmljivanja.UseTileImage = true;
            this.tilePregledIznajmljivanja.Click += new System.EventHandler(this.tilePregledIznajmljivanja_Click);
            this.tilePregledIznajmljivanja.MouseLeave += new System.EventHandler(this.tilePregledIznajmljivanja_MouseLeave);
            this.tilePregledIznajmljivanja.MouseHover += new System.EventHandler(this.tilePregledIznajmljivanja_MouseHover);
            // 
            // tileIznajmi
            // 
            this.tileIznajmi.Location = new System.Drawing.Point(23, 92);
            this.tileIznajmi.MaximumSize = new System.Drawing.Size(240, 190);
            this.tileIznajmi.MinimumSize = new System.Drawing.Size(210, 180);
            this.tileIznajmi.Name = "tileIznajmi";
            this.tileIznajmi.Size = new System.Drawing.Size(240, 190);
            this.tileIznajmi.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileIznajmi.TabIndex = 1;
            this.tileIznajmi.Text = "IZNAJMLJIVANJE";
            this.tileIznajmi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.tileUnosClana.Location = new System.Drawing.Point(23, 287);
            this.tileUnosClana.MaximumSize = new System.Drawing.Size(240, 190);
            this.tileUnosClana.MinimumSize = new System.Drawing.Size(210, 180);
            this.tileUnosClana.Name = "tileUnosClana";
            this.tileUnosClana.Size = new System.Drawing.Size(240, 190);
            this.tileUnosClana.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileUnosClana.TabIndex = 0;
            this.tileUnosClana.Text = "DODAJ NOVOG ČLANA";
            this.tileUnosClana.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileUnosClana.TileImage = global::DBBiblioteka.Properties.Resources.addmember;
            this.tileUnosClana.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUnosClana.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileUnosClana.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileUnosClana.UseTileImage = true;
            this.tileUnosClana.Click += new System.EventHandler(this.tileUnosClana_Click);
            this.tileUnosClana.MouseLeave += new System.EventHandler(this.tileUnosClana_MouseLeave);
            this.tileUnosClana.MouseHover += new System.EventHandler(this.tileUnosClana_MouseHover);
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
            this.pictureBoxBibliotekarPozadina.Click += new System.EventHandler(this.pictureBoxBibliotekarPozadina_Click);
            // 
            // FormBibliotekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.tileRazduzivanje);
            this.Controls.Add(this.panelUserName);
            this.Controls.Add(this.panelPromjenaLozinke);
            this.Controls.Add(this.tileProfile);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.tileClanarina);
            this.Controls.Add(this.tilePregledIznajmljivanja);
            this.Controls.Add(this.tileIznajmi);
            this.Controls.Add(this.tilePretraga);
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
            this.panelUserName.ResumeLayout(false);
            this.panelUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBibliotekarPozadina)).EndInit();
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
        private MetroFramework.Controls.MetroTile tilePasswordChange;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Components.MetroToolTip metroToolTip2;
        private System.Windows.Forms.Label lblPogresnaStara;
        private System.Windows.Forms.Label lblUpozorenje;
    }
}