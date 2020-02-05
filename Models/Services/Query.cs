using System.Data;
using eLearningService.Models;

namespace eLearningService.Models.Services
{
    public class Query : IQuery
    {
        DataTable IQuery.OttieniCorsi()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("Select * from Corsi");
            return tabbola;
        }

        DataTable IQuery.OttieniPNG()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("Select * from Materiali_Didattici");
            return tabbola;
        }

        

        


        //creare le funzioni di servizio
    }
}