using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProfileDetail.Models;

namespace ProfileDetail.Controllers
{
    public class HomeController : Controller
    {


        private readonly AppDbContext appDb;
        
        //private readonly ILogger<HomeController> _logger;
       

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(AppDbContext appDB)
        {
            this.appDb = appDB;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string gmail, string password)
        {
            if (gmail == "ali@gmail.com" && password== "ali12345")
            {
                return RedirectToAction("UserProfile");
            }
            
            return View();
        }

        public IActionResult UserProfile()
        {

            var data = appDb.ProfileDetails.FirstOrDefault();

            return View(data);
        }
        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
