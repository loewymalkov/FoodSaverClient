using System.Collections.Generic;


namespace FoodSaverClient.Models
{
    public class User
    {
        public int Budget { get; set; }
        public int ServingQuantity { get; set; }
        public decimal ShoppingListTotal { get; set; }
        public List<Recipe> RecipeId { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}