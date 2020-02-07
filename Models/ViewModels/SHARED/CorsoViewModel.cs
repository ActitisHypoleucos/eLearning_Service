using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace eLearningService.Models.ViewModels.SHARED
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
        public int id { get; set; }
        public string nomeCorso { get; set; }
        public double costo { get; set; }
        public int totaleOre { get; set; }
        public DateTime dataInizio { get; set; }
        public DateTime dataFine { get; set; }
        public int assenzeLimite { get; set; }
        public CorsoViewModel(DataRow itemRow)
        {
            id = Convert.ToInt32(CheckDBNULL(itemRow["Id_Corso_PK"]));
            nomeCorso = Convert.ToString(CheckDBNULL(itemRow["Nome_Corso"]));
            costo = Convert.ToDouble(CheckDBNULL(itemRow["Costo"]));
            totaleOre = Convert.ToInt32(CheckDBNULL(itemRow["Totale_Ore"]));
            dataInizio = Convert.ToDateTime(CheckDBNULL(itemRow["Data_Inizio"]));
            dataFine = Convert.ToDateTime(CheckDBNULL(itemRow["Data_Fine"]));           
            assenzeLimite = Convert.ToInt32(CheckDBNULL(itemRow["Assenze_Limite"]));
        }
    }
}