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
using System.Windows.Threading;
using System.Windows.Media.Effects;

namespace KinjoApp
{
    /// <summary>
    /// Interaction logic for SpecialMaki.xaml
    /// </summary>
    public partial class SpecialMaki : Page
    {
        private DispatcherTimer dispatcherTimer;
        BlurEffect blur;

        public SpecialMaki()
        {
            InitializeComponent();
            widgetGrid.Visibility = Visibility.Hidden;
            checkMarkGrid.Visibility = Visibility.Hidden;
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
        }

        private void goToMenu(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenu());
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            widgetGrid.Visibility = Visibility.Hidden;
            listView.Effect = null;
        }

        private void substractBtn_Click(object sender, RoutedEventArgs e)
        {
            var number = Int32.Parse(itemNumber.Content.ToString());

            if (number > 1)
            {
                number = number - 1;
            }
            itemNumber.Content = number.ToString();

        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            var number = Int32.Parse(itemNumber.Content.ToString());
            number = number + 1;
            itemNumber.Content = number.ToString();
        }

        private void selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            blur = new BlurEffect();
            blur.Radius = 20;
            listView.Effect = blur;
            ItemContainerGenerator generator = this.listView.ItemContainerGenerator;
            ListBoxItem selectedItem = (ListBoxItem)generator.ContainerFromIndex(listView.SelectedIndex);
            var id = "index" + listView.SelectedIndex.ToString();
            Label aLabel = GetChildrenByType(selectedItem, typeof(Label), id) as Label;
            if (aLabel != null)
            {

                widgetGrid.Visibility = Visibility.Visible;
                nameLabel.Content = aLabel.Content;
                itemNumber.Content = 1.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public static Visual GetChildrenByType(Visual visualElement, Type typeElement, string nameElement)
        {
            if (visualElement == null) return null;
            if (visualElement.GetType() == typeElement)
            {
                FrameworkElement fe = visualElement as FrameworkElement;
                if (fe != null)
                {
                    if (fe.Name == nameElement)
                    {
                        return fe;
                    }
                }
            }
            Visual foundElement = null;
            if (visualElement is FrameworkElement)
                (visualElement as FrameworkElement).ApplyTemplate();
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(visualElement); i++)
            {
                Visual visual = VisualTreeHelper.GetChild(visualElement, i) as Visual;
                foundElement = GetChildrenByType(visual, typeElement, nameElement);
                if (foundElement != null)
                    break;
            }
            return foundElement;
        }

        private void doneBtn_Click(object sender, RoutedEventArgs e)
        {
            widgetGrid.Visibility = Visibility.Hidden;
            checkMarkGrid.Visibility = Visibility.Visible;
            dispatcherTimer.Start();
            
        }

        private void doubleClick(object sender, MouseButtonEventArgs e)
        {
            blur = new BlurEffect();
            blur.Radius = 20;
            listView.Effect = blur;
            ItemContainerGenerator generator = this.listView.ItemContainerGenerator;
            ListBoxItem selectedItem = (ListBoxItem)generator.ContainerFromIndex(listView.SelectedIndex);
            var id = "index" + listView.SelectedIndex.ToString();
            Label aLabel = GetChildrenByType(selectedItem, typeof(Label), id) as Label;
            if (aLabel != null)
            {

                widgetGrid.Visibility = Visibility.Visible;
                nameLabel.Content = aLabel.Content;
                itemNumber.Content = 1.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }


        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            checkMarkGrid.Visibility = System.Windows.Visibility.Collapsed;
            listView.Effect = null;
            //Disable the timer
            dispatcherTimer.IsEnabled = false;
        }
    }
}
