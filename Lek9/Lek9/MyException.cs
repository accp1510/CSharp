using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek9
{
    class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("Наша ошибка");
        }
        public void Log() {
            Console.WriteLine("Log");
        }
    }
}
