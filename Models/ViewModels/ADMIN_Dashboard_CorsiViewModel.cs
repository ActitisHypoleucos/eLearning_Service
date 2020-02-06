using System;
using System.Data;

namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Dashboard_CorsiViewModel
    {
        public string stato { get; set; } 
        public string nome { get; set;}
        public int durata { get; set;}
        public int limite_Assenze { get; set;}
        public string docente { get; set;}
        public ADMIN_Dashboard_CorsiViewModel(DataRow itemRow)
        {
            stato = Convert.ToString(itemRow["Stato"]);
            nome = Convert.ToString(itemRow["Nome"]);
            durata = Convert.ToInt32(itemRow["Durata (H)"]);
            limite_Assenze = Convert.ToInt32(itemRow["Limite Assenze"]);
            docente = Convert.ToString(itemRow["Docente"]);
        }
    }
}