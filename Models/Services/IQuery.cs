using System.Data;
namespace eLearningService.Models.Services
{
    public interface IQuery
    {
         DataTable OttieniCorsi();
         DataTable OttieniPNG();
         DataTable OttieniDashboardADMIN();
    }
}