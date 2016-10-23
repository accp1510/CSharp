using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek4
{
    class Animal : Object
    {
        protected string field;
        public string name;

        public Animal() {
            Console.WriteLine("Animal");
        }

        public Animal(string name) {
            this.name = name;
        }

        public void Eat()
        {
            Console.WriteLine("Что-то ест");
        }

        //виртуальный метод (может замещен в классах-потомках)
        public virtual void Speak() {
            Console.WriteLine("Говорить");
        }

        //виртуальный метод (может замещен в классах-потомках)
        public virtual void Run() {
            Console.WriteLine("Бегает");
        }
    }
}
