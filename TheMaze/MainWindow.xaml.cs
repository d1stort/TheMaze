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
            Level1 window = new Level1();
            window.ShowDialog();
        }

        private void statsButton_Click(object sender, RoutedEventArgs e)
        {
            scoresTable.Visibility = System.Windows.Visibility.Visible;
            Player players = new Player();
            //ShowPlayers(LoadEmployeesFromDB(new Context()));

        }

        static IQueryable<Player> LoadEmployeesFromDB(Context context)
        {
            return from player in context.Players
                   select new Player
                   {
                       NickName = player.NickName,
                       Score = player.Score,
                       Rating = player.Rating
                   };
        }

        private void ShowPlayers(IEnumerable<Player> players)
        {
            Console.WriteLine("|{0,-17}|{1,-10}|{2,-22}|", "Name", "Score", "Rating");
            foreach (var p in players)
            {
                Console.WriteLine("|{0,-17}|{1,-10}|{2,-22}|", p.NickName, p.Score, p.Rating);
            }
        }
    }

}
