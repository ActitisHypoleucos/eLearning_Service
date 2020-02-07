using System;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.ViewModels.ADMIN
{
    public class ADMIN_Filtro_Corsisti : ViewModelBase
    {
        public string stato { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string email { get; set; }
        public string superato { get; set; }
        public int assenze { get; set; }
        public string corso { get; set; }

        public ADMIN_Filtro_Corsisti(DataRow itemRow)
        {
            stato = Convert.ToString(CheckDBNULL(itemRow["Stato"]));
            nome= Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            cognome = Convert.ToString(CheckDBNULL(itemRow["Cognome"]));
            email = Convert.ToString(CheckDBNULL(itemRow["Email"]));
            superato = Convert.ToString(CheckDBNULL(itemRow["Superato?"]));
            assenze = Convert.ToInt32(CheckDBNULL(itemRow["Assenze"]));
            corso = Convert.ToString(CheckDBNULL(itemRow["Corso"]));
        }
    }
}