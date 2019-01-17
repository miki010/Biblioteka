﻿namespace DBBiblioteka
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
            this.tileAutor = new MetroFramework.Controls.MetroTile();
            this.tileIzdavac = new MetroFramework.Controls.MetroTile();
            this.tileNovaKnjiga = new MetroFramework.Controls.MetroTile();
            this.tileNoviRadnik = new MetroFramework.Controls.MetroTile();
            this.lblImeZaposlenog = new MetroFramework.Controls.MetroLabel();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileAutor
            // 
            this.tileAutor.Location = new System.Drawing.Point(362, 263);
            this.tileAutor.Name = "tileAutor";
            this.tileAutor.Size = new System.Drawing.Size(284, 185);
            this.tileAutor.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileAutor.TabIndex = 3;
            this.tileAutor.Text = "AUTOR";
            this.tileAutor.TileImage = global::DBBiblioteka.Properties.Resources.author;
            this.tileAutor.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAutor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileAutor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileAutor.UseTileImage = true;
            this.tileAutor.Click += new System.EventHandler(this.tileAutor_Click);
            // 
            // tileIzdavac
            // 
            this.tileIzdavac.Location = new System.Drawing.Point(35, 263);
            this.tileIzdavac.Name = "tileIzdavac";
            this.tileIzdavac.Size = new System.Drawing.Size(321, 185);
            this.tileIzdavac.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileIzdavac.TabIndex = 2;
            this.tileIzdavac.Text = "IZDAVAČ";
            this.tileIzdavac.TileImage = global::DBBiblioteka.Properties.Resources.publisher;
            this.tileIzdavac.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzdavac.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileIzdavac.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileIzdavac.UseTileImage = true;
            this.tileIzdavac.Click += new System.EventHandler(this.tileIzdavac_Click);
            // 
            // tileNovaKnjiga
            // 
            this.tileNovaKnjiga.Location = new System.Drawing.Point(322, 83);
            this.tileNovaKnjiga.Name = "tileNovaKnjiga";
            this.tileNovaKnjiga.Size = new System.Drawing.Size(324, 174);
            this.tileNovaKnjiga.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileNovaKnjiga.TabIndex = 1;
            this.tileNovaKnjiga.Text = "NOVA KNJIGA";
            this.tileNovaKnjiga.TileImage = global::DBBiblioteka.Properties.Resources.addbook;
            this.tileNovaKnjiga.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNovaKnjiga.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileNovaKnjiga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileNovaKnjiga.UseTileImage = true;
            this.tileNovaKnjiga.Click += new System.EventHandler(this.tileNovaKnjiga_Click);
            // 
            // tileNoviRadnik
            // 
            this.tileNoviRadnik.Location = new System.Drawing.Point(35, 83);
            this.tileNoviRadnik.Name = "tileNoviRadnik";
            this.tileNoviRadnik.Size = new System.Drawing.Size(281, 174);
            this.tileNoviRadnik.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileNoviRadnik.TabIndex = 0;
            this.tileNoviRadnik.Text = "NOVI RADNIK";
            this.tileNoviRadnik.TileImage = global::DBBiblioteka.Properties.Resources.adduser;
            this.tileNoviRadnik.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNoviRadnik.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileNoviRadnik.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileNoviRadnik.UseTileImage = true;
            this.tileNoviRadnik.Click += new System.EventHandler(this.tileNoviRadnik_Click);
            // 
            // lblImeZaposlenog
            // 
            this.lblImeZaposlenog.AutoSize = true;
            this.lblImeZaposlenog.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblImeZaposlenog.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblImeZaposlenog.Location = new System.Drawing.Point(655, 27);
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
            this.tileLogout.CustomBackground = true;
            this.tileLogout.Location = new System.Drawing.Point(780, 18);
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
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.lblImeZaposlenog);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.tileAutor);
            this.Controls.Add(this.tileIzdavac);
            this.Controls.Add(this.tileNovaKnjiga);
            this.Controls.Add(this.tileNoviRadnik);
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Panel: Administrator ";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileNoviRadnik;
        private MetroFramework.Controls.MetroTile tileNovaKnjiga;
        private MetroFramework.Controls.MetroTile tileIzdavac;
        private MetroFramework.Controls.MetroTile tileAutor;
        private MetroFramework.Controls.MetroLabel lblImeZaposlenog;
        private MetroFramework.Controls.MetroTile tileLogout;
    }
}