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
    /// Interaction logic for Transit.xaml
    /// </summary>
    public partial class ResGroup : UserControl
    {
        public ResGroup()
        {
            InitializeComponent();
        }
        private void Back_MouseDown(object sender, RoutedEventArgs e)
        {
            Home mynewPage = new Home(); //newPage is the name of the newPage.xaml file
            this.Content = mynewPage;
        }
        private void Image_MouseDown_1(object sender, RoutedEventArgs e)
        {
            Navigate.Move(new CalBridge());
        }
        private void Image_MouseDown_2(object sender, RoutedEventArgs e)
        {
            Navigate.Move(new ImgServ());
        }
        private void Image_MouseDown(object sender, RoutedEventArgs e)
        {
            Navigate.Move(new Newcomers());
        }

        private void Clipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Clipboard());
        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Home());
        }
    }
}
