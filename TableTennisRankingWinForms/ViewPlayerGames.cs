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
    public partial class ViewPlayerGames : UserControl
    {
        public ViewPlayerGames()
        {
            InitializeComponent();
            VisibleChanged += ViewGames_VisibleChanged;
        }

        private void ViewGames_VisibleChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < FilesAccess.db.player.Count; i++)
            {
                comboBox1.Items.Add(FilesAccess.db.player[i].Name);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPlayer = FilesAccess.db.player.Single(x => x.Name == comboBox1.Text).Id;
            dataGridView1.DataSource = ((DataSet1.gamesRow[])(FilesAccess.db.games.Select("IdPlayerA='" + idPlayer + "' OR IdPlayerB='" + idPlayer + "'"))).OrderByDescending(x => x.Date).ToList();

        }
    }
}
