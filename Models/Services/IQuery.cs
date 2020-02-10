using System.Data;
namespace eLearningService.Models.Services
{
    public interface IQuery
    {
        #region SINGLE ELEMENT
        DataTable OttieniCorsi();
        DataTable OttieniPNG();
        #endregion
        #region ADMIN
            #region Views
                DataTable OttieniADMINDashboard_Corsi();
                DataTable OttieniADMINDashboard_Corsisti();
                DataTable OttieniADMINDashboard_Docenti();
                DataTable OttieniADMINDettagli_Corsi();
                DataTable OttieniADMINDettagli_Corsisti();
                DataTable OttieniADMINDettagli_Docenti();
                DataTable OttieniADMINLezione_ListaLezioni();
                DataTable OttieniADMINLezione_ListaMateriali();
                DataTable OttieniADMINLezione_ListaModuli();
                DataTable OttieniADMINLezione_ListaCorsi();
                DataTable OttieniADMINLezione_Test();
                DataTable OttieniADMINTest_ListaCorsisti();
                DataTable OttioniADMINTest_ListaTest();
            #endregion
            #region Stored Procedures
                DataTable OttieniADMIN_Filtro_CorsiAssegnati();
                DataTable OttieniADMIN_Filtro_Corsisti();
                DataTable OttieniADMIN_Filtro_Corso();
                
            #endregion
         #endregion
    }
}