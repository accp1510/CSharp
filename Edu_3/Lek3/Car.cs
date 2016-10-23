using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek3
{
    class Car
    {
        public string Make;
        public string Model;
        public int Massa = 0;
        public string color;

        public static int number;

        static Car()
        {
            number = 10;
            Console.WriteLine("static konstructor");
        }

        ~Car()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Model + "delete");
        }


        public Car()
        {
            number++;
            Console.WriteLine("Фигня");

        }

        public Car(string Make, string Model, string color, int Massa)
            : this()
        {
            this.Make = Make;
            this.Model = Model;
            this.color = color;
            this.Massa = Massa;
            Driving();
        }


        public void Driving()
        {
            Console.WriteLine("Поехали");
        }

        public void Breaking()
        {
            Console.WriteLine("Стоп");
        }

        public static int GetNumber()
        {

            return number;
        }

        public void GetRef(ref int b)
        {
            b = 15;
        }
        public void GetRef(int b)
        {
            b = 10;
        }

        public void GetOut(out int b)
        {
            b = 100;
        }

        public void GetOut(int b)
        {
            b = 200;
        }

        public int GetPerad(int speed)
        {
            Console.WriteLine("meth int");
            return speed > 50 ? 2 : 1;
        }

        public long GetPerad(double speed)
        {
            Console.WriteLine("meth int");
            return speed > 50 ? 2 : 1;
        }

        public int GetPerad(string speed)
        {
            Console.WriteLine("meth string");
            int s = int.Parse(speed);
            return GetPerad(s);
        }

        public void SetMass(int Massa)
        {
            this.Massa = Massa;
            this.GetPerad(10);
        }


    }
}
