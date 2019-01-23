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
        string ime, prezime, srednjeIme, pol;
        public FormAdmin()
        {
            InitializeComponent();
            tileNoviRadnik.BringToFront();
            tileAutor.BringToFront();
            tileIzdavac.BringToFront();
            tileNovaKnjiga.BringToFront();
            
        }
        public FormAdmin(string ime, string prezime, string srednjeIme, string pol)
        {
            InitializeComponent();
            this.ime = ime;
            this.prezime = prezime;
            this.srednjeIme = srednjeIme;
            this.pol = pol;
            this.ControlBox = false;
            panelPromjenaLozinke.Visible = false;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblImeZaposlenog.Text = ime.ToString() + " " + prezime.ToString();
            tileProfile.UseTileImage = true;
            if (pol == "M")
            {
                tileProfile.TileImage = DBBiblioteka.Properties.Resources.resetpasswordfinal;
            }
            else if (pol == "Z" || pol == "Ž")
            {
                tileProfile.TileImage = DBBiblioteka.Properties.Resources.resetpasswordfinal;
            }
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

        private void tileNoviRadnik_MouseHover(object sender, EventArgs e)
        {
            tileNoviRadnik.Height -= 15;
            tileNoviRadnik.Width -= 20;
        }

        private void tileNoviRadnik_MouseLeave(object sender, EventArgs e)
        {
            tileNoviRadnik.Height += 15;
            tileNoviRadnik.Width += 20;
        }

        private void tileNovaKnjiga_MouseHover(object sender, EventArgs e)
        {
            tileNovaKnjiga.Height -= 15;
            tileNovaKnjiga.Width -= 20;
        }

        private void tileNovaKnjiga_MouseLeave(object sender, EventArgs e)
        {
            tileNovaKnjiga.Height += 15;
            tileNovaKnjiga.Width += 20;
        }

        private void tileIzdavac_MouseHover(object sender, EventArgs e)
        {
            tileIzdavac.Height -= 15;
            tileIzdavac.Width -= 20;
        }

        private void tileProfile_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Visible = true;
            panelPromjenaLozinke.BringToFront();
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

        private void tileProfile_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show("Promijeni lozinku?", tileProfile);
        }

        private void tileLogout_MouseHover(object sender, EventArgs e)
        {
            metroToolTip2.Show("Odjava?", tileLogout);
        }

        private void lblImeZaposlenog_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAdminPozadina_Click(object sender, EventArgs e)
        {

        }

        private void tileIzdavac_MouseLeave(object sender, EventArgs e)
        {
            tileIzdavac.Height += 15;
            tileIzdavac.Width += 20;
        }

        private void tileAutor_MouseHover(object sender, EventArgs e)
        {
            tileAutor.Height -= 15;
            tileAutor.Width -= 20;
        }

        private void tileAutor_MouseLeave(object sender, EventArgs e)
        {
            tileAutor.Height += 15;
            tileAutor.Width += 20;
        }
    }
}
