using Microsoft.AspNetCore.Mvc;
using Student.Dataccess.Modal;
using Student.UI.Models;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Net.Http;
using Newtonsoft.Json;



namespace Student.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

            public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
            {
                _logger = logger;
                

            }

         public IActionResult Index()
         {
             return View();
         }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
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
