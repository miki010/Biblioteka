namespace DBBiblioteka
{
    partial class FormStandard
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
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.tileDodaj = new MetroFramework.Controls.MetroTile();
            this.tileIzmijeni = new MetroFramework.Controls.MetroTile();
            this.tileObrisi = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnVrati = new MetroFramework.Controls.MetroTile();
            this.lbDetaljno = new System.Windows.Forms.ListBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnDetaljnaPretraga = new MetroFramework.Controls.MetroButton();
            this.btnAzurirajZapise = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.AllowUserToAddRows = false;
            this.dgvPrikaz.AllowUserToDeleteRows = false;
            this.dgvPrikaz.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Location = new System.Drawing.Point(57, 193);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.ReadOnly = true;
            this.dgvPrikaz.Size = new System.Drawing.Size(505, 328);
            this.dgvPrikaz.TabIndex = 0;
            this.dgvPrikaz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPrikaz_MouseClick);
            // 
            // tileDodaj
            // 
            this.tileDodaj.Location = new System.Drawing.Point(3, 3);
            this.tileDodaj.Name = "tileDodaj";
            this.tileDodaj.Size = new System.Drawing.Size(240, 50);
            this.tileDodaj.Style = MetroFramework.MetroColorStyle.Green;
            this.tileDodaj.TabIndex = 1;
            this.tileDodaj.Text = "DODAJ";
            this.tileDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDodaj.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileDodaj.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDodaj.Click += new System.EventHandler(this.tileDodaj_Click);
            // 
            // tileIzmijeni
            // 
            this.tileIzmijeni.Location = new System.Drawing.Point(260, 3);
            this.tileIzmijeni.Name = "tileIzmijeni";
            this.tileIzmijeni.Size = new System.Drawing.Size(240, 50);
            this.tileIzmijeni.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileIzmijeni.TabIndex = 2;
            this.tileIzmijeni.Text = "IZMIJENI";
            this.tileIzmijeni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzmijeni.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileIzmijeni.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileIzmijeni.Click += new System.EventHandler(this.tileIzmijeni_Click);
            // 
            // tileObrisi
            // 
            this.tileObrisi.Location = new System.Drawing.Point(504, 3);
            this.tileObrisi.Name = "tileObrisi";
            this.tileObrisi.Size = new System.Drawing.Size(240, 50);
            this.tileObrisi.Style = MetroFramework.MetroColorStyle.Red;
            this.tileObrisi.TabIndex = 3;
            this.tileObrisi.Text = "OBRIŠI";
            this.tileObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileObrisi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileObrisi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileObrisi.Click += new System.EventHandler(this.tileObrisi_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tileObrisi);
            this.metroPanel1.Controls.Add(this.tileIzmijeni);
            this.metroPanel1.Controls.Add(this.tileDodaj);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(77, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(746, 66);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnVrati);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(98, 22);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(408, 79);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Visible = false;
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(31, 14);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(192, 54);
            this.btnVrati.TabIndex = 2;
            this.btnVrati.Text = "POTVRDI";
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // lbDetaljno
            // 
            this.lbDetaljno.FormattingEnabled = true;
            this.lbDetaljno.Location = new System.Drawing.Point(566, 193);
            this.lbDetaljno.Name = "lbDetaljno";
            this.lbDetaljno.Size = new System.Drawing.Size(309, 329);
            this.lbDetaljno.TabIndex = 6;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(624, 167);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(251, 20);
            this.txtPretraga.TabIndex = 6;
            this.txtPretraga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDetaljnaPretraga
            // 
            this.btnDetaljnaPretraga.Location = new System.Drawing.Point(734, 129);
            this.btnDetaljnaPretraga.Name = "btnDetaljnaPretraga";
            this.btnDetaljnaPretraga.Size = new System.Drawing.Size(141, 32);
            this.btnDetaljnaPretraga.TabIndex = 10;
            this.btnDetaljnaPretraga.Text = "Detaljna pretraga";
            this.btnDetaljnaPretraga.Click += new System.EventHandler(this.btnDetaljnaPretraga_Click);
            // 
            // btnAzurirajZapise
            // 
            this.btnAzurirajZapise.Location = new System.Drawing.Point(57, 167);
            this.btnAzurirajZapise.Name = "btnAzurirajZapise";
            this.btnAzurirajZapise.Size = new System.Drawing.Size(161, 20);
            this.btnAzurirajZapise.TabIndex = 11;
            this.btnAzurirajZapise.Text = "Ažuriraj zapise";
            this.btnAzurirajZapise.Click += new System.EventHandler(this.btnAzurirajZapise_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(514, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Brza pretraga: ";
            // 
            // FormStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 566);
            this.Controls.Add(this.lbDetaljno);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnAzurirajZapise);
            this.Controls.Add(this.btnDetaljnaPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dgvPrikaz);
            this.MaximizeBox = false;
            this.Name = "FormStandard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormStandard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikaz;
        private MetroFramework.Controls.MetroTile tileDodaj;
        private MetroFramework.Controls.MetroTile tileIzmijeni;
        private MetroFramework.Controls.MetroTile tileObrisi;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        public MetroFramework.Controls.MetroTile btnVrati;
        private System.Windows.Forms.ListBox lbDetaljno;
        private System.Windows.Forms.TextBox txtPretraga;
        private MetroFramework.Controls.MetroButton btnDetaljnaPretraga;
        private MetroFramework.Controls.MetroButton btnAzurirajZapise;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}