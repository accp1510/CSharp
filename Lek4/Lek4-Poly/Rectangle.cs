using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4_Poly
{
    class Rectangle : Figure
    {
        public double width;
        public double height;

        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
