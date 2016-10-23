using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek61
{
    class Car
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    name = "";
                    Model = "dsf";
                }
                else
                    name = value;//value - устанавливаемое значение
            }
        }
        //только для записи
        public string Model { private get; set; }
        //только для чтения
        public string Make { get; private set; }
        // для чтения и запись
        public string Color { get; set; }

        private string[] NamePerson = new string[10];
        //создание индексатора у класса
        public string this[int index]
        {
            get
            {
                return NamePerson[index];
            }
            set
            {
                NamePerson[index] = value;
            }
        }

    }
}
