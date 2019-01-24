
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBBiblioteka.Helper;
using DBBiblioteka.PropertiesClass;

namespace DBBiblioteka
{
    public partial class FormAdmin : MetroFramework.Forms.MetroForm
    {
        PropertyLogin myProperty = new PropertyLogin();
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
            lblPogresnaStara.Visible = false;
            lblUpozorenje.Visible = false;
            txtTrenutnaLozinka.Focus();
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

        private void txtTrenutnaLozinka_TextChanged(object sender, EventArgs e)
        {
            lblPogresnaStara.Visible = false;
        }

        private void txtNovaLozinka_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenje.Visible = false;
        }

        private void txtPotvrdiLozinku_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenje.Visible = false;
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
