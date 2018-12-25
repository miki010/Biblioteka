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

        public void SetKey(string key)
        {
            txtID.Text = key;
        }

        private void tileLookUp_Click_1(object sender, EventArgs e)
        {
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
            if (txtID.Text == "")
            {
                txtName.Text = "";

            }

            else 
            {
                FormStandard sf = new FormStandard(myInterface, StateEnum.LookUp, Convert.ToInt32(txtID.Text));
                sf.Vrati();
                Key = sf.Key;
                Value = sf.Value;
                txtName.Text = Value; 
            }

        }
        

    }
}
