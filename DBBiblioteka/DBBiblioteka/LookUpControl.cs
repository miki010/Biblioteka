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
using MetroFramework.Controls;

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

        public void AddTextChangedEvent()
        {
            txtID.TextChanged += TxtID_TextChangedZaInput;
        }

        public void TxtID_TextChangedZaInput(object sender, EventArgs e)
        {
            var listaKontrola = Parent.Controls;
            for (int i = 0; i < listaKontrola.Count; i++)
            {
                if (listaKontrola[i].Name == "DatumIstekaClanarine")
                {
                    try { 
                    Value = Value.Trim();
                    if (Value == "Mjesecna")
                        ((DateTimeControl)listaKontrola[i]).SetValue(DateTime.Now.AddMonths(1));
                    else if (Value == "Polugodisnja")
                        ((DateTimeControl)listaKontrola[i]).SetValue(DateTime.Now.AddMonths(6));
                    else if (Value == "Godisnja")
                        ((DateTimeControl)listaKontrola[i]).SetValue(DateTime.Now.AddYears(1));
                        else
                        {
                            ((DateTimeControl)listaKontrola[i]).SetValue(DateTime.Now);
                            return;
                        }
                        
                    }
                    catch (Exception)
                    {
                        ((DateTimeControl)listaKontrola[i]).SetValue(DateTime.Now);
                    }
                }
            }
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
