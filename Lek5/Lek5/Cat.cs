using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek5
{
    class Cat : Animal, ICanine, IZveri
    {

        //Так как в классе-родителе(Animal) имеется конструктор с одним параметром, то создаем так же в потомке конструктор с одним параметром. Кострукция base(name) вызывает конструктор класса Animal
        public Cat(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine("Мяу");
        }


        public override void Kusat()
        {
            Console.WriteLine("Кусать кусать");
        }

        void ICanine.Kusat() {
            Kusat();
        }

        void IZveri.Kusat() {
            Console.WriteLine("24 зуба");
        }

        public void KuastConine() {
            ICanine c = this;
            c.Kusat();            
        }

        public void KuastZveri()
        {
            IZveri c = this;
            c.Kusat();
        }
     
    }
}
