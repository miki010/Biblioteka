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

namespace DBBiblioteka
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        PropertyLogin myProperty = new PropertyLogin();
        PropertyZaposleni propertyZaposleni = new PropertyZaposleni();
        

        public FormLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Login();
            
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

                string pass = getHashSha256(txtPassword.Text);
                //MessageBox.Show(sifra, "iz baze", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show(pass, "iz txt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                try
                {
                    using (StreamWriter sw = new StreamWriter("sha256.txt"))
                    {
                        string z = pass;
                       
                        sw.WriteLine(z);

                    }
                }
                catch (Exception e)
                {

                    MessageBox.Show("Greska!");
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
                    else if (idProsao == zaposleniID && idRadnogMjesta == 2)
                    {
                        FormBlagajnik formBlagajnik = new FormBlagajnik();
                        formBlagajnik.Show();
                       
                    }
                    else if (idProsao == zaposleniID && idRadnogMjesta == 3)
                    {
                        FormBibliotekar formBibliotekar = new FormBibliotekar();
                        formBibliotekar.Show();
                        
                    }
                    this.Hide();
                    txtPassword.Clear();
                    txtUserName.Clear();
                }   
            }
            else if (prosaoIme)
            {
                //MessageBox.Show("Pogresna lozinka");
                lblInvalid.Visible = true;
                txtPassword.Clear();
            }
            else if (nijeProsaoIme)
            {
                MessageBox.Show("Uneseno korisnicko ime ne postoji u bazi!");//
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
            if (MessageBox.Show("Da li ste sigurni da želite da napustite aplikaciju?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
