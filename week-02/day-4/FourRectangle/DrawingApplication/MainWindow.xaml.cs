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

            // draw four different size and color rectangles.
            // avoid code duplication.

            //var[] myColors = {Colors.Blue, Colors.Yellow, Colors.Green, Colors.Red};

            var myColors = new List<Color>
            {
                Colors.Blue,
                Colors.Yellow,
                Colors.Red,
                Colors.Pink
            };

            for (int i = 0; i < 4; i ++)
            {
                DrawMyRectangle(foxDraw, i * 100, 0, (i + 1) * 20, (i + 1) * 20, myColors[i]);
            }
        }
        public void DrawMyRectangle(FoxDraw foxdraw, double x, double y, double width, double height, Color color)
        {
            foxdraw.SetFillColor(color);
            foxdraw.DrawRectangle(x, y, width, height);
        }

        public void DrawLineToCentre(FoxDraw foxdraw, double x, double y)
        {
            foxdraw.DrawLine(x, y, Width / 2, Height / 2);
        }
        public static void DrawGreenDiagonal(FoxDraw foxdraw, double x1, double y1, double x2, double y2)
        {
            if (x1 == 0 && y1 == 0)
            {
                foxdraw.SetStrokeColor(Colors.Green);
                foxdraw.DrawLine(x1, y1, x2, y2);
            }
            else
            {
                foxdraw.SetStrokeColor(Colors.Blue);
                foxdraw.DrawLine(x1, y1, x2, y2);
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}