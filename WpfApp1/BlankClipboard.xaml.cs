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
    public partial class BlankClipboard : UserControl
    {
        public BlankClipboard()
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
                if (MessageBox.Show("Email this collection to " + email + " ?", "Email", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    //do no stuff
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("An email has been sent to you. Have a good day! :)");
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Please enter a proper email in the form name@mail.com");
            }
        }

        private void Print_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Do you wish to print this collection?", "Print", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                //do no stuff
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Printing now. Have a good day! :)");
            }
        }

        private void Trash_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Remove this information from clipboard?", "Remove", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                //do no stuff
            }
            else
            {
                Navigate.Move(new Trash());
            }
        }

        private void enterEmail(object sender, MouseEventArgs e)
        {
            if (userEmail.Text.Trim() != "" || userEmail.Text != null)

            {

                userEmail.Text = "";

            }
        }

        private void restorePrompt(object sender, MouseEventArgs e)
        {
            userEmail.Text = "Enter your email here";
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Welcome());
        }
    }
}