namespace DBBiblioteka
{
    partial class LookUpControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtL1 = new MetroFramework.Controls.MetroTextBox();
            this.txtL2 = new MetroFramework.Controls.MetroTextBox();
            this.tileLookUp = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(29, 15);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(94, 25);
            this.txtL1.TabIndex = 0;
            // 
            // txtL2
            // 
            this.txtL2.Location = new System.Drawing.Point(242, 15);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(300, 25);
            this.txtL2.TabIndex = 1;
            // 
            // tileLookUp
            // 
            this.tileLookUp.Location = new System.Drawing.Point(139, 15);
            this.tileLookUp.Name = "tileLookUp";
            this.tileLookUp.Size = new System.Drawing.Size(84, 24);
            this.tileLookUp.TabIndex = 2;
            this.tileLookUp.Text = "...";
            this.tileLookUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLookUp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLookUp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // LookUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileLookUp);
            this.Controls.Add(this.txtL2);
            this.Controls.Add(this.txtL1);
            this.Name = "LookUpControl";
            this.Size = new System.Drawing.Size(591, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtL1;
        private MetroFramework.Controls.MetroTextBox txtL2;
        private MetroFramework.Controls.MetroTile tileLookUp;
    }
}
