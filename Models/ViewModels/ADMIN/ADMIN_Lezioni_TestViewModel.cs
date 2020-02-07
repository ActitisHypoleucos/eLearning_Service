using System;
using System.Data;
using eLearningService.Models.ViewModels.SHARED;

namespace eLearningService.Models.ViewModels.ADMIN
{
    public class ADMIN_Lezioni_TestViewModel : ViewModelBase
    {
        public string nome { get; set; }
        public int tempoStimato { get; set; }
        public decimal percentualeSuperamento { get; set; }

        public ADMIN_Lezioni_TestViewModel(DataRow itemRow)
        {
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            tempoStimato = Convert.ToInt32(CheckDBNULL(itemRow["Tempo Stimato"]));
            percentualeSuperamento = Convert.ToDecimal(CheckDBNULL(itemRow["% Superamento"]));
        }
    }
}