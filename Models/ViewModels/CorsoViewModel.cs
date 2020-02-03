using System;
using System.Data;

namespace eLearningService.Models.ViewModels
{
    public class CorsoViewModel
    {
        public int IdCorso { get; set; }
        public string NomeCorso { get; set; }
        public double Costo { get; set; }
        public int TotaleOre { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public int AssenzeLimite { get; set; }

        public static CorsoViewModel FromDataRow(DataRow itemRow)
        {
            try
            {
                var item = new CorsoViewModel()
                {
                    IdCorso = Convert.ToInt32(itemRow["Id_Corso_PK"]),
                    NomeCorso = Convert.ToString(itemRow["Nome_Corso"]),
                    Costo = Convert.ToDouble(itemRow["Costo"]),
                    TotaleOre = Convert.ToInt32(itemRow["Totale_Ore"]),
                    DataInizio = Convert.ToDateTime(itemRow["Data_Inizio"]),
                    DataFine = Convert.ToDateTime(itemRow["Data_Fine"]),
                    AssenzeLimite = Convert.ToInt32(itemRow["Assenze_Limite"])
                };
            return item;
            }            
            catch (System.Exception)
            {
                return null;
            }            
        }
    }
}