using DBBiblioteka.AtributesClass;
using DBBiblioteka.AttributesClass;
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
   public class PropertyIzdavacKnjiga:PropertyInterface
    {


        #region Properties

        [DisplayName("IzdavacKnjigaID")]
        [SqlName("IzdavacKnjigaID")]
        [PrimaryKey]
        public int IzdavacKnjigaID { get; set; }

        [DisplayName("Knjiga ID")]
        [SqlName("KnjigaID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKey("Knjiga", "KnjigaID", "DBBiblioteka.PropertyKnjiga")]
        public int KnjigaID { get; set; }

        [DisplayName("IzdavacID")]
        [SqlName("IzdavacID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKey("IzdavacID", "IzdavacID", "DBBiblioteka.PropertyIzdavac")]
        public int IzdavacID { get; set; }
     

        [DisplayName("Kolicina")]
        [SqlName("Kolicina")]
        [DateTimeAttribute]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public DateTime Kolicina { get; set; }


        #endregion


        #region Querries

        public string GetSelectQuery()
        {
            return @"SELECT IzdavacKnjigaID
                              ,KnjigaID
                              ,IzdavacID
                              ,Kolicina
                          FROM dbo.IzdavacKnjiga";
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO dbo.IzdavacKnjiga
                           ,KnjigaID
                           ,IzdavacID
                           ,Kolicina)
                     VALUES
                           (@KnjigaID
                           ,@IzdavacID
                           ,@Kolicina)";
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE dbo.IzdavacKnjiga
                       SET KnjigaID
                          ,IzdavacID
                          ,Kolicina
                     WHERE IzdavacKnjigaID=@IzdavacKnjigaID";
        }


        public string GetDeleteQuery()
        {
            return @"DELETE FROM dbo.IzdavacKnjiga
                  WHERE IzdavacKnjigaID=@IzdavacKnjigaID";
        }

        #endregion



        #region Parameters

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@KnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = KnjigaID;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@IzdavacID", System.Data.SqlDbType.TinyInt);
                parameter.Value = IzdavacID;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@Kolicina", System.Data.SqlDbType.SmallInt);
                parameter.Value = Kolicina;
                list.Add(parameter);
            }

          
            return list;
        }


        public List<SqlParameter> GetUpdateParameters()
        {

            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@IzdavacKnjigaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = IzdavacKnjigaID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@KnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = KnjigaID;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@IzdavacID", System.Data.SqlDbType.TinyInt);
                parameter.Value = IzdavacID;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@Kolicina", System.Data.SqlDbType.SmallInt);
                parameter.Value = Kolicina;
                list.Add(parameter);
            }

          
            return list;
        }


        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@IzdavacKnjigaID", System.Data.SqlDbType.SmallInt);
                parameter.Value = IzdavacKnjigaID;
                list.Add(parameter);
            }

            return list;
        }


        #endregion
    }
}
