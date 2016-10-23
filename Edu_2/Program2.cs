using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek21
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime time = DateTime.Now;
            //Console.WriteLine("{0}",time);
            //Console.WriteLine("{0:d}", time);
            //Console.WriteLine("{0:D}", time);
            //Console.WriteLine("{0:g}", time);

            //Console.WriteLine("{0}", time.ToLongTimeString());
            //Console.WriteLine("{0}", time.ToShortTimeString());
            //Console.WriteLine("{0}", time.ToString("ddd dd-MMMM/yyyy H:mm:ss"));

            //Console.WriteLine("{0}", time.ToString("yyyy MMMM dd dddd"));

            //Console.WriteLine("{0}", time.ToString(" MMMM dd yyyy dddd"));

            //Console.WriteLine("{0}", time.ToString(CultureInfo.CreateSpecificCulture("en-US")));
            //Console.WriteLine("{0}", time.ToString(CultureInfo.CreateSpecificCulture("zh-CN")));

            //string t =time.ToString("dd MMMM yyyy",CultureInfo.CreateSpecificCulture("zh-CN"));
            //Console.WriteLine("{0}", t);

            //int x = 10;
            //if (x > 0 | x<10)
            //{
            //    Console.WriteLine("positive");
            //}
            //else
            //{
            //    Console.WriteLine("zero negative");
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello");
            //}
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //checked
            //{

            //    byte b = (byte)255;
            //    b += (byte)1;
            //    Console.WriteLine(b);
            //}

            //double d = 5.6;

            //Console.WriteLine(d-(int)d);
            //if (True() || True())
            //{

            //}

            //int x = 5;
            //int c = ++x;
            //Console.WriteLine(x+" "+c);

            int x = 5;
            int c = ++x + x++;
            Console.WriteLine(x + " " + c);

        }

        public static bool True()
        {
            Console.WriteLine("true");
            return true;
        }

        public static bool False()
        {
            Console.WriteLine("false");
            return false;
        }
    }
}
