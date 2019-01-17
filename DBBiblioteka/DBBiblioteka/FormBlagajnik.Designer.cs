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
            this.SuspendLayout();
            // 
            // tileIzvjestaj
            // 
            this.tileIzvjestaj.Location = new System.Drawing.Point(285, 274);
            this.tileIzvjestaj.MaximumSize = new System.Drawing.Size(375, 175);
            this.tileIzvjestaj.MinimumSize = new System.Drawing.Size(355, 160);
            this.tileIzvjestaj.Name = "tileIzvjestaj";
            this.tileIzvjestaj.Size = new System.Drawing.Size(375, 175);
            this.tileIzvjestaj.TabIndex = 3;
            this.tileIzvjestaj.Text = "DETALJAN FINANCIJSKI IZVJEŠTAJ";
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
            this.tileTipClanarine.Location = new System.Drawing.Point(35, 274);
            this.tileTipClanarine.MaximumSize = new System.Drawing.Size(245, 175);
            this.tileTipClanarine.MinimumSize = new System.Drawing.Size(225, 160);
            this.tileTipClanarine.Name = "tileTipClanarine";
            this.tileTipClanarine.Size = new System.Drawing.Size(245, 175);
            this.tileTipClanarine.TabIndex = 2;
            this.tileTipClanarine.Text = "TIP ČLANARINE";
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
            this.tilePregledClanarina.Location = new System.Drawing.Point(315, 85);
            this.tilePregledClanarina.MaximumSize = new System.Drawing.Size(345, 185);
            this.tilePregledClanarina.MinimumSize = new System.Drawing.Size(325, 170);
            this.tilePregledClanarina.Name = "tilePregledClanarina";
            this.tilePregledClanarina.Size = new System.Drawing.Size(345, 185);
            this.tilePregledClanarina.TabIndex = 1;
            this.tilePregledClanarina.Text = "PREGLED ČLANARINA SA PRETRAGOM";
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
            this.tileDodajClanarinu.Location = new System.Drawing.Point(35, 85);
            this.tileDodajClanarinu.MaximumSize = new System.Drawing.Size(275, 185);
            this.tileDodajClanarinu.MinimumSize = new System.Drawing.Size(255, 170);
            this.tileDodajClanarinu.Name = "tileDodajClanarinu";
            this.tileDodajClanarinu.Size = new System.Drawing.Size(275, 185);
            this.tileDodajClanarinu.TabIndex = 0;
            this.tileDodajClanarinu.Text = "DODAJ ČLANARINU";
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
            this.tileLogout.Location = new System.Drawing.Point(780, 31);
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
            // lblImeZaposlenog
            // 
            this.lblImeZaposlenog.AutoSize = true;
            this.lblImeZaposlenog.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblImeZaposlenog.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblImeZaposlenog.Location = new System.Drawing.Point(602, 49);
            this.lblImeZaposlenog.MaximumSize = new System.Drawing.Size(0, 25);
            this.lblImeZaposlenog.Name = "lblImeZaposlenog";
            this.lblImeZaposlenog.Size = new System.Drawing.Size(41, 25);
            this.lblImeZaposlenog.TabIndex = 11;
            this.lblImeZaposlenog.Text = "ime";
            this.lblImeZaposlenog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormBlagajnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.lblImeZaposlenog);
            this.Controls.Add(this.tileIzvjestaj);
            this.Controls.Add(this.tileTipClanarine);
            this.Controls.Add(this.tilePregledClanarina);
            this.Controls.Add(this.tileDodajClanarinu);
            this.MaximizeBox = false;
            this.Name = "FormBlagajnik";
            this.Resizable = false;
            this.Text = "Blagajnik";
            this.Load += new System.EventHandler(this.FormBlagajnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileDodajClanarinu;
        private MetroFramework.Controls.MetroTile tilePregledClanarina;
        private MetroFramework.Controls.MetroTile tileTipClanarine;
        private MetroFramework.Controls.MetroTile tileIzvjestaj;
        private System.Windows.Forms.PictureBox pictureBoxBlagajnikPozadina;
        private MetroFramework.Controls.MetroTile tileLogout;
        private MetroFramework.Controls.MetroLabel lblImeZaposlenog;
    }
}