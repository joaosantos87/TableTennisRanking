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
    /// Interaction logic for AddClub.xaml
    /// </summary>
    public partial class AddClub : UserControl
    {
        public AddClub()
        {
            InitializeComponent();
            createClubButton.Click += createClubButton_Click;
        }

        private void createClubButton_Click(object sender, RoutedEventArgs e)
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
                        MessageBox.Show("Club already insert in database! [id = "+clubId+"]");
                        insert=false;
                        break;
                    }
                    MessageBoxResult mbRes = MessageBox.Show("Similar club already in database [" + FilesAccess.db.clubs[i].Name + "]" +
                        Environment.NewLine + "Do you still want to enter new club?", "Information", MessageBoxButton.YesNo);

                    //Insert club
                    if (mbRes == MessageBoxResult.Yes)
                    {
                        insert = true;
                        
                    }
                    else if (mbRes == MessageBoxResult.No)
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
    }
}
