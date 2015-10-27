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
    public partial class AddChamp : UserControl
    {
        public AddChamp()
        {
            InitializeComponent();
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            FilesAccess.db.championships.AddchampionshipsRow(
                nameTextbox.Text, 1);

            FilesAccess.db.UpdateChamp();
        }
    }
}
