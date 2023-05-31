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
    }
}
