using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyam_Nyam.Models
{
    public partial class Ingredient_RecipeSteps
    {
        public bool Color
        {
            get
            {
                if (Quantity * int.Parse(RecipeSteps.Dish.BaseServings) < Ingredient.AvailableCountInStock || Quantity * int.Parse(RecipeSteps.Dish.BaseServings) == Ingredient.AvailableCountInStock)
                    return true;
                if (Quantity * int.Parse(RecipeSteps.Dish.BaseServings) > Ingredient.AvailableCountInStock)
                    return false;
                else
                    return false;
            }
        }
    }
}
