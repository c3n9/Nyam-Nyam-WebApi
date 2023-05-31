using NyamNyamWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NyamNyamWebApi.Controllers
{
    public class RecipeStepsController : ApiController
    { 
        NyamNyamEntities DB = new NyamNyamEntities();
        [HttpGet]
        [Route("api/RecipeSteps/GetAllRecipeSteps")]
        public IHttpActionResult GetAllRecipeSteps()
        {
            return Ok(DB.RecipeSteps.Select(r => new
            {
                r.Id,
                r.ProcessDescription,
                r.Time,
                DishId = r.DishId
            }));
        }
    }
}
