using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eLearningService.Models.ViewModels;
using eLearningService.Models.Query;
using System.Data;

namespace eLearningService.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuery _query;

        public HomeController(IQuery query)
        {
            _query = query;
        }

        public JsonResult Index()
        {
            DataTable tabbola = _query.OttieniCorsi();
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
