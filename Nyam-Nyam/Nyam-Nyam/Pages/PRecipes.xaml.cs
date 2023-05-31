using Nyam_Nyam.Models;
using Nyam_Nyam.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nyam_Nyam.Pages
{
    /// <summary>
    /// Логика взаимодействия для PRecipes.xaml
    /// </summary>
    public partial class PRecipes : Page
    {
        Dish contextDish;
        public PRecipes(Dish dish)
        {
            InitializeComponent();        
            contextDish = dish;
            
            Refresh();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BMinus_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(contextDish.BaseServings) == 0)
                return;
            contextDish.BaseServings = Convert.ToString(int.Parse(contextDish.BaseServings) - 1);
            //App.DB.SaveChanges();
            Refresh();
            DataContext = null;
            DataContext = contextDish;
        }
        private void Refresh()
        {
            DataContext = null;
            DataContext = contextDish;
            var v = contextDish.RecipeSteps.SelectMany(s => s.Ingredient_RecipeSteps).ToList();
            double result = 0;
            foreach (var i in v)
            {
                if (i.Used == true)
                {
                    result += double.Parse(i.Ingredient.PricePerUnit) * i.Quantity.Value * double.Parse(contextDish.BaseServings);
                }
            }
            TBTotalCost.Text = $"Total cost: {result}";
            DGIngredient.ItemsSource = v;
            LVRecipesStep.ItemsSource = contextDish.RecipeSteps.ToList();
        }
        private void BPlus_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(contextDish.BaseServings) == 99)
                return;
            contextDish.BaseServings = Convert.ToString(int.Parse(contextDish.BaseServings) + 1);
            //App.DB.SaveChanges();
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void TBCount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private void TBCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            //App.DB.SaveChanges();
        }

        private void DGIngredient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //App.DB.SaveChanges();
            Refresh();
        }
    }
}
