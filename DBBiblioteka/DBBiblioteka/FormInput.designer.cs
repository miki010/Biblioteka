namespace DBBiblioteka
{
    partial class FormInput
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
            this.flPanelControls = new System.Windows.Forms.FlowLayoutPanel();
            this.tilePotvrdi = new MetroFramework.Controls.MetroTile();
            this.tileOdustani = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPanelControls
            // 
            this.flPanelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.flPanelControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelControls.Location = new System.Drawing.Point(20, 60);
            this.flPanelControls.Name = "flPanelControls";
            this.flPanelControls.Size = new System.Drawing.Size(561, 638);
            this.flPanelControls.TabIndex = 0;
            // 
            // tilePotvrdi
            // 
            this.tilePotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tilePotvrdi.Location = new System.Drawing.Point(118, 5);
            this.tilePotvrdi.Name = "tilePotvrdi";
            this.tilePotvrdi.Size = new System.Drawing.Size(125, 45);
            this.tilePotvrdi.Style = MetroFramework.MetroColorStyle.Green;
            this.tilePotvrdi.TabIndex = 1;
            this.tilePotvrdi.Text = "POTVRDI";
            this.tilePotvrdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePotvrdi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePotvrdi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tilePotvrdi.Click += new System.EventHandler(this.tilePotvrdi_Click);
            // 
            // tileOdustani
            // 
            this.tileOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileOdustani.Location = new System.Drawing.Point(282, 5);
            this.tileOdustani.Name = "tileOdustani";
            this.tileOdustani.Size = new System.Drawing.Size(125, 45);
            this.tileOdustani.Style = MetroFramework.MetroColorStyle.Red;
            this.tileOdustani.TabIndex = 2;
            this.tileOdustani.Text = "ODUSTANI";
            this.tileOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileOdustani.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileOdustani.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileOdustani.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileOdustani.Click += new System.EventHandler(this.tileOdustani_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tilePotvrdi);
            this.metroPanel1.Controls.Add(this.tileOdustani);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 698);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(561, 57);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(601, 756);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.flPanelControls);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "FormInput";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Unos podataka";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanelControls;
        private MetroFramework.Controls.MetroTile tilePotvrdi;
        private MetroFramework.Controls.MetroTile tileOdustani;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}