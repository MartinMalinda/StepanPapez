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

            // Reproduce this:
            // [https://github.com/green-fox-academy/chama-cs-prg-syllabus/blob/master/workshop/drawing/assets/r3.png]

            int step = 10;
            foxDraw.SetFillColor(Colors.Purple);
            for (int i = 0; i < 19; i++)
            {
                foxDraw.DrawRectangle(step, step, 10, 10);
                step += 10;
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