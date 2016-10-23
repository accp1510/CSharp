using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lek81;
using System.IO;

namespace Lek91
{
    public delegate void MyDeleg(string s);
    class Program
    {
        static void Main(string[] args)
        {
            MyDeleg m = new MyDeleg(Print);
            int a = 10;
            m += delegate(string s)
            {
                Console.WriteLine("Annonimys Method " + a + s);
                a = 100;
            };
            Console.WriteLine(a);
            m("print");
            Console.WriteLine(a);
            Car c = new Car();
            c.Breaking();
            int? i = null;
            int d = i ?? 055;
            Console.WriteLine(d);
            c.Color = ColorCar.Blue;
            Console.WriteLine((int)c.Color);
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine((ColorCar)j);
            }
            switch (c.Color)
            {
                case ColorCar.Red:
                    break;
                case ColorCar.Black:
                    break;
                case ColorCar.Blue:
                    break;
                default:
                    break;
            }
            FileInfo f = new FileInfo("2.txt");
            //  f.Create()
            Console.WriteLine(f.FullName);
            f.IsReadOnly = true;
            DirectoryInfo dir = new DirectoryInfo("C:\\");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Dir  " + dir.GetDirectories().Count());
            Console.WriteLine("Files  " + dir.GetFiles().Count());
            Console.WriteLine("------------------------------------");
            string[] str = File.ReadAllLines("1.txt", Encoding.GetEncoding("Windows-1251"));
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            File.AppendAllText("1.txt", ", пользователь", Encoding.GetEncoding("Windows-1251"));
            FileStream fs = File.OpenWrite("1.txt");
            fs.Seek(-10, SeekOrigin.End);
            using (StreamWriter wr = new StreamWriter(fs, Encoding.GetEncoding("Windows-1251")))
            {
                wr.Write("9999999");               
            }


        }

        static void Print(string s)
        {
            Console.WriteLine("Static method " + s);
        }
    }
}
