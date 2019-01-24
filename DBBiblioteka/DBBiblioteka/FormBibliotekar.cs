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
using System.Data.SqlClient;
using DBBiblioteka.Helper;

namespace DBBiblioteka
{
    public partial class FormBibliotekar : MetroFramework.Forms.MetroForm
    {
        PropertyLogin myProperty = new PropertyLogin();
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
                tileProfile.TileImage = DBBiblioteka.Properties.Resources.resetpasswordfinal;
            }
            else if(pol=="Z" || pol == "Ž")
            {
                tileProfile.TileImage= DBBiblioteka.Properties.Resources.resetpasswordfinal;
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
            formStandard.tileIzmijeni.Enabled = false;
            formStandard.tileObrisi.Enabled = false;
            formStandard.ShowDialog();

            
        }

        private void tileRazduzivanje_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyIznajmljivanje());
            formStandard.tileDodaj.Enabled = false;
            formStandard.tileObrisi.Enabled = false;
            formStandard.ShowDialog();
        }

        string pregled = "Knjige";
        private void tileClanarina_Click(object sender, EventArgs e)
        {

            Report1 rpt3 = new Report1(pregled);
            rpt3.ShowDialog();
        }

        private void tileUnosClana_MouseHover(object sender, EventArgs e)
        {
            tileUnosClana.Height -= 10;
            tileUnosClana.Width -= 10;
        }

        private void tileUnosClana_MouseLeave(object sender, EventArgs e)
        {
            tileUnosClana.Height += 10;
            tileUnosClana.Width += 10;
        }

        private void tilePretraga_MouseHover(object sender, EventArgs e)
        {
            tilePretraga.Height -= 10;
            tilePretraga.Width -= 10;
        }

        private void tilePretraga_MouseLeave(object sender, EventArgs e)
        {
            tilePretraga.Height += 10;
            tilePretraga.Width += 10;
        }

        private void tilePregledIznajmljivanja_MouseHover(object sender, EventArgs e)
        {
            tilePregledIznajmljivanja.Height -= 10;
            tilePregledIznajmljivanja.Width -= 10;
        }

        private void tilePregledIznajmljivanja_MouseLeave(object sender, EventArgs e)
        {
            tilePregledIznajmljivanja.Height += 10;
            tilePregledIznajmljivanja.Width += 10;
        }

        private void tileIznajmi_MouseHover(object sender, EventArgs e)
        {
            tileIznajmi.Height -= 10;
            tileIznajmi.Width -= 10;
        }

        private void tileIznajmi_MouseLeave(object sender, EventArgs e)
        {
            tileIznajmi.Height += 10;
            tileIznajmi.Width += 10;
        }

        private void tileVracanje_MouseHover(object sender, EventArgs e)
        {
            tileRazduzivanje.Height -= 10;
            tileRazduzivanje.Width -= 10;
        }

        private void tileVracanje_MouseLeave(object sender, EventArgs e)
        {
            tileRazduzivanje.Height += 10;
            tileRazduzivanje.Width += 10;
        }

        private void tileProfile_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Visible = true;
            panelPromjenaLozinke.BringToFront();
            lblPogresnaStara.Visible = false;
            lblUpozorenje.Visible = false;
            txtTrenutnaLozinka.Focus();
        }

        private void tileSacuvaj_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Visible = false;
        }

        private void tileSacuvajIzmjene_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Focus();
            string staraLozinka = "";
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, myProperty.GetLoginQuery());

            dt.Load(reader);
            reader.Close();
            bool idProsao = false;

            if (txtTrenutnaLozinka.Text != "" && txtNovaLozinka.Text != "" && txtPotvrdiLozinku.Text != "")
            {
                foreach (DataRow row in dt.Rows)
                {
                    string ZaposleniID = row["ZaposleniID"].ToString();
                    string trenutnaLozinkaIzBaze = row["Lozinka"].ToString();

                    if (ZaposleniID == FormLogin.idZaposlenog)
                    {
                        idProsao = true;
                        staraLozinka = trenutnaLozinkaIzBaze;
                        break;
                    }
                }

                if (!idProsao)
                {
                    txtTrenutnaLozinka.Focus();
                    txtTrenutnaLozinka.Text = "";
                }

                else
                {
                    lblPogresnaStara.Visible = false;
                    if (staraLozinka != txtTrenutnaLozinka.Text)
                    {
                        lblPogresnaStara.Visible = true;
                        lblPogresnaStara.Text = "Pogrešna lozinka!";
                    }
                    else if (staraLozinka == txtTrenutnaLozinka.Text)
                    {
                        lblPogresnaStara.Visible = false;
                        if (txtNovaLozinka.Text == txtTrenutnaLozinka.Text)
                        {
                            lblUpozorenje.Visible = true;
                            lblUpozorenje.Text = "Lozinka je vec u upotrebi!";
                        }
                        else if (txtNovaLozinka.Text == txtPotvrdiLozinku.Text)
                        {
                            lblUpozorenje.Visible = false;
                            lblPogresnaStara.Visible = false;
                            string zaposleniID = FormLogin.idZaposlenog;
                            string Lozinka = txtNovaLozinka.Text.Trim();

                            PasswordToBase.NewPasswordToBase(zaposleniID, Lozinka);

                            MessageBox.Show("Uspješno ste promijenili lozinku!");
                            resetujPolja();
                            lblUpozorenje.Visible = false;
                            lblPogresnaStara.Visible = false;
                            panelPromjenaLozinke.Visible = false;
                        }
                        else
                        {
                            lblUpozorenje.Visible = true;
                            lblUpozorenje.Text = "Lozinke se ne poklapaju!";
                            txtPotvrdiLozinku.Focus();
                        }
                    }
                }
            }
            else
            {
                // MessageBox.Show("Sva polja moraju biti popunjena!");
                lblUpozorenje.Visible = true;
                lblUpozorenje.Text = "Sva polja moraju biti popunjena!";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetujPolja();
            lblPogresnaStara.Visible = false;
            lblUpozorenje.Visible = false;
            panelPromjenaLozinke.Visible = false;
        }
   
        private void resetujPolja()
        {
            txtNovaLozinka.Text = "";
            txtTrenutnaLozinka.Text = "";
            txtPotvrdiLozinku.Text = "";
        }
   

        private void tileProfile_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show("Promijeni lozinku?", tileProfile);
        }

        private void tileLogout_MouseHover(object sender, EventArgs e)
        {
            metroToolTip2.Show("Odjava?", tileLogout);
        }

        private void pictureBoxBibliotekarPozadina_Click(object sender, EventArgs e)
        {

        }

        private void panelPromjenaLozinke_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tileLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin forma = new FormLogin();
            forma.Show();
            forma.Activate();
        }

        private void txtTrenutnaLozinka_TextChanged(object sender, EventArgs e)
        {
            lblPogresnaStara.Visible = false;
        }

        private void txtPotvrdiLozinku_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenje.Visible = false;
        }

        private void txtNovaLozinka_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenje.Visible = false;
        }

        string korisnik = "iznajmljivanje";
        private void tilePregledIznajmljivanja_Click(object sender, EventArgs e)
        {
            Report1 rpt = new Report1(korisnik);
            rpt.ShowDialog();
        }

        private void tileClanarina_MouseHover(object sender, EventArgs e)
        {
            tileClanarina.Height -= 10;
            tileClanarina.Width -= 10;
        }

        private void tileClanarina_MouseLeave(object sender, EventArgs e)
        {
            tileClanarina.Height += 10;
            tileClanarina.Width += 10;
        }
    }
}
