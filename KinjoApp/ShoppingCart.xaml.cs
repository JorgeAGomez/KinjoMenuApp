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
     
    public partial class ShoppingCart : Page
    {       

        public ShoppingCart()
        {
            InitializeComponent();
            string[] list1 = new string[4] { "pack://siteoforigin:,,,/Resources/Edamame.jpg", "Edamame", "Soft soybeans served in the pod, which are steamed and lightly tossed in sea salt.", "$5.10" };
            string[] list2 = new string[4] { "pack://siteoforigin:,,,/Resources/SearedTunaSushi.jpg", "Seared Tuna Sushi (2 pcs)", "Lightly seared tuna, sushi rice, and spicy mayo topped with green onions.", "$4.10" };

            FoodItem.foodItems = new List<string[]>();
            FoodItem.foodItems.Add(list1);
            FoodItem.foodItems.Add(list2);
            
            foreach (string[] item in FoodItem.foodItems) {
                ListViewItem appetizerItem = new ListViewItem();
                appetizerItem.Background = Brushes.White;
                appetizerItem.BorderThickness = new Thickness(1, 1, 1, 1);
                appetizerItem.BorderBrush = Brushes.Gray;
                appetizerItem.Height = 72;

                StackPanel appetizerStack = new StackPanel();
                appetizerStack.Orientation = Orientation.Horizontal;
                appetizerStack.Width = 695;

                //Item image
                Image appetizerImage = new Image();
                appetizerImage.Height = 58;
                appetizerImage.Width = 65;
                appetizerImage.SnapsToDevicePixels = true;
                appetizerImage.Stretch = Stretch.Fill;
                BitmapImage imagePath = new BitmapImage(new Uri(item[0]));
                appetizerImage.Source = imagePath;

                StackPanel appetizerStack2 = new StackPanel();
                appetizerStack2.Orientation = Orientation.Vertical;
                appetizerStack2.Width = 513;

                //Title and detail 
                TextBlock title = new TextBlock();
                TextBlock detail = new TextBlock();
                title.Height = 22;
                title.FontFamily = new FontFamily("Yu Gothic UI");
                title.FontSize = 16;
                title.Margin = new Thickness(5, 0, 10, 5);
                title.RenderTransformOrigin = new Point(0.497, 0.422);
                title.FontWeight = FontWeights.Bold;
                title.Text = item[1];

                detail.Height = 22;
                detail.FontFamily = new FontFamily("Yu Gothic UI");
                detail.FontSize = 14;
                detail.Margin = new Thickness(5, 0, 0, 5);
                detail.HorizontalAlignment = HorizontalAlignment.Left;
                detail.Width = 557;
                detail.Foreground = Brushes.Gray;
                detail.Text = item[2];

                //Price
                TextBlock price = new TextBlock();
                price.Height = 17;
                price.FontFamily = new FontFamily("Yu Gothic UI");
                price.FontSize = 16;
                price.Width = 40;
                price.Margin = new Thickness(20, 0, 0, 10);
                price.FontWeight = FontWeights.Bold;
                price.Text = item[3];

                //delete icon
                //Item image
                Image deleteIcon = new Image();
                deleteIcon.Height = 24;
                deleteIcon.Width = 28;
                BitmapImage deleteIconPath = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/Delete.png"));
                deleteIcon.Source = deleteIconPath;

                //Delete Button
                Button deleteBtn = new Button();
                deleteBtn.FontFamily = new FontFamily("Yu Gothic UI");
                deleteBtn.Height = 34;
                deleteBtn.Width = 38;
                deleteBtn.Margin = new Thickness(10, 0, 0, 0);
                deleteBtn.Click += DeleteBtn_Click;
                deleteBtn.Background = Brushes.White;
                var bc = new BrushConverter();
                deleteBtn.BorderBrush = (Brush)bc.ConvertFrom("#FFF39E08");
                deleteBtn.Content = deleteIcon;


                appetizerStack2.Children.Add(title);
                appetizerStack2.Children.Add(detail);


                appetizerStack.Children.Add(appetizerImage);
                appetizerStack.Children.Add(appetizerStack2);
                appetizerStack.Children.Add(price);
                appetizerStack.Children.Add(deleteBtn);

                appetizerItem.Content = appetizerStack;
                listView.Items.Add(appetizerItem);


            }

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //delete item here


        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void backToMenu(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenu());
        }
    }
}
