using Newtonsoft.Json;
using Nyam_Nyam.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Nyam_Nyam.Models
{
    public partial class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BaseServings { get; set; }
        public int CategoryId { get; set; }
        public byte[] Photo { get; set; }
        public string SourceRecipeLink { get; set; }
        public string Description { get; set; }
        public string FinalPrice { get; set; }

        [JsonIgnore]
        public Category Category
        {
            get
            {
                return DBConnection.Categories.FirstOrDefault(c => c.Id == CategoryId);
            }
            set
            {
                CategoryId = value.Id;
            }
        }

        public virtual ICollection<RecipeSteps> RecipeSteps { get; set; }
    }
}
