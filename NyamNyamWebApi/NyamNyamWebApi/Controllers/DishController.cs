using NyamNyamWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NyamNyamWebApi.Controllers
{
    public class DishController : ApiController
    {
        NyamNyamEntities DB = new NyamNyamEntities();
        [HttpGet]
        [Route("api/Dish/GetAllDishes")]
        public IHttpActionResult GetAllDishes()
        {
            return Ok(DB.Dish.Select(d => new
            {
                d.Id,
                d.Name, 
                d.Description,
                d.FinalPrice,
                d.BaseServings,
                d.Photo,
                CategoryId = d.CategoryId,
                RecipeSteps = d.RecipeSteps.Select(r => new //Обращаемся к самой таблице, навигационные свойства
                {
                    r.Id,
                    r.DishId,
                    r.ProcessDescription,
                    r.Time,
                    Ingredient_RecipeSteps = r.Ingredient_RecipeSteps.Select(i => new
                    {
                        i.Id,
                        i.IngredientId,
                        i.Used,
                        i.Quantity,
                        i.RecipesId
                       
                    })
                })
            }));
        }
    }
}
