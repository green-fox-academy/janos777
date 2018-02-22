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

namespace Everything_goes_to_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x = 0;
        int y = 0;
        int z = 20;
        

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.

            canvas.Width = 600;
            canvas.Height = 600;

            for (x = 0; x <= canvas.Width; x += z)
            {
                if (x == 0 || x == canvas.Width)
                {
                    for (y = 0; y <= canvas.Height; y += z)
                    {
                        LineDrawing(x, y);
                    }
                }

                if (0 < x && x < canvas.Width)
                {
                    y = 0;
                    LineDrawing(x, y);

                    y = Convert.ToInt32(canvas.Height);
                    LineDrawing(x, y);
                }
            }
        }

        public void LineDrawing(int x, int y)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Black);

            var startPoint = new Point(x, y);
            var endPoint = new Point(canvas.Width / 2, canvas.Height / 2);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
