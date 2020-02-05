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

        public IActionResult Index()
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
            return View(listaCorsi);
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
        
        public IActionResult FileView()
        {
            List<MaterialiViewModel> images = GetImages();
            return View();           
        }
        
        [HttpPost]
        public IActionResult FileView(int imageId)
        {
            List<MaterialiViewModel> images = GetImages();
            MaterialiViewModel image = images.Find(p => p.ID == imageId);
            if (image != null)
            {
                image.IsSelected = true;
                ViewBag.Base64String = "data:image/png;base64," + Convert.ToBase64String(image.Materiale, 0, image.Materiale.Length);
            }
            return View(images);
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