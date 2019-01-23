using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace DBBiblioteka
{
    public partial class UserControlRadio : UserControl
    {
        public UserControlRadio()
        {
            InitializeComponent();
        }

        public void SetLabel(string name)
        {
            lblNaziv.Text = name;
        }

        public string GetValue()
        {
            if (rbM.Checked)
                return rbM.Text.Substring(0, 1);
            else if (rbZenski.Checked)
                return rbZenski.Text.Substring(0, 1);
            else
                return "N";
        }

        public void SetValue(string value)
        {
            if (value == rbM.Text.Substring(0, 1))
            {
                rbM.Checked = true;

            }
            else if (value == rbZenski.Text.Substring(0, 1))
            {
                rbZenski.Checked = true;

            }
        }

        //Zadrzati! setovana labela za obaveznan unos u polje M/Z
        public void SetLblObavezno(string text)
        {
            lblObavezno.Visible = true;
            lblObavezno.Text = text;
            lblObavezno.ForeColor = Color.Red;

            if(rbM.Checked == true || rbZenski.Checked)
            {
                lblObavezno.Visible = false;
            }

            if (text == "*")
            {
                lblObavezno.FontSize = MetroLabelSize.Tall;
                lblObavezno.FontWeight = MetroLabelWeight.Bold;
            }
            else
            {
                lblObavezno.FontSize = MetroLabelSize.Small;
                lblObavezno.FontWeight = MetroLabelWeight.Regular;
            }
        }

        private void rbM_CheckedChanged(object sender, EventArgs e)
        {
            lblObavezno.Visible = false;
        }

        private void rbZenski_CheckedChanged(object sender, EventArgs e)
        {
            lblObavezno.Visible = false;
        }
    }
}
