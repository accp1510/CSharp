using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestBuild;

namespace GCTest
{
    class Program
    {
        ~Program()
        {
            Console.WriteLine("Меня удалили");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.ToString());

            p = null;
            GC.Collect();
            Console.WriteLine(GC.MaxGeneration);

            
            Class1.M();
            
            Console.ReadLine();
        }
    }
}
