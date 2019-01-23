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
using DBBiblioteka.Properties;
using DBBiblioteka.Helper;
using System.Data.SqlClient;

namespace DBBiblioteka
{
    public partial class FormBibliotekar : MetroFramework.Forms.MetroForm
    {
        string ime, prezime, srednjeIme, pol;
        public FormBibliotekar()
        {
            InitializeComponent();           
        }

        public FormBibliotekar(string ime, string srednjeIme, string prezime, string pol)
        {
            InitializeComponent();
            this.ime = ime;
            this.prezime = prezime;
            this.srednjeIme = srednjeIme;
            this.ControlBox = false;
            this.pol = pol;
            tileClanarina.BringToFront();
            tileIznajmi.BringToFront();
            tilePregledIznajmljivanja.BringToFront();
            tilePretraga.BringToFront();
            tileUnosClana.BringToFront();
            tileRazduzivanje.BringToFront();
            panelPromjenaLozinke.Visible = false;
        }

        private void Bibliotekar_Load(object sender, EventArgs e)
        {   
              lblImeZaposlenog.Text = ime.ToString() + " " + srednjeIme.ToString() + " " + prezime.ToString();
            tileProfile.UseTileImage = true;
            if(pol=="M")
            {
                tileProfile.TileImage = DBBiblioteka.Properties.Resources.user_man_profile;
            }
            else if(pol=="Z" || pol == "Ž")
            {
                tileProfile.TileImage= DBBiblioteka.Properties.Resources.edit_woman_profile;
            }

        }

        private void tilePretraga_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyKnjiga());
            formStandard.ShowDialog();
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

        string pregled = "Knjige";
        private void tileClanarina_Click(object sender, EventArgs e)
        {

            Report rpt3 = new Report(pregled);
            rpt3.ShowDialog();
        }

        private void tileUnosClana_MouseHover(object sender, EventArgs e)
        {
            tileUnosClana.Height -= 15;
            tileUnosClana.Width -= 20;
        }

        private void tileUnosClana_MouseLeave(object sender, EventArgs e)
        {
            tileUnosClana.Height += 15;
            tileUnosClana.Width += 20;
        }

        private void tilePretraga_MouseHover(object sender, EventArgs e)
        {
            tilePretraga.Height -= 15;
            tilePretraga.Width -= 20;
        }

        private void tilePretraga_MouseLeave(object sender, EventArgs e)
        {
            tilePretraga.Height += 15;
            tilePretraga.Width += 20;
        }

        private void tilePregledIznajmljivanja_MouseHover(object sender, EventArgs e)
        {
            tilePregledIznajmljivanja.Height -= 15;
            tilePregledIznajmljivanja.Width -= 20;
        }

        private void tilePregledIznajmljivanja_MouseLeave(object sender, EventArgs e)
        {
            tilePregledIznajmljivanja.Height += 15;
            tilePregledIznajmljivanja.Width += 20;
        }

        private void tileIznajmi_MouseHover(object sender, EventArgs e)
        {
            tileIznajmi.Height -= 20;
            tileIznajmi.Width -= 15;
        }

        private void tileIznajmi_MouseLeave(object sender, EventArgs e)
        {
            tileIznajmi.Height += 20;
            tileIznajmi.Width += 15;
        }

        private void tileVracanje_MouseHover(object sender, EventArgs e)
        {
            tileRazduzivanje.Height -= 15;
            tileRazduzivanje.Width -= 15;
        }

        private void tileVracanje_MouseLeave(object sender, EventArgs e)
        {
            tileRazduzivanje.Height += 15;
            tileRazduzivanje.Width += 15;
        }

        private void tileProfile_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Visible = true;
            panelPromjenaLozinke.BringToFront();
        }

        private void tileSacuvaj_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Visible = false;
        }

        private void tileSacuvajIzmjene_Click(object sender, EventArgs e)
        {
            //dodati kod za izmjenu lozinke
            panelPromjenaLozinke.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Visible = false;
        }

        private void tileLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin forma = new FormLogin();
            forma.Show();
            forma.Activate();
        }
        string korisnik = "iznajmljivanje";
        private void tilePregledIznajmljivanja_Click(object sender, EventArgs e)
        {
            Report rpt = new Report(korisnik);
            rpt.ShowDialog();
        }

        private void tileClanarina_MouseHover(object sender, EventArgs e)
        {
            tileClanarina.Height -= 15;
            tileClanarina.Width -= 20;
        }

        private void tileClanarina_MouseLeave(object sender, EventArgs e)
        {
            tileClanarina.Height += 15;
            tileClanarina.Width += 20;
        }
    }
}
