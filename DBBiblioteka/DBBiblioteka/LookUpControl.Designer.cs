﻿namespace DBBiblioteka
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
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.tileLookUp = new MetroFramework.Controls.MetroTile();
            this.lblText = new System.Windows.Forms.Label();
            this.lblObavezno = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 7);
            this.txtID.MaxLength = 9;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(94, 25);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(312, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 25);
            this.txtName.TabIndex = 1;
            // 
            // tileLookUp
            // 
            this.tileLookUp.Location = new System.Drawing.Point(209, 7);
            this.tileLookUp.Name = "tileLookUp";
            this.tileLookUp.Size = new System.Drawing.Size(84, 24);
            this.tileLookUp.TabIndex = 2;
            this.tileLookUp.Text = "...";
            this.tileLookUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLookUp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLookUp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileLookUp.Click += new System.EventHandler(this.tileLookUp_Click_1);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(11, 13);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "label1";
            // 
            // lblObavezno
            // 
            this.lblObavezno.AutoSize = true;
            this.lblObavezno.ForeColor = System.Drawing.Color.Red;
            this.lblObavezno.Location = new System.Drawing.Point(99, 35);
            this.lblObavezno.Name = "lblObavezno";
            this.lblObavezno.Size = new System.Drawing.Size(0, 0);
            this.lblObavezno.Style = MetroFramework.MetroColorStyle.Red;
            this.lblObavezno.TabIndex = 4;
            this.lblObavezno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LookUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblObavezno);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.tileLookUp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Name = "LookUpControl";
            this.Size = new System.Drawing.Size(620, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTile tileLookUp;
        private System.Windows.Forms.Label lblText;
        private MetroFramework.Controls.MetroLabel lblObavezno;
    }
}
