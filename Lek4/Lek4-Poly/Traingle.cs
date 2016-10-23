using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4_Poly
{
    class Traingle : Figure
    {
        public double a;
        public double b;
        public double c;

        public Traingle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
