using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Нельзя создавать объекты абстрактного класса
            //Animal a = new Animal("barsik");

            Cat c = new Cat("barsik");
            c.Speak();

            Animal a = new Cat("vasya");
            a.Speak();

            Animal a1 = new ChaoChao("моська");
            a1.Speak();

            ICanine can = new Cat("barsik");
            can.Kusat();

            Animal a3 = (Animal)can;
            a3.Speak();

            IZveri z = c;
            z.Kusat();

            //Инкапсюляция - сокрытие реализации. С объектами класса можно работать только через публичные методы и поля. Внутренняя логика класса ( поля и методы )нам не доступна
            Human h = new Human("Vasya Pupkin", 28);
            Console.WriteLine(h);
            h.Meth();
            for (int i = 0; i < 10; i++)
            {
                h.AddYearToAge();
                Console.WriteLine(h);
            }
        }
    }
}
