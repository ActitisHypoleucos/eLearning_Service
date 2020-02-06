using System;
using System.Data;

namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Dashboard_CorsistiViewModel
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
            stato = Convert.ToString(itemRow["Stato"]);
            nome = Convert.ToString(itemRow["Nome"]);
            cognome = Convert.ToString(itemRow["Cognome"]);
            email = Convert.ToString(itemRow["Email"]);
            superato = Convert.ToString(itemRow["Superato?"]);
            assenze = Convert.ToInt32(itemRow["Assenze"]);
            nomeCorso = Convert.ToString(itemRow["Corso"]);
        }
    }
}