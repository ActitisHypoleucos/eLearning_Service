using System;
using System.Data;

namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Dashboard_CorsistiViewModel : ViewModelBase
    {
        public string stato { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string email { get; set; }
        public string superato { get; set; }
        public int assenze { get; set; }
        public string nomeCorso { get; set; }

        public ADMIN_Dashboard_CorsistiViewModel(DataRow itemRow)
        {
            stato = Convert.ToString(CheckDBNULL(itemRow["Stato"]));
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            cognome = Convert.ToString(CheckDBNULL(itemRow["Cognome"]));
            email = Convert.ToString(CheckDBNULL(itemRow["Email"]));
            superato = Convert.ToString(CheckDBNULL(itemRow["Superato?"]));
            assenze = Convert.ToInt32(CheckDBNULL(itemRow["Assenze"]));
            nomeCorso = Convert.ToString(CheckDBNULL(itemRow["Corso"]));
        }
    }
}