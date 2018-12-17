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
    public class PropertyTipClanarine : Attribute
    {
        #region property

        [DisplayName("ID tipa")]
        [SqlName("TipID")]
        [PrimaryKey]
        public int TipID { get; set; }

        [DisplayName("Naziv tipa")]
        [SqlName("NazivTipa")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public string NazivTipa { get; set; }

        [DisplayName("Iznos clanarine")]
        [SqlName("IznosClanarine")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public decimal IznosClanarine { get; set; }

        #endregion

        #region Attributes
        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@TipID", System.Data.SqlDbType.TinyInt);
                parameter.Value = TipID;
                list.Add(parameter);
            }
            return list;
        }

        public string GetDeleteQuery()
        {
            return @"DELETE FROM [dbo].[TipClanarine]
                        WHERE TipID = @TipID";
        }

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@NazivTipa", System.Data.SqlDbType.NVarChar);
                parameter.Value = NazivTipa;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@IznosClanarine", System.Data.SqlDbType.Decimal);
                parameter.Value = IznosClanarine;
                list.Add(parameter);
            }
            return list;
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO [dbo].[TipClanarine]
                           ([NazivTipa],
                            [IznosClanarine])
                     VALUES
                           (@NazivTipa, @IznosClanarine)";
        }

        public string GetSelectQuery()
        {
            return @"SELECT [TipID]
                          ,[NazivTipa]
                          ,[IznosClanarine]
                      FROM [Biblioteka].[dbo].[RadnoMjesto]";
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@TipID", System.Data.SqlDbType.TinyInt);
                parameter.Value = TipID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@NazivTipa", System.Data.SqlDbType.NVarChar);
                parameter.Value = NazivTipa;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@IznosClanarine", System.Data.SqlDbType.Decimal);
                parameter.Value = IznosClanarine;
                list.Add(parameter);
            }
            return list;
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE [dbo].[TipClanarine]
                       SET [NazivTipa] = @NazivTipa
                          ,[IznosClanarine] = @IznosClanarine
                     WHERE TipID = @TipID";
        }
        #endregion
    }
}
