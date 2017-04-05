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
    /// Interaction logic for Appetizer.xaml
    /// </summary>
    public partial class Appetizer : Page
    {
        public Appetizer()
        {
            InitializeComponent();
            //FoodItem.foodItems = new List<string[]>();
        }

        private void backToMenu(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenu());
        }



        private void itemSelected(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListView;
            if (item != null)
            {
                //string[] list3 = new string[4] { "pack://siteoforigin:,,,/Resources/Edamame.jpg", "Edamame", "Soft soybeans served in the pod, which are steamed and lightly tossed in sea salt.", "$5.10" };
                
                //FoodItem.foodItems.Add(list3);

            }
        }
    }
}
