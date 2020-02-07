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
        #region Dichiarazione
            private readonly IQuery _query;

            public HomeController(IQuery query)
            {
                _query = query;
            }
        #endregion
        #region ViewResult
            public IActionResult Privacy()
            {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        #endregion
        #region base    
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
        #endregion
        
        
        
        
        
    }
}