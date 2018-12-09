using System;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Clipboard.xaml
    /// </summary>
    public partial class Trash : UserControl
    {
        public Trash()
        {
            InitializeComponent();
        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Home());
        }

        private void Email_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string email = userEmail.Text;
            if (email.Contains("@"))
            {
                MessageBoxResult result = MessageBox.Show("Email is sent! Have a good day! :)");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Please enter a proper email in the form name@mail.com");
            }
        }

        private void Print_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Printing now! Have a good day! :)");
        }

        private void Trash_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Trash());
        }
    }
}

