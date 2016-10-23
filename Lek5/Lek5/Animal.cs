using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek5
{
    abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void Speak();

        public virtual void Kusat() {
            Console.WriteLine("Звери кусаются");
        }
    }
}
