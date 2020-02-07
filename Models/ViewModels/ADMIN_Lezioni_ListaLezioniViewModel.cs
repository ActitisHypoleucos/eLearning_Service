using System;
using System.Data;
using eLearningService.Models.ViewModels;

namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Lezioni_ListaLezioniViewModel : ViewModelBase
    {
        public string argomento { get; set; }
        public DateTime? data { get; set; }
        public int numeroMateriali { get; set; }
        public string test { get; set; }
        public ADMIN_Lezioni_ListaLezioniViewModel(DataRow itemRow)
        {
            argomento = Convert.ToString(CheckDBNULL(itemRow["Argomento"]));
            data = Convert.ToDateTime(CheckDBNULL(itemRow["Data"]));
            numeroMateriali = Convert.ToInt32(CheckDBNULL(itemRow["Numero Materiali"]));
            test = Convert.ToString(CheckDBNULL(itemRow["Test"]));
        } 
    }
}