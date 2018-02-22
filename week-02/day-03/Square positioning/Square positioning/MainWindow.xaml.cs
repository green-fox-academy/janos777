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

namespace Square_positioning
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
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.      

            int[] X = new int[] { 30, 10, 150 };
            int[] Y = new int[] { 30, 100, 50 };

            for (int i = 0; i < X.Length; i++)
            {
                SquareDrawing(X[i], Y[i]);
            }
        }

        public void SquareDrawing(int X, int Y)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int squareSize = 50;

            foxDraw.FillColor(Colors.Black);

            foxDraw.DrawRectangle(X, Y, squareSize, squareSize);
        }
    }
}
