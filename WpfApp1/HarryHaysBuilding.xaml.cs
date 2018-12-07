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
    public partial class UserControlM1 : UserControl
    {
        public UserControlM1()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Button backbuton = (Button)sender;
            backbuton.Visibility = Visibility.Collapsed;
            Navigate.Move(new GovDoc());
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
            Navigate.Move(new GovDoc());
        }

        private void AddToClipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Adding Harry Hays to clipboard", "Info Kiosk", MessageBoxButton.OKCancel);
            switch (result)
            {
                case MessageBoxResult.OK:
                    MessageBox.Show("Added to clipboard!", "Info Kiosk");
                    Navigate.Move(new GovDoc());
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }
    }
}
