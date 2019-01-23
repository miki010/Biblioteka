using DBBiblioteka.AtributesClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBiblioteka.PropertiesClass
{
    public class PropertyLogin
    {
        [SqlName("ID")]
        [PrimaryKey]
        public int ID { get; set; }

        [SqlName("ZaposleniID")]
        public int ZaposleniID { get; set; }

        [SqlName("KorisnickoIme")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string KorisnickoIme { get; set; }

        [SqlName("Lozinka")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string Lozinka { get; set; }

        public List<SqlParameter> GetLoginParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@KorisnickoIme", System.Data.SqlDbType.VarChar);
                parameter.Value = KorisnickoIme;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Lozinka", System.Data.SqlDbType.VarChar);
                parameter.Value = Lozinka;
                list.Add(parameter);
            }

            return list;
        }


        public string GetLoginQuery()
        {
            return @"SELECT ZaposleniID , KorisnickoIme, Lozinka FROM dbo.PristupniPodaci";
        }


        public List<SqlParameter> GetSelectNewPasswordParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();        
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Lozinka", System.Data.SqlDbType.VarChar);
                parameter.Value = Lozinka;
                list.Add(parameter);
            }
            return list;
        }
        public string GetSelectNewPassword()
        {
            return @"UPDATE [dbo].[PristupniPodaci]
                     SET 
                         [Lozinka] = @Lozinka
                     WHERE ZaposleniID=@ZaposleniID";
        }

    }
}
