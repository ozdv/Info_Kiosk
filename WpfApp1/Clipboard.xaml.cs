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
    /// Interaction logic for Clipboard.xaml
    /// </summary>
    public partial class Clipboard : UserControl
    {
        public Clipboard()
        {
            InitializeComponent();
        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Home());
        }

        private void Email_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Email());
        }

        private void Print_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Print());
        }

        private void Trash_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Trash());
        }
    }
}
