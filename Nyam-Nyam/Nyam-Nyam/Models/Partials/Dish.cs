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

        //public BitmapImage BytesToImage
        //{
        //    get
        //    {
        //        var image = new BitmapImage();
        //        foreach (var item in Photo)
        //        {
        //            using (MemoryStream ms = new MemoryStream(item))
        //            {
        //                image = new BitmapImage();
        //                image.BeginInit();
        //                image.CacheOption = BitmapCacheOption.OnLoad;
        //                image.StreamSource = ms;
        //                image.EndInit();

        //            }
        //        }
        //        return image;
        //    }
        //}


        //public int AllTime
        //{
        //    get
        //    {
        //        return this.RecipeSteps.Sum(s => s.Time);
        //    }
        //}
    }
}
