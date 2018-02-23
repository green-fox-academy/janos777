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

namespace Fill_with_rectangles
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
            // draw four different size and color rectangles.
            // avoid code duplication.

            int[] X = new int[] { 30, 10, 150, 200 };
            int[] Y = new int[] { 30, 100, 50, 200 };
            int[] V = new int[] { 10, 20, 30, 40 };
            int[] W = new int[] { 10, 20, 30, 40 };
            string[] C = new string[] { "Red", "Blue", "Black", "Green" };

            for (int i = 0; i < X.Length; i++)
            {
                Rectangle(X[i], Y[i], V[i], W[i], C[i]);
            }
        }

        public void Rectangle(int X, int Y, int V, int W, string C)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Color color = (Color)ColorConverter.ConvertFromString(C);

            foxDraw.FillColor(color);

            foxDraw.DrawRectangle(X, Y, V, W);
        }
    }
}
