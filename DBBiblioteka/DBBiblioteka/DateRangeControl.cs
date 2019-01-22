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
    public partial class DateRangeControl : UserControl
    {
        public DateRangeControl()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy.";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy.";
        }

        public void SetLabel(string name)
        {
            lblText.Text = name;
        }

        public DateTime[] GetValue()
        {
            return new DateTime[] { dateTimePicker1.Value, dateTimePicker2.Value };
        }

        public bool GetChecked()
        {
            if (cbEnableDate.Checked)
                return true;
            else
                return false;
        }
        public void SetValue(DateTime date1, DateTime date2)
        {
           
        }

       
    }
}
