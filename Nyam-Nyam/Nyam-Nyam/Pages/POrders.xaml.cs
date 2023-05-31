using Nyam_Nyam.Models;
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

namespace Nyam_Nyam.Pages
{
    /// <summary>
    /// Логика взаимодействия для POrders.xaml
    /// </summary>
    public partial class POrders : Page
    {
        public POrders()
        {
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        {
            App.MainWindowInstance.HLOrders.IsEnabled = false;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            App.MainWindowInstance.HLOrders.IsEnabled = true;
        }
    }
}
