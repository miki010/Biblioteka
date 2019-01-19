using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBBiblioteka.PropertiesClass;
using MetroFramework;

namespace DBBiblioteka
{
    public partial class LookUpControl : UserControl
    {
        PropertyInterface myInterface;
        public string Key;
        public string Value;

        public LookUpControl(PropertyInterface interf)
        {
            InitializeComponent();
            myInterface = interf;
            txtName.ReadOnly = true;
        }

        public void SetLabel(string text)
        {
            lblText.Text = text;
        }
        public void SetLabelObavezno(string text)
        {
            lblObavezno.Visible = true;
            lblObavezno.Text = text;
            lblObavezno.ForeColor = Color.Red;
            //Label label = new Label();
            //label.Text = text;
        }

        public void SetKey(string key)
        {
            txtID.Text = key;
        }

        private void tileLookUp_Click_1(object sender, EventArgs e)
        {
            lblObavezno.Visible = false;

            FormStandard sf = new FormStandard(myInterface, StateEnum.LookUp);
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
            {
                Key = sf.Key;
                txtID.Text = Key;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            lblObavezno.Visible = false;
            //Key = "";
            if (txtID.Text == "")
            {
                txtName.Text = "";
                
            }

            else
            {
                char[] str = txtID.Text.ToCharArray();
                if (str[str.Length - 1] < 48 || str[str.Length - 1] > 57)
                {
                    txtID.Text = "";
                    return;
                }

                FormStandard sf = new FormStandard(myInterface, StateEnum.LookUp, Convert.ToInt32(txtID.Text));
                sf.Vrati();
                Key = sf.Key;
                Value = sf.Value;
                txtName.Text = Value;
            }

        }


    }
}
