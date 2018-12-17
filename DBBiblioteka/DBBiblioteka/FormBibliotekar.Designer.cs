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
            this.tileUnosClana = new MetroFramework.Controls.MetroTile();
            this.tileIznajmi = new MetroFramework.Controls.MetroTile();
            this.tileVracanje = new MetroFramework.Controls.MetroTile();
            this.tilePregledIznajmljivanja = new MetroFramework.Controls.MetroTile();
            this.tilePretraga = new MetroFramework.Controls.MetroTile();
            this.tileClanarina = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileUnosClana
            // 
            this.tileUnosClana.Location = new System.Drawing.Point(70, 86);
            this.tileUnosClana.Name = "tileUnosClana";
            this.tileUnosClana.Size = new System.Drawing.Size(147, 103);
            this.tileUnosClana.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileUnosClana.TabIndex = 0;
            this.tileUnosClana.Text = "UNOS CLANA";
            // 
            // tileIznajmi
            // 
            this.tileIznajmi.Location = new System.Drawing.Point(223, 86);
            this.tileIznajmi.Name = "tileIznajmi";
            this.tileIznajmi.Size = new System.Drawing.Size(320, 103);
            this.tileIznajmi.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileIznajmi.TabIndex = 1;
            this.tileIznajmi.Text = "IZNAJMI";
            // 
            // tileVracanje
            // 
            this.tileVracanje.Location = new System.Drawing.Point(70, 195);
            this.tileVracanje.Name = "tileVracanje";
            this.tileVracanje.Size = new System.Drawing.Size(238, 103);
            this.tileVracanje.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileVracanje.TabIndex = 5;
            this.tileVracanje.Text = "VRACANJE";
            // 
            // tilePregledIznajmljivanja
            // 
            this.tilePregledIznajmljivanja.Location = new System.Drawing.Point(70, 304);
            this.tilePregledIznajmljivanja.Name = "tilePregledIznajmljivanja";
            this.tilePregledIznajmljivanja.Size = new System.Drawing.Size(209, 103);
            this.tilePregledIznajmljivanja.Style = MetroFramework.MetroColorStyle.Purple;
            this.tilePregledIznajmljivanja.TabIndex = 4;
            this.tilePregledIznajmljivanja.Text = "PREGLED SVIH IZNAJMLJIVANJA";
            // 
            // tilePretraga
            // 
            this.tilePretraga.Location = new System.Drawing.Point(314, 195);
            this.tilePretraga.Name = "tilePretraga";
            this.tilePretraga.Size = new System.Drawing.Size(229, 103);
            this.tilePretraga.Style = MetroFramework.MetroColorStyle.Purple;
            this.tilePretraga.TabIndex = 3;
            this.tilePretraga.Text = "PRETRAGA KNJIGA";
            // 
            // tileClanarina
            // 
            this.tileClanarina.Location = new System.Drawing.Point(285, 304);
            this.tileClanarina.Name = "tileClanarina";
            this.tileClanarina.Size = new System.Drawing.Size(258, 103);
            this.tileClanarina.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileClanarina.TabIndex = 6;
            this.tileClanarina.Text = "PREGLED CLANOVA SA CLANARINOM";
            // 
            // FormBibliotekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 494);
            this.Controls.Add(this.tileClanarina);
            this.Controls.Add(this.tileVracanje);
            this.Controls.Add(this.tilePregledIznajmljivanja);
            this.Controls.Add(this.tilePretraga);
            this.Controls.Add(this.tileIznajmi);
            this.Controls.Add(this.tileUnosClana);
            this.Name = "FormBibliotekar";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Bibliotekar";
            this.Load += new System.EventHandler(this.Bibliotekar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileUnosClana;
        private MetroFramework.Controls.MetroTile tileIznajmi;
        private MetroFramework.Controls.MetroTile tileVracanje;
        private MetroFramework.Controls.MetroTile tilePregledIznajmljivanja;
        private MetroFramework.Controls.MetroTile tilePretraga;
        private MetroFramework.Controls.MetroTile tileClanarina;
    }
}