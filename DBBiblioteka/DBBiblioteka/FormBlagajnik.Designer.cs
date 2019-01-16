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
            this.tileIzvjestaj = new MetroFramework.Controls.MetroTile();
            this.tileTipClanarine = new MetroFramework.Controls.MetroTile();
            this.tilePregledClanarina = new MetroFramework.Controls.MetroTile();
            this.tileDodajClanarinu = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileIzvjestaj
            // 
            this.tileIzvjestaj.Location = new System.Drawing.Point(288, 274);
            this.tileIzvjestaj.Name = "tileIzvjestaj";
            this.tileIzvjestaj.Size = new System.Drawing.Size(370, 175);
            this.tileIzvjestaj.TabIndex = 3;
            this.tileIzvjestaj.Text = "DETALJAN FINANCIJSKI IZVJEŠTAJ";
           this.tileIzvjestaj.TileImage = global::DBBiblioteka.Properties.Resources.financialreport;
            this.tileIzvjestaj.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzvjestaj.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileIzvjestaj.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileIzvjestaj.UseTileImage = true;
            // 
            // tileTipClanarine
            // 
            this.tileTipClanarine.Location = new System.Drawing.Point(35, 274);
            this.tileTipClanarine.Name = "tileTipClanarine";
            this.tileTipClanarine.Size = new System.Drawing.Size(247, 175);
            this.tileTipClanarine.TabIndex = 2;
            this.tileTipClanarine.Text = "TIP ČLANARINE";
           this.tileTipClanarine.TileImage = global::DBBiblioteka.Properties.Resources.typeofmembership;
            this.tileTipClanarine.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTipClanarine.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileTipClanarine.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileTipClanarine.UseTileImage = true;
            this.tileTipClanarine.Click += new System.EventHandler(this.tileTipClanarine_Click);
            // 
            // tilePregledClanarina
            // 
            this.tilePregledClanarina.Location = new System.Drawing.Point(313, 85);
            this.tilePregledClanarina.Name = "tilePregledClanarina";
            this.tilePregledClanarina.Size = new System.Drawing.Size(345, 183);
            this.tilePregledClanarina.TabIndex = 1;
            this.tilePregledClanarina.Text = "PREGLED ČLANARINA SA PRETRAGOM";
            this.tilePregledClanarina.TileImage = global::DBBiblioteka.Properties.Resources.listofmembers;
            this.tilePregledClanarina.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePregledClanarina.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePregledClanarina.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePregledClanarina.UseTileImage = true;
            // 
            // tileDodajClanarinu
            // 
            this.tileDodajClanarinu.Location = new System.Drawing.Point(35, 85);
            this.tileDodajClanarinu.Name = "tileDodajClanarinu";
            this.tileDodajClanarinu.Size = new System.Drawing.Size(272, 183);
            this.tileDodajClanarinu.TabIndex = 0;
            this.tileDodajClanarinu.Text = "DODAJ ČLANARINU";
            this.tileDodajClanarinu.TileImage = global::DBBiblioteka.Properties.Resources.id_card;
            this.tileDodajClanarinu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDodajClanarinu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileDodajClanarinu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDodajClanarinu.UseTileImage = true;
            this.tileDodajClanarinu.Click += new System.EventHandler(this.tileDodajClanarinu_Click);
            // 
            // FormBlagajnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.tileIzvjestaj);
            this.Controls.Add(this.tileTipClanarine);
            this.Controls.Add(this.tilePregledClanarina);
            this.Controls.Add(this.tileDodajClanarinu);
            this.MaximizeBox = false;
            this.Name = "FormBlagajnik";
            this.Resizable = false;
            this.Text = "Panel: Blagajnik";
            this.Load += new System.EventHandler(this.FormBlagajnik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileDodajClanarinu;
        private MetroFramework.Controls.MetroTile tilePregledClanarina;
        private MetroFramework.Controls.MetroTile tileTipClanarine;
        private MetroFramework.Controls.MetroTile tileIzvjestaj;
    }
}