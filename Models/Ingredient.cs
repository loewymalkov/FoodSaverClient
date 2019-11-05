
using System.Collections.Generic;

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
    }
}