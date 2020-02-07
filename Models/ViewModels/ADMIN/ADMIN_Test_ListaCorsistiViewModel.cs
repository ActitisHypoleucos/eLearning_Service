using System;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.ViewModels.ADMIN
{
    public class ADMIN_Test_ListaCorsistiViewModel : ViewModelBase
    {
        public string stato { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string numeroTest { get; set; }

        public ADMIN_Test_ListaCorsistiViewModel(DataRow itemRow)
        {
            stato = Convert.ToString(CheckDBNULL(itemRow["Stato"]));
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            cognome = Convert.ToString(CheckDBNULL(itemRow["Cognome"]));
            numeroTest = Convert.ToString(CheckDBNULL(itemRow["Numero"]));
        } 
    }
}