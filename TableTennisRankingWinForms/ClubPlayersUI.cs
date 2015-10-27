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
    public partial class ClubPlayersUI : UserControl
    {
        public ClubPlayersUI()
        {
            InitializeComponent();
            VisibleChanged += ClubPlayersUI_VisibleChanged;
            clubCombobox.SelectedIndexChanged += clubCombobox_SelectedIndexChanged;
        }

        private void clubCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clubCombobox.Text == null)
                return;
            int idClub = FilesAccess.db.clubs.Single(x => x.Name == clubCombobox.Text).Id;
            dataGridView1.DataSource = (((DataSet1.playerRow[])FilesAccess.db.player.Select("IdClub=" + idClub)).OrderByDescending(x => x.currentPoints)).ToList();
        }

        private void ClubPlayersUI_VisibleChanged(object sender, EventArgs e)
        {
            clubCombobox.Items.Clear();
            for (int i = 0; i < FilesAccess.db.clubs.Count; i++)
                clubCombobox.Items.Add(FilesAccess.db.clubs[i].Name);

            if (clubCombobox.Items.Count > 0)
                clubCombobox.SelectedIndex = 0;
        }
    }
}
