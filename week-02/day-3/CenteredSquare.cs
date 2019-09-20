using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

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

            // Draw a green 10x10 square to the canvas' center.

            double a = 10;
            
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.SetFillColor(Colors.Green);
            foxDraw.DrawRectangle(Width / 2 - a / 2, Height / 2 - a / 2, 10, 10);
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