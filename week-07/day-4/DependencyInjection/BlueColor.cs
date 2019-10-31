using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class BlueColor : IColor
    {
        private Printer printer;

        public BlueColor(Printer printer)
        {
            this.printer = printer;
        }

        public void PrintColor()
        {
            printer.Log("It is blue in color...");
        }
    }
}
