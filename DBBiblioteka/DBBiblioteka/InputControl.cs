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
    public partial class InputControl : UserControl
    {
        
        public InputControl()
        {
            InitializeComponent();
        }

        public void SetLabel(string name)
        {
            lblText.Text = name;
        }

        public void SetLblObavezno(string text)
        {
            lblObavezno.Visible = true;
            lblObavezno.Text = text;
            lblObavezno.ForeColor = Color.Red;
        }

        public string GetValue()
        {
            return txtValue.Text;
        }

        public void SetValue(string value)
        {
            txtValue.Text = value;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            lblObavezno.Visible = false;
        }
    }
}
