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
            // Draw a box that has different colored lines on each edge.

            foxDraw.SetStrokeThicknes(3);

            // line a
            foxDraw.SetStrokeColor(Colors.Aqua);
            foxDraw.DrawLine(10, 10, 200, 10);
            
            // line b
            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(200, 10, 200, 200);

            // line c
            foxDraw.SetStrokeColor(Colors.Chartreuse);
            foxDraw.DrawLine(10, 200, 200, 200);

            // line d
            foxDraw.SetStrokeColor(Colors.DarkGreen);
            foxDraw.DrawLine(10, 10, 10, 200);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}