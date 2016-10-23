using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4_Poly
{
    class Circle : Figure
    {
        public double radius;

        public Circle(double r)
        {
            this.radius = r;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
