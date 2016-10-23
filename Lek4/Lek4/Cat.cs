using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4
{
    sealed class Cat : Animal
    {
        public int i;

        public Cat(){}

        public Cat(string name):base(name) {
            base.field = "cat";            
        }

        //метод замещен (переопределен)
        public override void Speak()
        {
            Console.WriteLine("Мяу");
        }

        //Замещает метод базового класса. Запрещает вызов этого метода через ссылку родительского класс, то есть 
        //Animal a3 = new Cat();        
        //a3.Run();
        //будет вызван метод класса Animal, а не Cat
        public new void Run() {
            Console.WriteLine("Лень бегать");
        }

    }

    //Нельзя унаследоваться от класса Cat, так как он защещен (помечен ключевым словом sealed)
    //class Pantera : Cat { 
    
    //}
}
