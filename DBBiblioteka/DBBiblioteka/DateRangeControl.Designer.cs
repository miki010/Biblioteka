namespace DBBiblioteka
{
    partial class DateRangeControl
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
            this.lblText = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnDanasnjiDatum = new MetroFramework.Controls.MetroTile();
            this.btnPonistiDatum = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblText.Location = new System.Drawing.Point(5, 4);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(86, 19);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "metroLabel1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 1);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(227, 30);
            this.dateTimePicker2.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.Location = new System.Drawing.Point(164, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Od: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(164, 30);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Do: ";
            // 
            // btnDanasnjiDatum
            // 
            this.btnDanasnjiDatum.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDanasnjiDatum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanasnjiDatum.CustomBackground = true;
            this.btnDanasnjiDatum.CustomForeColor = true;
            this.btnDanasnjiDatum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDanasnjiDatum.Location = new System.Drawing.Point(376, 3);
            this.btnDanasnjiDatum.Name = "btnDanasnjiDatum";
            this.btnDanasnjiDatum.Size = new System.Drawing.Size(115, 21);
            this.btnDanasnjiDatum.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDanasnjiDatum.TabIndex = 7;
            this.btnDanasnjiDatum.Text = "Današnji datum";
            this.btnDanasnjiDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDanasnjiDatum.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDanasnjiDatum.Click += new System.EventHandler(this.btnDanasnjiDatum_Click);
            // 
            // btnPonistiDatum
            // 
            this.btnPonistiDatum.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPonistiDatum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPonistiDatum.CustomBackground = true;
            this.btnPonistiDatum.CustomForeColor = true;
            this.btnPonistiDatum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPonistiDatum.Location = new System.Drawing.Point(376, 30);
            this.btnPonistiDatum.Name = "btnPonistiDatum";
            this.btnPonistiDatum.Size = new System.Drawing.Size(115, 21);
            this.btnPonistiDatum.Style = MetroFramework.MetroColorStyle.Red;
            this.btnPonistiDatum.TabIndex = 8;
            this.btnPonistiDatum.Text = "Poništi";
            this.btnPonistiDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPonistiDatum.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPonistiDatum.Click += new System.EventHandler(this.btnPonistiDatum_Click);
            // 
            // DateRangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPonistiDatum);
            this.Controls.Add(this.btnDanasnjiDatum);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblText);
            this.Name = "DateRangeControl";
            this.Size = new System.Drawing.Size(500, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile btnDanasnjiDatum;
        private MetroFramework.Controls.MetroTile btnPonistiDatum;
    }
}
