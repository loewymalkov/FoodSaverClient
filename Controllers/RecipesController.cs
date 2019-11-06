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
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            var allRecipes = Recipe.GetRecipes();
            return View(allRecipes);
        }

        public ActionResult Details (Recipe recipe)
        {
            return View(recipe);
        }


    }
}