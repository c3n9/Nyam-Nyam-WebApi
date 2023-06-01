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
        [HttpPost]
        [Route("api/Ingredient/Add")]
        public IHttpActionResult PostDish(Ingredient ingredient)
        {
            if (ingredient != null)
            {
                DB.Ingredient.Add(ingredient);
                DB.SaveChanges();
            }
            return Ok();
        }
        [HttpPut]
        [Route("api/Ingredient/Edit")]
        public IHttpActionResult PutDish(Ingredient contextIngredient)
        {
            var ingredient = DB.Ingredient.FirstOrDefault(d => d.Id == contextIngredient.Id);
            if (ingredient == null)
                return BadRequest("User not found");
            if (ModelState.IsValid)
                DB.Entry(ingredient).CurrentValues.SetValues(contextIngredient);
            DB.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        [Route("api/Ingredient/Delete/{Id}")]
        public IHttpActionResult DeleteUser(int id)
        {
            var ingredient = DB.Ingredient.FirstOrDefault(i=> i.Id == id);
            if (ingredient == null)
                return BadRequest("Пользователь не найден");
            DB.Ingredient.Remove(ingredient);
            DB.SaveChanges();
            return Ok(true);
        }
    }
}
