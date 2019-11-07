using System.Collections.Generic;


namespace FoodSaverClient.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int Budget { get; set; }
        public int ServingQuantity { get; set; }
        public int ServingMultiplier { get; set; }
        public decimal ShoppingListTotal { get; set; }
        public List<Recipe> Recipes { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}