using System;
using System.Data;

namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Lezioni_ListaMaterialiViewModel : ViewModelBase
    {
        public object blob { get; set; }
        public string estensione { get; set;}
        public ADMIN_Lezioni_ListaMaterialiViewModel(DataRow itemRow)
        {
            blob = CheckDBNULL(itemRow["Nome"]);
            estensione = Convert.ToString(CheckDBNULL(itemRow["Tipo"]));
        }
    }
}