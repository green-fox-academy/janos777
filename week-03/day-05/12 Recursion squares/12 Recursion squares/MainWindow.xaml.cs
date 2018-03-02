using GreenFox;
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

namespace _12_Recursion_squares
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

            double x = 0;
            double y = 0;
            double size = 200;
            double offsetX = size;
            double offsetY = size;

            Recursion(x, y, offsetX, offsetY, size);
        }

        public void Recursion(double x, double y, double offsetX, double offsetY, double size)
        {
            if (size < 5)
            {
                return;
            }
            else
            {
                Draw(x + offsetX, y, size);
                Draw(x, y + offsetY, size);
                Draw(x + 2 * offsetX, y + offsetY, size);
                Draw(x + offsetX, y + 2 * offsetY, size);

                Recursion(x + size / 3, y, offsetX, offsetY, size / 3);
                Recursion(x, y + size / 3, offsetX, offsetY, size / 3);
                Recursion(x + 2 * size / 3, y + size / 3, offsetX, offsetY, size / 3);
                Recursion(x + size / 3, y + 2 * size / 3, offsetX, offsetY, size / 3);
            }
        }

        public void Draw(double x, double y, double size)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.DarkBlue);
            foxDraw.FillColor(Colors.DeepSkyBlue);

            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}