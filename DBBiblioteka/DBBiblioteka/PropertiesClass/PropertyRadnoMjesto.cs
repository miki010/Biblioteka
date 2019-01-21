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
    public class PropertyRadnoMjesto : PropertyInterface
    {
        #region property

        [DisplayName("ID radnog mjesta")]
        [SqlName("RadnoMjestoID")]
        [PrimaryKey]
        [LookupKey]
        public int RadnoMjestoID { get; set; }

        [DisplayName("Naziv")]
        [SqlName("Naziv")]
        [LookupValue]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string Naziv { get; set; }

        #endregion

        #region Attributes
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RadnoMjestoID", System.Data.SqlDbType.Int);
                parameter.Value = RadnoMjestoID;
                list.Add(parameter);
            }
            return list;
        }

        public string GetDeleteQuery()
        {
            return @"DELETE FROM [dbo].[RadnoMjesto]
                        WHERE RadnoMjestoID = @RadnoMjestoID";
        }

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Naziv", System.Data.SqlDbType.NVarChar);
                parameter.Value = Naziv;
                list.Add(parameter);
            }
            return list;
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO [dbo].[RadnoMjesto]
                           ([Naziv])
                     VALUES
                           (@Naziv)";
        }

        public List<SqlParameter> GetProcedureParameters()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureSelectAllDetails()
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

        public string GetProcedureUpdateKnjiga()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetProcedureUpdateParameters()
        {
            throw new NotImplementedException();
        }

        public string GetSelectPregledClanarinePoClanovima()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetSelectPregledClanarinePoClanovimaParameters()
        {
            throw new NotImplementedException();
        }

        public string GetSelectQuery()
        {
            return @"SELECT [RadnoMjestoID]
                          ,[Naziv]
                      FROM [Biblioteka].[dbo].[RadnoMjesto]";
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RadnoMjestoID", System.Data.SqlDbType.Int);
                parameter.Value = RadnoMjestoID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Naziv", System.Data.SqlDbType.NVarChar);
                parameter.Value = Naziv;
                list.Add(parameter);
            }
            return list;
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE [dbo].[RadnoMjesto]
                       SET [Naziv] = @Naziv
                     WHERE RadnoMjestoID = @RadnoMjestoID";
        } 
        #endregion
    }
}
