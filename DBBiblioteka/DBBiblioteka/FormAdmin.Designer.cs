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
            this.pictureBoxAdminPozadina = new System.Windows.Forms.PictureBox();
            this.tileAutor = new MetroFramework.Controls.MetroTile();
            this.tileIzdavac = new MetroFramework.Controls.MetroTile();
            this.tileNovaKnjiga = new MetroFramework.Controls.MetroTile();
            this.tileNoviRadnik = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminPozadina)).BeginInit();
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
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pictureBoxAdminPozadina);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminPozadina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileNoviRadnik;
        private MetroFramework.Controls.MetroTile tileNovaKnjiga;
        private MetroFramework.Controls.MetroTile tileIzdavac;
        private MetroFramework.Controls.MetroTile tileAutor;
        private System.Windows.Forms.PictureBox pictureBoxAdminPozadina;
    }
}