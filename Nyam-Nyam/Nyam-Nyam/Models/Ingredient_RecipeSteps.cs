using Newtonsoft.Json;
using Nyam_Nyam.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyam_Nyam.Models
{
    public partial class Ingredient_RecipeSteps
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int RecipesId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<bool> Used { get; set; }
        [JsonIgnore]
        public Ingredient Ingredient
        {
            get
            {
                return DBConnection.Ingredients.FirstOrDefault(i => i.Id == IngredientId);
            }
            set
            {
                IngredientId = value.Id;
            }
        }
        [JsonIgnore]
        public RecipeSteps RecipeSteps
        {
            get
            {
                return DBConnection.RecipesSteps.FirstOrDefault(r => r.Id == RecipesId);
            }
            set
            {
                RecipesId = value.Id;
            }
        }
    }
}
