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

namespace Line_play_quarters
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
            int multiplicator = 4; //how many graphics should be on the canvas
            double size = Width / Math.Sqrt(multiplicator);
            int origoX;
            int origoY = 0;

            for (int i = 0; i <= Math.Sqrt(multiplicator); i += (int)size)
            {
                origoX = i;
                for (int j = 0; j <= Math.Sqrt(multiplicator); j += (int)size)
                {
                    origoY = j;
                    points1.Add(new Point(origoX + i, origoY + 0));
                    points2.Add(new Point(origoX + size, origoY + j));
                    points3.Add(new Point(origoX + 0, origoY + j));
                    points4.Add(new Point(origoX + i, origoY + size));

                    DrawGraphic(points1, points2, Colors.Purple);
                    DrawGraphic(points3, points4, Colors.Green);
                }
            }

            /*
            for (int i = z; i < size; i += z)
            {
                points1.Add(new Point(origoX + i, origoY + 0));
                points2.Add(new Point(origoX + size, origoY + i));
                points3.Add(new Point(origoX + 0, origoY + i));
                points4.Add(new Point(origoX + i, origoY + size));
            }
            DrawGraphic(points1, points2, Colors.Purple);
            DrawGraphic(points3, points4, Colors.Green);
            */
        }

        public void DrawGraphic(List<Point> startPoints, List<Point> endPoints, Color color)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            for (int k = 0; k < points1.Count; k++)
            {
                var startPoint = startPoints[k];
                var endPoint = endPoints[k];

                foxDraw.StrokeColor(color);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }
    }
}