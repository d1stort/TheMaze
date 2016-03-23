using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheMaze.View;

namespace TheMaze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Clicked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void startButton_Clicked(object sender, RoutedEventArgs e)
        {
            AccountWindow acw = new AccountWindow();
            acw.ShowDialog();
        }

        private void statsButton_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                scoresTable.Visibility = System.Windows.Visibility.Visible;
                scoresData.Visibility = System.Windows.Visibility.Visible;
                goBackButton.Visibility = System.Windows.Visibility.Visible;
                //ShowPlayers(LoadPlayersFromDB(new Context()));
            }
            catch(SystemException)
            {

            }
            
        }

        static IQueryable<Player> LoadPlayersFromDB(Context context)
        {
            return from player in context.Players
                   select new Player
                   {
                       NickName = player.NickName,
                       Score = player.Score,
                   };
        }

        private void ShowPlayers(IEnumerable<Player> players)
        {
            foreach (var p in players)
            {
                scoresData.Text = p.NickName + " " + p.Score;
            }
        }

        private void goBackButton_Clicked(object sender, RoutedEventArgs e)
        {
            scoresTable.Visibility = System.Windows.Visibility.Hidden;
            scoresData.Visibility = System.Windows.Visibility.Hidden;
            goBackButton.Visibility = System.Windows.Visibility.Hidden;
        }
    }

}
