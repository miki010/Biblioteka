using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBBiblioteka
{
    public partial class DateTimeControl : UserControl
    {
        public DateTimeControl()
        {
            InitializeComponent();
            
        }


        public void SetLabel(string name)
        {
            lblText.Text = name;
        }

        public DateTime GetValue()
        {
            return dateTimePicker.Value;
        }

        public void SetValue(DateTime date)
        {
            dateTimePicker.Value = date;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd.MM.yyyy.";
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //if(lblText.Text == "Datum iznajmljivanja")
            //{
            //    DateTimeControl dtcIznajmljivanje = new DateTimeControl();

            //    foreach (var control in Parent.Controls)
            //    {
            //        if (control is DateTimeControl)
            //            dtcIznajmljivanje = control as DateTimeControl;
            //    }

            //    dtcIznajmljivanje.SetValue(GetValue().AddDays(15));
            //}

            //Parent.Controls.Cast<ControlCollection>().Where(c =>)
        }
    }
}
