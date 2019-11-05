using System.Collections.Generic;

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
        public string Directions { get; set; }
        public string NutritionInfo { get; set; }
        public string RecipeTips { get; set; }
        public decimal PricePerServing { get; set; }
        public ICollection<IngredientRecipe> Ingredients { get; }
        
    }
}