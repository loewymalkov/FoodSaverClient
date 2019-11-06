// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let shoppingListTotal = 0;
let shoppingListTotal = 0;
let ingredientArray = [];

let sidebarDisplayUpdater = function(pricePerServing, servingSelection, recipeServings) {
        // Updates price
        pricePerServing *= servingSelection;
        shoppingListTotal += pricePerServing;
        // Updates servings
        recipeServings *= servingSelection;
        shoppingListServings += recipeServings;
    };

// ADD 


// NEED TO PASS shoppingListTotal back to User model
// @Recipe.ShoppingListTotal += shoppingListTotal;

// For loop to go through all ingredients for a given recipe
// 

