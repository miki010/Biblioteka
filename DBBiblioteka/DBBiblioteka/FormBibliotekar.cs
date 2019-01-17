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
    public partial class FormBibliotekar : MetroFramework.Forms.MetroForm
    {
        string ime, prezime, srednjeIme;
        public FormBibliotekar()
        {
            InitializeComponent();
        }

        public FormBibliotekar(string ime, string srednjeIme, string prezime)
        {
            InitializeComponent();
            this.ime = ime;
            this.prezime = prezime;
            this.srednjeIme = srednjeIme;
            this.ControlBox = false;    
        }

        private void Bibliotekar_Load(object sender, EventArgs e)
        {   
              lblImeZaposlenog.Text = ime.ToString() + " " + srednjeIme.ToString() + " " + prezime.ToString();
        }

        private void tilePretraga_Click(object sender, EventArgs e)
        {

        }

        private void tileUnosClana_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyClan());
            formStandard.ShowDialog();
        }

        private void tileIznajmi_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyIznajmljivanje());
            formStandard.ShowDialog();
        }

        private void tileRazduzivanje_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyIznajmljivanje());
            formStandard.ShowDialog();
        }

        private void tileClanarina_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyClan(), StateEnum.View);
            formStandard.ShowDialog();
        }

      

        private void tileLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin novaForma = new FormLogin();
            novaForma.Show();
            novaForma.Activate();
        }

      
    }
}
