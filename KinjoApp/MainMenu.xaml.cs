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

namespace KinjoApp
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void goToAppetizer(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Appetizer());
        }

        private void goToSushi(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Sushi());
        }

        private void goToSashimi(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Sashimi());
        }

        private void goToMaki(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Maki());
        }
    }
}
