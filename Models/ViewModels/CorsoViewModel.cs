using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace eLearningService.Models.ViewModels
{
    public class CorsoViewModel : ViewModelBase
    {
        /*
        [Key]
        [Column("Id_Corso_PK")]
        public int ID { get; set; } 
        [Column("Nome_Corso")]
        public string NomeCorso { get; set; } // ="";
        [Column("Costo")]
        public double? Costo { get; set; }
        [Column("Totale_Ore")]
        public int? TotaleOre { get; set; }
        [Column("Data_Inizio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime? DataInizio { get; set; } // = Convert.ToDateTime("1950-01-01 00:00:00.000");
        [Column("Data_Fine")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime? DataFine { get; set; } // = Convert.ToDateTime("1950-01-01 00:00:00.000");
        [Column("Assenze_Limite")]
        public int? AssenzeLimite { get; set; }
        */

        public string NomeCorso { get; set; }
        public double Costo { get; set; }
        public int TotaleOre { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public int AssenzeLimite { get; set; }
        public CorsoViewModel(DataRow itemRow)
        {
            ID = Convert.ToInt32(CheckDBNULL(itemRow["Id_Corso_PK"]));
            NomeCorso = Convert.ToString(CheckDBNULL(itemRow["Nome_Corso"]));
            Costo = Convert.ToDouble(CheckDBNULL(itemRow["Costo"]));
            TotaleOre = Convert.ToInt32(CheckDBNULL(itemRow["Totale_Ore"]));
            DataInizio = Convert.ToDateTime(CheckDBNULL(itemRow["Data_Inizio"]));
            DataFine = Convert.ToDateTime(CheckDBNULL(itemRow["Data_Fine"]));           
            AssenzeLimite = Convert.ToInt32(CheckDBNULL(itemRow["Assenze_Limite"]));
        }
    }
}