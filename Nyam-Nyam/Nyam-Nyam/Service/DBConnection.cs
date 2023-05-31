using Nyam_Nyam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyam_Nyam.Service
{
    public static class DBConnection
    {
        public static List<Dish> Dishs { get; set; }
        public static List<Category> Categories { get; set; }
        public static List<Ingredient> Ingredients { get; set; }
        public static List<Ingredient_RecipeSteps> Ingredients_RecipeSteps { get; set; }
        public static List<RecipeSteps> RecipesSteps { get; set; }

        public static async Task InitializeDBConnection()
        {
            await RefreshEnums();
            await RefreshData();
        }
        public static async Task RefreshData()
        {
            Dishs = await NetManager.Get<List<Dish>>("api/Dish/GetAllDishes");
            RecipesSteps = await NetManager.Get<List<RecipeSteps>>("api/RecipeSteps/GetAllRecipeSteps");
            Ingredients_RecipeSteps = await NetManager.Get<List<Ingredient_RecipeSteps>>("api/IngredientRecipeSteps/GetAllIngredientsRecipeSteps");
        }
        public static async Task RefreshEnums()
        {
            Categories = await NetManager.Get<List<Category>>("api/Category/GetAllCategory");
            Ingredients = await NetManager.Get<List<Ingredient>>("api/Ingredient/GetAllIngredient");
        }
    }
}
