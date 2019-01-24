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
    public class PropertyLogin : PropertyInterface
    {
        [DisplayName("ID")]
        [SqlName("ID")]
        [PrimaryKey]
        public int ID { get; set; }

        [DisplayName("Zaposleni ID")]
        [SqlName("ZaposleniID")]
        public int ZaposleniID { get; set; }

        [DisplayName("Korisnicko ime")]
        [SqlName("KorisnickoIme")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string KorisnickoIme { get; set; }

        [DisplayName("Lozinka")]
        [SqlName("Lozinka")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string Lozinka { get; set; }

        [DisplayName("ID radnog mjesta")]
        [SqlName("RadnoMjestoID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKeyAttribute("RadnoMjesto", "RadnoMjestoID", "DBBiblioteka.PropertiesClass.PropertyRadnoMjesto")]
        public string RadnoMjestoID { get; set; }

        public List<SqlParameter> GetLoginParameters()
        {
            throw new NotImplementedException();
        }


        public string GetLoginQuery()
        {
            return @"SELECT ZaposleniID , KorisnickoIme, Lozinka FROM dbo.PristupniPodaci";
        }


        public string GetInsertQuery()
        {
            return @"EXEC [dbo].[proc_PristupniPodaci] @ZaposleniID, @KorisnickoIme, @RadnoMjestoID";
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

        public string GetSelectQuery()
        {
            return @"SELECT KorisnickoIme FROM dbo.PristupniPodaci";
        }

        public string GetUpdateQuery()
        {
            throw new NotImplementedException();
        }

        public string GetDeleteQuery()
        {
            throw new NotImplementedException();
        }

        public string GetSelectPregledClanarinePoClanovima()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureSelectAutor()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureSelectIzdavac()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureSelectAllDetails()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureStatusClanarineZaClanID()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureUpdateKnjiga()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetInsertParameters()
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
                SqlParameter parameter = new SqlParameter("@RadnoMjestoID", System.Data.SqlDbType.TinyInt);
                parameter.Value = RadnoMjestoID;
                list.Add(parameter);
            }

            return list;
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetDeleteParameters()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetSelectPregledClanarinePoClanovimaParameters()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetProcedureParameters()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetProcedureParametersClanID()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureUpdateKnjigaVrati()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetProcedureParametersIznajmljivanjeID()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureMozeLiSeDici()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureKnjigaNaStanju()
        {
            throw new NotImplementedException();
        }
    }
}
