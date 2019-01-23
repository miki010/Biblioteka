﻿using System;
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
            txtID.Focus();
        }

        public void SetLabel(string text)
        {
            lblText.Text = text;
        }

        public void SetLabelObavezno(string text)
        {
            lblObavezno.Visible = true;
            lblObavezno.Text = text;
            var point = new Point(170, 32);
            this.lblObavezno.Location = point;
            lblObavezno.CustomForeColor = true;
            lblObavezno.ForeColor = Color.Red;
            txtID.Text = "";
            txtName.Text = "";
            Key = null;
            Value = null;

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
            if (txtID.Text == "")
            {
                txtName.Text = "";
                SetLabelObavezno("");
                return;
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
