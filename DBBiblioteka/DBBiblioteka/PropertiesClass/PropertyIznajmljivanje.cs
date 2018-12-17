﻿using DBBiblioteka.AtributesClass;
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
    public class PropertyIznajmljivanje : PropertyInterface
    {
        #region attributes

        [DisplayName("Izmajmljivanje ID")]
        [SqlName("IznajmljivanjeID")]
        [PrimaryKey]
        public int IznajmljivanjeID { get; set; }

        [DisplayName("Član ID")]
        [SqlName("ClanID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKeyAttribute("Clan", "ClanID", "DBBiblioteka.PropertyClan")]
        public int ClanID { get; set; }

        [DisplayName("Knjiga ID")]
        [SqlName("KnjigaID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKeyAttribute("Knjiga", "KnjigaID", "DBBiblioteka.PropertyKnjiga")]
        public int KnjigaID { get; set; }

        [DisplayName("Zaposleni ID")]
        [SqlName("ZaposleniID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKeyAttribute("Zaposleni", "ZaposleniID", "DBBiblioteka.PropertyZaposleni")]
        public int ZaposleniID { get; set; }

        [DisplayName("Datum iznajmljivanja")]
        [SqlName("DatumIznajmljivanja")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public DateTime DatumIznajmljivanja { get; set; }

        [DisplayName("Datum razduživanja")]
        [SqlName("DatumRazduzivanja")]
        public DateTime DatumRazduzivanja { get; set; }

    #endregion


    public List<SqlParameter> GetDeleteParameters()
        {
            throw new NotImplementedException();
        }

        public string GetDeleteQuery()
        {
            throw new NotImplementedException();
        }

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ClanID", System.Data.SqlDbType.Int);
                parameter.Value = ClanID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@KnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = KnjigaID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumIznajmljivanja", System.Data.SqlDbType.Date);
                parameter.Value = DatumIznajmljivanja;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumRazduzivanja", System.Data.SqlDbType.Date);
                parameter.Value = DatumRazduzivanja;
                list.Add(parameter);
            }
            
            return list;
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO [dbo].[Iznajmljivanje]
                           ([ClanID]
                           ,[KnjigaID]
                           ,[ZaposleniID]
                           ,[DatumIznajmljivanja]
                           ,[DatumRazduzivanja])
                     VALUES
                           (@ClanID
                           ,@KnjigaID
                           ,@ZaposleniID
                           ,@DatumIznajmljivanja
                           ,@DatumRazduzivanja)";
        }

        public string GetSelectQuery()
        {
            return @"SELECT [IznajmljivanjeID]
                          ,[ClanID]
                          ,[KnjigaID]
                          ,[ZaposleniID]
                          ,[DatumIznajmljivanja]
                          ,[DatumRazduzivanja]
                      FROM [Biblioteka].[dbo].[Iznajmljivanje]";
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@IznajmljivanjeID", System.Data.SqlDbType.Int);
                parameter.Value = IznajmljivanjeID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ClanID", System.Data.SqlDbType.Int);
                parameter.Value = ClanID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@KnjigaID", System.Data.SqlDbType.Int);
                parameter.Value = KnjigaID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumIznajmljivanja", System.Data.SqlDbType.Date);
                parameter.Value = DatumIznajmljivanja;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumRazduzivanja", System.Data.SqlDbType.Date);
                parameter.Value = DatumRazduzivanja;
                list.Add(parameter);
            }

            return list;
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE [dbo].[Iznajmljivanje]
                       SET [ClanID] = @ClanID
                          ,[KnjigaID] = @KnjigaID
                          ,[ZaposleniID] = @ZaposleniID
                          ,[DatumIznajmljivanja] = @DatumIznajmljivanja
                          ,[DatumRazduzivanja] = @DatumRazduzivanja
                     WHERE IznajmljivanjeID = @IznajmljivanjeID";
        }
    }
}