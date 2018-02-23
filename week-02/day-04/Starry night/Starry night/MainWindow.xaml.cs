using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Starry_night
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int squareSize = 10;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            canvas.Width = 600;
            canvas.Height = 600;
            canvas.Background = new SolidColorBrush(Colors.Black);

            var r = new Random();

            for (int i = 0; i < 20; i++)
            {
                double x = r.Next(0, (Convert.ToInt32(canvas.Width)) - squareSize);
                double y = r.Next(0, (Convert.ToInt32(canvas.Height)) - squareSize);

                Console.WriteLine(x);
                Console.WriteLine(y);

                int c = r.Next(0, 255);
                byte cByte = Convert.ToByte(c);
                Color color = new Color();
                color = Color.FromRgb(cByte, cByte, cByte);

                foxDraw.StrokeColor(color);
                foxDraw.FillColor(color);
                foxDraw.DrawRectangle(x, y, squareSize, squareSize);
            }
        }
    }
}
