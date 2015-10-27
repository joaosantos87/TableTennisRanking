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
    public partial class ViewGames : UserControl
    {
        public ViewGames()
        {
            InitializeComponent();
            VisibleChanged += ViewGames_VisibleChanged;
        }

        private void ViewGames_VisibleChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FilesAccess.db.games.OrderByDescending(x => x.Date).ToList();
        }
    }
}
