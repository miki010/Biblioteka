namespace DBBiblioteka
{
    partial class InputControl
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblObavezno = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(5, 10);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(45, 16);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "label1";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(170, 7);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(320, 22);
            this.txtValue.TabIndex = 1;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // lblObavezno
            // 
            this.lblObavezno.AutoSize = true;
            this.lblObavezno.BackColor = System.Drawing.SystemColors.Control;
            this.lblObavezno.ForeColor = System.Drawing.Color.Red;
            this.lblObavezno.Location = new System.Drawing.Point(113, 31);
            this.lblObavezno.Name = "lblObavezno";
            this.lblObavezno.Size = new System.Drawing.Size(0, 0);
            this.lblObavezno.Style = MetroFramework.MetroColorStyle.Red;
            this.lblObavezno.TabIndex = 2;
            this.lblObavezno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblObavezno);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblText);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(500, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtValue;
        private MetroFramework.Controls.MetroLabel lblObavezno;
    }
}
