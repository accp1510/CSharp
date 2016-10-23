using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.number=10;
            Console.WriteLine("--------");
            Car car = new Car();
            car.color = "Red";
            car.Make = "BMW";
            car.Model = "X6M";
            car.Massa = 3000;

            Console.WriteLine(car.Make);
            car.Driving();
            car.Breaking();
            int n = Car.GetNumber();
            Console.WriteLine(n);

            Console.WriteLine(Car.number);

            Car car2 = new Car();
            Console.WriteLine("number car " + Car.number);

            int i = 5;
            car.GetRef(i);
            Console.WriteLine("i = " + i);

            car.GetRef(ref i);
            Console.WriteLine("i = " + i);

            Console.WriteLine("out");
            int b;
            car.GetOut(out b);
            Console.WriteLine(b);

            Console.WriteLine(car2.Make);

            Console.WriteLine("Перегрузка");
            Console.WriteLine(car.GetPerad(60));
            string speed = "36";
            Console.WriteLine(car.GetPerad(speed));

            Car car3 = new Car("BMW", "X6", "Blue", 3001);
            Console.WriteLine(Car.number);
            car = null;
            //Console.WriteLine(DateTime.Now);
            //List<string> list = new List<string>();
            //while (true)
            //{
            //    list.Add("1");
            //}

        }
    }
}
