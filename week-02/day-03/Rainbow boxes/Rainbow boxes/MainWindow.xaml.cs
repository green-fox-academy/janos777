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

namespace Rainbow_boxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int z = 10; //visible width of the squares (on one side)
        int X;
        int q;
        string colorString;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a square drawing function that takes 2 parameters:
            // The square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares.

            string[] C = new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

            List<string> CList = new List<string>();

            for (int i = 0; i < (Width / 2 / z); i++)
            {
                CList.Add(C[i % C.Length]);
            }

            for (q = 1; q < Convert.ToInt32(Height) / z; q++)
            {
                X = Convert.ToInt32(Height);
                X = X + z - (q * z);

                if (0 < X)
                {
                    colorString = C[(q - 1) % C.Length];
                }
                else
                {
                    X = X + z;
                    colorString = C[q];
                }
                SquareDrawing(X, colorString);
            }
        }

        public void SquareDrawing(int X, string colorString)
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Color color = (Color)ColorConverter.ConvertFromString(colorString);

            foxDraw.FillColor(color);

            foxDraw.DrawRectangle((q * z) / 2, (q * z) / 2, X, X);
        }
    }
}
