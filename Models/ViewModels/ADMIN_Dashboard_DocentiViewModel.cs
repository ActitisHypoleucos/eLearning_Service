using System;
using System.Data;

namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Dashboard_DocentiViewModel : ViewModelBase
    {
        public string competenza { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string partitaIVA { get; set; }
        public string email { get; set; }
        public string corso { get; set; }

        public ADMIN_Dashboard_DocentiViewModel(DataRow itemRow)
        {
            competenza = Convert.ToString(CheckDBNULL(itemRow["Competenza"]));
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            cognome = Convert.ToString(CheckDBNULL(itemRow["Cognome"]));
            partitaIVA = Convert.ToString(CheckDBNULL(itemRow["Partita IVA"]));
            email = Convert.ToString(CheckDBNULL(itemRow["email"]));
            corso = Convert.ToString(CheckDBNULL(itemRow["Corso"]));
        }
    }
}