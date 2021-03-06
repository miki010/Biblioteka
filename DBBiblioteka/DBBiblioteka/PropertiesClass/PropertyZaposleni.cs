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
    public class PropertyZaposleni : PropertyInterface
    {
        #region property

        [DisplayName("ID zaposlenog")]
        [SqlName("ZaposleniID")]
        [LookupKey]
        [PrimaryKey]
        public int ZaposleniID { get; set; }

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
        public string Telefon { get; set; }

        [DisplayName("Email")]
        [SqlName("Email")]
        public string Email { get; set; }

        [DisplayName("Datum zaposlenja")]
        [SqlName("DatumZaposlenja")]
        [DateTimeAttribute]
        public DateTime DatumZaposlenja { get; set; }

        [DisplayName("ID radnog mjesta")]
        [SqlName("RadnoMjestoID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKey("RadnoMjesto", "RadnoMjestoID", "DBBiblioteka.PropertiesClass.PropertyRadnoMjesto")]
        public int RadnoMjestoID { get; set; }

       

        #endregion

        #region Attributes
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            return list;
        } 

        public string GetDeleteQuery()
        {
            return @"DELETE FROM [dbo].[Zaposleni]
                        WHERE ZaposleniID = @ZaposleniID";
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
            {
                SqlParameter parameter = new SqlParameter("@Pol", System.Data.SqlDbType.NVarChar);
                parameter.Value = Pol;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumRodjenja", System.Data.SqlDbType.NVarChar);
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
                SqlParameter parameter = new SqlParameter("@Email", System.Data.SqlDbType.NVarChar);
                parameter.Value = Email;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumZaposlenja", System.Data.SqlDbType.NVarChar);
                parameter.Value = DatumZaposlenja;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RadnoMjestoID", System.Data.SqlDbType.NVarChar);
                parameter.Value = RadnoMjestoID;
                list.Add(parameter);
            }
           
            
            return list;
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO [dbo].[Zaposleni]
                           ([Ime]
                           ,[SrednjeIme]
                           ,[Prezime]
                           ,[Pol]
                           ,[DatumRodjenja]
                           ,[Adresa]
                           ,[Telefon]
                           ,[Email]
                           ,[DatumZaposlenja]
                           ,[RadnoMjestoID]
                           )
                     VALUES
                           (@Ime
                           ,@SrednjeIme
                           ,@Prezime
                           ,@Pol
                           ,@DatumRodjenja
                           ,@Adresa
                           ,@Telefon
                           ,@Email
                           ,@DatumZaposlenja
                           ,@RadnoMjestoID
                           )";
        }

        public string GetSelectQuery()
        {
            return @"SELECT [ZaposleniID]
                          ,[Ime]
                          ,[SrednjeIme]
                          ,[Prezime]
                          ,[Pol]
                          ,[DatumRodjenja]
                          ,[Adresa]
                          ,[Telefon]
                          ,[Email]
                          ,[DatumZaposlenja]
                          ,[RadnoMjestoID]
                          
                      FROM [Biblioteka].[dbo].[Zaposleni]";
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
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
                SqlParameter parameter = new SqlParameter("@Pol", System.Data.SqlDbType.NVarChar);
                parameter.Value = Pol;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumRodjenja", System.Data.SqlDbType.NVarChar);
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
                SqlParameter parameter = new SqlParameter("@Email", System.Data.SqlDbType.NVarChar);
                parameter.Value = Email;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumZaposlenja", System.Data.SqlDbType.NVarChar);
                parameter.Value = DatumZaposlenja;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RadnoMjestoID", System.Data.SqlDbType.NVarChar);
                parameter.Value = RadnoMjestoID;
                list.Add(parameter);
            }
         
            return list;
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE [dbo].[Zaposleni]
                       SET [Ime] = @Ime
                          ,[SrednjeIme] = @SrednjeIme
                          ,[Prezime] = @Prezime
                          ,[Pol] = @Pol
                          ,[DatumRodjenja] = @DatumRodjenja
                          ,[Adresa] = @Adresa
                          ,[Telefon] = @Telefon
                          ,[Email] = @Email
                          ,[DatumZaposlenja] = @DatumZaposlenja
                          ,[RadnoMjestoID] = @RadnoMjestoID
                          
                     WHERE ZaposleniID = @ZaposleniID";
        }

        //za login formu
        public List<SqlParameter> GetSelectParametersForLogin()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            return list;
        }

        public string GetSelectQueryForLogin()
        {
            return @"SELECT *
                      FROM [Biblioteka].[dbo].[Zaposleni]";
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
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            return list;
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
            return @"EXEC [dbo].[sp.Radnik] @ZaposleniID";
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
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            return list;
        }

        public string GetProcedureMozeLiSeDici()
        {
            throw new NotImplementedException();
        }

        public string GetProcedureKnjigaNaStanju()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
