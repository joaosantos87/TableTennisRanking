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
    public partial class AddPlayer : UserControl
    {
        public AddPlayer()
        {
            InitializeComponent();

            VisibleChanged += AddPlayer_IsVisibleChanged;
            createPlayerButton.Click += createPlayerButton_Click;
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            string playerToInsert = nameTextbox.Text;

            List<string> similarPlayers = new List<string>();
            List<string> samePlayers = new List<string>();


            for (int i = 0; i < FilesAccess.db.player.Count; i++)
            {
                if (Utilities.LevenshteinDistance(FilesAccess.db.player[i].Name, playerToInsert) == 1)
                {
                    int clubId = FilesAccess.db.player[i].Id;
                    samePlayers.Add("[" + FilesAccess.db.player[i].Name + " - " + FilesAccess.db.clubs.Single(x => x.Id == FilesAccess.db.player[i].IdClub).Name + "]");
                }

                if (Utilities.ContainsWord(FilesAccess.db.player[i].Name, playerToInsert))
                {
                    similarPlayers.Add("[" + FilesAccess.db.player[i].Name + " - " + FilesAccess.db.clubs.Single(x => x.Id == FilesAccess.db.player[i].IdClub).Name + "]");
                }
            }

            string messageShow = "";

            if (samePlayers.Count > 0)
            {
                messageShow = "Found " + samePlayers.Count + " same players in the database: " + Environment.NewLine;
                for (int i = 0; i < samePlayers.Count; i++)
                    messageShow += samePlayers[i] + Environment.NewLine;
                messageShow += "Do you still want to enter the new player?";
            }

            if (messageShow == "" && similarPlayers.Count > 0)
            {
                messageShow = "Found " + similarPlayers.Count + " similiar players in the database: " + Environment.NewLine;
                for (int i = 0; i < similarPlayers.Count; i++)
                    messageShow += similarPlayers[i] + Environment.NewLine;
                messageShow += "Do you still want to enter the new player?";
            }

            bool insert = true;

            if (messageShow != "")
            {
                
                DialogResult mbRes = MessageBox.Show(messageShow, "Information", MessageBoxButtons.YesNo);

                //Insert player
                if (mbRes == DialogResult.Yes)
                {
                    insert = true;

                }
                else if (mbRes == DialogResult.No)
                    insert = false;
            }
            if (insert)
            {
                FilesAccess.db.player.AddplayerRow(
                nameTextbox.Text,
                BirthDate,
               FilesAccess.db.clubs.Single(x => x.Name == clubCombobox.Text).Id,
                genderCombobox.Text,
                photoTextbox.Text,
                1000,
                -1);

                FilesAccess.db.UpdatePlayer();
            }
        }

        private void AddPlayer_IsVisibleChanged(object sender, EventArgs e)
        {
            clubCombobox.Items.Clear();
            for (int i = 0; i < FilesAccess.db.clubs.Count; i++)
            {
                clubCombobox.Items.Add(FilesAccess.db.clubs[i].Name);
            }
            if (clubCombobox.Items.Count > 0)
                clubCombobox.SelectedIndex = 0;
        }

        public DateTime BirthDate
        {
            get
            {
                try
                {
                    return new DateTime(Convert.ToInt32(birthTextbox.Text), 1, 1);
                }
                catch { return new DateTime(1900, 1, 1); }
            }
        }
    }
}
