using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TableTennisRanking
{
    public partial class UserControlGUI : UserControl
    {
        List<Control> mainInterfaceElements = new List<Control>();

        public UserControlGUI()
        {
            InitializeComponent();

            //button1.Visible = false;
            //button2.Visible = false;
            //button3.Visible = false;
            //button4.Visible = false;
            //button5.Visible = false;
            //button6.Visible = false;
            //button7.Visible = false;
            //button1.Tag = 0;
            //button2.Tag = 1;
            //button3.Tag = 2;
            //button4.Tag = 3;
            //button5.Tag = 4;
            //button6.Tag = 5;
            //button7.Tag = 6;
            //button1.MouseDown += button1_MouseDown;
            //button2.MouseDown += button1_MouseDown;
        }
        /*
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < panel1.Controls.Count; i++)
                panel1.Controls[i].Visible = false;
            LeftMenu b1 = (LeftMenu)sender;
            if (grid2.Children.Count > Convert.ToInt32(b1.Tag))
                grid2.Children[Convert.ToInt32(b1.Tag)].Visibility = System.Windows.Visibility.Visible;
        }

        public void SetName(string name)
        {
            Title.Content = name;
        }

        public void AddMainInterface(UIElement element)
        {
            mainInterfaceElements.Add(element);
            grid2.Children.Add(mainInterfaceElements[mainInterfaceElements.Count - 1]);
            grid2.Children[mainInterfaceElements.Count - 1].Visibility = System.Windows.Visibility.Hidden;
        }

        public void SetButton(int id, string name, string image)
        {
            switch (id)
            {
                case 0:
                    button1.Visibility = System.Windows.Visibility.Visible;
                    button1.SetName(name, image);
                    break;

                case 1:
                    button2.Visibility = System.Windows.Visibility.Visible;
                    button2.SetName(name, image);
                    break;

                case 2:
                    button3.Visibility = System.Windows.Visibility.Visible;
                    button3.SetName(name, image);
                    break;

                case 3:
                    button4.Visibility = System.Windows.Visibility.Visible;
                    button4.SetName(name, image);
                    break;

                case 4:
                    button5.Visibility = System.Windows.Visibility.Visible;
                    button5.SetName(name, image);
                    break;

                case 5:
                    button6.Visibility = System.Windows.Visibility.Visible;
                    button6.SetName(name, image);
                    break;

                case 6:
                    button7.Visibility = System.Windows.Visibility.Visible;
                    button7.SetName(name, image);
                    break;
            }
        }*/
    }
}
