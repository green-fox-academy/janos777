﻿using System;
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

namespace Centered_boxes
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
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            int[] X = new int[] { 100, 70, 40 };

            for (int i = 0; i < X.Length; i++)
            {
                SquareDrawing(X[i]);
            }
        }

        public void SquareDrawing(int X)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Olive);

            foxDraw.DrawRectangle((Width - X) / 2, (Height - X) / 2, X, X);
        }
    }
}
