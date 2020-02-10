using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using eLearningService.Models.ViewModels.SHARED;
using eLearningService.Models.ViewModels.ADMIN;
using eLearningService.Models.Services;
using System.Data;
using Microsoft.AspNetCore.Http;

namespace eLearningService.Controllers
{
    public class AdminController : Controller
    {
        private readonly IQuery _query;
        public AdminController(IQuery query)
        {
            _query = query;
        }

        #region Dashboard
            public JsonResult Dashboard_Corsi()
            {
                DataTable tabbola = _query.OttieniADMINDashboard_Corsi();
                List<ADMIN_Dashboard_CorsiViewModel> list = new List<ADMIN_Dashboard_CorsiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Dashboard_CorsiViewModel item = new ADMIN_Dashboard_CorsiViewModel(riga);
                    list.Add(item);
                }
                    return Json(list);
            }

            public JsonResult Dashboard_Corsisti()
            {
                DataTable tabbola = _query.OttieniADMINDashboard_Corsisti();
                List<ADMIN_Dashboard_CorsistiViewModel> list = new List<ADMIN_Dashboard_CorsistiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Dashboard_CorsistiViewModel item = new ADMIN_Dashboard_CorsistiViewModel(riga);
                    list.Add(item);
                }
                    return Json(list);
            }

            public JsonResult Dashboard_Docenti()
            {
                DataTable tabbola = _query.OttieniADMINDashboard_Docenti();
                List<ADMIN_Dashboard_DocentiViewModel> list = new List<ADMIN_Dashboard_DocentiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Dashboard_DocentiViewModel item = new ADMIN_Dashboard_DocentiViewModel(riga);
                    list.Add(item);
                }
                    return Json(list);
            }
        #endregion
        #region Dettagli
            public JsonResult Dettagli_Corsi()
            {
                DataTable tabbola = _query.OttieniADMINDettagli_Corsi();
                List<ADMIN_Dettagli_CorsiViewModel> list = new List<ADMIN_Dettagli_CorsiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Dettagli_CorsiViewModel item = new ADMIN_Dettagli_CorsiViewModel(riga);
                    list.Add(item);
                }
                    return Json(list);
            }

            public JsonResult Dettagli_Corsisti()
            {
                DataTable tabbola = _query.OttieniADMINDettagli_Corsisti();
                List<ADMIN_Dettagli_CorsistiViewModel> list = new List<ADMIN_Dettagli_CorsistiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Dettagli_CorsistiViewModel item = new ADMIN_Dettagli_CorsistiViewModel(riga);
                    list.Add(item);
                }
                    return Json(list);
            }

            public JsonResult Dettagli_Docenti()
            {
                DataTable tabbola = _query.OttieniADMINDettagli_Docenti();
                List<ADMIN_Dettagli_DocentiViewModel> list = new List<ADMIN_Dettagli_DocentiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Dettagli_DocentiViewModel item = new ADMIN_Dettagli_DocentiViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }
        #endregion
        #region Lezioni
            public JsonResult Lezioni_ListaLezioni()
            {
                DataTable tabbola = _query.OttieniADMINLezione_ListaLezioni();
                List<ADMIN_Lezioni_ListaLezioniViewModel> list = new List<ADMIN_Lezioni_ListaLezioniViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Lezioni_ListaLezioniViewModel item = new ADMIN_Lezioni_ListaLezioniViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }

            public JsonResult Lezioni_ListaMateriali()
            {
                DataTable tabbola = _query.OttieniADMINLezione_ListaMateriali();
                List<ADMIN_Lezioni_ListaMaterialiViewModel> list = new List<ADMIN_Lezioni_ListaMaterialiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Lezioni_ListaMaterialiViewModel item = new ADMIN_Lezioni_ListaMaterialiViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }
            public JsonResult Lezioni_ListaModuli()
            {
                DataTable tabbola = _query.OttieniADMINLezione_ListaModuli();
                List<ADMIN_Lezioni_ListaModuliViewModel> list = new List<ADMIN_Lezioni_ListaModuliViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Lezioni_ListaModuliViewModel item = new ADMIN_Lezioni_ListaModuliViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }

            public JsonResult Lezioni_Test()
            {
                DataTable tabbola = _query.OttieniADMINLezione_Test();
                List<ADMIN_Lezioni_TestViewModel> list = new List<ADMIN_Lezioni_TestViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Lezioni_TestViewModel item = new ADMIN_Lezioni_TestViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }

            public JsonResult Lezioni_ListaCorsi()
            {
                DataTable tabbola = _query.OttieniADMINLezione_ListaCorsi();
                List<ADMIN_Lezioni_ListaCorsiViewModel> list = new List<ADMIN_Lezioni_ListaCorsiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Lezioni_ListaCorsiViewModel item = new ADMIN_Lezioni_ListaCorsiViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }
        #endregion
        #region Test
            public JsonResult Test_ListaCorsisti()        
            {
                DataTable tabbola = _query.OttieniADMINTest_ListaCorsisti();
                List<ADMIN_Test_ListaCorsistiViewModel> list = new List<ADMIN_Test_ListaCorsistiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Test_ListaCorsistiViewModel item = new ADMIN_Test_ListaCorsistiViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }

            public JsonResult Test_ListaTest()
            {
                DataTable tabbola = _query.OttioniADMINTest_ListaTest();
                List<ADMIN_Test_ListaTestViewModel> list = new List<ADMIN_Test_ListaTestViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Test_ListaTestViewModel item = new ADMIN_Test_ListaTestViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }
        #endregion
        #region Filtri
            public JsonResult Filtro_CorsiAssegnati(List<string> parametri,List<string> valori)
            {
                parametri.Add("@stato1"); 
                // valori.Add("profassegnato");
                DataTable tabbola = _query.OttieniADMIN_Filtro_CorsiAssegnati(parametri, valori);
                List<ADMIN_Filtro_CorsiAssegnatiViewModel> list = new List<ADMIN_Filtro_CorsiAssegnatiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Filtro_CorsiAssegnatiViewModel item = new ADMIN_Filtro_CorsiAssegnatiViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }

            public JsonResult Filtro_Corsisti(List<string> parametri,List<string> valori)
            {
                parametri.Add("@stato1"); parametri.Add("@stato2");
                // valori.Add("attivo"); parametri.Add("allontanato");
                DataTable tabbola = _query.OttieniADMIN_Filtro_Corsisti(parametri, valori);
                List<ADMIN_Filtro_CorsistiViewModel> list = new List<ADMIN_Filtro_CorsistiViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Filtro_CorsistiViewModel item = new ADMIN_Filtro_CorsistiViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }

            public JsonResult Filtro_Corso(List<string> parametri,List<string> valori)
            {
                parametri.Add("@stato1"); parametri.Add("@stato2"); parametri.Add("@stato3");
                // valori.Add("attivo"); valori.Add("concluso"); valori.Add("annullato");
                DataTable tabbola = _query.OttieniADMIN_Filtro_Corso(parametri,valori);
                List<ADMIN_Filtro_CorsoViewModel> list = new List<ADMIN_Filtro_CorsoViewModel>();
                foreach (DataRow riga in tabbola.Rows)
                {
                    ADMIN_Filtro_CorsoViewModel item = new ADMIN_Filtro_CorsoViewModel(riga); 
                    list.Add(item);
                }
                return Json(list);
            }
        #endregion 
    }
}