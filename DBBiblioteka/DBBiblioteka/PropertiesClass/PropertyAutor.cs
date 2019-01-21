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
   public class PropertyAutor : PropertyInterface
    {

        #region attributes
        [DisplayName("Autor ID")]
        [SqlName("AutorID")]
        [LookupKey]
        [PrimaryKey]
        public int AutorID { get; set; }

        [DisplayName("Ime")]
        [SqlName("Ime")]
        [LookupValue]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string Ime { get; set; }

        [DisplayName("Srednje ime")]
        [SqlName("SrednjeIme")]
        [LookupValue]
        public string SrednjeIme { get; set; }

        [DisplayName("Prezime")]
        [SqlName("Prezime")]
        [LookupValue]
        public string Prezime { get; set; }



        #endregion



        public string GetSelectQuery()
        {
            return @"SELECT [AutorID]
                      ,[Ime]
                      ,[SrednjeIme]
                      ,[Prezime]
                      FROM [dbo].[Autor]";
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO [dbo].[Autor]
                   ([Ime]
                   ,[SrednjeIme]
                   ,[Prezime])
                    VALUES
                    (@Ime, @SrednjeIme, @Prezime)";
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE  [dbo].[Autor]
                    SET Ime=@Ime, SrednjeIme=@SrednjeIme, Prezime=@Prezime where AutorID=@AutorID ";
        }

        public string GetDeleteQuery()
        {
            return @"DELETE FROM dbo.Autor where AutorID=@AutorID";
        }

      

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();

            {
                SqlParameter parameter = new SqlParameter("@Ime", System.Data.SqlDbType.NVarChar);
                parameter.Value = Ime;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SrednjeIme", System.Data.SqlDbType.NVarChar);
                parameter.Value = SrednjeIme;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Prezime", System.Data.SqlDbType.NVarChar);
                parameter.Value = Prezime;
                list.Add(parameter);
            }
           

            return list;
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@AutorID", System.Data.SqlDbType.SmallInt);
                parameter.Value = AutorID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Ime", System.Data.SqlDbType.NVarChar);
                parameter.Value = Ime;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SrednjeIme", System.Data.SqlDbType.NVarChar);
                parameter.Value = SrednjeIme;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Prezime", System.Data.SqlDbType.NVarChar);
                parameter.Value = Prezime;
                list.Add(parameter);
            }
           

            return list;
        }

        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@AutorID", System.Data.SqlDbType.SmallInt);
                parameter.Value = AutorID;
                list.Add(parameter);
            }

            return list;
        }

        public string GetSelectPregledClanarinePoClanovima()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetSelectPregledClanarinePoClanovimaParameters()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureSelectAutor()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetProcedureParameters()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureSelectIzdavac()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureUpdateKnjiga()
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
    }
}
