﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBiblioteka.PropertiesClass
{
    public interface PropertyInterface
    {
        string GetSelectQuery();
        string GetInsertQuery();
        string GetUpdateQuery();
        string GetDeleteQuery();

        //select upiti
        string GetSelectPregledClanarinePoClanovima();

        string GetProcedureSelectAutor();
        string GetProcedureSelectIzdavac();
        string GetProcedureSelectAllDetails();
        string GetProcedureStatusClanarineZaClanID();
        string GetProcedureMozeLiSeDici();
        string GetProcedureKnjigaNaStanju();

        //update upiti
        string GetProcedureUpdateKnjiga();
        string GetProcedureUpdateKnjigaVrati();

        List<SqlParameter> GetInsertParameters();
        List<SqlParameter> GetUpdateParameters();
        List<SqlParameter> GetDeleteParameters();

        //parametri za select upite
        List<SqlParameter> GetSelectPregledClanarinePoClanovimaParameters();

        List<SqlParameter> GetProcedureParameters();
        List<SqlParameter> GetProcedureParametersClanID();
        List<SqlParameter> GetProcedureParametersIznajmljivanjeID();



    }
}
