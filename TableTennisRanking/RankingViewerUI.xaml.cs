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
    /// Interaction logic for RankingViewerUI.xaml
    /// </summary>
    public partial class RankingViewerUI : UserControl
    {
        DateTime startDate = new DateTime(2000,1,1);
        DateTime finalDate = new DateTime(2015,12,31);

        public RankingViewerUI()
        {
            InitializeComponent();
            StartDateTextbox.TextChanged += StartDateTextbox_TextChanged;
            FinalDateTextbox.TextChanged += FinalDateTextbox_TextChanged;
            IsVisibleChanged += RankingViewerUI_IsVisibleChanged;
        }

        private void FinalDateTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                finalDate = new DateTime(Convert.ToInt32(FinalDateTextbox.Text.Split('-')[0]), Convert.ToInt32(FinalDateTextbox.Text.Split('-')[1]), Convert.ToInt32(FinalDateTextbox.Text.Split('-')[2]));
                
            }
            catch { }
        }

        private void StartDateTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                startDate = new DateTime(Convert.ToInt32(StartDateTextbox.Text.Split('-')[0]), Convert.ToInt32(StartDateTextbox.Text.Split('-')[1]), Convert.ToInt32(StartDateTextbox.Text.Split('-')[2]));
            }
            catch { }
        }

        private void RankingViewerUI_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == System.Windows.Visibility.Visible)
            {
                //Ranking rank = new Ranking(startDate, finalDate, 1);
                Ranking rank = new Ranking(startDate, finalDate);

                grid.ItemsSource = FilesAccess.db.player.OrderByDescending(x => x.currentPoints);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ranking rank = new Ranking(startDate, finalDate, 1);
            grid.ItemsSource = FilesAccess.db.player.OrderByDescending(x => x.currentPoints);
        }
    }
}
