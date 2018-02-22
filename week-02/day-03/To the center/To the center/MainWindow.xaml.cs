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

namespace To_the_center
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
            // Create X line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws X line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.

            int[] X = new int[] { 10, 50, 100 };
            int[] Y = new int[] { 10, 50, 100 };

            for (int i = 0; i < X.Length; i++)
            {
                LineDrawing(X[i], Y[i]);
            }
        }

        public void LineDrawing(int X, int Y)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Purple);
            var startPoint = new Point(X, Y);
            var endPoint = new Point(Width / 2, Height / 2);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}