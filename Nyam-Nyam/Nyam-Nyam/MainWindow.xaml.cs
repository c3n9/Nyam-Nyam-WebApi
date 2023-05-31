using Nyam_Nyam.Pages;
using Nyam_Nyam.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Nyam_Nyam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUp();
        }

        private async void SetUp()
        {
            await DBConnection.InitializeDBConnection();
            App.MainWindowInstance = this;
            MainFrame.Navigate(new PDishes());
        }

        private void HLDishes_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PDishes());
        }

        private void HLIngredients_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PListOfIngredients());
        }

        private void HLOrders_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new POrders());
        }

    }
}
