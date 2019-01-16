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
    public class PropertyKnjiga : PropertyInterface
    {
        #region property

        [DisplayName("Knjiga ID")]
        [SqlName("KnjigaID")]
        [PrimaryKey]
        [LookupKey]
        public int KnjigaID { get; set; }

        [DisplayName("Šifra knjige")]
        [SqlName("Sifra")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string Sifra { get; set; }

        [DisplayName("Naziv")]
        [SqlName("Naziv")]
        [LookupValue]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string Naziv { get; set; }

        [DisplayName("Količina")]
        [SqlName("Kolicina")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public int Kolicina { get; set; }

        [DisplayName("Žanr")]
        [SqlName("Zanr")]
        public string Zanr { get; set; }
 
        #endregion


        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@KnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = KnjigaID;
                list.Add(parameter);
            }
            return list;
        }

        public string GetDeleteQuery()
        {
            return @"DELETE FROM [dbo].[Knjiga]
                        WHERE KnjigaID = @KnjigaID";
        }

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Sifra", System.Data.SqlDbType.Char);
                parameter.Value = Sifra;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Naziv", System.Data.SqlDbType.NVarChar);
                parameter.Value = Naziv;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Kolicina", System.Data.SqlDbType.SmallInt);
                parameter.Value = Kolicina;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Zanr", System.Data.SqlDbType.Char);
                parameter.Value = Zanr;
                list.Add(parameter);
            }
           

            return list;
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO [dbo].[Knjiga]
                           ([Sifra]
                           ,[Naziv]
                           ,[Kolicina]
                           ,[Zanr])
                     VALUES
                           (@Sifra
                           ,@Naziv
                           ,@Kolicina
                           ,@Zanr";
        }

        

        public string GetSelectQuery()
        {
            return @"SELECT [KnjigaID]
                          ,[Sifra]
                          ,[Naziv]
                          ,[Kolicina]
                          ,[Zanr]
                      FROM [Biblioteka].[dbo].[Knjiga]";
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@KnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = KnjigaID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Sifra", System.Data.SqlDbType.Char);
                parameter.Value = Sifra;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Naziv", System.Data.SqlDbType.NVarChar);
                parameter.Value = Naziv;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Kolicina", System.Data.SqlDbType.SmallInt);
                parameter.Value = Kolicina;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Zanr", System.Data.SqlDbType.Char);
                parameter.Value = Zanr;
                list.Add(parameter);
            }


            return list;
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE [dbo].[Knjiga]
                       SET [Sifra] = @Sifra
                          ,[Naziv] = @Naziv
                          ,[Kolicina] = @Kolicina
                          ,[Zanr] = @Zanr
                     WHERE KnjigaID = @KnjigaID";
        }

        public List<SqlParameter> GetProcedureParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@KnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = KnjigaID;
                list.Add(parameter);
            }
            return list;
        }
        public string GetProcedureSelectAutor()
        {
            return @"EXEC sp_KnjigaAutor @KnjigaID";
        }

        public string GetSelectPregledClanarinePoClanovima()
        {
            throw new NotImplementedException();

        }
        public List<SqlParameter> GetSelectPregledClanarinePoClanovimaParameters()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureSelectIzdavac()
        {
            return @"EXEC sp_KnjigaIzdavac @KnjigaID";
        }

        public string GetProcedureUpdateKnjiga()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureSelectAllDetails()
        {
            throw new NotImplementedException();
        }
    }
}
