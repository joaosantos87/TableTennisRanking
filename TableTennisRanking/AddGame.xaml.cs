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
    /// Interaction logic for AddGame.xaml
    /// </summary>
    public partial class AddGame : UserControl
    {
        int numberOfSets = 0;
        public AddGame()
        {
            InitializeComponent();
            IsVisibleChanged += AddGame_IsVisibleChanged;
        }

        private void AddGame_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            champCombobox.Items.Clear();
            for (int i = 0; i < FilesAccess.db.championships.Count; i++)
                champCombobox.Items.Add(FilesAccess.db.championships[i].Name);
            if (champCombobox.Items.Count > 0)
                champCombobox.SelectedIndex = 0;

            playerAName.Items.Clear();
            for (int i = 0; i < FilesAccess.db.player.Count; i++)
                playerAName.Items.Add(FilesAccess.db.player[i].Name);
            if (playerAName.Items.Count > 0)
                playerAName.SelectedIndex = 0;

            playerBName.Items.Clear();
            for (int i = 0; i < FilesAccess.db.player.Count; i++)
                playerBName.Items.Add(FilesAccess.db.player[i].Name);
            if (playerBName.Items.Count > 0)
                playerBName.SelectedIndex = 0;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                numberOfSets = Convert.ToInt32(setsPlayerA.Text) + Convert.ToInt32(setsPlayerB.Text);

                set5PlayerA.Visibility = System.Windows.Visibility.Hidden;
                set5PlayerB.Visibility = System.Windows.Visibility.Hidden;
                set4PlayerA.Visibility = System.Windows.Visibility.Hidden;
                set4PlayerB.Visibility = System.Windows.Visibility.Hidden;
                set3PlayerA.Visibility = System.Windows.Visibility.Hidden;
                set3PlayerB.Visibility = System.Windows.Visibility.Hidden;
                set2PlayerA.Visibility = System.Windows.Visibility.Hidden;
                set2PlayerB.Visibility = System.Windows.Visibility.Hidden;
                set1PlayerA.Visibility = System.Windows.Visibility.Hidden;
                set1PlayerB.Visibility = System.Windows.Visibility.Hidden;

                return;

                if (numberOfSets > 4)
                {
                    set5PlayerA.Visibility = System.Windows.Visibility.Visible;
                    set5PlayerB.Visibility = System.Windows.Visibility.Visible;
                }
                if (numberOfSets > 3)
                {
                    set4PlayerA.Visibility = System.Windows.Visibility.Visible;
                    set4PlayerB.Visibility = System.Windows.Visibility.Visible;
                }
                if (numberOfSets > 2)
                {
                    set3PlayerA.Visibility = System.Windows.Visibility.Visible;
                    set3PlayerB.Visibility = System.Windows.Visibility.Visible;
                }
                if (numberOfSets > 1)
                {
                    set2PlayerA.Visibility = System.Windows.Visibility.Visible;
                    set2PlayerB.Visibility = System.Windows.Visibility.Visible;
                }
                if (numberOfSets > 0)
                {
                    set1PlayerA.Visibility = System.Windows.Visibility.Visible;
                    set1PlayerB.Visibility = System.Windows.Visibility.Visible;
                }
            }
            catch { }
        }

        public int IdPlayerWinner
        {
            get 
            {
                //if (Convert.ToInt32(setsPlayerA.Text) == 3)
                if(Convert.ToInt32(setsPlayerA.Text) > Convert.ToInt32(setsPlayerB.Text))
                    return FilesAccess.db.player.Single(x => x.Name == playerAName.Text).Id;
                else //if(Convert.ToInt32(setsPlayerB.Text) == 3)
                    return FilesAccess.db.player.Single(x => x.Name == playerBName.Text).Id;
                return -1;
            }
        }

        private void CreateGameButton_Click(object sender, RoutedEventArgs e)
        {
            pointsExchange.Content = playerAName.Text;
        }
    }
}
