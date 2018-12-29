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
            this.panelCRUD = new MetroFramework.Controls.MetroPanel();
            this.panelPotvrdi = new MetroFramework.Controls.MetroPanel();
            this.btnVrati = new MetroFramework.Controls.MetroTile();
            this.panelSearch = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.btnSelectFirst = new MetroFramework.Controls.MetroTile();
            this.btnSelectPrevious = new MetroFramework.Controls.MetroTile();
            this.btnSelectLast = new MetroFramework.Controls.MetroTile();
            this.btnSelectNext = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.panelCRUD.SuspendLayout();
            this.panelPotvrdi.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.AllowUserToAddRows = false;
            this.dgvPrikaz.AllowUserToDeleteRows = false;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Location = new System.Drawing.Point(10, 108);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.ReadOnly = true;
            this.dgvPrikaz.Size = new System.Drawing.Size(920, 348);
            this.dgvPrikaz.TabIndex = 0;
            // 
            // tileDodaj
            // 
            this.tileDodaj.Location = new System.Drawing.Point(3, 3);
            this.tileDodaj.Name = "tileDodaj";
            this.tileDodaj.Size = new System.Drawing.Size(80, 41);
            this.tileDodaj.Style = MetroFramework.MetroColorStyle.Green;
            this.tileDodaj.TabIndex = 1;
            this.tileDodaj.Text = "DODAJ";
            this.tileDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDodaj.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDodaj.Click += new System.EventHandler(this.tileDodaj_Click);
            // 
            // tileIzmijeni
            // 
            this.tileIzmijeni.Location = new System.Drawing.Point(89, 3);
            this.tileIzmijeni.Name = "tileIzmijeni";
            this.tileIzmijeni.Size = new System.Drawing.Size(85, 41);
            this.tileIzmijeni.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileIzmijeni.TabIndex = 2;
            this.tileIzmijeni.Text = "IZMIJENI";
            this.tileIzmijeni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzmijeni.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileIzmijeni.Click += new System.EventHandler(this.tileIzmijeni_Click);
            // 
            // tileObrisi
            // 
            this.tileObrisi.Location = new System.Drawing.Point(180, 3);
            this.tileObrisi.Name = "tileObrisi";
            this.tileObrisi.Size = new System.Drawing.Size(82, 41);
            this.tileObrisi.Style = MetroFramework.MetroColorStyle.Red;
            this.tileObrisi.TabIndex = 3;
            this.tileObrisi.Text = "OBRIŠI";
            this.tileObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileObrisi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileObrisi.Click += new System.EventHandler(this.tileObrisi_Click);
            // 
            // panelCRUD
            // 
            this.panelCRUD.Controls.Add(this.tileObrisi);
            this.panelCRUD.Controls.Add(this.tileIzmijeni);
            this.panelCRUD.Controls.Add(this.tileDodaj);
            this.panelCRUD.HorizontalScrollbarBarColor = true;
            this.panelCRUD.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCRUD.HorizontalScrollbarSize = 10;
            this.panelCRUD.Location = new System.Drawing.Point(7, 29);
            this.panelCRUD.Name = "panelCRUD";
            this.panelCRUD.Size = new System.Drawing.Size(268, 53);
            this.panelCRUD.TabIndex = 4;
            this.panelCRUD.VerticalScrollbarBarColor = true;
            this.panelCRUD.VerticalScrollbarHighlightOnWheel = false;
            this.panelCRUD.VerticalScrollbarSize = 10;
            // 
            // panelPotvrdi
            // 
            this.panelPotvrdi.Controls.Add(this.btnVrati);
            this.panelPotvrdi.HorizontalScrollbarBarColor = true;
            this.panelPotvrdi.HorizontalScrollbarHighlightOnWheel = false;
            this.panelPotvrdi.HorizontalScrollbarSize = 10;
            this.panelPotvrdi.Location = new System.Drawing.Point(281, 29);
            this.panelPotvrdi.Name = "panelPotvrdi";
            this.panelPotvrdi.Size = new System.Drawing.Size(95, 53);
            this.panelPotvrdi.TabIndex = 5;
            this.panelPotvrdi.VerticalScrollbarBarColor = true;
            this.panelPotvrdi.VerticalScrollbarHighlightOnWheel = false;
            this.panelPotvrdi.VerticalScrollbarSize = 10;
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(3, 6);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(87, 41);
            this.btnVrati.TabIndex = 2;
            this.btnVrati.Text = "POTVRDI";
            this.btnVrati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVrati.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelSearch.CausesValidation = false;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnSelectFirst);
            this.panelSearch.Controls.Add(this.btnSelectPrevious);
            this.panelSearch.Controls.Add(this.btnSelectLast);
            this.panelSearch.Controls.Add(this.btnSelectNext);
            this.panelSearch.CustomBackground = true;
            this.panelSearch.HorizontalScrollbarBarColor = true;
            this.panelSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSearch.HorizontalScrollbarSize = 10;
            this.panelSearch.Location = new System.Drawing.Point(391, 29);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(547, 53);
            this.panelSearch.TabIndex = 7;
            this.panelSearch.VerticalScrollbarBarColor = true;
            this.panelSearch.VerticalScrollbarHighlightOnWheel = false;
            this.panelSearch.VerticalScrollbarSize = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(286, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 26);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(494, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.TileImage = global::DBBiblioteka.Properties.Resources.search;
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.UseTileImage = true;
            // 
            // btnSelectFirst
            // 
            this.btnSelectFirst.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSelectFirst.Location = new System.Drawing.Point(196, 9);
            this.btnSelectFirst.Name = "btnSelectFirst";
            this.btnSelectFirst.Size = new System.Drawing.Size(66, 35);
            this.btnSelectFirst.Style = MetroFramework.MetroColorStyle.White;
            this.btnSelectFirst.TabIndex = 6;
            this.btnSelectFirst.TileImage = global::DBBiblioteka.Properties.Resources.resultset_first;
            this.btnSelectFirst.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectFirst.UseTileImage = true;
            // 
            // btnSelectPrevious
            // 
            this.btnSelectPrevious.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSelectPrevious.Location = new System.Drawing.Point(133, 9);
            this.btnSelectPrevious.Name = "btnSelectPrevious";
            this.btnSelectPrevious.Size = new System.Drawing.Size(57, 35);
            this.btnSelectPrevious.Style = MetroFramework.MetroColorStyle.White;
            this.btnSelectPrevious.TabIndex = 5;
            this.btnSelectPrevious.TileImage = global::DBBiblioteka.Properties.Resources.resultset_previous;
            this.btnSelectPrevious.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectPrevious.UseTileImage = true;
            // 
            // btnSelectLast
            // 
            this.btnSelectLast.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSelectLast.Location = new System.Drawing.Point(72, 9);
            this.btnSelectLast.Name = "btnSelectLast";
            this.btnSelectLast.Size = new System.Drawing.Size(55, 35);
            this.btnSelectLast.Style = MetroFramework.MetroColorStyle.White;
            this.btnSelectLast.TabIndex = 4;
            this.btnSelectLast.TileImage = global::DBBiblioteka.Properties.Resources.resultset_last;
            this.btnSelectLast.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectLast.UseTileImage = true;
            // 
            // btnSelectNext
            // 
            this.btnSelectNext.BackColor = System.Drawing.Color.Cyan;
            this.btnSelectNext.Location = new System.Drawing.Point(12, 9);
            this.btnSelectNext.Name = "btnSelectNext";
            this.btnSelectNext.Size = new System.Drawing.Size(54, 35);
            this.btnSelectNext.Style = MetroFramework.MetroColorStyle.White;
            this.btnSelectNext.TabIndex = 3;
            this.btnSelectNext.TileImage = global::DBBiblioteka.Properties.Resources.resultset_next;
            this.btnSelectNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectNext.UseTileImage = true;
            // 
            // FormStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 500);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelPotvrdi);
            this.Controls.Add(this.panelCRUD);
            this.Controls.Add(this.dgvPrikaz);
            this.MaximizeBox = false;
            this.Name = "FormStandard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormStandard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.panelCRUD.ResumeLayout(false);
            this.panelPotvrdi.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikaz;
        private MetroFramework.Controls.MetroTile tileDodaj;
        private MetroFramework.Controls.MetroTile tileIzmijeni;
        private MetroFramework.Controls.MetroTile tileObrisi;
        private MetroFramework.Controls.MetroPanel panelCRUD;
        private MetroFramework.Controls.MetroPanel panelPotvrdi;
        public MetroFramework.Controls.MetroTile btnVrati;
        private MetroFramework.Controls.MetroPanel panelSearch;
        public MetroFramework.Controls.MetroTile btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        public MetroFramework.Controls.MetroTile btnSelectFirst;
        public MetroFramework.Controls.MetroTile btnSelectPrevious;
        public MetroFramework.Controls.MetroTile btnSelectLast;
        public MetroFramework.Controls.MetroTile btnSelectNext;
    }
}