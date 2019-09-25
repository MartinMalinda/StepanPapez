using System;
using System.Collections.Generic;
using System.Text;

namespace Post_it
{
    public class PostIt
    {
        public string BackgroundColor { get; set; }
        public string Text { get; set; }
        public string TextColor { get; set; }

        public PostIt(string backgroundColor, string text, string textColor)
        {
            this.BackgroundColor = backgroundColor;
            this.Text = text;
            this.TextColor = textColor;
        }
    }
}
