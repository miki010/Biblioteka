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
        string ime, prezime;
        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(string ime, string prezime)
        {
            InitializeComponent();
            this.ime = ime;
            this.prezime = prezime;
            this.ControlBox = false;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblImeZaposlenog.Text = ime.ToString() + " " + prezime.ToString();
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

        private void tileLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin novaForma = new FormLogin();
            novaForma.Show();
            novaForma.Activate();
        }

        private void tileAutor_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyAutor());
            formStandard.ShowDialog();
        }
    }
}
