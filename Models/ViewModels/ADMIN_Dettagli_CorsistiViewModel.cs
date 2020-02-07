using System;
using System.Data;
namespace eLearningService.Models.ViewModels
{
    public class ADMIN_Dettagli_CorsistiViewModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string nome { get; set; }
        public string cognome{ get; set; }
        public DateTime? bornDate { get; set; }
        public string codFiscale{ get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string indirizzo { get; set; }
        public string corso { get; set; } 
        public int assenze { get; set; }
        public string superato { get; set; }
        public string stato { get; set; }
        public string motiviAllontanamento { get; set; }

        public ADMIN_Dettagli_CorsistiViewModel(DataRow itemRow)
        {
            username = Convert.ToString(CheckDBNULL(itemRow["Username"]));
            password = Convert.ToString(CheckDBNULL(itemRow["Password"]));
            nome = Convert.ToString(CheckDBNULL(itemRow["Nome"]));
            cognome = Convert.ToString(CheckDBNULL(itemRow["Cognome"]));
            bornDate = Convert.ToDateTime(CheckDBNULL(itemRow["Data di Nascita"]));
            codFiscale = Convert.ToString(CheckDBNULL(itemRow["Codice Fiscale"]));
            email = Convert.ToString(CheckDBNULL(itemRow["Email"]));
            telefono = Convert.ToString(CheckDBNULL(itemRow["Telefono"]));
            indirizzo = Convert.ToString(CheckDBNULL(itemRow["Indirizzo"]));
            corso = Convert.ToString(CheckDBNULL(itemRow["Corso"]));
            assenze = Convert.ToInt32(CheckDBNULL(itemRow["Assenze"]));
            superato = Convert.ToString(CheckDBNULL(itemRow["Superato?"]));
            stato = Convert.ToString(CheckDBNULL(itemRow["Stato"]));
            motiviAllontanamento = Convert.ToString(CheckDBNULL(itemRow["Motivi Allontanamento"]));
        }

        #region CheckFor DBNULL
        public object CheckDBNULL(object campo)
        {
                if (campo == DBNull.Value)
                {
                     return null;
                }
                else
                {
                    return campo;
                }
        }
        #endregion
        
    }
}