using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek8DelEvents
{
    class DelegMath
    {
        public static int Sum(int a, int b)
        {
            Console.WriteLine("Operation Sum");
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            Console.WriteLine("Operation Sub");
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            Console.WriteLine("Operation Mul");
            return a * b;
        }

        public static int Div(int a, int b)
        {
            Console.WriteLine("Operation Div");
            return a / b;            
        }
    }
}
