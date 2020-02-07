using System;
using System.Data;
namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Dettagli_DocentiViewModel : ViewModelBase
    {
        public string username { get; set; }
        public string password { get; set; }
        public string nome { get; set; }
        public string codFiscale { get; set; }
        public DateTime bornDate { get; set; }
        public string indirizzo { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string partitaIVA { get; set; }
        public string interno { get; set; }
        public string competenza { get; set; }
        public string corso { get; set; }

        public ADMIN_Dettagli_DocentiViewModel(DataRow itemRow)
        {
            username = Convert.ToString(CheckDBNULL(itemRow["Username"]));
            password = Convert.ToString(CheckDBNULL(itemRow["Password"]));
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            codFiscale = Convert.ToString(CheckDBNULL(itemRow["Codice Fiscale"]));
            bornDate = Convert.ToDateTime(CheckDBNULL(itemRow["Data di Nascita"]));
            indirizzo = Convert.ToString(CheckDBNULL(itemRow["Indirizzo"]));
            email = Convert.ToString(CheckDBNULL(itemRow["Email"]));
            telefono = Convert.ToString(CheckDBNULL(itemRow["Telefono"]));
            partitaIVA = Convert.ToString(CheckDBNULL(itemRow["Partita Iva"]));
            interno = Convert.ToString(CheckDBNULL(itemRow["Interno?"]));
            competenza = Convert.ToString(CheckDBNULL(itemRow["Competenza"]));
            corso = Convert.ToString(CheckDBNULL(itemRow["Corso"]));
        }
    }
}