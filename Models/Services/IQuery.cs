using System.Data;
namespace eLearningService.Models.Services
{
    public interface IQuery
    {
         DataTable OttieniCorsi();
         DataTable OttieniPNG();
         DataTable OttieniADMINDashboard_Corsi();
         DataTable OttieniADMINDashboard_Corsisti();
         DataTable OttieniADMINDashboard_Docenti();
         //DataTable OttieniADMINDettagli_Corsi();
    }
}