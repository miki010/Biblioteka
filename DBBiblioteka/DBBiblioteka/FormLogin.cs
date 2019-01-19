using DBBiblioteka.Helper;
using DBBiblioteka.PropertiesClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Windows.Controls;

namespace DBBiblioteka
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        PropertyLogin myProperty = new PropertyLogin();
        PropertyZaposleni propertyZaposleni = new PropertyZaposleni();
        public static string idZaposlenog = "";



        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            txtPassword.UseSystemPasswordChar = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //prije poziva f-je provjerava da li su oba polja popunjena
            
            
            if(!txtUserName.Text.Trim().Equals("") && !txtPassword.Text.Trim().Equals(""))
            {
                Login();

                lblInvalid.Visible = false;
                lblUName.Visible = false;
            }
            else if (txtUserName.Text.Trim().Equals(""))
            {
                lblUName.Visible = true;
                lblUName.Text = "Polje je obavezno za unos!";
                lblUName.ForeColor = Color.Red;
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
                lblInvalid.Visible = true;
                lblInvalid.Text = "Polje je obavezno za unos!";
            }

            
        }

        private void Login()
        { 
            
            //uzima podatke iz tabele PristupniPodaci sa kojima se vrsi poredjenje unesenih podataka
            DataTable dt = new DataTable();

            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                myProperty.GetLoginQuery());

            dt.Load(reader);
            reader.Close();

            bool prosaoIme = false;
            bool nijeProsaoIme = false;
            bool prosao = false;
            string idProsao = "";

            foreach (DataRow row in dt.Rows)
            {
                string ime = row["KorisnickoIme"].ToString();
                string sifra = row["Lozinka"].ToString();
                string id = row["ZaposleniID"].ToString();
                idZaposlenog = id; //koristi se za pracenje ko se prijavio u sistem
                string pass = getHashSha256(txtPassword.Text);                

                try
                {
                    using (StreamWriter sw = new StreamWriter("sha256.txt"))
                    {
                        string z = pass;
                       
                        sw.WriteLine(z);

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Greška!", "Upozorenje!");
                }

                if (ime == txtUserName.Text)
                {
                    //if (sifra == getHashSha256(txtPassword.Text)) //==
                    if (sifra == txtPassword.Text) //==
                    {
                        prosao = true;//dobar username i pass   
                        idProsao = id;
                        
                        break;
                    }
                    else if (!sifra.Equals(txtPassword.Text)) //!=
                    {
                        prosaoIme = true;//dobar username   
                        break;
                    }
                    nijeProsaoIme = false;
                }

                if (ime != txtUserName.Text)
                {
                    nijeProsaoIme = true;//pogrsan username   
                }
            }

            if (prosao)
            {
                DataTable dt2 = new DataTable();
                SqlDataReader reader2 = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                    propertyZaposleni.GetSelectQueryForLogin());

                dt2.Load(reader2);
                reader2.Close();
                
                foreach (DataRow row in dt2.Rows)
                {
                    
                    string zaposleniID = row["ZaposleniID"].ToString();
                    int idRadnogMjesta = Convert.ToInt32(row["RadnoMjestoID"]);

                    if (idProsao == zaposleniID && idRadnogMjesta == 1)
                    {
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.Show();
                       
                    }
                    else if (idProsao == zaposleniID && idRadnogMjesta == 4)
                    {
                        FormBlagajnik formBlagajnik = new FormBlagajnik();
                        formBlagajnik.Show();
                       
                    }
                    else if (idProsao == zaposleniID && idRadnogMjesta == 3)
                    {
                        FormBibliotekar formBibliotekar = new FormBibliotekar();
                        formBibliotekar.Show();
                        
                    }
                    //this.Hide();
                    txtPassword.Clear();
                    txtUserName.Clear();
                }   
            }
            else if (prosaoIme)
            {
                MessageBox.Show("Pogrešna lozinka!", "Obavještenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblInvalid.Visible = true;
                txtPassword.Clear();
            }
            else if (nijeProsaoIme)
            {
                MessageBox.Show("Unešeno korisničko ime ne postoji!", "Obavještenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);//
                txtPassword.Clear();
                txtUserName.Clear();
            }        
        }

        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite napustiti aplikaciju?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblInvalid.Visible = false;

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblUName.Visible = false;

        }

        private void togglePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (togglePassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
