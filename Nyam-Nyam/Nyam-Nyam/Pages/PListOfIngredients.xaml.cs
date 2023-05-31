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
    /// Логика взаимодействия для PListOfIngredients.xaml
    /// </summary>
    public partial class PListOfIngredients : Page
    {
        public PListOfIngredients()
        {
            InitializeComponent();
            Refresh();
        }

        private void HLDelete_Click(object sender, RoutedEventArgs e)
        {
            var ingredient = (sender as Hyperlink).DataContext as Ingredient;
            //App.DB.Ingredient.Remove(ingredient);
            //App.DB.SaveChanges();
            Refresh();
        }
        private void Refresh()
        {
            var ingredients =DBConnection.Ingredients.ToList();
            double result = 0;
            foreach(var i in ingredients)
            {
                double c = double.Parse(i.PricePerUnit) * i.AvailableCountInStock;
                result += c;
            }
            TBFullCost.Text = $"Total available ingredients for the amount ($): {result}";
            LVIngredients.ItemsSource = ingredients;
            App.MainWindowInstance.HLIngredients.IsEnabled = false;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            App.MainWindowInstance.HLIngredients.IsEnabled = true;
        }

        private void TBСount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            if(!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private void BPlus_Click(object sender, RoutedEventArgs e)
        {
            var ingredient = (sender as Button).DataContext as Ingredient;
            if (ingredient.AvailableCountInStock == 99)
                return;
            ingredient.AvailableCountInStock += 1;
            //App.DB.SaveChanges();
            Refresh();
        }

        private void BMinus_Click(object sender, RoutedEventArgs e)
        {
            var ingredient = (sender as Button).DataContext as Ingredient;
            if (ingredient.AvailableCountInStock == 0)
                return;
            ingredient.AvailableCountInStock -= 1;
            //App.DB.SaveChanges();
            Refresh();
        }

        private void TBСount_TextChanged(object sender, TextChangedEventArgs e)
        {
            //App.DB.SaveChanges();
        }
    }
}
