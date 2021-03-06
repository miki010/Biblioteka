﻿using DBBiblioteka.AtributesClass;
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
   public class PropertyClan : PropertyInterface
    {
        #region attributes
        [DisplayName("Član ID")]
        [SqlName("ClanID")]
        [PrimaryKey]
        [LookupKey]
        public int ClanID { get; set; }

        [DisplayName("Broj legitimacije")]
        [SqlName("BrojLegitimacije")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string BrojLegitimacije { get; set; }

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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string Prezime { get; set; }

        [DisplayName("Pol")]
        [SqlName("Pol")]
        [RadioValue]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public char Pol { get; set; }


        [DisplayName("Datum rođenja")]
        [SqlName("DatumRodjenja")]
        [DateTimeAttribute]
        public DateTime DatumRodjenja { get; set; }


        [DisplayName("Adresa")]
        [SqlName("Adresa")]
        public string Adresa { get; set; }

        [DisplayName("Telefon")]
        [SqlName("Telefon")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string Telefon { get; set; }

        [DisplayName("Email")]
        [SqlName("Email")]
        public string Email { get; set; }

        [DisplayName("Datum učlanjenja")]
        [SqlName("DatumUclanjenja")]
        [DateTimeAttribute]
        public DateTime DatumUclanjenja { get; set; }



        #endregion



        public string GetSelectQuery()
        {
            return @"SELECT [ClanID]
                      ,[BrojLegitimacije]
                      ,[Ime]
                      ,[SrednjeIme]
                      ,[Prezime]
                      ,[Pol]
                      ,[DatumRodjenja]
                      ,[Adresa]
                      ,[Telefon]
                      ,[Email]
                      ,[DatumUclanjenja]
                  FROM [dbo].[Clan]";
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO [dbo].[Clan]
                   ([BrojLegitimacije] 
                   ,[Ime]  
                   ,[SrednjeIme]
                   ,[Prezime]
                   ,[Pol]
                   ,[DatumRodjenja]
                   ,[Adresa]
                   ,[Telefon]
                   ,[Email]
                   ,[DatumUclanjenja])
                    VALUES
                    (@BrojLegitimacije, @Ime, @SrednjeIme, @Prezime, @Pol, @DatumRodjenja, @Adresa, @Telefon, @Email, @DatumUclanjenja)";
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE  [dbo].[Clan]
                    SET BrojLegitimacije=@BrojLegitimacije, Ime=@Ime, SrednjeIme=@SrednjeIme, Prezime=@Prezime, Pol=@Pol, DatumRodjenja=@DatumRodjenja, Adresa=@Adresa,
                    Telefon = @Telefon, Email = @Email, DatumUclanjenja = @DatumUclanjenja where ClanID=@ClanID ";
        }

        public string GetDeleteQuery()
        {
            return @"DELETE FROM dbo.Clan where ClanID=@ClanID";
        }



        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@BrojLegitimacije", System.Data.SqlDbType.VarChar);
                parameter.Value = BrojLegitimacije;
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
            {
                SqlParameter parameter = new SqlParameter("@Pol", System.Data.SqlDbType.Char);
                parameter.Value = Pol;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumRodjenja", System.Data.SqlDbType.Date);
                parameter.Value = DatumRodjenja;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Adresa", System.Data.SqlDbType.NVarChar);
                parameter.Value = Adresa;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Telefon", System.Data.SqlDbType.NVarChar);
                parameter.Value = Telefon;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                parameter.Value = Email;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumUclanjenja", System.Data.SqlDbType.Date);
                parameter.Value = DatumUclanjenja;
                list.Add(parameter);
            }
            return list;
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();


            {
                SqlParameter parameter = new SqlParameter("@ClanID", System.Data.SqlDbType.Int);
                parameter.Value = ClanID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@BrojLegitimacije", System.Data.SqlDbType.VarChar);
                parameter.Value = BrojLegitimacije;
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
            {
                SqlParameter parameter = new SqlParameter("@Pol", System.Data.SqlDbType.Char);
                parameter.Value = Pol;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumRodjenja", System.Data.SqlDbType.Date);
                parameter.Value = DatumRodjenja;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Adresa", System.Data.SqlDbType.NVarChar);
                parameter.Value = Adresa;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Telefon", System.Data.SqlDbType.NVarChar);
                parameter.Value = Telefon;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                parameter.Value = Email;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumUclanjenja", System.Data.SqlDbType.Date);
                parameter.Value = DatumUclanjenja;
                list.Add(parameter);
            }
            return list;
        }

        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ClanID", System.Data.SqlDbType.Int);
                parameter.Value = ClanID;
                list.Add(parameter);
            }

            return list;
        }

        public string GetSelectPregledClanarinePoClanovima()
        {
            return @"EXEC sp_PregledClanarinePoClanovima @BrojLegitimacije";
        }

        public List<SqlParameter> GetSelectPregledClanarinePoClanovimaParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@BrojLegitimacije", System.Data.SqlDbType.VarChar);
                parameter.Value = BrojLegitimacije;
                list.Add(parameter);
            }

            return list;
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
