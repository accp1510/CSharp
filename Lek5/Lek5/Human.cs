using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek5
{
    class Human
    {
        //скрытые поля (тоступны только квнутри класса Human)
        private string name;
        private int age;

        //в конструкторе класса происходит инициализация скрытый полей
        public Human(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        //Каждый год неохдимо увеличивать возрат, но напрямую нельзя обратиться к полю age. Поэтому неоходимо описать открытый публичный медот, который будет увеличивать значение возраста
        public void AddYearToAge()
        {
            age++;
        }

        public override string ToString()
        {
            return "Имя: " + name + " Возраст: " + age;
        }

        private void Method1()
        {
            Console.WriteLine("Что-то скрытно делается");
        }

        private void Method2()
        {
            Console.WriteLine("Что-то вдвоейне скрытно делается");
        }

        public void Meth()
        {
            Method1();
            Method2();
        }



    }
}
