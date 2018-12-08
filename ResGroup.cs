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

        private void Clipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new CalgBridge());
        }


        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Home());
        }


        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new UserControlM1());
        }


        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new CalgBridge());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new New_Cent());
        }

    }
}
