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
            this.pictureBoxBibliotekarPozadina = new System.Windows.Forms.PictureBox();
            this.tileClanarina = new MetroFramework.Controls.MetroTile();
            this.tileVracanje = new MetroFramework.Controls.MetroTile();
            this.tilePregledIznajmljivanja = new MetroFramework.Controls.MetroTile();
            this.tilePretraga = new MetroFramework.Controls.MetroTile();
            this.tileIznajmi = new MetroFramework.Controls.MetroTile();
            this.tileUnosClana = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBibliotekarPozadina)).BeginInit();
            this.SuspendLayout();
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
            // tileVracanje
            // 
            this.tileVracanje.Location = new System.Drawing.Point(194, 284);
            this.tileVracanje.MaximumSize = new System.Drawing.Size(190, 190);
            this.tileVracanje.MinimumSize = new System.Drawing.Size(175, 175);
            this.tileVracanje.Name = "tileVracanje";
            this.tileVracanje.Size = new System.Drawing.Size(190, 190);
            this.tileVracanje.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileVracanje.TabIndex = 5;
            this.tileVracanje.Text = "VRAĆANJE";
            this.tileVracanje.TileImage = global::DBBiblioteka.Properties.Resources.returnedbooks;
            this.tileVracanje.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVracanje.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileVracanje.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileVracanje.UseTileImage = true;
            this.tileVracanje.Click += new System.EventHandler(this.tileVracanje_Click);
            this.tileVracanje.MouseLeave += new System.EventHandler(this.tileVracanje_MouseLeave);
            this.tileVracanje.MouseHover += new System.EventHandler(this.tileVracanje_MouseHover);
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
            // FormBibliotekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.pictureBoxBibliotekarPozadina);
            this.Controls.Add(this.tileClanarina);
            this.Controls.Add(this.tileVracanje);
            this.Controls.Add(this.tilePregledIznajmljivanja);
            this.Controls.Add(this.tilePretraga);
            this.Controls.Add(this.tileIznajmi);
            this.Controls.Add(this.tileUnosClana);
            this.MaximizeBox = false;
            this.Name = "FormBibliotekar";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Panel: Bibliotekar";
            this.Load += new System.EventHandler(this.Bibliotekar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBibliotekarPozadina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileUnosClana;
        private MetroFramework.Controls.MetroTile tileIznajmi;
        private MetroFramework.Controls.MetroTile tileVracanje;
        private MetroFramework.Controls.MetroTile tilePregledIznajmljivanja;
        private MetroFramework.Controls.MetroTile tilePretraga;
        private MetroFramework.Controls.MetroTile tileClanarina;
        private System.Windows.Forms.PictureBox pictureBoxBibliotekarPozadina;
    }
}