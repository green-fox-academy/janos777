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

namespace Purple_steps
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
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]


            int size = 20;
            int position;

            for (int i = 0; i < 10; i++)
            {
                position = size + (size * i);
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
