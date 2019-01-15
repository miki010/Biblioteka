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
            this.lblNaziv.Location = new System.Drawing.Point(3, 4);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(55, 19);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "lblNaziv";
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(92, 8);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(55, 15);
            this.rbM.TabIndex = 1;
            this.rbM.TabStop = true;
            this.rbM.Text = "Muški";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.Location = new System.Drawing.Point(153, 8);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(57, 15);
            this.rbZenski.TabIndex = 2;
            this.rbZenski.TabStop = true;
            this.rbZenski.Text = "Ženski";
            this.rbZenski.UseVisualStyleBackColor = true;
            // 
            // UserControlRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbZenski);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UserControlRadio";
            this.Size = new System.Drawing.Size(219, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton rbM;
        private MetroFramework.Controls.MetroRadioButton rbZenski;
        public MetroFramework.Controls.MetroLabel lblNaziv;
    }
}
