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
    public class PropertyClanarina:PropertyInterface
    {
        #region Properties

        [DisplayName("Clanarina ID")]
        [SqlName("ClanarinaID")]
        [PrimaryKey]
        public int ClanarinaID { get; set; }

        [DisplayName("Clan ID")]
        [SqlName("ClanID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKey("Clan", "ClanID", "DBBiblioteka.PropertyClan")]
        public int ClanID { get; set; }

        [DisplayName("Tip ID")]
        [SqlName("TipID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKey("TipClanarine", "TipID", "DBBiblioteka.PropertyTipClanarina")]
        public int TipID { get; set; }

        [DisplayName("Datum uplate")]
        [SqlName("DatumUplate")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public DateTime DatumUplate { get; set; }

        [DisplayName("Zaposleni ID")]
        [SqlName("ZaposleniID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        [ForeignKey("Zaposleni", "ZaposleniID", "DBBiblioteka.PropertyZaposleni")]
        public int ZaposleniID { get; set; }

        [DisplayName("Vazi do")]
        [SqlName("DatumIstekaClanarine")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Polje je obavezno za unos!")]
        public DateTime DatumIstekaClanarine { get; set; }


        #endregion


        #region Querries

        public string GetSelectQuery()
        {
            return @"SELECT[ClanarinaID
                           ,ClanID
                           ,TipID
                           ,DatumUplate
                           ,ZaposleniID
                           ,DatumIstekaClanarine
                    FROM dbo.Clanarina";
        }

        public string GetInsertQuery()
        {
            return @"INSERT INTO dbo.Clanarina
                   (ClanID
                   ,TipID
                   ,DatumUplate
                   ,ZaposleniID
                   ,DatumIstekaClanarine)
             VALUES
                   (@ClanID,
                   ,@TipID,
                   ,@DatumUplate,
                   ,@ZaposleniID,
                   ,@DatumIstekaClanarine)";
        }

        public string GetUpdateQuery()
        {
            return @"UPDATE dbo.Clanarina
                       SET ClanID
                          ,TipID
                          ,DatumUplate
                          ,ZaposleniID
                          ,DatumIstekaClanarine
                     WHERE ClanarinaID=@ClanarinaID";
        }


        public string GetDeleteQuery()
        {
            return @"DELETE FROM dbo.Clanarina
                  WHERE ClanarinaID=@ClanarinaID";
        }

        #endregion



        #region Parameters

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ClanID", System.Data.SqlDbType.Int);
                parameter.Value = ClanID;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@TipID", System.Data.SqlDbType.TinyInt);
                parameter.Value = TipID;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@DatumUplate", System.Data.SqlDbType.Date);
                parameter.Value = DatumUplate;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumIstekaClanarine", System.Data.SqlDbType.Date);
                parameter.Value = DatumIstekaClanarine;
                list.Add(parameter);
            }

            return list;
        }


        public List<SqlParameter> GetUpdateParameters()
        {

            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ClanarinaID", System.Data.SqlDbType.Int);
                parameter.Value = ClanarinaID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@ClanID", System.Data.SqlDbType.Int);
                parameter.Value = ClanID;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@TipID", System.Data.SqlDbType.TinyInt);
                parameter.Value = TipID;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@DatumUplate", System.Data.SqlDbType.Date);
                parameter.Value = DatumUplate;
                list.Add(parameter);
            }

            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", System.Data.SqlDbType.TinyInt);
                parameter.Value = ZaposleniID;
                list.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@DatumIstekaClanarine", System.Data.SqlDbType.Date);
                parameter.Value = DatumIstekaClanarine;
                list.Add(parameter);
            }


            return list;
        }


        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ClanarinaID", System.Data.SqlDbType.Int);
                parameter.Value = ClanarinaID;
                list.Add(parameter);
            }

            return list;
        }


        #endregion

    }
}