using System;
using System.Data;
using eLearningService.Models;

namespace eLearningService.Models.ViewModels
{
    public class MaterialiViewModel : ViewModelBase
    {
        public object Materiale { get; set; }
        public string Estensione { get; set; }
        public bool IsSelected { get;set; }
        public int IDLezione { get; set; }
        
        public MaterialiViewModel(DataRow itemRow)
        {
            ID = Convert.ToInt32(CheckDBNULL(itemRow["Id_Materiale_PK"]));
            Materiale = CheckDBNULL(itemRow["Materiale"]);
            Estensione = Convert.ToString(CheckDBNULL(itemRow["Tipo"]));
            IDLezione = Convert.ToInt32(CheckDBNULL(itemRow["Id_Lezione_FK"]));
            IsSelected = false;
        }
    }
}   