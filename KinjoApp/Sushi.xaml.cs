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
    /// Interaction logic for Sushi.xaml
    /// </summary>
    public partial class Sushi : Page
    {
        public Sushi()
        {
            InitializeComponent();
        }

        private void goToMenu(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenu());
        }
    }
}
