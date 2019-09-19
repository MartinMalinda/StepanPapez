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

            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.

            for (int i = 0; i < 3; i++)
            {
                Draw5050(foxDraw, i * 100, i * 100);
            }
            
        }
        public void Draw5050(FoxDraw foxdraw, double x, double y)
        {
            foxdraw.DrawRectangle(x, y, 50, 50);
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