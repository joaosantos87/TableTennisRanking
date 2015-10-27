using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TableTennisRanking
{
    /// <summary>
    /// Interaction logic for LeftMenu.xaml
    /// </summary>
    public partial class LeftMenu : UserControl
    {
        public LeftMenu()
        {
            InitializeComponent();
            rectangle1.MouseDown += rectangle1_MouseDown;
            button1.MouseDown += rectangle1_MouseDown;
            image1.MouseDown += rectangle1_MouseDown;
        }

        private void rectangle1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Clicked");
        }

        public void SetName(string text, string image = "")
        {
            button1.Content = text;
            image1.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(image));
        }
    }
}
