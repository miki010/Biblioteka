﻿using System;
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
            lblImeZaposlenog.Text = ime.ToString() + " " + prezime.ToString();
            tileProfile.UseTileImage = true;
            if (pol == "M")
            {
                tileProfile.TileImage = DBBiblioteka.Properties.Resources.user_man_profile;
            }
            else if (pol == "Z" || pol == "Ž")
            {
                tileProfile.TileImage = DBBiblioteka.Properties.Resources.edit_woman_profile;
            }
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


        private void tileSacuvajIzmjene_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Focus();
            string staraLozinka = "";
            string novaLozinka = txtNovaLozinka.Text.Trim();
            string potvrdiLozinku = txtPotvrdiLozinku.Text.Trim();

            DataTable dt = new DataTable();

            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                myProperty.GetLoginQuery());

            dt.Load(reader);
            reader.Close();
            bool idProsao = false;

            if (txtTrenutnaLozinka.Text != "" && txtNovaLozinka.Text != "" && txtPotvrdiLozinku.Text != "")
            {
                foreach (DataRow row in dt.Rows)
                {
                    // string idZaposlenog = FormLogin.idZaposlenog;

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
                    MessageBox.Show("Pogresna trenutna lozinka");
                    txtTrenutnaLozinka.Text = "";
                    txtTrenutnaLozinka.Focus();
                }

                else
                {
                    if (staraLozinka != txtTrenutnaLozinka.Text)
                    {
                        MessageBox.Show("Lozinka iz baze se ne poklapa sa trenutnom unešenom lozinkom!");
                        //   txtNovaLozinka.Text = "";
                        txtNovaLozinka.Focus();
                    }
                    else if (staraLozinka == txtTrenutnaLozinka.Text)
                    {
                        // MessageBox.Show("Trenutna se poklapa sa lozinkom iz baze " + txtTrenutnaLozinka.Text);
                        if (txtNovaLozinka.Text == txtTrenutnaLozinka.Text)
                        {
                            MessageBox.Show("Lozinka je vec u upotrebi! Pokušajte ponovo!");
                        }
                        else if (txtNovaLozinka.Text == txtPotvrdiLozinku.Text)
                        {
                            string zaposleniID = FormLogin.idZaposlenog;
                            string Lozinka = txtNovaLozinka.Text.Trim();

                            PasswordToBase.NewPasswordToBase(zaposleniID, Lozinka);

                            MessageBox.Show("Uspješno ste promijenili lozinku!");
                            resetujPolja();
                            panelPromjenaLozinke.Visible = false;

                        }

                        else
                        {
                            MessageBox.Show("Nova i ponovljena lozinka se ne poklapaju!");
                            txtPotvrdiLozinku.Text = "";
                            txtPotvrdiLozinku.Focus();

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                //staviti fokuse
                if (txtTrenutnaLozinka.Text == "")
                {
                    txtTrenutnaLozinka.Focus();
                }
                if (txtNovaLozinka.Text == "")
                {
                    txtNovaLozinka.Focus();
                }
                if (txtPotvrdiLozinku.Text == "")
                {
                    txtPotvrdiLozinku.Focus();
                }
            }

        }

        private void tileProfile_Click(object sender, EventArgs e)
        {
            panelPromjenaLozinke.Visible = true;
            panelPromjenaLozinke.BringToFront();
            txtTrenutnaLozinka.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetujPolja();
            panelPromjenaLozinke.Visible = false;
        }

        private void resetujPolja()
        {
            txtNovaLozinka.Text = "";
            txtTrenutnaLozinka.Text = "";
            txtPotvrdiLozinku.Text = "";
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
