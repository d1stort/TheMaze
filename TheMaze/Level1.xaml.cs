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

namespace TheMaze
{
    /// <summary>
    /// Interaction logic for Level1.xaml
    /// </summary>
    public partial class Level1 : Window
    {
        public Level1()
        {
            InitializeComponent();
        }

        private void MoveMouseToStart()
        {
            Point startPoint = new Point();
            startPoint.Offset(5, 5);
            //Cursor = PointToScreen(startPoint);
        }

        private void mouseOver_finish(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Congrads!");
            Close();
        }
    }
}
