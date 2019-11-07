using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FoodSaverClient.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            this.Recipes = new HashSet<IngredientRecipe>();
        }
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public decimal IngredientPrice { get; set; }
        public int IngredientQuantity { get; set; }
        public string IngredientSubstitution { get; set; }
        public ICollection<IngredientRecipe> Recipes { get; }

        public static List<Ingredient> GetIngredients () 
        {
            var apiCallTask = ApiHelper.IngredientCall ();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray> (result);
            List<Ingredient> ingredientList = JsonConvert.DeserializeObject<List<Ingredient>>(jsonResponse.ToString());
            return ingredientList;
        }
    }
}