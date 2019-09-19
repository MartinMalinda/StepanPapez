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

            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.

       for (int i = 50; i < 150; i += 25)
            {
                DrawLineToCentre(foxDraw, 30, i);
            }
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