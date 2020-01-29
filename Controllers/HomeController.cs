using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eLearning_Trying_Database.Models;
using System.Data;

namespace eLearning_Trying_Database.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public JsonResult Index()
        {
            CLS_DB dibbi = new CLS_DB();
            DataTable tabbola = dibbi.MySelect("Select Nome_Corso from Corsi");
            List<CorsoViewModel> listaCorsi = new List<CorsoViewModel>();
            //per ogni riga del datatable...
            foreach(DataRow corsoRow in tabbola.Rows)
            {
                //converte in oggetto Corsi un record di tabella
                CorsoViewModel corso = CorsoViewModel.FromDataRow(corsoRow);
                listaCorsi.Add(corso);
            }
            return Json(listaCorsi);
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
    }
}
