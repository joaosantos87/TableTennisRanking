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
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            leftButtonUserControl1.Visible = false;
            leftButtonUserControl2.Visible = false;
            leftButtonUserControl3.Visible = false;
            leftButtonUserControl4.Visible = false;
            leftButtonUserControl5.Visible = false;
            leftButtonUserControl6.Visible = false;
            leftButtonUserControl7.Visible = false;
            leftButtonUserControl1.Tag = 0;
            leftButtonUserControl2.Tag = 1;
            leftButtonUserControl3.Tag = 2;
            leftButtonUserControl4.Tag = 3;
            leftButtonUserControl5.Tag = 4;
            leftButtonUserControl6.Tag = 5;
            leftButtonUserControl7.Tag = 6;
            leftButtonUserControl1.clickButton += button1_MouseDown;
            leftButtonUserControl2.clickButton += button1_MouseDown;
            //leftButtonUserControl1.Click += button1_MouseDown;
            //leftButtonUserControl2.Click += button1_MouseDown;
        }

        private void button1_MouseDown(object sender, EventArgs e)
        {
            for (int i = 0; i < panel1.Controls.Count; i++)
                panel1.Controls[i].Visible = false;
            LeftButtonUserControl b1 = (LeftButtonUserControl)sender;
            if (panel1.Controls.Count > Convert.ToInt32(b1.Tag))
                panel1.Controls[Convert.ToInt32(b1.Tag)].Visible = true;
        }

        public void SetName(string name)
        {
           label1.Text = name;
        }

        public void AddMainInterface(Control element)
        {
            mainInterfaceElements.Add(element);
            panel1.Controls.Add(mainInterfaceElements[mainInterfaceElements.Count - 1]);
            panel1.Controls[mainInterfaceElements.Count - 1].Visible = false;
        }

        public void SetButton(int id, string name, string image)
        {
            switch (id)
            {
                case 0:
                    leftButtonUserControl1.Visible = true;
                    leftButtonUserControl1.SetName(name, image);
                    break;

                case 1:
                    leftButtonUserControl2.Visible = true;
                    leftButtonUserControl2.SetName(name, image);
                    break;

                case 2:
                    leftButtonUserControl3.Visible = true;
                    leftButtonUserControl3.SetName(name, image);
                    break;

                case 3:
                    leftButtonUserControl4.Visible = true;
                    leftButtonUserControl4.SetName(name, image);
                    break;

                case 4:
                    leftButtonUserControl5.Visible = true;
                    leftButtonUserControl5.SetName(name, image);
                    break;

                case 5:
                    leftButtonUserControl6.Visible = true;
                    leftButtonUserControl6.SetName(name, image);
                    break;

                case 6:
                    leftButtonUserControl7.Visible = true;
                    leftButtonUserControl7.SetName(name, image);
                    break;
            }
        }
    }
}
