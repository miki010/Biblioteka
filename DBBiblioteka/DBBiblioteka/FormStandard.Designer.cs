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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStandard));
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.tileDodaj = new MetroFramework.Controls.MetroTile();
            this.tileIzmijeni = new MetroFramework.Controls.MetroTile();
            this.tileObrisi = new MetroFramework.Controls.MetroTile();
            this.panelCrud = new MetroFramework.Controls.MetroPanel();
            this.panelVrati = new MetroFramework.Controls.MetroPanel();
            this.tileVrati = new MetroFramework.Controls.MetroTile();
            this.lbDetaljno = new System.Windows.Forms.ListBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblBrojRedova = new System.Windows.Forms.Label();
            this.panelPretraga = new MetroFramework.Controls.MetroPanel();
            this.tileAzurirajZapise = new MetroFramework.Controls.MetroTile();
            this.tileDetaljnaPretraga = new MetroFramework.Controls.MetroTile();
            this.tileSelectFirst = new MetroFramework.Controls.MetroTile();
            this.tileSelectNext = new MetroFramework.Controls.MetroTile();
            this.tileSelectPrevious = new MetroFramework.Controls.MetroTile();
            this.tileSelectLast = new MetroFramework.Controls.MetroTile();
            this.lblDetaljno = new MetroFramework.Controls.MetroLabel();
            this.panelDetalno = new MetroFramework.Controls.MetroPanel();
            this.lblRedIndex = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.panelCrud.SuspendLayout();
            this.panelVrati.SuspendLayout();
            this.panelPretraga.SuspendLayout();
            this.panelDetalno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.AllowUserToAddRows = false;
            this.dgvPrikaz.AllowUserToDeleteRows = false;
            this.dgvPrikaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikaz.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Location = new System.Drawing.Point(23, 151);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.ReadOnly = true;
            this.dgvPrikaz.Size = new System.Drawing.Size(1115, 524);
            this.dgvPrikaz.TabIndex = 0;
            this.dgvPrikaz.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPrikaz_RowsAdded);
            this.dgvPrikaz.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPrikaz_RowsRemoved);
            this.dgvPrikaz.SelectionChanged += new System.EventHandler(this.dgvPrikaz_SelectionChanged);
            this.dgvPrikaz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPrikaz_MouseClick);
            // 
            // tileDodaj
            // 
            this.tileDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDodaj.Location = new System.Drawing.Point(3, 3);
            this.tileDodaj.Name = "tileDodaj";
            this.tileDodaj.Size = new System.Drawing.Size(70, 70);
            this.tileDodaj.Style = MetroFramework.MetroColorStyle.Green;
            this.tileDodaj.TabIndex = 1;
            this.tileDodaj.Text = "DODAJ";
            this.tileDodaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDodaj.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDodaj.TileImage")));
            this.tileDodaj.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDodaj.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileDodaj.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDodaj.UseTileImage = true;
            this.tileDodaj.Click += new System.EventHandler(this.tileDodaj_Click);
            // 
            // tileIzmijeni
            // 
            this.tileIzmijeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileIzmijeni.Location = new System.Drawing.Point(79, 3);
            this.tileIzmijeni.Name = "tileIzmijeni";
            this.tileIzmijeni.Size = new System.Drawing.Size(70, 70);
            this.tileIzmijeni.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileIzmijeni.TabIndex = 2;
            this.tileIzmijeni.Text = "IZMIJENI";
            this.tileIzmijeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileIzmijeni.TileImage = ((System.Drawing.Image)(resources.GetObject("tileIzmijeni.TileImage")));
            this.tileIzmijeni.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzmijeni.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileIzmijeni.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileIzmijeni.UseTileImage = true;
            this.tileIzmijeni.Click += new System.EventHandler(this.tileIzmijeni_Click);
            // 
            // tileObrisi
            // 
            this.tileObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileObrisi.Location = new System.Drawing.Point(155, 3);
            this.tileObrisi.Name = "tileObrisi";
            this.tileObrisi.Size = new System.Drawing.Size(70, 70);
            this.tileObrisi.Style = MetroFramework.MetroColorStyle.Red;
            this.tileObrisi.TabIndex = 3;
            this.tileObrisi.Text = "OBRIŠI";
            this.tileObrisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileObrisi.TileImage = ((System.Drawing.Image)(resources.GetObject("tileObrisi.TileImage")));
            this.tileObrisi.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileObrisi.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileObrisi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileObrisi.UseTileImage = true;
            this.tileObrisi.Click += new System.EventHandler(this.tileObrisi_Click);
            // 
            // panelCrud
            // 
            this.panelCrud.Controls.Add(this.tileObrisi);
            this.panelCrud.Controls.Add(this.tileIzmijeni);
            this.panelCrud.Controls.Add(this.tileDodaj);
            this.panelCrud.HorizontalScrollbarBarColor = true;
            this.panelCrud.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCrud.HorizontalScrollbarSize = 10;
            this.panelCrud.Location = new System.Drawing.Point(23, 22);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(232, 81);
            this.panelCrud.TabIndex = 4;
            this.panelCrud.VerticalScrollbarBarColor = true;
            this.panelCrud.VerticalScrollbarHighlightOnWheel = false;
            this.panelCrud.VerticalScrollbarSize = 10;
            // 
            // panelVrati
            // 
            this.panelVrati.Controls.Add(this.tileVrati);
            this.panelVrati.HorizontalScrollbarBarColor = true;
            this.panelVrati.HorizontalScrollbarHighlightOnWheel = false;
            this.panelVrati.HorizontalScrollbarSize = 10;
            this.panelVrati.Location = new System.Drawing.Point(261, 22);
            this.panelVrati.Name = "panelVrati";
            this.panelVrati.Size = new System.Drawing.Size(79, 81);
            this.panelVrati.TabIndex = 5;
            this.panelVrati.VerticalScrollbarBarColor = true;
            this.panelVrati.VerticalScrollbarHighlightOnWheel = false;
            this.panelVrati.VerticalScrollbarSize = 10;
            // 
            // tileVrati
            // 
            this.tileVrati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileVrati.Location = new System.Drawing.Point(3, 3);
            this.tileVrati.Name = "tileVrati";
            this.tileVrati.Size = new System.Drawing.Size(70, 70);
            this.tileVrati.TabIndex = 2;
            this.tileVrati.Text = "POTVRDI";
            this.tileVrati.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileVrati.TileImage = ((System.Drawing.Image)(resources.GetObject("tileVrati.TileImage")));
            this.tileVrati.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVrati.UseTileImage = true;
            this.tileVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // lbDetaljno
            // 
            this.lbDetaljno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDetaljno.FormattingEnabled = true;
            this.lbDetaljno.Location = new System.Drawing.Point(7, 32);
            this.lbDetaljno.Name = "lbDetaljno";
            this.lbDetaljno.Size = new System.Drawing.Size(241, 481);
            this.lbDetaljno.TabIndex = 6;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(340, 39);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(162, 26);
            this.txtPretraga.TabIndex = 6;
            this.txtPretraga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(340, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Brza pretraga: ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrojRedova
            // 
            this.lblBrojRedova.AutoSize = true;
            this.lblBrojRedova.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojRedova.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBrojRedova.Location = new System.Drawing.Point(37, 678);
            this.lblBrojRedova.Name = "lblBrojRedova";
            this.lblBrojRedova.Size = new System.Drawing.Size(39, 15);
            this.lblBrojRedova.TabIndex = 13;
            this.lblBrojRedova.Text = "label1";
            // 
            // panelPretraga
            // 
            this.panelPretraga.BackColor = System.Drawing.Color.AliceBlue;
            this.panelPretraga.CausesValidation = false;
            this.panelPretraga.Controls.Add(this.tileAzurirajZapise);
            this.panelPretraga.Controls.Add(this.metroLabel1);
            this.panelPretraga.Controls.Add(this.tileDetaljnaPretraga);
            this.panelPretraga.Controls.Add(this.tileSelectFirst);
            this.panelPretraga.Controls.Add(this.tileSelectNext);
            this.panelPretraga.Controls.Add(this.tileSelectPrevious);
            this.panelPretraga.Controls.Add(this.txtPretraga);
            this.panelPretraga.Controls.Add(this.tileSelectLast);
            this.panelPretraga.CustomBackground = true;
            this.panelPretraga.HorizontalScrollbarBarColor = true;
            this.panelPretraga.HorizontalScrollbarHighlightOnWheel = false;
            this.panelPretraga.HorizontalScrollbarSize = 10;
            this.panelPretraga.Location = new System.Drawing.Point(346, 22);
            this.panelPretraga.Name = "panelPretraga";
            this.panelPretraga.Size = new System.Drawing.Size(694, 81);
            this.panelPretraga.TabIndex = 14;
            this.panelPretraga.VerticalScrollbarBarColor = true;
            this.panelPretraga.VerticalScrollbarHighlightOnWheel = false;
            this.panelPretraga.VerticalScrollbarSize = 10;
            // 
            // tileAzurirajZapise
            // 
            this.tileAzurirajZapise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileAzurirajZapise.Location = new System.Drawing.Point(595, 8);
            this.tileAzurirajZapise.Name = "tileAzurirajZapise";
            this.tileAzurirajZapise.Size = new System.Drawing.Size(70, 70);
            this.tileAzurirajZapise.TabIndex = 9;
            this.tileAzurirajZapise.Text = "Azuriraj\r\nzapise";
            this.tileAzurirajZapise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileAzurirajZapise.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAzurirajZapise.TileImage")));
            this.tileAzurirajZapise.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileAzurirajZapise.UseTileImage = true;
            this.tileAzurirajZapise.Click += new System.EventHandler(this.tileAzurirajZapise_Click);
            // 
            // tileDetaljnaPretraga
            // 
            this.tileDetaljnaPretraga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDetaljnaPretraga.Location = new System.Drawing.Point(520, 7);
            this.tileDetaljnaPretraga.Name = "tileDetaljnaPretraga";
            this.tileDetaljnaPretraga.Size = new System.Drawing.Size(70, 70);
            this.tileDetaljnaPretraga.TabIndex = 8;
            this.tileDetaljnaPretraga.Text = "Detaljna\r\npretraga";
            this.tileDetaljnaPretraga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDetaljnaPretraga.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDetaljnaPretraga.TileImage")));
            this.tileDetaljnaPretraga.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileDetaljnaPretraga.UseTileImage = true;
            this.tileDetaljnaPretraga.Click += new System.EventHandler(this.tileDetaljnaPretraga_Click);
            // 
            // tileSelectFirst
            // 
            this.tileSelectFirst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tileSelectFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSelectFirst.CustomBackground = true;
            this.tileSelectFirst.Location = new System.Drawing.Point(231, 3);
            this.tileSelectFirst.Name = "tileSelectFirst";
            this.tileSelectFirst.Size = new System.Drawing.Size(70, 70);
            this.tileSelectFirst.Style = MetroFramework.MetroColorStyle.White;
            this.tileSelectFirst.TabIndex = 6;
            this.tileSelectFirst.TileImage = ((System.Drawing.Image)(resources.GetObject("tileSelectFirst.TileImage")));
            this.tileSelectFirst.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSelectFirst.UseTileImage = true;
            // 
            // tileSelectNext
            // 
            this.tileSelectNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tileSelectNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSelectNext.CustomBackground = true;
            this.tileSelectNext.Location = new System.Drawing.Point(79, 3);
            this.tileSelectNext.Name = "tileSelectNext";
            this.tileSelectNext.Size = new System.Drawing.Size(70, 70);
            this.tileSelectNext.Style = MetroFramework.MetroColorStyle.White;
            this.tileSelectNext.TabIndex = 3;
            this.tileSelectNext.TileImage = ((System.Drawing.Image)(resources.GetObject("tileSelectNext.TileImage")));
            this.tileSelectNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSelectNext.UseTileImage = true;
            // 
            // tileSelectPrevious
            // 
            this.tileSelectPrevious.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tileSelectPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSelectPrevious.CustomBackground = true;
            this.tileSelectPrevious.Location = new System.Drawing.Point(155, 3);
            this.tileSelectPrevious.Name = "tileSelectPrevious";
            this.tileSelectPrevious.Size = new System.Drawing.Size(70, 70);
            this.tileSelectPrevious.Style = MetroFramework.MetroColorStyle.White;
            this.tileSelectPrevious.TabIndex = 5;
            this.tileSelectPrevious.TileImage = ((System.Drawing.Image)(resources.GetObject("tileSelectPrevious.TileImage")));
            this.tileSelectPrevious.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSelectPrevious.UseTileImage = true;
            // 
            // tileSelectLast
            // 
            this.tileSelectLast.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tileSelectLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSelectLast.CustomBackground = true;
            this.tileSelectLast.Location = new System.Drawing.Point(3, 3);
            this.tileSelectLast.Name = "tileSelectLast";
            this.tileSelectLast.Size = new System.Drawing.Size(70, 70);
            this.tileSelectLast.Style = MetroFramework.MetroColorStyle.White;
            this.tileSelectLast.TabIndex = 4;
            this.tileSelectLast.TileImage = ((System.Drawing.Image)(resources.GetObject("tileSelectLast.TileImage")));
            this.tileSelectLast.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSelectLast.UseTileImage = true;
            // 
            // lblDetaljno
            // 
            this.lblDetaljno.AutoSize = true;
            this.lblDetaljno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDetaljno.Location = new System.Drawing.Point(3, 1);
            this.lblDetaljno.Name = "lblDetaljno";
            this.lblDetaljno.Size = new System.Drawing.Size(137, 25);
            this.lblDetaljno.TabIndex = 15;
            this.lblDetaljno.Text = "Detaljan pregled";
            this.lblDetaljno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDetalno
            // 
            this.panelDetalno.BackColor = System.Drawing.Color.White;
            this.panelDetalno.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelDetalno.CausesValidation = false;
            this.panelDetalno.Controls.Add(this.metroPanel1);
            this.panelDetalno.Controls.Add(this.lblDetaljno);
            this.panelDetalno.Controls.Add(this.lbDetaljno);
            this.panelDetalno.CustomBackground = true;
            this.panelDetalno.HorizontalScrollbarBarColor = true;
            this.panelDetalno.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDetalno.HorizontalScrollbarSize = 10;
            this.panelDetalno.Location = new System.Drawing.Point(1141, 151);
            this.panelDetalno.Name = "panelDetalno";
            this.panelDetalno.Size = new System.Drawing.Size(259, 524);
            this.panelDetalno.TabIndex = 16;
            this.panelDetalno.VerticalScrollbarBarColor = true;
            this.panelDetalno.VerticalScrollbarHighlightOnWheel = false;
            this.panelDetalno.VerticalScrollbarSize = 10;
            // 
            // lblRedIndex
            // 
            this.lblRedIndex.AutoSize = true;
            this.lblRedIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedIndex.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRedIndex.Location = new System.Drawing.Point(99, 678);
            this.lblRedIndex.Name = "lblRedIndex";
            this.lblRedIndex.Size = new System.Drawing.Size(39, 15);
            this.lblRedIndex.TabIndex = 14;
            this.lblRedIndex.Text = "label1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 27);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 1);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FormStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 713);
            this.Controls.Add(this.panelDetalno);
            this.Controls.Add(this.panelPretraga);
            this.Controls.Add(this.lblRedIndex);
            this.Controls.Add(this.lblBrojRedova);
            this.Controls.Add(this.panelVrati);
            this.Controls.Add(this.panelCrud);
            this.Controls.Add(this.dgvPrikaz);
            this.Name = "FormStandard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormStandard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.panelCrud.ResumeLayout(false);
            this.panelVrati.ResumeLayout(false);
            this.panelPretraga.ResumeLayout(false);
            this.panelPretraga.PerformLayout();
            this.panelDetalno.ResumeLayout(false);
            this.panelDetalno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikaz;
        private MetroFramework.Controls.MetroTile tileDodaj;
        private MetroFramework.Controls.MetroTile tileIzmijeni;
        private MetroFramework.Controls.MetroTile tileObrisi;
        private MetroFramework.Controls.MetroPanel panelCrud;
        private MetroFramework.Controls.MetroPanel panelVrati;
        public MetroFramework.Controls.MetroTile tileVrati;
        private System.Windows.Forms.ListBox lbDetaljno;
        private System.Windows.Forms.TextBox txtPretraga;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lblBrojRedova;
        private MetroFramework.Controls.MetroPanel panelPretraga;
        public MetroFramework.Controls.MetroTile tileDetaljnaPretraga;
        public MetroFramework.Controls.MetroTile tileSelectFirst;
        public MetroFramework.Controls.MetroTile tileSelectPrevious;
        public MetroFramework.Controls.MetroTile tileSelectLast;
        public MetroFramework.Controls.MetroTile tileSelectNext;
        public MetroFramework.Controls.MetroTile tileAzurirajZapise;
        private MetroFramework.Controls.MetroLabel lblDetaljno;
        private MetroFramework.Controls.MetroPanel panelDetalno;
        private System.Windows.Forms.Label lblRedIndex;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}