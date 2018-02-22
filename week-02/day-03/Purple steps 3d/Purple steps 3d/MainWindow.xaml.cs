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

namespace Purple_steps_3d
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
            // Reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps-3d/r4.png]

            int position = 0;
            int size = 10;
            int growing = 10;

            for (int i = 0; i < 7; i++)
            {
                position += size;
                size += growing;
                Rectangle(position, size);
            }
        }

        public void Rectangle(int position, int size)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.Purple);

            foxDraw.DrawRectangle(position, position, size, size);
        }
    }
}