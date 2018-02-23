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

namespace Connect_the_dots
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that takes 1 parameter:
            // A list of (x, y) points
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}

            List<Point> points1 = new List<Point>();
            points1.Add(new Point(10, 10));
            points1.Add(new Point(290, 10));
            points1.Add(new Point(290, 290));
            points1.Add(new Point(10, 290));
        
            List<Point> points2 = new List<Point>();
            points2.Add(new Point(50, 100));
            points2.Add(new Point(70, 70));
            points2.Add(new Point(80, 90));
            points2.Add(new Point(90, 90));
            points2.Add(new Point(100, 70));
            points2.Add(new Point(120, 100));
            points2.Add(new Point(85, 130));
            points2.Add(new Point(50, 100));

            for (int i = 0; i < points1.Count; i++)
            {
                Connecting(points1);
            }
            for (int i = 0; i < points2.Count; i++)
            {
                Connecting(points2);
            }
        }

        public void Connecting(List<Point> polygon)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.White);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawPolygon(polygon);
        }
    }
}
