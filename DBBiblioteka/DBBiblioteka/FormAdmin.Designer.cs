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
            this.tileNoviRadnik = new MetroFramework.Controls.MetroTile();
            this.tileNovaKnjiga = new MetroFramework.Controls.MetroTile();
            this.tileIzdavac = new MetroFramework.Controls.MetroTile();
            this.tileAutor = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileNoviRadnik
            // 
            this.tileNoviRadnik.Location = new System.Drawing.Point(114, 104);
            this.tileNoviRadnik.Name = "tileNoviRadnik";
            this.tileNoviRadnik.Size = new System.Drawing.Size(172, 105);
            this.tileNoviRadnik.Style = MetroFramework.MetroColorStyle.Magenta;
            this.tileNoviRadnik.TabIndex = 0;
            this.tileNoviRadnik.Text = "NOVI RADNIK";
            // 
            // tileNovaKnjiga
            // 
            this.tileNovaKnjiga.Location = new System.Drawing.Point(292, 104);
            this.tileNovaKnjiga.Name = "tileNovaKnjiga";
            this.tileNovaKnjiga.Size = new System.Drawing.Size(216, 105);
            this.tileNovaKnjiga.Style = MetroFramework.MetroColorStyle.Magenta;
            this.tileNovaKnjiga.TabIndex = 1;
            this.tileNovaKnjiga.Text = "NOVA KNJIGA";
            // 
            // tileIzdavac
            // 
            this.tileIzdavac.Location = new System.Drawing.Point(114, 215);
            this.tileIzdavac.Name = "tileIzdavac";
            this.tileIzdavac.Size = new System.Drawing.Size(216, 105);
            this.tileIzdavac.Style = MetroFramework.MetroColorStyle.Magenta;
            this.tileIzdavac.TabIndex = 2;
            this.tileIzdavac.Text = "IZDAVAC";
            // 
            // tileAutor
            // 
            this.tileAutor.Location = new System.Drawing.Point(336, 215);
            this.tileAutor.Name = "tileAutor";
            this.tileAutor.Size = new System.Drawing.Size(172, 105);
            this.tileAutor.Style = MetroFramework.MetroColorStyle.Magenta;
            this.tileAutor.TabIndex = 3;
            this.tileAutor.Text = "AUTOR";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 428);
            this.Controls.Add(this.tileAutor);
            this.Controls.Add(this.tileIzdavac);
            this.Controls.Add(this.tileNovaKnjiga);
            this.Controls.Add(this.tileNoviRadnik);
            this.Name = "FormAdmin";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileNoviRadnik;
        private MetroFramework.Controls.MetroTile tileNovaKnjiga;
        private MetroFramework.Controls.MetroTile tileIzdavac;
        private MetroFramework.Controls.MetroTile tileAutor;
    }
}