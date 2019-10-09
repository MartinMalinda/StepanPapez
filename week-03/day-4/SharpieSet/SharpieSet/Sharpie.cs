using System;
using System.Collections.Generic;
using System.Text;

namespace SharpieSet
{
    public class Sharpie
    {
        public string Color { get; private set; }
        public double Width { get; private set; }
        public double InkAmount { get; private set; }

        public Sharpie(string color, double width)
        {
            this.Color = color;
            this.Width = width;
            InkAmount = 100;
        }

        public void Use()
        {
            InkAmount--;
        }
    }
}
