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

        public JsonResult Index()
        {
            DataTable tabbola = _query.OttieniCorsi();
            List<CorsoViewModel> list = new List<CorsoViewModel>();
            //per ogni riga del datatable...
            foreach(DataRow riga in tabbola.Rows)
            {
                //converte in oggetto Corsi un record di tabella
                CorsoViewModel vista = CorsoViewModel.FromDataRow(riga);
                list.Add(vista);
            }
            return Json(list);
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
        
        public JsonResult FileView()
        {
            DataTable tabbola = _query.OttieniPNG();
            List<MaterialiViewModel> list = new List<MaterialiViewModel>();
            //per ogni riga del datatable...
            foreach(DataRow riga in tabbola.Rows)
            {
                //converte in oggetto Corsi un record di tabella
                MaterialiViewModel vista = MaterialiViewModel.FromDataRow(riga);
                list.Add(vista);
            }
            return Json(list);      
        }

        private List<MaterialiViewModel> GetImages()
        {
            DataTable IMGTAB= new DataTable();
            IMGTAB = _query.OttieniPNG();
            List<MaterialiViewModel> images = new List<MaterialiViewModel>();
            foreach (DataRow riga in IMGTAB.Rows)
            {
                MaterialiViewModel Immagine = MaterialiViewModel.FromDataRow(riga);
                images.Add(Immagine);
            }
            return images;
        }
    }
}