using System;
using System.Data;

namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Dashboard_CorsiViewModel : ViewModelBase
    {
        public string stato { get; set; } 
        public string nome { get; set;}
        public int durata { get; set;}
        public int limite_Assenze { get; set;}
        public string docente { get; set;}
        public ADMIN_Dashboard_CorsiViewModel(DataRow itemRow)
        {
            stato = Convert.ToString(CheckDBNULL(itemRow["Stato"]));
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            durata = Convert.ToInt32(CheckDBNULL(itemRow["Durata (H)"]));
            limite_Assenze = Convert.ToInt32(CheckDBNULL(itemRow["Limite Assenze"]));
            docente = Convert.ToString(CheckDBNULL(itemRow["Docente"]));
        }
    }
}