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

namespace TeslaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SolidColorBrush chB = new SolidColorBrush(Color.FromRgb(128,128,128));
        public SolidColorBrush panelB = new SolidColorBrush(Color.FromRgb(128, 128, 128));
        public SolidColorBrush chBEnabled = new SolidColorBrush(Color.FromRgb(9, 132, 209));
        public SolidColorBrush panelEnabled = new SolidColorBrush(Color.FromRgb(23, 84, 123));
        public MainWindow()
        {
            InitializeComponent();
        }

        private void carbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            carch.Background = chBEnabled;
            carpanel.Background = panelEnabled;
            chargingch.Background = chB;
            chargingpanel.Background = panelB;
            climatech.Background = chB;
            climatepanel.Background=panelB;
            carcontr.Visibility = Visibility.Visible;
            chargingcontr.Visibility = Visibility.Hidden;
            climatecontr.Visibility = Visibility.Hidden;
        }

        private void Closebtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void chargingbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            carch.Background = chB;
            carpanel.Background = panelB;
            chargingch.Background = chBEnabled;
            chargingpanel.Background = panelEnabled;
            climatech.Background = chB;
            climatepanel.Background = panelB;
            carcontr.Visibility = Visibility.Hidden;
            chargingcontr.Visibility = Visibility.Visible;
            climatecontr.Visibility = Visibility.Hidden;
        }

        private void climatebtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            carch.Background = chB;
            carpanel.Background = panelB;
            chargingch.Background = chB;
            chargingpanel.Background = panelB;
            climatech.Background = chBEnabled;
            climatepanel.Background = panelEnabled;
            carcontr.Visibility = Visibility.Hidden;
            chargingcontr.Visibility = Visibility.Hidden;
            climatecontr.Visibility = Visibility.Visible;
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
