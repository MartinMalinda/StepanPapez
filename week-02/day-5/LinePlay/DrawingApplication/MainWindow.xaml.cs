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

            DrawLinePlay(foxDraw, 15);
            
        }

        public void DrawLinePlay(FoxDraw foxDraw, double lines)
        {
            double numberOfPoints = lines;
            double distance = Height / numberOfPoints;
            foxDraw.SetStrokeThicknes(2);

            for (int i = 0; i < numberOfPoints; i++)
            {
                foxDraw.SetStrokeColor(Colors.MediumPurple);
                foxDraw.DrawLine(distance * i, 0, Height, distance * i);
                foxDraw.SetStrokeColor(Colors.LimeGreen);
                foxDraw.DrawLine(0, distance * i, distance * i, Height);
            }
        }
        public void DrawEnvelopeStar(FoxDraw foxDraw, double lines)
        {
            foxDraw.SetStrokeColor(Colors.LimeGreen);
            double numberOfPoints = lines;
            double halfWindow = Height / 2;
            double distance = halfWindow / numberOfPoints;


            for (int i = 0; i < numberOfPoints; i++)
            {
                foxDraw.DrawLine(halfWindow, distance * i, halfWindow + distance * i, halfWindow);
                foxDraw.DrawLine(halfWindow, distance * i, halfWindow - distance * i, halfWindow);
                foxDraw.DrawLine(halfWindow, Height - distance * i, halfWindow - distance * i, halfWindow);
                foxDraw.DrawLine(halfWindow, Height - distance * i, halfWindow + distance * i, halfWindow);
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