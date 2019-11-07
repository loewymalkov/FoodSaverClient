using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FoodSaverClient.Models
{
    public class Recipe 
    {
        public Recipe()
        {
            this.Ingredients = new HashSet<IngredientRecipe>();
        }
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipePhoto { get; set; }
        public int BaseServings { get; set; }
        public decimal CostPerServing { get; set; }
        public string PrepTime { get; set; }
        public string Directions { get; set; }
        public string NutritionInfo { get; set; }
        public string RecipeTips { get; set; }
        public ICollection<IngredientRecipe> Ingredients { get; }

        public static List<Recipe> GetRecipes () 
        {
            var apiCallTask = ApiHelper.RecipeCall ();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray> (result);
            List<Recipe> recipeList = JsonConvert.DeserializeObject<List<Recipe>>(jsonResponse.ToString());
            return recipeList;
        }

         public static Recipe PutRecipe(Recipe recipe)
        {
            var apiCallTask = ApiHelper.CallRecipeList(recipe.RecipeName);
            var result = apiCallTask.Result;
            JArray jresponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Recipe> recipeResponse = JsonConvert.DeserializeObject<List<Recipe>>(jresponse.ToString());
            Recipe targetRecipe = recipeResponse[0];
            if (targetRecipe.RecipeName != null)
            {
                // display the list

            }
            else
            {
                targetRecipe.RecipeName = recipe.RecipeName;
            }
            var apiPutTask = ApiHelper.ApiPut(targetRecipe.RecipeId, targetRecipe);
            return targetRecipe;
        }
    }
}