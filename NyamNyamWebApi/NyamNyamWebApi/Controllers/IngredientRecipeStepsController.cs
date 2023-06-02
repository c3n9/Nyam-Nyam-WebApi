using NyamNyamWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NyamNyamWebApi.Controllers
{
    public class IngredientRecipeStepsController : ApiController
    {
        NyamNyamEntities DB = new NyamNyamEntities();
        [HttpGet]
        [Route("api/IngredientRecipeSteps/GetAllIngredientsRecipeSteps")]
        public IHttpActionResult GetAllIngredientsRecipeSteps()
        {
            return Ok(DB.Ingredient_RecipeSteps.Select(i => new
            {
                i.Id,
                i.IngredientId,
                i.RecipesId,
                i.Quantity,
                i.Used
            }));
        }

        [HttpPost]
        [Route("api/IngredientRecipeStep/Add")]
        public IHttpActionResult PostIngredientRecipeStep(Ingredient_RecipeSteps contextIngredientStep)
        {
            if (contextIngredientStep != null)
            {
                DB.Ingredient_RecipeSteps.Add(contextIngredientStep);
                DB.SaveChanges();
            }
            return Ok();
        }
        [HttpPost]
        [Route("api/IngredientRecipeStep/AddRange")]
        public IHttpActionResult PostIngredientRecipeStepRange(List<Ingredient_RecipeSteps> contextIngredientStep)
        {
            if (contextIngredientStep.Count != 0)
            {
                DB.Ingredient_RecipeSteps.AddRange(contextIngredientStep);
                DB.SaveChanges();
            }
            return Ok();
        }
    }
}
