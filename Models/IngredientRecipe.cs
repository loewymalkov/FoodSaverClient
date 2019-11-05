namespace FoodSaverClient.Models
{
    public class IngredientRecipe
    {
        public int IngredientRecipeId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }


    }
}