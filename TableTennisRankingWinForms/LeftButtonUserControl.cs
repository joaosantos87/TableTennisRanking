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
    public partial class LeftButtonUserControl : UserControl
    {
        public event EventHandler clickButton;
        public LeftButtonUserControl()
        {
            InitializeComponent();
            label1.Click += label1_Click;
            pictureBox1.Click += label1_Click;
            this.Click += label1_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
                clickButton(this, e);
            Console.WriteLine("Clicked");
        }

        public void SetName(string text, string image = "")
        {
            label1.Text = text;
            pictureBox1.Image = new System.Drawing.Bitmap(image);
        }
    }
}
