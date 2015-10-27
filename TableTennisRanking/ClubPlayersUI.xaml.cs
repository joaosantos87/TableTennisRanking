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
    /// Interaction logic for ClubPlayersUI.xaml
    /// </summary>
    public partial class ClubPlayersUI : UserControl
    {
        public ClubPlayersUI()
        {
            InitializeComponent();
            IsVisibleChanged += ClubPlayersUI_IsVisibleChanged;
        }

        private void ClubPlayersUI_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            clubCombobox.Items.Clear();
            for (int i = 0; i < FilesAccess.db.clubs.Count; i++)
                clubCombobox.Items.Add(FilesAccess.db.clubs[i].Name);

            if (clubCombobox.Items.Count > 0)
                clubCombobox.SelectedIndex = 0;
        }

        private void clubCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (clubCombobox.SelectedValue == null)
                return;
            int idClub = FilesAccess.db.clubs.Single(x=>x.Name == clubCombobox.SelectedValue).Id;
            grid.ItemsSource = ((DataSet1.playerRow[])FilesAccess.db.player.Select("IdClub="+idClub)).OrderByDescending(x=>x.currentPoints);
        }
    }
}
