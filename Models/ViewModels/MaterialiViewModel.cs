using System;
using System.Data;
using eLearningService.Models;

namespace eLearningService.Models.ViewModels
{
    public class MaterialiViewModel : ViewModelBase
    {
        public object materiale { get; set; }
        public string estensione { get; set; }
        public int idLezione { get; set; }
        
        public MaterialiViewModel(DataRow itemRow)
        {
            ID = Convert.ToInt32(CheckDBNULL(itemRow["Id_Materiale_PK"]));
            materiale = CheckDBNULL(itemRow["Materiale"]);
            estensione = Convert.ToString(CheckDBNULL(itemRow["Tipo"]));
            idLezione = Convert.ToInt32(CheckDBNULL(itemRow["Id_Lezione_FK"]));
        }
    }
}   