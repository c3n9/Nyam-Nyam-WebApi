using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyam_Nyam.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PricePerUnit { get; set; }
        public string MainUnit { get; set; }
        public int AvailableCountInStock { get; set; }
    }
}
