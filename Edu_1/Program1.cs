using System;

namespace Lek1.haudfrhjhu.sstu
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();         
            // string str = "Hello";         
            // Console.WriteLine("Hello {0}",name );

            //bool b = true;
            //while (b)
            //{
            //    string str = Console.ReadLine();
            //    try
            //    {
            //        int a = Convert.ToInt32(str);
            //        b = false;
            //        Console.WriteLine(a);
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Строка не число. Повторите ввод");
            //    }
            //}

            //string str = Console.ReadLine();
            //int a;
            //bool b = int.TryParse(str, out a);
            //if (b)
            //{
            //    Console.WriteLine("Строка не число. Повторите ввод {0:x}", a);
            //}
            //else
            //{
            //    Console.WriteLine("Строка не число. Повторите ввод {0:x}",a);
            //}
            try
            {
                Console.WriteLine("Введите число 1:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число 2:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите операцию:");
                string str = Console.ReadLine();
                char oper = str[0];
                int rez = 0;
                switch (oper)
                {
                    case '+':
                        rez = a + b;
                        break;
                    default:
                        Console.WriteLine("Error");
                        return;
                }
                Console.WriteLine("Результат {0} {2} {1} = {3}", a, b, oper, rez);
            }catch(Exception ex)
            {
                Console.WriteLine("Что-то пошло не так "+ ex.Message);
            }


        }


        static void Method()
        {

        }
    }
}
