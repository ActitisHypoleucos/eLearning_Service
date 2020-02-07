using System.Data;
using eLearningService.Models;

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
        
        //creare le funzioni di servizio
    }
}