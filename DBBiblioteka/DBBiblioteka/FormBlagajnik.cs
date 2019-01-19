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
    public partial class FormBlagajnik : MetroFramework.Forms.MetroForm
    {
        string ime, prezime;

      
        public FormBlagajnik()
        {
            InitializeComponent();   
        }
    
        public FormBlagajnik(string ime, string prezime)
        {
            InitializeComponent();
            this.ime = ime;
            this.prezime = prezime;
            this.ControlBox = false;
            tileDodajClanarinu.BringToFront();
            tileIzvjestaj.BringToFront();
            tilePregledClanarina.BringToFront();
            tileTipClanarine.BringToFront();
        }

        private void FormBlagajnik_Load(object sender, EventArgs e)
        {
            lblImeZaposlenog.Text = ime.ToString() + " " + prezime.ToString();
        }

        private void tileDodajClanarinu_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyClanarina());
            formStandard.ShowDialog();
        }

        private void tileLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin novaForma = new FormLogin();
            novaForma.Show();
            novaForma.Activate();
        }

        private void tileTipClanarine_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyTipClanarine());
            formStandard.ShowDialog();
        }

        private void tileIzvjestaj_Click(object sender, EventArgs e)
        {

        }

        private void tilePregledClanarina_Click(object sender, EventArgs e)
        {

        }


        private void tileDodajClanarinu_MouseHover(object sender, EventArgs e)
        {
            tileDodajClanarinu.Height -= 15;
            tileDodajClanarinu.Width -= 20;
        }

        private void tileDodajClanarinu_MouseLeave(object sender, EventArgs e)
        {
            tileDodajClanarinu.Height += 15;
            tileDodajClanarinu.Width += 20;
        }

        private void tilePregledClanarina_MouseHover(object sender, EventArgs e)
        {
            tilePregledClanarina.Height -= 15;
            tilePregledClanarina.Width -= 20;
        }

        private void tilePregledClanarina_MouseLeave(object sender, EventArgs e)
        {
            tilePregledClanarina.Height += 15;
            tilePregledClanarina.Width += 20;
        }

        private void tileTipClanarine_MouseHover(object sender, EventArgs e)
        {
            tileTipClanarine.Height -= 15;
            tileTipClanarine.Width -= 20;
        }

        private void tileTipClanarine_MouseLeave(object sender, EventArgs e)
        {
            tileTipClanarine.Height += 15;
            tileTipClanarine.Width += 20;
        }

        private void tileIzvjestaj_MouseHover(object sender, EventArgs e)
        {
            tileIzvjestaj.Height -= 15;
            tileIzvjestaj.Width -= 20;
        }

        private void tileIzvjestaj_MouseLeave(object sender, EventArgs e)
        {
            tileIzvjestaj.Height += 15;
            tileIzvjestaj.Width += 20;
        }
    }
}
