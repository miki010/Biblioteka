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
        }

        public void SetLabel(string name)
        {
            lblText.Text = name;
        }

        public DateTime[] GetValue()
        {
            return new DateTime[] { dateTimePicker1.Value, dateTimePicker2.Value };
        }

        public void SetValue(DateTime date1, DateTime date2)
        {
            dateTimePicker1.Value = date1;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy.";

            dateTimePicker2.Value = date2;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy.";
        }

        private void btnDanasnjiDan_Click(object sender, EventArgs e)
        {
            SetValue(DateTime.Now.Date, DateTime.Now.Date);
        }

        private void btnPonistiDatum_Click(object sender, EventArgs e)
        {
            SetValue(DateTimePicker.MinimumDateTime, DateTimePicker.MinimumDateTime);
        }
    }
}
