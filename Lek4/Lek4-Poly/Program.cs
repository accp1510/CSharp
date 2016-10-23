using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4_Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] f = new Figure[5];
            f[0] = new Circle(1);
            f[1] = new Rectangle(2, 34);
            f[2] = new Traingle(3, 4, 5);
            f[3] = new Figure();
            f[4] = new Circle(60);

            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine(f[i].Area());
            }
        }
    }
}
