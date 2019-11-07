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
        public IActionResult Index(User user)
        {
            User newUser = new User();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            SelectListItem one = new SelectListItem { Text = "34 Servings", Value = "1" };
            SelectListItem two = new SelectListItem { Text = "68 Servings", Value = "2" };
            ViewBag.servingMultiplier = new List<SelectListItem> { one, two };
            return View();
        }

        [HttpPost]
        public ActionResult Create(Recipe recipe)
        {
            var allRecipes = Recipe.GetRecipes();
            return RedirectToAction("Details", "ShoppingList");
        }

        public ActionResult Details (User user)
        {
            return View(user);
        }


    }
}