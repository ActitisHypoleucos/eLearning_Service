using System;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.ViewModels.ADMIN
{
    public class ADMIN_Filtro_CorsiAssegnatiViewModel : ViewModelBase
    {
        public string stato { get; set; }
        public string nome { get; set; }
        public int durata { get; set; }
        public int limiteAssenze { get; set; }
        public string docente { get; set; }

        public ADMIN_Filtro_CorsiAssegnatiViewModel(DataRow itemRow)
        {
            stato = Convert.ToString(CheckDBNULL(itemRow["Stato"]));
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            durata = Convert.ToInt32(CheckDBNULL(itemRow["Durata (H)"]));
            limiteAssenze= Convert.ToInt32(CheckDBNULL(itemRow["Limite Assenze"]));
            docente= Convert.ToString(CheckDBNULL(itemRow["Docente"]));
        }
    }
}