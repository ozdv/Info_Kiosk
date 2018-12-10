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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class ImgServ2 : UserControl
    {
        public ImgServ2()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Button backbuton = (Button)sender;
            backbuton.Visibility = Visibility.Collapsed;
            Navigate.Move(new ResGroup2());
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Clipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Clipboard());
        }


        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new ResGroup2());
        }

        private void AddToClipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Adding this information to your clipboard?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                //do no stuff
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Added to your Clipboard!");
            }
        }
    }
}
