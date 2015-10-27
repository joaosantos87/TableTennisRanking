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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //MySqlDatabase sql = new MySqlDatabase();

        UserControl1 playerUI = new UserControl1();
        UserControl1 clubUI = new UserControl1();
        UserControl1 champUI = new UserControl1();
        UserControl1 gamesUI = new UserControl1();
        UserControl1 rankingUI = new UserControl1();

        AddPlayer addPlayerUI = new AddPlayer();
        AddClub addClubUI = new AddClub();
        AddChamp addChamp = new AddChamp();
        AddGame addGame = new AddGame();
        ViewGames viewGame = new ViewGames();
        RankingViewerUI rankViewer = new RankingViewerUI();
        ClubPlayersUI viewClubPlayers = new ClubPlayersUI();

        public MainWindow()
        {
            InitializeComponent();

            MySqlDatabase.Instance.ToString();

            playerUI.SetName("Players");
            playerUI.SetButton(0, "Add Player", Environment.CurrentDirectory + @"\plus.png");
            playerUI.SetButton(1, "View Players", Environment.CurrentDirectory + @"\list.png");
            playerUI.AddMainInterface(addPlayerUI);
            addPlayerUI.createPlayerButton.Click += createPlayerButton_Click;

            clubUI.SetName("Clubs");
            clubUI.SetButton(0, "Add Club", Environment.CurrentDirectory + @"\plus.png");
            clubUI.SetButton(1, "View Clubs", Environment.CurrentDirectory + @"\list.png");
            clubUI.AddMainInterface(addClubUI);
            clubUI.AddMainInterface(viewClubPlayers);
            addClubUI.createClubButton.Click += createCLubButton_Click;

            champUI.SetName("Champs");
            champUI.SetButton(0, "Add Champ", Environment.CurrentDirectory + @"\plus.png");
            champUI.SetButton(1, "View Champs", Environment.CurrentDirectory + @"\list.png");
            champUI.AddMainInterface(addChamp);
            addChamp.createChampButton.Click += createChampButton_Click;

            gamesUI.SetName("Games");
            gamesUI.SetButton(0, "Add Game", Environment.CurrentDirectory + @"\plus.png");
            gamesUI.SetButton(1, "View Games", Environment.CurrentDirectory + @"\list.png");
            gamesUI.AddMainInterface(addGame);
            gamesUI.AddMainInterface(viewGame);
            addGame.CreateGameButton.Click += createGameButton_Click;
            

            rankingUI.SetName("Ranking");
            rankingUI.SetButton(0, "View Ranking", Environment.CurrentDirectory + @"\list.png");
            rankingUI.AddMainInterface(rankViewer);
            //gamesUI.AddMainInterface(addGame);

            grid1.Children.Add(playerUI);
            grid1.Children.Add(clubUI);
            grid1.Children.Add(champUI);
            grid1.Children.Add(gamesUI);
            grid1.Children.Add(rankingUI);
            playerUI.Visibility = Visibility.Hidden;
            clubUI.Visibility = Visibility.Hidden;
            champUI.Visibility = Visibility.Hidden;
            gamesUI.Visibility = Visibility.Hidden;
            rankingUI.Visibility = Visibility.Hidden;
        }

        private void createGameButton_Click(object sender, RoutedEventArgs e)
        {
            int playerAId = FilesAccess.db.player.Single(x => x.Name == addGame.playerAName.Text).Id;
            int playerBId = FilesAccess.db.player.Single(x => x.Name == addGame.playerBName.Text).Id;
            if (FilesAccess.db.games.Count(
                    x => (((x.IdPlayerA == playerAId && x.IdPlayerB == playerBId) ||
                        (x.IdPlayerA == playerBId && x.IdPlayerB == playerAId)) &&
                        x.Date == addGame.gameDate.DisplayDate)) > 0)
            {
                Console.WriteLine(FilesAccess.db.games.Single(
                    x => ((x.IdPlayerA == playerAId && x.IdPlayerB == playerBId) ||
                        (x.IdPlayerA == playerBId && x.IdPlayerB == playerAId) &&
                        x.Date == addGame.gameDate.DisplayDate)).Date);
                MessageBox.Show("Game Already Entered");
                return;
            }

            FilesAccess.db.games.AddgamesRow(
                playerAId,
                playerBId,
                Convert.ToInt32(addGame.setsPlayerA.Text),
                Convert.ToInt32(addGame.setsPlayerB.Text),
                addGame.IdPlayerWinner,
                addGame.gameDate.DisplayDate,
                FilesAccess.db.championships.Single(x => x.Name == addGame.champCombobox.Text).Id,
                0);

            FilesAccess.db.UpdateGames();
        }

        private void createChampButton_Click(object sender, RoutedEventArgs e)
        {
            FilesAccess.db.championships.AddchampionshipsRow(
                addChamp.nameTextbox.Text,1);

            FilesAccess.db.UpdateChamp();
        }

        private void createCLubButton_Click(object sender, RoutedEventArgs e)
        {
            //FilesAccess.db.clubs.AddclubsRow(
            //    addClubUI.nameTextbox.Text,
            //    addClubUI.photoTextbox.Text);

            //FilesAccess.db.UpdateClub();
        }

        private void createPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            //FilesAccess.db.player.AddplayerRow(
            //    addPlayerUI.nameTextbox.Text,
            //    addPlayerUI.BirthDate,
            //   FilesAccess.db.clubs.Single(x=>x.Name == addPlayerUI.clubCombobox.Text).Id,
            //    addPlayerUI.genderCombobox.Text,
            //    addPlayerUI.photoTextbox.Text,
            //    1000,
            //    -1);

            //FilesAccess.db.UpdatePlayer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            playerUI.Visibility = Visibility.Visible;
            clubUI.Visibility = Visibility.Hidden;
            champUI.Visibility = Visibility.Hidden;
            gamesUI.Visibility = Visibility.Hidden;
            rankingUI.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            playerUI.Visibility = Visibility.Hidden;
            clubUI.Visibility = Visibility.Visible;
            champUI.Visibility = Visibility.Hidden;
            gamesUI.Visibility = Visibility.Hidden;
            rankingUI.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            playerUI.Visibility = Visibility.Hidden;
            clubUI.Visibility = Visibility.Hidden;
            champUI.Visibility = Visibility.Visible;
            gamesUI.Visibility = Visibility.Hidden;
            rankingUI.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            playerUI.Visibility = Visibility.Hidden;
            clubUI.Visibility = Visibility.Hidden;
            champUI.Visibility = Visibility.Hidden;
            gamesUI.Visibility = Visibility.Visible;
            rankingUI.Visibility = Visibility.Hidden;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            playerUI.Visibility = Visibility.Hidden;
            clubUI.Visibility = Visibility.Hidden;
            champUI.Visibility = Visibility.Hidden;
            gamesUI.Visibility = Visibility.Hidden;
            rankingUI.Visibility = Visibility.Visible;
        }
    }
}
