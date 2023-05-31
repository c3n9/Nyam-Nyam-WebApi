using Newtonsoft.Json;
using Nyam_Nyam.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyam_Nyam.Models
{
    public partial class RecipeSteps
    {
        public int Id { get; set; }
        public string ProcessDescription { get; set; }
        public int Time { get; set; }
        public Nullable<int> DishId { get; set; }
        [JsonIgnore]
        public Dish Dish 
        {
            get
            {
                return DBConnection.Dishs.FirstOrDefault(d=> d.Id == DishId);
            }
            set
            {
                DishId = value.Id;
            } 
        }
        public virtual ICollection<Ingredient_RecipeSteps> Ingredient_RecipeSteps { get; set; }
    }
}
