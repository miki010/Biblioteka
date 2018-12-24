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
    class PropertyAutorKnjiga : PropertyInterface
    {
        #region attributes
        [DisplayName("Autor knjiga ID")]
        [SqlName("AutorKnjigaID")]
        [PrimaryKey]
        public int AutorKnjigaID { get; set; }

        [DisplayName("Knjiga ID")]
        [SqlName("KnjigaID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKey("Knjiga", "KnjigaID", "DBBiblioteka.PropertiesClass.PropertyKnjiga")]
        public int KnjigaID { get; set; }

        [DisplayName("Autor ID")]
        [SqlName("AutorID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKey("Autor", "AutorID", "DBBiblioteka.PropertiesClass.PropertyAutor")]
        public int AutorID { get; set; }

        #endregion



        public string GetSelectQuery()
        {
        return @"SELECT[AutorKnjigaID]
                            ,[KnjigaID]
                            ,[AutorID]
                FROM[dbo].[AutorKnjiga]";
    }

        public string GetInsertQuery()
        {
            return @"INSERT INTO [dbo].[AutorKnjiga]
                   ([KnjigaID]
                   ,[AutorID])
                    VALUES
                    (@KnjigaID, @AutorID)";
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE  [dbo].[AutorKnjiga]
                    (SET KnjigaID=@KnjigaID, AutorID=@AutorID where AutorKnjigaID=@AutorKnigaID ";
        }

        public string GetDeleteQuery()
        {
            return @"DELETE FROM dbo.AutorKnjiga where AutorKnjigaID=@AutorKnjigaID";
        }



        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();

            {
                SqlParameter parameter = new SqlParameter("@KnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = KnjigaID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@AutorID", System.Data.SqlDbType.SmallInt);
                parameter.Value = AutorID;
                list.Add(parameter);
            }
          


            return list;
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@AutorKnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = AutorKnjigaID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@KnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = KnjigaID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@AutorID", System.Data.SqlDbType.SmallInt);
                parameter.Value = AutorID;
                list.Add(parameter);
            }
           


            return list;
        }

        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@AutorKnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = AutorKnjigaID;
                list.Add(parameter);
            }

            return list;
        }
    }
}
