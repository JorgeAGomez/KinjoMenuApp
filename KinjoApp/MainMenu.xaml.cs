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

        private void goToSpecialMaki(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SpecialMaki());
        }

        private void goToTempura(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Tempura()); 
        }

        private void goToYakiniku(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Yakiniku());
        }

        private void goToPartyPlatter(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PartyPlatters());
        }

        private void goToSauces(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SideSauces());
        }

        private void goToDrinks(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Drinks());
        }

        private void goToCart(object sender, RoutedEventArgs e)
        {
            //Cart window1 = new KinjoApp.Cart();
            // window1.ShowDialog();
            this.NavigationService.Navigate(new ShoppingCart());
        }
    }
}
