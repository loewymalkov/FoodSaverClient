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

        [HttpPost]
        public ActionResult Create()
        {
            return RedirectToAction("Details", "ShoppingList");
        }

        public ActionResult Details ()
        {
            return View();
        }


    }
}