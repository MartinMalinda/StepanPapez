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
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.
            
            canvas.Width = 400;
            canvas.Height = 400;
            foxDraw.SetBackgroundColor(Colors.WhiteSmoke);

            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(canvas.Width / 2, 0, canvas.Width / 2, canvas.Height);

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(0, canvas.Height / 2, canvas.Width, canvas.Height / 2);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}