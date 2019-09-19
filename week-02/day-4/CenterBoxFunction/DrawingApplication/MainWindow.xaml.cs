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

            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            int squareSize = 100;
            for (int i = 0; i < 3; i++)
            {
                DrawCenter(foxDraw, squareSize);
                squareSize -= 30;
            }
            
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