﻿using System;
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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home3 : UserControl
    {
        public Home3()
        {
            InitializeComponent();
        }

        private void Banking_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void GovDoc_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new GovDoc());
        }

        private void ResourceGroups_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new ResGroup());
        }

        private void Health_Resources_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Events_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Attractions_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Accommodations_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Transit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Transit());
        }

        private void Map_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Map());
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Languages());
        }

        private void Clipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new Clipboard());
        }

        private void BlankClipboard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Navigate.Move(new BlankClipboard());

        }
    }
}
