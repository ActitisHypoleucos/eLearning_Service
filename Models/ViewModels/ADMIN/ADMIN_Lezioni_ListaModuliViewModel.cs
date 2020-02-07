using System;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.ViewModels.ADMIN
{
    public class ADMIN_Lezioni_ListaModuliViewModel : ViewModelBase
    {
        public string nome { get; set; }
        public int numeroLezioni { get; set; }
        public string descrizione { get; set; }
        public ADMIN_Lezioni_ListaModuliViewModel(DataRow itemRow)
        {
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            numeroLezioni = Convert.ToInt32(CheckDBNULL(itemRow["Numero Lezioni"]));
            descrizione = Convert.ToString(CheckDBNULL(itemRow["Descrizione"]));
        }  
    }
}