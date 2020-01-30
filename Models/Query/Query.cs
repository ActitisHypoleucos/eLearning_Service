using System.Data;
using eLearningService.Models;

namespace eLearningService.Models.Query
{
    public class Query : IQuery
    {
        DataTable IQuery.OttieniCorsi()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("Select * from Corsi");
            return tabbola;
        }
    }
}