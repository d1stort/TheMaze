using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        private static void SetCursor(int x, int y)
        {
            var xL = (int)App.Current.MainWindow.Left;

            var yT = (int)App.Current.MainWindow.Top;

            SetCursorPos(x + xL, y + yT);
        }

        public Level1()
        {
            InitializeComponent();
        }
        

        private void mouseOver_finish(object sender, MouseEventArgs e)
        {
            panel.Visibility = System.Windows.Visibility.Visible;
            congradsLabel.Visibility = System.Windows.Visibility.Visible;
            //Close();
        }

        private void mouseEnter_label(object sender, MouseEventArgs e)
        {
            Point relativePoint = label01.TransformToAncestor(this).Transform(new Point(0, 0));
            Point pt = new Point(relativePoint.X - 25,relativePoint.Y - 25);
            Point windowCenterPoint = this.PointToScreen(pt);
            Point centerPointRelativeToSCreen = this.PointToScreen(windowCenterPoint);

            SetCursorPos((int)windowCenterPoint.X, (int)windowCenterPoint.Y);
        }

        private void Level_Loaded(object sender, RoutedEventArgs e)
        {
            Point relativePoint = label01.TransformToAncestor(this).Transform(new Point(0, 0));
            Point pt = new Point(relativePoint.X - 25, relativePoint.Y - 25);
            Point windowCenterPoint = this.PointToScreen(pt);
            Point centerPointRelativeToSCreen = this.PointToScreen(windowCenterPoint);

            SetCursorPos((int)windowCenterPoint.X, (int)windowCenterPoint.Y);
        }

    }
}
