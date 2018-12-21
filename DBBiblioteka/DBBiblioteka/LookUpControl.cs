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
        }

         public void SetLabel(string text)
        {
            lblText.Text = text;       
        }

        private void tileLookUp_Click_1(object sender, EventArgs e)
        {
            FormStandard sf = new FormStandard(myInterface);
            sf.ShowDialog();
            Key = sf.Key;
            Value = sf.Value;
            txtID.Text = Value;
            txtName.Text = Value;
        }
    }
}
