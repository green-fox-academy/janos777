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

namespace Line_play
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Point> points1 = new List<Point>();
        List<Point> points2 = new List<Point>();
        List<Point> points3 = new List<Point>();
        List<Point> points4 = new List<Point>();

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int z = 10; //the distance beetween the points on the sides
            double size = Width;

            for (int i = z; i < size; i += z)
            {
                points1.Add(new Point(i, 0));
                points2.Add(new Point(size, i));
                points3.Add(new Point(0, i));
                points4.Add(new Point(i, size));
            }
            DrawGraphic(points1, points2, Colors.Purple);
            DrawGraphic(points3, points4, Colors.Green);
        }

        public void DrawGraphic(List<Point> startPoints, List<Point> endPoints, Color color)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            for (int j = 0; j < points1.Count; j++)
            {
                var startPoint = startPoints[j];
                var endPoint = endPoints[j];

                foxDraw.StrokeColor(color);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }
    }
}