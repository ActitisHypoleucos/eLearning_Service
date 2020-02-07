using System;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.ViewModels.ADMIN
{
    public class ADMIN_Test_ListaTestViewModel : ViewModelBase
    {
        public string nome { get; set; }
        public int durata { get; set; }
        public string passato { get; set; }
        public decimal voto { get; set; }


        public ADMIN_Test_ListaTestViewModel(DataRow itemRow)
        {
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            durata = Convert.ToInt32(CheckDBNULL(itemRow["Durata (MIN)"]));
            passato = Convert.ToString(CheckDBNULL(itemRow["Passato?"]));
            voto = Convert.ToDecimal(CheckDBNULL(itemRow["Voto/100"]));
        }
    }
}