using System;
using System.Data;
namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Dashboard_DocentiViewModel
    {
        public string competenza { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string partitaIVA { get; set; }
        public string email { get; set; }
        public string corso { get; set; }

        public ADMIN_Dashboard_DocentiViewModel(DataRow itemRow)
        {
            competenza = Convert.ToString(itemRow["Competenza"]);
            nome = Convert.ToString(itemRow["Nome"]);
            cognome = Convert.ToString(itemRow["Cognome"]);
            partitaIVA = Convert.ToString(itemRow["Partita IVA"]);
            email = Convert.ToString(itemRow["email"]);
            corso = Convert.ToString(itemRow["Corso"]);
        }
    }
}