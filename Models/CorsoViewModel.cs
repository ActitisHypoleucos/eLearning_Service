using System;
using System.Data;

namespace eLearning_Trying_Database.Models
{
    public class CorsoViewModel
    {
        public int IdCorso { get; set; }
        public string NomeCorso { get; set; }
        public float Costo { get; set; }
        public int TotaleOre { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public int AssenzeLimite { get; set; }

        public static CorsoViewModel FromDataRow(DataRow corsoRow)
        {
            var corso = new CorsoViewModel()
            {
                NomeCorso = corsoRow["Nome_Corso"].ToString()
            };
            return corso;
        }
    }
}