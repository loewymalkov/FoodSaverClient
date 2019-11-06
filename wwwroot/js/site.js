// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let shoppingListTotal = 0;
let ingredientArray = [];

let sidebarDisplayUpdater = function(pricePerServing, servingQuantity, recipeServings) {
        // Updates price
        pricePerServing *= servingQuantity;
        shoppingListTotal += pricePerServing;
        // Updates servings
        recipeServings *= servingQuantity;
        shoppingListServings += recipeServings;
    };


let grandTotal = function(shoppingList){
    
}
// ADD 
// NEED TO PASS shoppingListTotal back to User model
// For loop to go through all ingredients for a given recipe
// 

