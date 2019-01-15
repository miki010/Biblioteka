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
            this.btnDanasnjiDan = new MetroFramework.Controls.MetroButton();
            this.btnPonistiDatum = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(3, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(81, 19);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "metroLabel1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 9);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(422, 9);
            this.dateTimePicker2.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.Location = new System.Drawing.Point(136, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Od: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(383, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Do: ";
            // 
            // btnDanasnjiDan
            // 
            this.btnDanasnjiDan.Location = new System.Drawing.Point(628, 9);
            this.btnDanasnjiDan.Name = "btnDanasnjiDan";
            this.btnDanasnjiDan.Size = new System.Drawing.Size(91, 20);
            this.btnDanasnjiDan.TabIndex = 5;
            this.btnDanasnjiDan.Text = "Današnji datum";
            this.btnDanasnjiDan.Click += new System.EventHandler(this.btnDanasnjiDan_Click);
            // 
            // btnPonistiDatum
            // 
            this.btnPonistiDatum.Location = new System.Drawing.Point(725, 9);
            this.btnPonistiDatum.Name = "btnPonistiDatum";
            this.btnPonistiDatum.Size = new System.Drawing.Size(91, 20);
            this.btnPonistiDatum.TabIndex = 6;
            this.btnPonistiDatum.Text = "Poništi";
            this.btnPonistiDatum.Click += new System.EventHandler(this.btnPonistiDatum_Click);
            // 
            // DateRangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnPonistiDatum);
            this.Controls.Add(this.btnDanasnjiDan);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblText);
            this.Name = "DateRangeControl";
            this.Size = new System.Drawing.Size(825, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnDanasnjiDan;
        private MetroFramework.Controls.MetroButton btnPonistiDatum;
    }
}
