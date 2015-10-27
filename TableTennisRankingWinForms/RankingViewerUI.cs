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
    public partial class RankingViewerUI : UserControl
    {
        DateTime startDate = new DateTime(2000, 1, 1);
        DateTime finalDate = new DateTime(2015, 12, 31);

        public RankingViewerUI()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StartDateTextbox.TextChanged += StartDateTextbox_TextChanged;
            FinalDateTextbox.TextChanged += FinalDateTextbox_TextChanged;

            VisibleChanged += RankingViewerUI_VisibleChanged;

            //fill the champs
            comboBox1.Items.Add("All");
            for (int i = 0; i<FilesAccess.db.championships.Count; i++)
            {
                comboBox1.Items.Add(FilesAccess.db.championships[i].Name);
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void RankingViewerUI_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                //Ranking rank = new Ranking(startDate, finalDate, 1);
                Ranking rank = new Ranking(startDate, finalDate);
                dataGridView1.DataSource = FilesAccess.db.player.OrderByDescending(x => x.currentPoints).ToList();

                comboBox1.Items.Clear();
                comboBox1.Items.Add("All");
                for (int i = 0; i < FilesAccess.db.championships.Count; i++)
                {
                    comboBox1.Items.Add(FilesAccess.db.championships[i].Name);
                }
            }
        }

        private void FinalDateTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                finalDate = new DateTime(Convert.ToInt32(FinalDateTextbox.Text.Split('-')[0]), Convert.ToInt32(FinalDateTextbox.Text.Split('-')[1]), Convert.ToInt32(FinalDateTextbox.Text.Split('-')[2]));
            }
            catch { }
        }

        private void StartDateTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                startDate = new DateTime(Convert.ToInt32(StartDateTextbox.Text.Split('-')[0]), Convert.ToInt32(StartDateTextbox.Text.Split('-')[1]), Convert.ToInt32(StartDateTextbox.Text.Split('-')[2]));
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int champ = -1;
            try
            {
                champ = FilesAccess.db.championships.Single(x => x.Name == comboBox1.Text).Id;
            }
            catch { }
            Ranking rank = new Ranking(startDate, finalDate, champ);
            dataGridView1.DataSource = ((DataSet1.playerRow[])(FilesAccess.db.player.Select("currentGames>0"))).OrderByDescending(x => x.currentPoints).ToList();
        }
    }
}
