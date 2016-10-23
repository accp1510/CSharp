using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek8DelEvents
{
    class Program
    {
        public delegate int Calculation(int i, int j);

        static void Main(string[] args)
        {
            Calculation calc = new Calculation(DelegMath.Sum);
            int i = calc(1, 2);
            Console.WriteLine(i);

            calc += DelegMath.Sub;
            i = calc(5, 5);
            Console.WriteLine(i);
            calc += DelegMath.Sub;
            calc += DelegMath.Mul;
            calc += DelegMath.Sub;
            calc += DelegMath.Sub;
            calc += DelegMath.Div;
            calc += DelegMath.Sum;
            calc += DelegMath.Div;

            i = calc(5, 5);
            Console.WriteLine(i);

            calc -= DelegMath.Sum;
            calc -= DelegMath.Sum;
            calc -= DelegMath.Sum;
            i = calc(5, 5);
            Console.WriteLine(i);

            Account a = new Account();
            a.PositionAdd += new Display(PositionAdd);
            //a.PositionErr += new Display(PositionErr);
            a.PositionSub += new Display(PositionSub);

            a.UpdatePosition(10000);
            a.UpdatePosition(-5000);
            a.UpdatePosition(-11234);
        }

        static void PositionAdd(int m)
        {
            Console.WriteLine("Наш счет увеличился на " + m);
        }

        static void PositionSub(int m)
        {
            Console.WriteLine("Наш счет уменьшился на " + m);
        }

        static void PositionErr(int m)
        {
            Console.WriteLine("Произошла ошибка при уменьшении счет на " + m);
        }
    }
}
