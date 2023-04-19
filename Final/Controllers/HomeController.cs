using Final.Models;
using Final.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        // Making the Repository
        private iEntertainerRepository repo { get; set; }

        public HomeController(iEntertainerRepository temp)
        {
            repo = temp;
        }

        // Returns Home Page
        public IActionResult Index()
        {

            return View();
        }

        // Returns Entertainer
        public IActionResult Entertainers()
        {
            var x = new ProjectsViewModel
            {
                Entertainers = repo.Entertainers
                .OrderBy(e => e.EntStageName)
            };
            return View(x);
        }

        //Returns the Input Page
        [HttpGet]
        public IActionResult Input()
        {
            return View(new Entertainer());
        }


        // Uploads to the Database
        [HttpPost]
        public IActionResult Input(Entertainer e)
        {
            if (ModelState.IsValid)
            {
                repo.AddEntertainer(e);

                return RedirectToAction("Entertainers");
            }
            else
            {
                return RedirectToAction("Entertainers");
            }
        }

        // Dsiplay the Details of the Entertainer Page
        [HttpGet]
        public IActionResult Details(int id)
        {
            var application = repo.Entertainers
                .Single(x => x.EntertainerId == id);

            return View(application);
        }

        // Upload Changes to the Database
        [HttpPost]
        public IActionResult Details(Entertainer e)
        {
            repo.EditEntertainer(e);

            return RedirectToAction("Entertainers");
        }


        // Deletes the Entertainer
        [HttpPost]
        public IActionResult Delete(Entertainer e)
        {
            repo.DeleteEntertainer(e);

            return RedirectToAction("Entertainers");
        }

    }
}
