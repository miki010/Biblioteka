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
            this.tileDodajClana = new MetroFramework.Controls.MetroTile();
            this.tilePregledClanarina = new MetroFramework.Controls.MetroTile();
            this.tileTipClanarine = new MetroFramework.Controls.MetroTile();
            this.tileIzvjestaj = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileDodajClana
            // 
            this.tileDodajClana.Location = new System.Drawing.Point(73, 93);
            this.tileDodajClana.Name = "tileDodajClana";
            this.tileDodajClana.Size = new System.Drawing.Size(204, 118);
            this.tileDodajClana.TabIndex = 0;
            this.tileDodajClana.Text = "DODAJ CLANARINU";
            this.tileDodajClana.Click += new System.EventHandler(this.tileDodajClana_Click);
            // 
            // tilePregledClanarina
            // 
            this.tilePregledClanarina.Location = new System.Drawing.Point(283, 93);
            this.tilePregledClanarina.Name = "tilePregledClanarina";
            this.tilePregledClanarina.Size = new System.Drawing.Size(293, 118);
            this.tilePregledClanarina.TabIndex = 1;
            this.tilePregledClanarina.Text = "PREGLED CLANARINA SA PRETRAGOM";
            // 
            // tileTipClanarine
            // 
            this.tileTipClanarine.Location = new System.Drawing.Point(73, 217);
            this.tileTipClanarine.Name = "tileTipClanarine";
            this.tileTipClanarine.Size = new System.Drawing.Size(247, 106);
            this.tileTipClanarine.TabIndex = 2;
            this.tileTipClanarine.Text = "TIP CLANARINE";
            // 
            // tileIzvjestaj
            // 
            this.tileIzvjestaj.Location = new System.Drawing.Point(326, 217);
            this.tileIzvjestaj.Name = "tileIzvjestaj";
            this.tileIzvjestaj.Size = new System.Drawing.Size(250, 106);
            this.tileIzvjestaj.TabIndex = 3;
            this.tileIzvjestaj.Text = "DETALJAN FINANCIJSKI IZVJESTAJ";
            // 
            // FormBlagajnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tileIzvjestaj);
            this.Controls.Add(this.tileTipClanarine);
            this.Controls.Add(this.tilePregledClanarina);
            this.Controls.Add(this.tileDodajClana);
            this.Name = "FormBlagajnik";
            this.Text = "Blagajnik";
            this.Load += new System.EventHandler(this.FormBlagajnik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileDodajClana;
        private MetroFramework.Controls.MetroTile tilePregledClanarina;
        private MetroFramework.Controls.MetroTile tileTipClanarine;
        private MetroFramework.Controls.MetroTile tileIzvjestaj;
    }
}