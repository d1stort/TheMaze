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
using System.Windows.Shapes;
using TheMaze.ViewModels;

namespace TheMaze
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();

            this.DataContext = new PlayerViewModel();
            Level1 l1 = new Level1();

            l1.ShowDialog();
            this.Close();
        }

        private void CloseRegWindButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
