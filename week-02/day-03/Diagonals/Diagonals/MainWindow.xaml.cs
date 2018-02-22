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

namespace Diagonals
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
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, Width, Height);

            foxDraw.StrokeColor(Colors.Red);
            var startPoint = new Point(Width, 0);
            var endPoint = new Point(0, Height);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
