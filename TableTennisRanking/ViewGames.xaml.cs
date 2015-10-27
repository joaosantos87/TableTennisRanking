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
    /// Interaction logic for ViewGames.xaml
    /// </summary>
    public partial class ViewGames : UserControl
    {
        public ViewGames()
        {
            InitializeComponent();
            IsVisibleChanged += ViewGames_IsVisibleChanged;
        }

        private void ViewGames_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grid.ItemsSource = FilesAccess.db.games.OrderByDescending(x => x.Date);
        }
    }
}
