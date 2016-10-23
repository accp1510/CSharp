using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek13
{
    public class Class1
    {
        public static void Main(string[] args)
        {

        }
        //Описываем функцию нахождения корней квадратного уравнения для ее последующего тестирования в UNit тесте
        public double[] Korni(double a, double b, double c)
        {
            if (a<b)
            {
                return null;
            }
            return new double[] { a * b * c };
        }
    }
}
