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
            this.panelCrud = new MetroFramework.Controls.MetroPanel();
            this.tileObrisi = new MetroFramework.Controls.MetroTile();
            this.tileIzmijeni = new MetroFramework.Controls.MetroTile();
            this.tileDodaj = new MetroFramework.Controls.MetroTile();
            this.panelVrati = new MetroFramework.Controls.MetroPanel();
            this.tileVrati = new MetroFramework.Controls.MetroTile();
            this.lbDetaljno = new System.Windows.Forms.ListBox();
            this.lblBrojRedova = new System.Windows.Forms.Label();
            this.lblDetaljno = new MetroFramework.Controls.MetroLabel();
            this.panelDetalno = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroToolTip2 = new MetroFramework.Components.MetroToolTip();
            this.metroToolTip3 = new MetroFramework.Components.MetroToolTip();
            this.metroToolTip4 = new MetroFramework.Components.MetroToolTip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPretraga = new MetroFramework.Controls.MetroPanel();
            this.tileDetaljnaPretraga = new MetroFramework.Controls.MetroTile();
            this.tileAzurirajZapise = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tileSelectFirst = new MetroFramework.Controls.MetroTile();
            this.tileSelectNext = new MetroFramework.Controls.MetroTile();
            this.tileSelectLast = new MetroFramework.Controls.MetroTile();
            this.tileSelectPrevious = new MetroFramework.Controls.MetroTile();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblRedIndex = new System.Windows.Forms.Label();
            this.panelCrud.SuspendLayout();
            this.panelVrati.SuspendLayout();
            this.panelDetalno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrud
            // 
            this.panelCrud.Controls.Add(this.tileObrisi);
            this.panelCrud.Controls.Add(this.tileIzmijeni);
            this.panelCrud.Controls.Add(this.tileDodaj);
            this.panelCrud.HorizontalScrollbarBarColor = true;
            this.panelCrud.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCrud.HorizontalScrollbarSize = 10;
            this.panelCrud.Location = new System.Drawing.Point(9, 63);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(270, 73);
            this.panelCrud.TabIndex = 4;
            this.panelCrud.VerticalScrollbarBarColor = true;
            this.panelCrud.VerticalScrollbarHighlightOnWheel = false;
            this.panelCrud.VerticalScrollbarSize = 10;
            // 
            // tileObrisi
            // 
            this.tileObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileObrisi.Location = new System.Drawing.Point(181, 1);
            this.tileObrisi.Name = "tileObrisi";
            this.tileObrisi.Size = new System.Drawing.Size(70, 70);
            this.tileObrisi.Style = MetroFramework.MetroColorStyle.Red;
            this.tileObrisi.TabIndex = 3;
            this.tileObrisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileObrisi.TileImage = ((System.Drawing.Image)(resources.GetObject("tileObrisi.TileImage")));
            this.tileObrisi.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileObrisi.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileObrisi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileObrisi.UseTileImage = true;
            this.tileObrisi.Click += new System.EventHandler(this.tileObrisi_Click);
            // 
            // tileIzmijeni
            // 
            this.tileIzmijeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileIzmijeni.Location = new System.Drawing.Point(93, 1);
            this.tileIzmijeni.Name = "tileIzmijeni";
            this.tileIzmijeni.Size = new System.Drawing.Size(70, 70);
            this.tileIzmijeni.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileIzmijeni.TabIndex = 2;
            this.tileIzmijeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileIzmijeni.TileImage = ((System.Drawing.Image)(resources.GetObject("tileIzmijeni.TileImage")));
            this.tileIzmijeni.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzmijeni.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileIzmijeni.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileIzmijeni.UseTileImage = true;
            this.tileIzmijeni.Click += new System.EventHandler(this.tileIzmijeni_Click);
            // 
            // tileDodaj
            // 
            this.tileDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDodaj.Location = new System.Drawing.Point(5, 1);
            this.tileDodaj.Name = "tileDodaj";
            this.tileDodaj.Size = new System.Drawing.Size(70, 70);
            this.tileDodaj.Style = MetroFramework.MetroColorStyle.Green;
            this.tileDodaj.TabIndex = 1;
            this.tileDodaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDodaj.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDodaj.TileImage")));
            this.tileDodaj.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDodaj.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileDodaj.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDodaj.UseTileImage = true;
            this.tileDodaj.Click += new System.EventHandler(this.tileDodaj_Click);
            // 
            // panelVrati
            // 
            this.panelVrati.Controls.Add(this.tileVrati);
            this.panelVrati.HorizontalScrollbarBarColor = true;
            this.panelVrati.HorizontalScrollbarHighlightOnWheel = false;
            this.panelVrati.HorizontalScrollbarSize = 10;
            this.panelVrati.Location = new System.Drawing.Point(319, 63);
            this.panelVrati.Name = "panelVrati";
            this.panelVrati.Size = new System.Drawing.Size(193, 73);
            this.panelVrati.TabIndex = 5;
            this.panelVrati.VerticalScrollbarBarColor = true;
            this.panelVrati.VerticalScrollbarHighlightOnWheel = false;
            this.panelVrati.VerticalScrollbarSize = 10;
            // 
            // tileVrati
            // 
            this.tileVrati.BackColor = System.Drawing.Color.SteelBlue;
            this.tileVrati.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileVrati.CustomBackground = true;
            this.tileVrati.CustomForeColor = true;
            this.tileVrati.ForeColor = System.Drawing.Color.White;
            this.tileVrati.Location = new System.Drawing.Point(3, 2);
            this.tileVrati.Name = "tileVrati";
            this.tileVrati.Size = new System.Drawing.Size(182, 70);
            this.tileVrati.TabIndex = 2;
            this.tileVrati.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileVrati.TileImage = ((System.Drawing.Image)(resources.GetObject("tileVrati.TileImage")));
            this.tileVrati.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVrati.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileVrati.UseTileImage = true;
            this.tileVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // lbDetaljno
            // 
            this.lbDetaljno.BackColor = System.Drawing.Color.White;
            this.lbDetaljno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDetaljno.ForeColor = System.Drawing.Color.Black;
            this.lbDetaljno.FormattingEnabled = true;
            this.lbDetaljno.Location = new System.Drawing.Point(5, 58);
            this.lbDetaljno.Name = "lbDetaljno";
            this.lbDetaljno.Size = new System.Drawing.Size(228, 442);
            this.lbDetaljno.TabIndex = 6;
            // 
            // lblBrojRedova
            // 
            this.lblBrojRedova.AutoSize = true;
            this.lblBrojRedova.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojRedova.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBrojRedova.Location = new System.Drawing.Point(1145, 173);
            this.lblBrojRedova.Name = "lblBrojRedova";
            this.lblBrojRedova.Size = new System.Drawing.Size(39, 15);
            this.lblBrojRedova.TabIndex = 13;
            this.lblBrojRedova.Text = "label1";
            // 
            // lblDetaljno
            // 
            this.lblDetaljno.AutoSize = true;
            this.lblDetaljno.BackColor = System.Drawing.Color.Transparent;
            this.lblDetaljno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDetaljno.Location = new System.Drawing.Point(3, 12);
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
            this.panelDetalno.Controls.Add(this.lbDetaljno);
            this.panelDetalno.Controls.Add(this.lblDetaljno);
            this.panelDetalno.CustomBackground = true;
            this.panelDetalno.ForeColor = System.Drawing.Color.Black;
            this.panelDetalno.HorizontalScrollbarBarColor = true;
            this.panelDetalno.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDetalno.HorizontalScrollbarSize = 10;
            this.panelDetalno.Location = new System.Drawing.Point(903, 155);
            this.panelDetalno.Name = "panelDetalno";
            this.panelDetalno.Size = new System.Drawing.Size(236, 537);
            this.panelDetalno.TabIndex = 16;
            this.panelDetalno.VerticalScrollbarBarColor = true;
            this.panelDetalno.VerticalScrollbarHighlightOnWheel = false;
            this.panelDetalno.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 48);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 1);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBBiblioteka.Properties.Resources.logoblagajnik;
            this.pictureBox1.Location = new System.Drawing.Point(956, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 110);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panelPretraga
            // 
            this.panelPretraga.BackColor = System.Drawing.Color.White;
            this.panelPretraga.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelPretraga.CausesValidation = false;
            this.panelPretraga.Controls.Add(this.tileDetaljnaPretraga);
            this.panelPretraga.Controls.Add(this.tileAzurirajZapise);
            this.panelPretraga.Controls.Add(this.metroLabel1);
            this.panelPretraga.Controls.Add(this.tileSelectFirst);
            this.panelPretraga.Controls.Add(this.tileSelectNext);
            this.panelPretraga.Controls.Add(this.tileSelectLast);
            this.panelPretraga.Controls.Add(this.tileSelectPrevious);
            this.panelPretraga.Controls.Add(this.txtPretraga);
            this.panelPretraga.CustomBackground = true;
            this.panelPretraga.HorizontalScrollbarBarColor = true;
            this.panelPretraga.HorizontalScrollbarHighlightOnWheel = false;
            this.panelPretraga.HorizontalScrollbarSize = 10;
            this.panelPretraga.Location = new System.Drawing.Point(6, 155);
            this.panelPretraga.Name = "panelPretraga";
            this.panelPretraga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelPretraga.Size = new System.Drawing.Size(893, 46);
            this.panelPretraga.TabIndex = 14;
            this.panelPretraga.VerticalScrollbarBarColor = true;
            this.panelPretraga.VerticalScrollbarHighlightOnWheel = false;
            this.panelPretraga.VerticalScrollbarSize = 10;
            // 
            // tileDetaljnaPretraga
            // 
            this.tileDetaljnaPretraga.BackColor = System.Drawing.Color.DodgerBlue;
            this.tileDetaljnaPretraga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDetaljnaPretraga.CustomBackground = true;
            this.tileDetaljnaPretraga.CustomForeColor = true;
            this.tileDetaljnaPretraga.ForeColor = System.Drawing.Color.White;
            this.tileDetaljnaPretraga.Location = new System.Drawing.Point(799, 4);
            this.tileDetaljnaPretraga.Name = "tileDetaljnaPretraga";
            this.tileDetaljnaPretraga.Size = new System.Drawing.Size(40, 40);
            this.tileDetaljnaPretraga.TabIndex = 8;
            this.tileDetaljnaPretraga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDetaljnaPretraga.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDetaljnaPretraga.TileImage")));
            this.tileDetaljnaPretraga.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDetaljnaPretraga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileDetaljnaPretraga.UseTileImage = true;
            this.tileDetaljnaPretraga.Click += new System.EventHandler(this.tileDetaljnaPretraga_Click);
            // 
            // tileAzurirajZapise
            // 
            this.tileAzurirajZapise.BackColor = System.Drawing.Color.DodgerBlue;
            this.tileAzurirajZapise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileAzurirajZapise.CustomBackground = true;
            this.tileAzurirajZapise.CustomForeColor = true;
            this.tileAzurirajZapise.ForeColor = System.Drawing.Color.White;
            this.tileAzurirajZapise.Location = new System.Drawing.Point(848, 4);
            this.tileAzurirajZapise.Name = "tileAzurirajZapise";
            this.tileAzurirajZapise.Size = new System.Drawing.Size(40, 40);
            this.tileAzurirajZapise.TabIndex = 9;
            this.tileAzurirajZapise.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileAzurirajZapise.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAzurirajZapise.TileImage")));
            this.tileAzurirajZapise.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAzurirajZapise.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileAzurirajZapise.UseTileImage = true;
            this.tileAzurirajZapise.Click += new System.EventHandler(this.tileAzurirajZapise_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(502, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Brza pretraga: ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // tileSelectFirst
            // 
            this.tileSelectFirst.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tileSelectFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSelectFirst.CustomBackground = true;
            this.tileSelectFirst.Location = new System.Drawing.Point(143, 3);
            this.tileSelectFirst.Name = "tileSelectFirst";
            this.tileSelectFirst.Size = new System.Drawing.Size(40, 40);
            this.tileSelectFirst.Style = MetroFramework.MetroColorStyle.White;
            this.tileSelectFirst.TabIndex = 6;
            this.tileSelectFirst.TileImage = global::DBBiblioteka.Properties.Resources.doubleup;
            this.tileSelectFirst.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSelectFirst.UseTileImage = true;
            this.tileSelectFirst.Click += new System.EventHandler(this.tileSelectFirst_Click);
            this.tileSelectFirst.MouseHover += new System.EventHandler(this.tileSelectFirst_MouseHover);
            // 
            // tileSelectNext
            // 
            this.tileSelectNext.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tileSelectNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSelectNext.CustomBackground = true;
            this.tileSelectNext.Location = new System.Drawing.Point(3, 3);
            this.tileSelectNext.Name = "tileSelectNext";
            this.tileSelectNext.Size = new System.Drawing.Size(40, 40);
            this.tileSelectNext.Style = MetroFramework.MetroColorStyle.White;
            this.tileSelectNext.TabIndex = 3;
            this.tileSelectNext.TileImage = global::DBBiblioteka.Properties.Resources.down;
            this.tileSelectNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSelectNext.UseTileImage = true;
            this.tileSelectNext.Click += new System.EventHandler(this.tileSelectNext_Click);
            this.tileSelectNext.MouseHover += new System.EventHandler(this.tileSelectNext_MouseHover);
            // 
            // tileSelectLast
            // 
            this.tileSelectLast.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tileSelectLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSelectLast.CustomBackground = true;
            this.tileSelectLast.Location = new System.Drawing.Point(51, 3);
            this.tileSelectLast.Name = "tileSelectLast";
            this.tileSelectLast.Size = new System.Drawing.Size(40, 40);
            this.tileSelectLast.Style = MetroFramework.MetroColorStyle.White;
            this.tileSelectLast.TabIndex = 4;
            this.tileSelectLast.TileImage = global::DBBiblioteka.Properties.Resources.doubledown;
            this.tileSelectLast.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSelectLast.UseTileImage = true;
            this.tileSelectLast.Click += new System.EventHandler(this.tileSelectLast_Click);
            this.tileSelectLast.MouseHover += new System.EventHandler(this.tileSelectLast_MouseHover);
            // 
            // tileSelectPrevious
            // 
            this.tileSelectPrevious.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tileSelectPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileSelectPrevious.CustomBackground = true;
            this.tileSelectPrevious.Location = new System.Drawing.Point(97, 3);
            this.tileSelectPrevious.Name = "tileSelectPrevious";
            this.tileSelectPrevious.Size = new System.Drawing.Size(40, 40);
            this.tileSelectPrevious.Style = MetroFramework.MetroColorStyle.White;
            this.tileSelectPrevious.TabIndex = 5;
            this.tileSelectPrevious.TileImage = global::DBBiblioteka.Properties.Resources.up;
            this.tileSelectPrevious.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSelectPrevious.UseTileImage = true;
            this.tileSelectPrevious.Click += new System.EventHandler(this.tileSelectPrevious_Click);
            this.tileSelectPrevious.MouseHover += new System.EventHandler(this.tileSelectPrevious_MouseHover);
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(624, 11);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(162, 26);
            this.txtPretraga.TabIndex = 6;
            this.txtPretraga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.AllowUserToAddRows = false;
            this.dgvPrikaz.AllowUserToDeleteRows = false;
            this.dgvPrikaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikaz.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Location = new System.Drawing.Point(6, 203);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.ReadOnly = true;
            this.dgvPrikaz.Size = new System.Drawing.Size(893, 474);
            this.dgvPrikaz.TabIndex = 0;
            this.dgvPrikaz.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPrikaz_RowsAdded);
            this.dgvPrikaz.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPrikaz_RowsRemoved);
            this.dgvPrikaz.SelectionChanged += new System.EventHandler(this.dgvPrikaz_SelectionChanged);
            this.dgvPrikaz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPrikaz_KeyDown);
            this.dgvPrikaz.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvPrikaz_KeyUp);
            this.dgvPrikaz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPrikaz_MouseClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTitle.Location = new System.Drawing.Point(7, 680);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(112, 15);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Rezultati pretrage:";
            // 
            // lblRedIndex
            // 
            this.lblRedIndex.AutoSize = true;
            this.lblRedIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedIndex.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRedIndex.Location = new System.Drawing.Point(136, 680);
            this.lblRedIndex.Name = "lblRedIndex";
            this.lblRedIndex.Size = new System.Drawing.Size(39, 15);
            this.lblRedIndex.TabIndex = 14;
            this.lblRedIndex.Text = "label1";
            // 
            // FormStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.lblRedIndex);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelPretraga);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelDetalno);
            this.Controls.Add(this.lblBrojRedova);
            this.Controls.Add(this.panelVrati);
            this.Controls.Add(this.panelCrud);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStandard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Pregled/izmjena podataka";
            this.Load += new System.EventHandler(this.FormStandard_Load);
            this.panelCrud.ResumeLayout(false);
            this.panelVrati.ResumeLayout(false);
            this.panelDetalno.ResumeLayout(false);
            this.panelDetalno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPretraga.ResumeLayout(false);
            this.panelPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile tileDodaj;
        private MetroFramework.Controls.MetroTile tileIzmijeni;
        private MetroFramework.Controls.MetroTile tileObrisi;
        private MetroFramework.Controls.MetroPanel panelCrud;
        private MetroFramework.Controls.MetroPanel panelVrati;
        public MetroFramework.Controls.MetroTile tileVrati;
        private System.Windows.Forms.ListBox lbDetaljno;
        private System.Windows.Forms.Label lblBrojRedova;
        private MetroFramework.Controls.MetroLabel lblDetaljno;
        private MetroFramework.Controls.MetroPanel panelDetalno;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Components.MetroToolTip metroToolTip2;
        private MetroFramework.Components.MetroToolTip metroToolTip3;
        private MetroFramework.Components.MetroToolTip metroToolTip4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel panelPretraga;
        public MetroFramework.Controls.MetroTile tileDetaljnaPretraga;
        public MetroFramework.Controls.MetroTile tileAzurirajZapise;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTile tileSelectFirst;
        public MetroFramework.Controls.MetroTile tileSelectNext;
        public MetroFramework.Controls.MetroTile tileSelectLast;
        public MetroFramework.Controls.MetroTile tileSelectPrevious;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblRedIndex;
    }
}