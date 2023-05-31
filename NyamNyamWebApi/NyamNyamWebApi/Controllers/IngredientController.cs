using NyamNyamWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NyamNyamWebApi.Controllers
{
    public class IngredientController : ApiController
    {
        NyamNyamEntities DB = new NyamNyamEntities();
        [HttpGet]
        [Route("api/Ingredient/GetAllIngredient")]
        public IHttpActionResult GetAllIngredients()
        {
            return Ok(DB.Ingredient.Select(i => new
            {
                i.Id,
                i.Name,
                i.PricePerUnit,
                i.MainUnit,
                i.AvailableCountInStock
            }));
        }
    }
}
