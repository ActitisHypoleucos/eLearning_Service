using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eLearningService.Models.ViewModels;
using eLearningService.Models.Services;
using System.Data;
using System.IO;
using Microsoft.AspNetCore.Http;
using static System.Net.WebRequestMethods;
using eLearningService.Models;

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
    }
}