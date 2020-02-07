using System;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.ViewModels.ADMIN
{
    public class ADMIN_Dettagli_CorsiViewModel : ViewModelBase
    {
        public string nomecorso { get; set; }
        public int durata { get; set; }
        public DateTime? dataInizio { get; set; }
        public DateTime? dataFine { get; set; }
        public int limiteAssenze { get; set; }
        public decimal costo { get; set; }
        public string stato { get; set; }
        public string motivazioneAnnullamento { get; set; }
        public object programma { get; set; }
        public string docente { get; set; }

        public ADMIN_Dettagli_CorsiViewModel(DataRow itemRow)
        {
            nomecorso = Convert.ToString(itemRow["Nome"]);
            durata = Convert.ToInt32(itemRow["Durata (H)"]);
            dataInizio = Convert.ToDateTime(CheckDBNULL(itemRow["Data Inizio"]));
            dataFine = Convert.ToDateTime(CheckDBNULL(itemRow["Data Fine"]));
            limiteAssenze = Convert.ToInt32(itemRow["Limite Assenze"]);
            costo = Convert.ToDecimal(itemRow["Costo"]);
            stato = Convert.ToString(itemRow["Stato"]);
            motivazioneAnnullamento = Convert.ToString(CheckDBNULL(itemRow["Motivazione Annullamento"]));
            programma = CheckDBNULL(itemRow["Programma"]);
            docente = Convert.ToString(CheckDBNULL(itemRow["Docente"]));
        }
    }
}