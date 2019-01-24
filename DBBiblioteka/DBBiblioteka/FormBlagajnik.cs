using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBBiblioteka.Helper;
using DBBiblioteka.PropertiesClass;
using MetroFramework;
using MetroFramework.Forms;

namespace DBBiblioteka
{
    public partial class FormBlagajnik : MetroFramework.Forms.MetroForm
    {

        PropertyLogin myProperty = new PropertyLogin();
        string ime, prezime, srednjeIme, pol;

        public FormBlagajnik()
        {
            InitializeComponent();
        }

        public FormBlagajnik(string ime, string srednjeIme, string prezime, string pol)
        {
            InitializeComponent();
            this.ime = ime;
            this.prezime = prezime;
            this.srednjeIme = srednjeIme;
            this.pol = pol;
            this.ControlBox = false;
            tileDodajClanarinu.BringToFront();
            tileIzvjestaj.BringToFront();
            tilePregledClanarina.BringToFront();
            tileTipClanarine.BringToFront();
            panelPromjenaLozinke.Visible = false;
        }

        private void FormBlagajnik_Load(object sender, EventArgs e)
        {
            lblImeZaposlenog.Text = ime.ToString() + " "  +srednjeIme.ToString() + " " + prezime.ToString();
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

        private void tileDodajClanarinu_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyClanarina());
            formStandard.tileObrisi.Enabled = false;
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
        string korisnik = "blagajnik";

        private void tileIzvjestaj_Click(object sender, EventArgs e)
        {
            
            Report1 rpt = new Report1(korisnik);
            rpt.ShowDialog();
        }

        private void tilePregledClanarina_Click(object sender, EventArgs e)
        {
            FormStandard formStandard = new FormStandard(new PropertyTipClanarine());
            formStandard.ShowDialog();
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

        private void tileProfile_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Visible = true;
            panelPromjenaLozinke.BringToFront();
            lblPogresnaStara.Visible = false;
            lblUpozorenje.Visible = false;
            txtTrenutnaLozinka.Focus();
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

        private void tileProfile_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show("Promijeni lozinku?", tileProfile);
        }

        private void tileLogout_MouseHover(object sender, EventArgs e)
        {
            metroToolTip2.Show("Odjava?", tileLogout);
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
