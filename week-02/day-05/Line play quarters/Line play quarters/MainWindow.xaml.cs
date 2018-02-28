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
        List<Point> pointsTop = new List<Point>();
        List<Point> pointsRight = new List<Point>();
        List<Point> pointsLeft = new List<Point>();
        List<Point> pointsBottom = new List<Point>();

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int z = 10; //the distance beetween the points on the sides
            int multiplicator = 1; //how many graphics should be on the canvas
            int size = (int)Width / (int)Math.Sqrt(multiplicator);
            int origoX;
            int origoY;

            for (int i = 0; i < (int)Math.Sqrt(multiplicator); i++)
            {
                origoX = i * size;

                for (int j = 0; j < (int)Math.Sqrt(multiplicator); j++)
                {
                    origoY = j * size;

                    for (int k = 1; k < size / z; k++)
                    {
                        pointsTop.Add(new Point(origoX + k * z, 0));
                        pointsRight.Add(new Point(size, origoX + k * z));
                        pointsLeft.Add(new Point(0, origoX + k * z));
                        pointsBottom.Add(new Point(origoX + k * z, size));
                    }
                    DrawGraphic(pointsTop, pointsRight, Colors.Purple);
                    DrawGraphic(pointsLeft, pointsBottom, Colors.Green);
                }
            }
        }

        public void DrawGraphic(List<Point> startPoints, List<Point> endPoints, Color color)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            for (int l = 0; l < pointsTop.Count; l++)
            {
                var startPoint = startPoints[l];
                var endPoint = endPoints[l];

                foxDraw.StrokeColor(color);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }
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


        /*
            for (int i = z; i < size; i += z)
        {
            points1.Add(new Point(i, 0));
            points2.Add(new Point(size, i));
            points3.Add(new Point(0, i));
            points4.Add(new Point(i, size));
        }
        */
