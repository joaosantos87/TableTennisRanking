using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TableTennisRanking
{
    public partial class Form1 : Form
    {
        UserControlGUI playerUI = new UserControlGUI();
        UserControlGUI clubUI = new UserControlGUI();
        UserControlGUI champUI = new UserControlGUI();
        UserControlGUI gamesUI = new UserControlGUI();
        UserControlGUI rankingUI = new UserControlGUI();

        AddPlayer addPlayerUI = new AddPlayer();
        AddChamp addChamp = new AddChamp();
        AddGame addGame = new AddGame();
        ViewGames viewGame = new ViewGames();
        AddClub addClubUI = new AddClub();
        ClubPlayersUI viewClubPlayers = new ClubPlayersUI();
        RankingViewerUI rankViewer = new RankingViewerUI();
        ViewPlayerGames viewPlayerGames = new ViewPlayerGames();

        public Form1()
        {
            InitializeComponent();
            MySqlDatabase.Instance.ToString();
            
            playerUI.SetName("Players");
            playerUI.SetButton(0, "Add Player", Environment.CurrentDirectory + @"\plus.png");
            //playerUI.SetButton(1, "View Players", Environment.CurrentDirectory + @"\list.png");
            playerUI.SetButton(1, "View Games", Environment.CurrentDirectory + @"\list.png");
            playerUI.AddMainInterface(addPlayerUI);
            playerUI.AddMainInterface(viewPlayerGames);
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
            
            gamesUI.SetName("Games");
            gamesUI.SetButton(0, "Add Game", Environment.CurrentDirectory + @"\plus.png");
            gamesUI.SetButton(1, "View Games", Environment.CurrentDirectory + @"\list.png");
            gamesUI.AddMainInterface(addGame);
            gamesUI.AddMainInterface(viewGame);

            
            rankingUI.SetName("Ranking");
            rankingUI.SetButton(0, "View Ranking", Environment.CurrentDirectory + @"\list.png");
            rankingUI.AddMainInterface(rankViewer);
            //gamesUI.AddMainInterface(addGame);
            

            panel3.Controls.Add(playerUI);
            panel3.Controls.Add(clubUI);
            panel3.Controls.Add(champUI);
            panel3.Controls.Add(gamesUI);
            panel3.Controls.Add(rankingUI);
            playerUI.Visible = false;
            clubUI.Visible = false;
            champUI.Visible = false;
            gamesUI.Visible = false;
            rankingUI.Visible = false;
        }
        
        private void createCLubButton_Click(object sender, EventArgs e)
        {
            //FilesAccess.db.clubs.AddclubsRow(
            //    addClubUI.nameTextbox.Text,
            //    addClubUI.photoTextbox.Text);

            //FilesAccess.db.UpdateClub();
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            playerUI.Visible = true;
            clubUI.Visible = false;
            champUI.Visible = false;
            gamesUI.Visible = false;
            rankingUI.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerUI.Visible = false;
            clubUI.Visible = true;
            champUI.Visible = false;
            gamesUI.Visible = false;
            rankingUI.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerUI.Visible = false;
            clubUI.Visible = false;
            champUI.Visible = true;
            gamesUI.Visible = false;
            rankingUI.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playerUI.Visible = false;
            clubUI.Visible = false;
            champUI.Visible = false;
            gamesUI.Visible = true;
            rankingUI.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playerUI.Visible = false;
            clubUI.Visible = false;
            champUI.Visible = false;
            gamesUI.Visible = false;
            rankingUI.Visible = true;
        }

    }
}
