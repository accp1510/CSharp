using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek5
{
    class ChaoChao : Dog
    {
        public ChaoChao(string name) : base(name) { }
        public override void Speak()
        {
            Console.WriteLine("Тяфкает");
        }
    }
}
