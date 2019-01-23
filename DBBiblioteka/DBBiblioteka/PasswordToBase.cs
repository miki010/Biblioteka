using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DBBiblioteka.Helper;
using DBBiblioteka.PropertiesClass;
using System.Windows;

namespace DBBiblioteka
{
    public sealed class PasswordToBase
    {
        static PasswordToBase()
        {

        }

        private PasswordToBase()
        {

        }

        public static PasswordToBase GetInstance { get; } = new PasswordToBase();


        public static void NewPasswordToBase(string ZapoleniID, string lozinka)
        {    
           string queryString = "UPDATE [dbo].[PristupniPodaci] SET [Lozinka] = NovaLozinka WHERE ZaposleniID = IDZaposlenog";
            queryString = queryString.Replace("NovaLozinka", "'"+lozinka+"'");
            queryString = queryString.Replace("IDZaposlenog", ZapoleniID);

            using (SqlConnection connection = new SqlConnection(
                       SqlHelper.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
    }

}


