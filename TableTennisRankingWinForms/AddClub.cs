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
    public partial class AddClub : UserControl
    {
        public AddClub()
        {
            InitializeComponent();
            createClubButton.Click += createClubButton_Click;
        }

        private void createClubButton_Click(object sender, EventArgs e)
        {
            string clubToInsert = nameTextbox.Text;
            bool insert = true;

            for (int i = 0; i < FilesAccess.db.clubs.Count; i++)
            {
                if (Utilities.ContainsWord(FilesAccess.db.clubs[i].Name, clubToInsert))
                {
                    if (Utilities.LevenshteinDistance(FilesAccess.db.clubs[i].Name, clubToInsert) == 1)
                    {
                        int clubId = FilesAccess.db.clubs[i].Id;
                        MessageBox.Show("Club already insert in database! [id = " + clubId + "]");
                        insert = false;
                        break;
                    }

                    DialogResult mbRes = MessageBox.Show("Similar club already in database [" + FilesAccess.db.clubs[i].Name + "]" +
                        Environment.NewLine + "Do you still want to enter new club?", "Information", MessageBoxButtons.YesNo);

                    //Insert club
                    if (mbRes == DialogResult.Yes)
                    {
                        insert = true;

                    }
                    else if (mbRes == DialogResult.No)
                        insert = false;
                    break;
                }
            }

            if (insert)
            {
                FilesAccess.db.clubs.AddclubsRow(
                        nameTextbox.Text,
                        photoTextbox.Text);

                FilesAccess.db.UpdateClub();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photoTextbox.Text = ofd.FileName;
            }
        }
    }
}
