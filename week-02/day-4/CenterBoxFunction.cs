using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).

            var colors = new List<Color>()
            {
                Colors.Red,
                Colors.Orange,
                Colors.Yellow,
                Colors.Green,
                Colors.Blue,
                Colors.Indigo,
                Colors.Violet
            };
           
            double size = Height;

            for (int i = 0; i < colors.Count; i++)
            {
                DrawSquare(foxDraw, size, colors[i]);
                size -= Height / colors.Count;
            }
        }
        public void DrawSquare(FoxDraw foxDraw, double size, Color color)
        {
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(Width / 2 - size / 2, Height / 2 - size / 2, size, size);
        }
        public void DrawCenter(FoxDraw foxDraw, double size)
        {
            foxDraw.DrawRectangle(Width / 2 - size / 2, Height / 2 - size / 2, size, size);
        }
        public void DrawMyRectangle(FoxDraw foxDraw, double x, double y, double width, double height, Color color)
        {
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(x, y, width, height);
        }

        public void DrawLineToCentre(FoxDraw foxDraw, double x, double y)
        {
            foxDraw.DrawLine(x, y, Width / 2, Height / 2);
        }
        public static void DrawGreenDiagonal(FoxDraw foxDraw, double x1, double y1, double x2, double y2)
        {
            if (x1 == 0 && y1 == 0)
            {
                foxDraw.SetStrokeColor(Colors.Green);
                foxDraw.DrawLine(x1, y1, x2, y2);
            }
            else
            {
                foxDraw.SetStrokeColor(Colors.Blue);
                foxDraw.DrawLine(x1, y1, x2, y2);
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}