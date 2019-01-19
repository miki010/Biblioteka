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
    public class PropertyIzdavac : PropertyInterface
    {


        #region Properties

        [DisplayName("Izdavac ID")]
        [SqlName("IzdavacID")]
        [PrimaryKey]
        [LookupKey]
        public int IzdavacID { get; set; }

        [DisplayName("Naziv izdavača")]
        [SqlName("Naziv")]
        [LookupValue]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string Naziv { get; set; }

        [DisplayName("Grad")]
        [SqlName("Grad")]
        public string Grad { get; set; }

        [DisplayName("Adresa")]
        [SqlName("Adresa")]
        public string Adresa { get; set; }

        [DisplayName("Br. Telefona")]
        [SqlName("Telefon")]
        public string Telefon { get; set; }

        [DisplayName("Email")]
        [SqlName("Email")]
        public string Email { get; set; }


        #endregion


        #region Querries

        public string GetSelectQuery()
        {
            return @"SELECT IzdavacID
                             ,Naziv
                             ,Grad
                             ,Adresa
                             ,Telefon
                             ,Email
                         FROM dbo.Izdavac";
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO dbo.Izdavac
                     (Naziv, Grad, Adresa, Telefon, Email)
                     VALUES 
                    (@Naziv, @Grad, @Adresa, @Telefon, @Email)";
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE dbo.Izdavac
                       SET Naziv = @Naziv
                          ,Grad = @Grad
                          ,Adresa = @Adresa
                          ,Telefon = @Telefon
                          ,Email = @Email
                     WHERE IzdavacID=@IzdavacID";
        }


        public string GetDeleteQuery()
        {
            return @"DELETE FROM dbo.Izdavac
                  WHERE IzdavacID=@IzdavacID";
        }

        #endregion



        #region Parameters

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Naziv", System.Data.SqlDbType.NVarChar);
                parameter.Value = Naziv;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@Grad", System.Data.SqlDbType.NVarChar);
                parameter.Value = Grad;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@Adresa", System.Data.SqlDbType.NVarChar);
                parameter.Value = Adresa;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@Telefon", System.Data.SqlDbType.VarChar);
                parameter.Value = Telefon;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                parameter.Value = Email;
                list.Add(parameter);
            }


            return list;
        }


        public List<SqlParameter> GetUpdateParameters()
        {

            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@IzdavacID", System.Data.SqlDbType.TinyInt);
                parameter.Value = IzdavacID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Naziv", System.Data.SqlDbType.NVarChar);
                parameter.Value = Naziv;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@Grad", System.Data.SqlDbType.NVarChar);
                parameter.Value = Grad;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@Adresa", System.Data.SqlDbType.NVarChar);
                parameter.Value = Adresa;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@Telefon", System.Data.SqlDbType.VarChar);
                parameter.Value = Telefon;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                parameter.Value = Email;
                list.Add(parameter);
            }


            return list;
        }


        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@IzdavacID", System.Data.SqlDbType.TinyInt);
                parameter.Value = IzdavacID;
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


        #endregion

    }
}
