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

namespace Checkerboard
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
            // Fill the canvas with a checkerboard pattern.

            int size = 40;
            int x = 0;
            int y = 0;
            string colorString;

            var C = new string[] { "Black", "White" };

            for (int i = 0; i < (Width / size); i++)
            {
                x = size * i;

                for (int j = 0; j < (Height / size); j++)
                {
                    y = size * j;

                    colorString = C[((i % 2) + (j % 2)) % 2];

                    Rectangle(x, y, size, colorString);
                }
            }
        }

        public void Rectangle(int x, int y, int size, string colorString)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Color color = (Color)ColorConverter.ConvertFromString(colorString);

            foxDraw.FillColor(color);

            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}
