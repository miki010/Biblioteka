namespace DBBiblioteka
{
    partial class FormBlagajnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlagajnik));
            this.tileIzvjestaj = new MetroFramework.Controls.MetroTile();
            this.tileTipClanarine = new MetroFramework.Controls.MetroTile();
            this.tilePregledClanarina = new MetroFramework.Controls.MetroTile();
            this.tileDodajClanarinu = new MetroFramework.Controls.MetroTile();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.lblImeZaposlenog = new MetroFramework.Controls.MetroLabel();
            this.panelPromjenaLozinke = new MetroFramework.Controls.MetroPanel();
            this.tilePasswordChange = new MetroFramework.Controls.MetroTile();
            this.lblUpozorenje = new System.Windows.Forms.Label();
            this.lblPogresnaStara = new System.Windows.Forms.Label();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lbPotvrdiLozinku = new MetroFramework.Controls.MetroLabel();
            this.txtPotvrdiLozinku = new MetroFramework.Controls.MetroTextBox();
            this.lblNovaLozinka = new MetroFramework.Controls.MetroLabel();
            this.lblTrenutnaLozinka = new MetroFramework.Controls.MetroLabel();
            this.txtNovaLozinka = new MetroFramework.Controls.MetroTextBox();
            this.txtTrenutnaLozinka = new MetroFramework.Controls.MetroTextBox();
            this.tileSacuvajIzmjene = new MetroFramework.Controls.MetroTile();
            this.panelUserName = new System.Windows.Forms.FlowLayoutPanel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroToolTip2 = new MetroFramework.Components.MetroToolTip();
            this.pictureBoxBlagajnikPozadina = new System.Windows.Forms.PictureBox();
            this.tileProfile = new MetroFramework.Controls.MetroTile();
            this.panelPromjenaLozinke.SuspendLayout();
            this.panelUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlagajnikPozadina)).BeginInit();
            this.SuspendLayout();
            // 
            // tileIzvjestaj
            // 
            this.tileIzvjestaj.Location = new System.Drawing.Point(285, 290);
            this.tileIzvjestaj.MaximumSize = new System.Drawing.Size(375, 175);
            this.tileIzvjestaj.MinimumSize = new System.Drawing.Size(355, 160);
            this.tileIzvjestaj.Name = "tileIzvjestaj";
            this.tileIzvjestaj.Size = new System.Drawing.Size(375, 175);
            this.tileIzvjestaj.TabIndex = 3;
            this.tileIzvjestaj.Text = "DETALJAN FINANSIJSKI IZVJEŠTAJ";
            this.tileIzvjestaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileIzvjestaj.TileImage = global::DBBiblioteka.Properties.Resources.financialreport;
            this.tileIzvjestaj.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzvjestaj.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileIzvjestaj.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileIzvjestaj.UseTileImage = true;
            this.tileIzvjestaj.Click += new System.EventHandler(this.tileIzvjestaj_Click);
            this.tileIzvjestaj.MouseLeave += new System.EventHandler(this.tileIzvjestaj_MouseLeave);
            this.tileIzvjestaj.MouseHover += new System.EventHandler(this.tileIzvjestaj_MouseHover);
            // 
            // tileTipClanarine
            // 
            this.tileTipClanarine.Location = new System.Drawing.Point(35, 290);
            this.tileTipClanarine.MaximumSize = new System.Drawing.Size(245, 175);
            this.tileTipClanarine.MinimumSize = new System.Drawing.Size(225, 160);
            this.tileTipClanarine.Name = "tileTipClanarine";
            this.tileTipClanarine.Size = new System.Drawing.Size(245, 175);
            this.tileTipClanarine.TabIndex = 2;
            this.tileTipClanarine.Text = "TIP ČLANARINE";
            this.tileTipClanarine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileTipClanarine.TileImage = global::DBBiblioteka.Properties.Resources.typeofmembership;
            this.tileTipClanarine.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTipClanarine.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileTipClanarine.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileTipClanarine.UseTileImage = true;
            this.tileTipClanarine.Click += new System.EventHandler(this.tileTipClanarine_Click);
            this.tileTipClanarine.MouseLeave += new System.EventHandler(this.tileTipClanarine_MouseLeave);
            this.tileTipClanarine.MouseHover += new System.EventHandler(this.tileTipClanarine_MouseHover);
            // 
            // tilePregledClanarina
            // 
            this.tilePregledClanarina.Location = new System.Drawing.Point(315, 100);
            this.tilePregledClanarina.MaximumSize = new System.Drawing.Size(345, 185);
            this.tilePregledClanarina.MinimumSize = new System.Drawing.Size(325, 170);
            this.tilePregledClanarina.Name = "tilePregledClanarina";
            this.tilePregledClanarina.Size = new System.Drawing.Size(345, 185);
            this.tilePregledClanarina.TabIndex = 1;
            this.tilePregledClanarina.Text = "PREGLED ČLANARINA SA PRETRAGOM";
            this.tilePregledClanarina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePregledClanarina.TileImage = global::DBBiblioteka.Properties.Resources.listofmembers;
            this.tilePregledClanarina.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePregledClanarina.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePregledClanarina.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePregledClanarina.UseTileImage = true;
            this.tilePregledClanarina.Click += new System.EventHandler(this.tilePregledClanarina_Click);
            this.tilePregledClanarina.MouseLeave += new System.EventHandler(this.tilePregledClanarina_MouseLeave);
            this.tilePregledClanarina.MouseHover += new System.EventHandler(this.tilePregledClanarina_MouseHover);
            // 
            // tileDodajClanarinu
            // 
            this.tileDodajClanarinu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDodajClanarinu.Location = new System.Drawing.Point(35, 100);
            this.tileDodajClanarinu.MaximumSize = new System.Drawing.Size(275, 185);
            this.tileDodajClanarinu.MinimumSize = new System.Drawing.Size(255, 170);
            this.tileDodajClanarinu.Name = "tileDodajClanarinu";
            this.tileDodajClanarinu.Size = new System.Drawing.Size(275, 185);
            this.tileDodajClanarinu.TabIndex = 0;
            this.tileDodajClanarinu.Text = "UPLATA ČLANARINE";
            this.tileDodajClanarinu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDodajClanarinu.TileImage = global::DBBiblioteka.Properties.Resources.id_card;
            this.tileDodajClanarinu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDodajClanarinu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileDodajClanarinu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDodajClanarinu.UseTileImage = true;
            this.tileDodajClanarinu.Click += new System.EventHandler(this.tileDodajClanarinu_Click);
            this.tileDodajClanarinu.MouseLeave += new System.EventHandler(this.tileDodajClanarinu_MouseLeave);
            this.tileDodajClanarinu.MouseHover += new System.EventHandler(this.tileDodajClanarinu_MouseHover);
            // 
            // tileLogout
            // 
            this.tileLogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tileLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileLogout.CustomBackground = true;
            this.tileLogout.Location = new System.Drawing.Point(845, 10);
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
            this.tileLogout.MouseHover += new System.EventHandler(this.tileLogout_MouseHover);
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
            // panelPromjenaLozinke
            // 
            this.panelPromjenaLozinke.BackColor = System.Drawing.Color.AliceBlue;
            this.panelPromjenaLozinke.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelPromjenaLozinke.Controls.Add(this.tilePasswordChange);
            this.panelPromjenaLozinke.Controls.Add(this.lblUpozorenje);
            this.panelPromjenaLozinke.Controls.Add(this.lblPogresnaStara);
            this.panelPromjenaLozinke.Controls.Add(this.btnCancel);
            this.panelPromjenaLozinke.Controls.Add(this.lbPotvrdiLozinku);
            this.panelPromjenaLozinke.Controls.Add(this.txtPotvrdiLozinku);
            this.panelPromjenaLozinke.Controls.Add(this.lblNovaLozinka);
            this.panelPromjenaLozinke.Controls.Add(this.lblTrenutnaLozinka);
            this.panelPromjenaLozinke.Controls.Add(this.txtNovaLozinka);
            this.panelPromjenaLozinke.Controls.Add(this.txtTrenutnaLozinka);
            this.panelPromjenaLozinke.Controls.Add(this.tileSacuvajIzmjene);
            this.panelPromjenaLozinke.CustomBackground = true;
            this.panelPromjenaLozinke.HorizontalScrollbarBarColor = true;
            this.panelPromjenaLozinke.HorizontalScrollbarHighlightOnWheel = false;
            this.panelPromjenaLozinke.HorizontalScrollbarSize = 10;
            this.panelPromjenaLozinke.Location = new System.Drawing.Point(555, 61);
            this.panelPromjenaLozinke.Name = "panelPromjenaLozinke";
            this.panelPromjenaLozinke.Size = new System.Drawing.Size(345, 330);
            this.panelPromjenaLozinke.TabIndex = 13;
            this.panelPromjenaLozinke.VerticalScrollbarBarColor = true;
            this.panelPromjenaLozinke.VerticalScrollbarHighlightOnWheel = false;
            this.panelPromjenaLozinke.VerticalScrollbarSize = 10;
            // 
            // tilePasswordChange
            // 
            this.tilePasswordChange.Location = new System.Drawing.Point(0, 1);
            this.tilePasswordChange.Name = "tilePasswordChange";
            this.tilePasswordChange.Size = new System.Drawing.Size(345, 80);
            this.tilePasswordChange.TabIndex = 11;
            this.tilePasswordChange.Text = "Podešavanja lozinke";
            this.tilePasswordChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePasswordChange.TileImage = global::DBBiblioteka.Properties.Resources.resetpasswordfinal3;
            this.tilePasswordChange.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePasswordChange.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tilePasswordChange.UseTileImage = true;
            // 
            // lblUpozorenje
            // 
            this.lblUpozorenje.AutoSize = true;
            this.lblUpozorenje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUpozorenje.Location = new System.Drawing.Point(115, 236);
            this.lblUpozorenje.Name = "lblUpozorenje";
            this.lblUpozorenje.Size = new System.Drawing.Size(35, 13);
            this.lblUpozorenje.TabIndex = 12;
            this.lblUpozorenje.Text = "label1";
            // 
            // lblPogresnaStara
            // 
            this.lblPogresnaStara.AutoSize = true;
            this.lblPogresnaStara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPogresnaStara.Location = new System.Drawing.Point(115, 139);
            this.lblPogresnaStara.Name = "lblPogresnaStara";
            this.lblPogresnaStara.Size = new System.Drawing.Size(35, 13);
            this.lblPogresnaStara.TabIndex = 11;
            this.lblPogresnaStara.Text = "label1";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(174, 269);
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
            this.lbPotvrdiLozinku.CustomBackground = true;
            this.lbPotvrdiLozinku.Location = new System.Drawing.Point(8, 215);
            this.lbPotvrdiLozinku.Name = "lbPotvrdiLozinku";
            this.lbPotvrdiLozinku.Size = new System.Drawing.Size(98, 19);
            this.lbPotvrdiLozinku.TabIndex = 8;
            this.lbPotvrdiLozinku.Text = "Potvrdi lozinku:";
            // 
            // txtPotvrdiLozinku
            // 
            this.txtPotvrdiLozinku.Location = new System.Drawing.Point(116, 211);
            this.txtPotvrdiLozinku.Name = "txtPotvrdiLozinku";
            this.txtPotvrdiLozinku.PasswordChar = '●';
            this.txtPotvrdiLozinku.Size = new System.Drawing.Size(213, 23);
            this.txtPotvrdiLozinku.TabIndex = 7;
            this.txtPotvrdiLozinku.UseSystemPasswordChar = true;
            this.txtPotvrdiLozinku.TextChanged += new System.EventHandler(this.txtPotvrdiLozinku_TextChanged);
            // 
            // lblNovaLozinka
            // 
            this.lblNovaLozinka.AutoSize = true;
            this.lblNovaLozinka.CustomBackground = true;
            this.lblNovaLozinka.Location = new System.Drawing.Point(8, 169);
            this.lblNovaLozinka.Name = "lblNovaLozinka";
            this.lblNovaLozinka.Size = new System.Drawing.Size(87, 19);
            this.lblNovaLozinka.TabIndex = 6;
            this.lblNovaLozinka.Text = "Nova lozinka:";
            // 
            // lblTrenutnaLozinka
            // 
            this.lblTrenutnaLozinka.AutoSize = true;
            this.lblTrenutnaLozinka.CustomBackground = true;
            this.lblTrenutnaLozinka.Location = new System.Drawing.Point(8, 117);
            this.lblTrenutnaLozinka.Name = "lblTrenutnaLozinka";
            this.lblTrenutnaLozinka.Size = new System.Drawing.Size(107, 19);
            this.lblTrenutnaLozinka.TabIndex = 5;
            this.lblTrenutnaLozinka.Text = "Trenutna lozinka:";
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Location = new System.Drawing.Point(116, 165);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.PasswordChar = '●';
            this.txtNovaLozinka.Size = new System.Drawing.Size(213, 23);
            this.txtNovaLozinka.TabIndex = 4;
            this.txtNovaLozinka.UseSystemPasswordChar = true;
            this.txtNovaLozinka.TextChanged += new System.EventHandler(this.txtNovaLozinka_TextChanged);
            // 
            // txtTrenutnaLozinka
            // 
            this.txtTrenutnaLozinka.Location = new System.Drawing.Point(116, 113);
            this.txtTrenutnaLozinka.Name = "txtTrenutnaLozinka";
            this.txtTrenutnaLozinka.PasswordChar = '●';
            this.txtTrenutnaLozinka.Size = new System.Drawing.Size(213, 23);
            this.txtTrenutnaLozinka.TabIndex = 3;
            this.txtTrenutnaLozinka.UseSystemPasswordChar = true;
            this.txtTrenutnaLozinka.TextChanged += new System.EventHandler(this.txtTrenutnaLozinka_TextChanged);
            // 
            // tileSacuvajIzmjene
            // 
            this.tileSacuvajIzmjene.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tileSacuvajIzmjene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSacuvajIzmjene.CustomBackground = true;
            this.tileSacuvajIzmjene.CustomForeColor = true;
            this.tileSacuvajIzmjene.ForeColor = System.Drawing.Color.White;
            this.tileSacuvajIzmjene.Location = new System.Drawing.Point(43, 269);
            this.tileSacuvajIzmjene.Name = "tileSacuvajIzmjene";
            this.tileSacuvajIzmjene.Size = new System.Drawing.Size(125, 45);
            this.tileSacuvajIzmjene.TabIndex = 2;
            this.tileSacuvajIzmjene.Text = "Sačuvaj izmjene";
            this.tileSacuvajIzmjene.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSacuvajIzmjene.Click += new System.EventHandler(this.tileSacuvajIzmjene_Click);
            // 
            // panelUserName
            // 
            this.panelUserName.Controls.Add(this.lblImeZaposlenog);
            this.panelUserName.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelUserName.Location = new System.Drawing.Point(430, 15);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(354, 35);
            this.panelUserName.TabIndex = 16;
            // 
            // pictureBoxBlagajnikPozadina
            // 
            this.pictureBoxBlagajnikPozadina.Image = global::DBBiblioteka.Properties.Resources.blaganikpozadina1;
            this.pictureBoxBlagajnikPozadina.Location = new System.Drawing.Point(0, 60);
            this.pictureBoxBlagajnikPozadina.Name = "pictureBoxBlagajnikPozadina";
            this.pictureBoxBlagajnikPozadina.Size = new System.Drawing.Size(900, 440);
            this.pictureBoxBlagajnikPozadina.TabIndex = 18;
            this.pictureBoxBlagajnikPozadina.TabStop = false;
            // 
            // tileProfile
            // 
            this.tileProfile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tileProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileProfile.CustomBackground = true;
            this.tileProfile.Location = new System.Drawing.Point(790, 10);
            this.tileProfile.Name = "tileProfile";
            this.tileProfile.Size = new System.Drawing.Size(47, 43);
            this.tileProfile.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileProfile.TabIndex = 12;
            this.tileProfile.TileImage = global::DBBiblioteka.Properties.Resources.resetpasswordfinal;
            this.tileProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileProfile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileProfile.UseTileImage = true;
            this.tileProfile.Click += new System.EventHandler(this.tileProfile_Click);
            this.tileProfile.MouseHover += new System.EventHandler(this.tileProfile_MouseHover);
            // 
            // FormBlagajnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panelUserName);
            this.Controls.Add(this.panelPromjenaLozinke);
            this.Controls.Add(this.tileProfile);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.tileIzvjestaj);
            this.Controls.Add(this.tileTipClanarine);
            this.Controls.Add(this.tilePregledClanarina);
            this.Controls.Add(this.tileDodajClanarinu);
            this.Controls.Add(this.pictureBoxBlagajnikPozadina);
            this.MaximizeBox = false;
            this.Name = "FormBlagajnik";
            this.Resizable = false;
            this.Text = "Blagajnik";
            this.Load += new System.EventHandler(this.FormBlagajnik_Load);
            this.panelPromjenaLozinke.ResumeLayout(false);
            this.panelPromjenaLozinke.PerformLayout();
            this.panelUserName.ResumeLayout(false);
            this.panelUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlagajnikPozadina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileDodajClanarinu;
        private MetroFramework.Controls.MetroTile tilePregledClanarina;
        private MetroFramework.Controls.MetroTile tileTipClanarine;
        private MetroFramework.Controls.MetroTile tileIzvjestaj;
        private MetroFramework.Controls.MetroTile tileLogout;
        private MetroFramework.Controls.MetroLabel lblImeZaposlenog;
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
        private System.Windows.Forms.Label lblUpozorenje;
        private System.Windows.Forms.Label lblPogresnaStara;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Components.MetroToolTip metroToolTip2;
        private System.Windows.Forms.PictureBox pictureBoxBlagajnikPozadina;
        private MetroFramework.Controls.MetroTile tilePasswordChange;
    }
}