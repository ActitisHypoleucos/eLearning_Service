using System;
using System.Collections.Generic;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.Services
{
    public class Query : IQuery
    {
    #region Single Element
        DataTable IQuery.OttieniCorsi()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM Corsi");
            return tabbola;
        }

        DataTable IQuery.OttieniPNG()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM Materiali_Didattici WHERE Tipo = '.png'");
            return tabbola;
        }
        /*
        DataTable IQuery.ChiamaStoredProcedure()
        {
            List<string> parametri = new List<string>();
            List<string> valori = new List<string>();
            parametri.Add("@stato1"); valori.Add ("attivo");
            parametri.Add("@stato2"); valori.Add ("");
            parametri.Add("@stato3"); valori.Add ("annullato");
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.StorePExe("SELECT","Filtro_ADMIN_Corso", parametri, valori);
            return tabbola;
        }
        */
        #endregion
    #region ADMIN
        #region Views
        DataTable IQuery.OttieniADMINDashboard_Corsi()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Dashboard_Corsi");
            return tabbola;
        }
        
        DataTable IQuery.OttieniADMINDashboard_Corsisti()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Dashboard_Corsisti");
            return tabbola;
        }

        DataTable IQuery.OttieniADMINDashboard_Docenti()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Dashboard_Docenti");
            return tabbola;
        }

        DataTable IQuery.OttieniADMINDettagli_Corsi()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Dettagli_Corsi");
            return tabbola;
        }

        DataTable IQuery.OttieniADMINDettagli_Corsisti()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Dettagli_Corsisti");
            return tabbola;
        }
        
        DataTable IQuery.OttieniADMINDettagli_Docenti()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Dettagli_Docenti");
            return tabbola;
        }

        DataTable IQuery.OttieniADMINLezione_ListaLezioni()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Lezioni_ListaLezioni");
            return tabbola;
        }

        DataTable IQuery.OttieniADMINLezione_ListaMateriali()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Lezioni_ListaMateriali");
            return tabbola;
        }

        DataTable IQuery.OttieniADMINLezione_ListaModuli()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Lezioni_ListaModuli");
            return tabbola;
        }

        DataTable IQuery.OttieniADMINLezione_Test()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Lezioni_Test");
            return tabbola;
        }

        DataTable IQuery.OttieniADMINTest_ListaCorsisti()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Test_ListaCorsisti");
            return tabbola;
        }

        DataTable IQuery.OttioniADMINTest_ListaTest()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Test_ListaTest");
            return tabbola;
        }
    #endregion
        #region Stored Procedures
        public DataTable OttieniADMIN_Filtro_CorsiAssegnati()
        {
            CLS_DB dibbi = new CLS_DB();
            List<string> parametri = new List<string>();
            List<string> valori = new List<string>();
            parametri.Add("@var"); valori.Add("profassegnato");
            DataTable tabbola = dibbi.StorePExe("SELECT", "Filtro_ADMIN_CorsiNonAssegnati", parametri, valori);
            return tabbola;
        }
        public DataTable OttieniADMIN_Filtro_CorsiNonAssegnati()
        {
            CLS_DB dibbi = new CLS_DB();List<string> parametri = new List<string>();
            List<string> valori = new List<string>();
            parametri.Add("@var"); valori.Add("");
            DataTable tabbola = dibbi.StorePExe("SELECT", "Filtro_ADMIN_CorsiNonAssegnati", parametri, valori);
            return tabbola;
        }
        
        /*
        public DataTable OttieniADMIN_Filtro_Corsisti()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Test_ListaTest");
            return tabbola;
        }

        public DataTable OttieniADMIN_Filtro_Corso()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Test_ListaTest");
            return tabbola;
        }

        public DataTable OttieniADMINLezioni_ListaCorsi()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("SELECT * FROM ADMIN_Test_ListaTest");
            return tabbola;
        }
        */
    #endregion
    #endregion
        //creare le funzioni di servizio
    }
}