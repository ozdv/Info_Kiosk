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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SavedImage.Visibility = Visibility.Collapsed;
        }

        private void Accessibility_Click(object sender, RoutedEventArgs e)
        {
            Page1 mynewPage = new Page1(); //newPage is the name of the newPage.xaml file
            this.Content = mynewPage;
        }

        public MainWindow(Button btn32x32, bool contentLoaded)
        {
            this.btn32x32 = btn32x32;
            _contentLoaded = contentLoaded;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button myButton = (Button)sender;
            myButton.Visibility = Visibility.Collapsed;
            SavedImage.Visibility = Visibility.Visible;
        }
    }
}
