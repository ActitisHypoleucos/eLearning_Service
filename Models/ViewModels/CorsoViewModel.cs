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

        public static CorsoViewModel FromDataRow(DataRow corsoRow)
        {
            try
            {
                var corso = new CorsoViewModel()
                {
                    IdCorso = Convert.ToInt32(corsoRow["Id_Corso_PK"]),
                    NomeCorso = Convert.ToString(corsoRow["Nome_Corso"]),
                    Costo = Convert.ToDouble(corsoRow["Costo"]),
                    TotaleOre = Convert.ToInt32(corsoRow["Totale_Ore"]),
                    DataInizio = Convert.ToDateTime(corsoRow["Data_Inizio"]),
                    DataFine = Convert.ToDateTime(corsoRow["Data_Fine"]),
                    AssenzeLimite = Convert.ToInt32(corsoRow["Assenze_Limite"])
                };
            return corso;
            }            
            catch (System.Exception)
            {
                return null;
            }            
        }
    }
}