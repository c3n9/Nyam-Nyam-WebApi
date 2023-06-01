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
        public int alltime
        {
            get
            {
                return this.RecipeSteps.Sum(s => s.Time);
            }
        }
    }
}
