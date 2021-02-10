using IS_413_Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413_Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Top5()
        {
            //declaration of the variable and instantiation of the variable
            //list is just a container that can hold objects
            List<string> RestaurantList = new List<string>();

            foreach(ProvoRestaurants r in ProvoRestaurants.GetProvoRestaurants())
            {
                RestaurantList.Add($"#{r.Rank}: {r.RestaurantName} Fav Dish: {r.FavoriteDish} Location: {r.Address} Phone: {r.PhoneNumber} Website: {r.WebsiteLink}");
            }

            return View(RestaurantList);
        }

        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]

        //this will be submit and it will pass in the NewSuggestion
        public IActionResult Submit(UserSuggestions model)
        {
            if (ModelState.IsValid)
            {
                ArchiveSuggestions.AddSuggestion(model);
                return View("Suggestions", ArchiveSuggestions.Suggestions);
            }
            return View();
        }

        //make sure the suggestions that have been submitted show up on the page
        public IActionResult Suggestions()
        {
            return View("Suggestions", ArchiveSuggestions.Suggestions);
        }

 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
