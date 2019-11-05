using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using FoodSaverClient.Models;


namespace FoodSaverClient.Controllers
{
    public class ShoppingListController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Recipe recipe)
        {
            var targetRecipe = Recipe.PutRecipe(recipe);
            return RedirectToAction("Details", "Home", targetRecipe);
        }

        public ActionResult Details ()
        {
            return View();
        }
    }
}