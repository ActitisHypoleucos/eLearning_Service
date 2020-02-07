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
         DataTable OttieniADMINDettagli_Corsi();
         DataTable OttieniADMINDettagli_Corsisti();
         DataTable OttieniADMINDettagli_Docenti();
         DataTable OttieniADMINLezione_ListaLezioni();
         DataTable OttieniADMINLezione_ListaMateriali();
         DataTable OttieniADMINLezione_ListaModuli();
         DataTable OttieniADMINLezione_Test();
         DataTable OttieniADMINTest_ListaCorsisti();
         DataTable OttioniADMINTest_ListaTest();
    }
}