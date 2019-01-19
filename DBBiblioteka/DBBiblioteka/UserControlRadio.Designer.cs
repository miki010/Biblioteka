namespace DBBiblioteka
{
    partial class UserControlRadio
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
            this.lblNaziv = new MetroFramework.Controls.MetroLabel();
            this.rbM = new MetroFramework.Controls.MetroRadioButton();
            this.rbZenski = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNaziv.Location = new System.Drawing.Point(5, 0);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(56, 19);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "lblNaziv";
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.rbM.Location = new System.Drawing.Point(203, 0);
            this.rbM.Margin = new System.Windows.Forms.Padding(4);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(62, 19);
            this.rbM.TabIndex = 1;
            this.rbM.TabStop = true;
            this.rbM.Text = "Muški";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.rbZenski.Location = new System.Drawing.Point(399, 0);
            this.rbZenski.Margin = new System.Windows.Forms.Padding(4);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(64, 19);
            this.rbZenski.TabIndex = 2;
            this.rbZenski.TabStop = true;
            this.rbZenski.Text = "Ženski";
            this.rbZenski.UseVisualStyleBackColor = true;
            // 
            // UserControlRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rbZenski);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.lblNaziv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRadio";
            this.Size = new System.Drawing.Size(500, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton rbM;
        private MetroFramework.Controls.MetroRadioButton rbZenski;
        public MetroFramework.Controls.MetroLabel lblNaziv;
    }
}
