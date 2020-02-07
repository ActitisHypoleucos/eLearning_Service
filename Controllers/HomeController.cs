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
    public class HomeController : Controller
    {
        private readonly IQuery _query;

        public HomeController(IQuery query)
        {
            _query = query;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public JsonResult IndexCorsi()
        {
            DataTable tabbola = _query.OttieniCorsi();
            List<CorsoViewModel> list = new List<CorsoViewModel>();
            //per ogni riga del datatable...
            foreach(DataRow riga in tabbola.Rows)
            {
                //converte in oggetto Corsi un record di tabella
                CorsoViewModel item = new CorsoViewModel(riga);
                list.Add(item);
            }
            return Json(list);
        }

        public JsonResult list_PNG()
        {
            DataTable tabbola = _query.OttieniPNG();
            List<MaterialiViewModel> list = new List<MaterialiViewModel>();
            //per ogni riga del datatable...
            foreach(DataRow riga in tabbola.Rows)
            {
                //converte in oggetto Corsi un record di tabella
                
                MaterialiViewModel item = new MaterialiViewModel(riga);
                list.Add(item);
            }
            return Json(list);      
        }

        public JsonResult ADMIN_Dashboard_Corsi()
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

        public JsonResult ADMIN_Dashboard_Corsisti()
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

        public JsonResult ADMIN_Dashboard_Docenti()
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

        public JsonResult ADMIN_Dettagli_Corsi()
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

        public JsonResult ADMIN_Dettagli_Corsisti()
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

        public JsonResult ADMIN_Dettagli_Docenti()
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

        public JsonResult ADMIN_Lezioni_ListaLezioni()
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

        public JsonResult ADMIN_Lezioni_ListaMateriali()
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
        public JsonResult ADMIN_Lezioni_ListaModuli()
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

        public JsonResult ADMIN_Lezioni_Test()
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

        public JsonResult ADMIN_Test_ListaCorsisti()        
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

        public JsonResult ADMIN_Test_ListaTest()
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
    }
}