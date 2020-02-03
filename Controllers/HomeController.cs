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

        
        public IActionResult FileAdd(List<IFormFile> files)
        {  /*
            if (File != null && file.ContentLength > 0)  
                
                try 
                {  
                    string path = Path.Combine(Server.MapPath("~/Images"),Path.GetFileName(file.FileName));
                    object p = file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";  
                }  
                catch (Exception ex)  
                {  
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();  
                }  
            else 
            {  
                ViewBag.Message = "You have not specified a file.";  
            }  */
            return View();  
        }
        
        
    }
}