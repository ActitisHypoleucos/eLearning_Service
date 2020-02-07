using System;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.ViewModels.ADMIN
{
    public class ADMIN_Lezioni_ListaCorsiViewModel : ViewModelBase
    {
        public string stato { get; set; }
        public string nome { get; set; }
        public string anniAttivita { get; set; }
        public int limiteAssenze { get; set; }

        public ADMIN_Lezioni_ListaCorsiViewModel(DataRow itemRow)
        {
            stato = Convert.ToString(CheckDBNULL(itemRow["Stato"]));
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            anniAttivita = Convert.ToString(CheckDBNULL(itemRow["Anno"]));
            limiteAssenze = Convert.ToInt32(CheckDBNULL(itemRow["Limite Assenze"]));
        }
    }
}