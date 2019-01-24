using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DBBiblioteka
{
    public class CheckBoxControl : UserControl
    {
        public MetroFramework.Controls.MetroCheckBox cbRazduzeno;
        public MetroFramework.Controls.MetroButton btnOmoguci;

        private void InitializeComponent()
        {
            this.btnOmoguci = new MetroFramework.Controls.MetroButton();
            this.cbRazduzeno = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // btnOmoguci
            // 
            this.btnOmoguci.Location = new System.Drawing.Point(166, 11);
            this.btnOmoguci.Name = "btnOmoguci";
            this.btnOmoguci.Size = new System.Drawing.Size(163, 23);
            this.btnOmoguci.TabIndex = 0;
            this.btnOmoguci.Text = "Uvrsti stanje iznajmljivanja";
            this.btnOmoguci.Click += new System.EventHandler(this.btnOmoguci_Click);
            // 
            // cbRazduzeno
            // 
            this.cbRazduzeno.Location = new System.Drawing.Point(35, 10);
            this.cbRazduzeno.Name = "cbRazduzeno";
            this.cbRazduzeno.Size = new System.Drawing.Size(104, 24);
            this.cbRazduzeno.TabIndex = 1;
            this.cbRazduzeno.Text = "Razduženo";
            this.cbRazduzeno.UseVisualStyleBackColor = true;
            // 
            // CheckBoxControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbRazduzeno);
            this.Controls.Add(this.btnOmoguci);
            this.Name = "CheckBoxControl";
            this.Size = new System.Drawing.Size(500, 45);
            this.Load += new System.EventHandler(this.CheckBoxControl_Load);
            this.ResumeLayout(false);

        }

        public CheckBoxControl()
        {
            InitializeComponent();
        }
        private void btnOmoguci_Click(object sender, EventArgs e)
        {
            if (cbRazduzeno.Enabled)
            {
                cbRazduzeno.Enabled = false;
            }
            else
            {
                cbRazduzeno.Enabled = true;
            }
                
        }

        private void CheckBoxControl_Load(object sender, EventArgs e)
        {
            cbRazduzeno.Enabled = false;
            cbRazduzeno.Checked = false;     
        }
    }
}
