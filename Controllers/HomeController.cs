﻿using System;
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
    }
}