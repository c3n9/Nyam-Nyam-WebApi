using Microsoft.Win32;
using Nyam_Nyam.Models;
using Nyam_Nyam.Service;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PAddNewDish.xaml
    /// </summary>
    public partial class PAddNewDish : Page
    {
        Dish contextDish;
        List <Ingredient> ingredients= new List <Ingredient> ();
        List<RecipeSteps> recipeSteps = new List<RecipeSteps>();
        List<Ingredient_RecipeSteps> ingredientRecipeSteps = new List<Ingredient_RecipeSteps>();
        public PAddNewDish(Dish dish)
        {
            InitializeComponent();
            contextDish = dish;
            DataContext = contextDish;
            CBCategory.ItemsSource = DBConnection.Categories.ToList();
            CBIngredient.ItemsSource = DBConnection.Ingredients.ToList();
            if (contextDish.Id == 0)
            {
                BDelete.Visibility = Visibility.Collapsed;
            }
            else
            {
                recipeSteps = dish.RecipeSteps.ToList();
                DGSteps.ItemsSource = recipeSteps;
            }
        }
        private void BPhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".png, .jpg, .jpeg| *.png; *.jpg; *.jpeg"};
            if (dialog.ShowDialog().GetValueOrDefault()) 
            { 
                var image = File.ReadAllBytes(dialog.FileName);
                contextDish.Photo = image;
                DataContext = null;
                DataContext = contextDish;
            }
        }

        private async void BDelete_Click(object sender, RoutedEventArgs e)
        {
            await NetManager.Delete<bool>($"api/Dish/Delete/{contextDish.Id}");
            await DBConnection.RefreshData();
            NavigationService.GoBack();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private async void BAddStep_Click(object sender, RoutedEventArgs e)
        {
            var step = new RecipeSteps();
            string error = "";
            if (String.IsNullOrWhiteSpace(TBStep.Text))
                error += "Enter process description\n";
            if (String.IsNullOrWhiteSpace(TBTime.Text))
                error += "Enter the process time\n";
            if (!String.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show(error);
                return;
            }
            step.ProcessDescription = TBStep.Text;
            step.Time = int.Parse(TBTime.Text);
            if (contextDish.Id != 0)
            {
                recipeSteps = DBConnection.RecipesSteps.Where(r => r.DishId == contextDish.Id).ToList();
                step.DishId = contextDish.Id;
                recipeSteps.Add(step);
                //App.DB.RecipeSteps.Add(step);
                await NetManager.Post("api/RecipeSteps/Add", step);
                await DBConnection.RefreshData();
            }
            if (contextDish.Id == 0)
            {
                recipeSteps.Add(step);
                step.DishId = 0;
            }
            DGSteps.ItemsSource = recipeSteps;
        }

        private void DGSteps_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var step = DGSteps.SelectedItem as RecipeSteps;
            DGIngredients.ItemsSource = DBConnection.Ingredients_RecipeSteps.Where(x => x.RecipesId == step.Id).ToList();
        }

        private async void BAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            if(contextDish.Id == 0)
            {
                MessageBox.Show("Save dish and steps");
                return;
            }
            string error = "";
            var ingredientSteps = new Ingredient_RecipeSteps();
            var step = DGSteps.SelectedItem as RecipeSteps;
            var ingredient = CBIngredient.SelectedItem as Ingredient;
            if (step == null)
            {
                error += "Select step\n";
            }
            if (ingredient == null)
            {
                error += "Select ingredient\n";
            }
            if (String.IsNullOrWhiteSpace(TBQuantity.Text))
            {
                error += "Enter quantity\n";
            }
            if (!String.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show(error);
                return;
            }
            ingredientSteps.RecipesId = step.Id;
            ingredientSteps.Quantity = int.Parse(TBQuantity.Text);
            ingredientSteps.IngredientId = ingredient.Id;
            ingredientSteps.Used = true;
            if (contextDish.Id == 0)
            {
                ingredientRecipeSteps.Add(ingredientSteps);
            }
            else
            {
                await NetManager.Post("api/IngredientRecipeStep/Add", ingredientSteps);
                await DBConnection.InitializeDBConnection();
                //App.DB.Ingredient_RecipeSteps.Add(ingredientSteps);
            }
            DGIngredients.ItemsSource = DBConnection.Ingredients_RecipeSteps.Where(x => x.RecipesId == step.Id).ToList();
        }

        private async void BSave_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            if (String.IsNullOrWhiteSpace(contextDish.Name))
                error += "Enter name\n";
            if (String.IsNullOrWhiteSpace(contextDish.Description))
                error += "Enter description\n";
            if (String.IsNullOrWhiteSpace(contextDish.SourceRecipeLink))
                error += "Enter source recipe link\n";
            if (String.IsNullOrWhiteSpace(contextDish.FinalPrice))
                error += "Enter final price\n";
            if (CBCategory.SelectedItem == null)
                error += "Select category\n";
            if (contextDish.Photo == null)
                error += "Load image\n";
            if (recipeSteps.Count == 0)
                error += "Add recipe step\n";
            if (!String.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show(error);
                return;
            }
            var selectedCategory = CBCategory.SelectedItem as Category;
            contextDish.CategoryId = selectedCategory.Id;
            if (contextDish.Id == 0)
            {
                await NetManager.Post("api/Dish/Add", contextDish);
                await DBConnection.RefreshData();
                //App.DB.Dish.Add(contextDish);
                //App.DB.SaveChanges();
                foreach (var r in recipeSteps)
                {
                    r.DishId = contextDish.Id;
                }
                await NetManager.Post("api/RecipeSteps/AddRange", recipeSteps);
                await DBConnection.RefreshData();
                await NetManager.Post("api/IngredientRecipeStep/AddRange", ingredientRecipeSteps);
                await DBConnection.RefreshData();
                //App.DB.RecipeSteps.AddRange(recipeSteps);
                //App.DB.SaveChanges();
                //App.DB.Ingredient_RecipeSteps.AddRange(ingredientRecipeSteps);
            }
            await DBConnection.InitializeDBConnection();
            //App.DB.SaveChanges();
            NavigationService.GoBack();
        }
    }
}
