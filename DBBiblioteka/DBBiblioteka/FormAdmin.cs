using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBBiblioteka.PropertiesClass;

namespace DBBiblioteka
{
    public partial class FormAdmin : MetroFramework.Forms.MetroForm
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tileNoviRadnik_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyZaposleni());
            formStandard.ShowDialog();
        }

        private void tileNovaKnjiga_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyKnjiga());
            formStandard.ShowDialog();
        }

        private void tileIzdavac_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyIzdavac());
            formStandard.ShowDialog();
        }

        private void tileAutor_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyAutor());
            formStandard.ShowDialog();
        }
    }
}
