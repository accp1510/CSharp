using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("");
            cat.Eat();
            cat.i=0;
            Console.WriteLine(cat.name);

            //Создаем переменную типа Animal и записываем в нее объект типа Сат. 
            //Это действие разрешено, так как в типе Сат имеются все поля и медоты в классе Animal (класс Cat наследуется от класса Animal)
            Animal animal = new Cat();
          
            // Невозможно запистать в переменную типа Cat объект Animal, так как в объекте нет полей и методов класса Cat
           // Cat c2 = new Animal();
      
            //Так как в переменной animal хранится ссылка на объект типа Cat, то можно получить ссылку типа Cat и обращатся к полям и методам класса Cat
            Cat c1 = (Cat)animal;
            c1.i = 0;

            Console.WriteLine();
            //---------------
            //переопределение методов
            Cat c2 = new Cat();
            c2.Speak();

            Animal a2 = new Animal();
            a2.Speak();

            Animal a1 = new Cat();
            a1.Speak();

            //Использование new
            Cat c3 = new Cat();
            c3.Run();

            Animal a3 = new Cat();
            a3.Run();

        }
    }
}
