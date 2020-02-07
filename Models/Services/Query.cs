using System;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.Services
{
    public class Query : IQuery
    {
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

        //creare le funzioni di servizio
    }
}