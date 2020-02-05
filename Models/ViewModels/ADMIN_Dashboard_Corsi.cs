using System;
using System.Data;

namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Dashboard_Corsi
    {
        public string stato { get; set; } 
        public string nome { get; set;}
        public int durata { get; set;}
        public int limite_Assenze { get; set;}
        public string docente { get; set;}
        public ADMIN_Dashboard_Corsi(DataRow itemRow)
        {
            stato = Convert.ToString(itemRow["Stato"]);
            nome = Convert.ToString(itemRow["Nome"]);
            durata = Convert.ToInt32(itemRow["Durata"]);
            limite_Assenze = Convert.ToInt32(itemRow["Limite_Assenze"]);
            docente = Convert.ToString(itemRow["Docente"]);
        }
    }
}