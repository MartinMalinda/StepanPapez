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

            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            canvas.Width = 400;
            canvas.Height = 300;

            DrawGreenDiagonal(foxDraw, 0, 0, canvas.Width, canvas.Height);
            DrawGreenDiagonal(foxDraw, canvas.Width, 0, 0, canvas.Height);

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