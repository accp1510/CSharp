using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSTU.Lek9.Namescape2;
using Prog = SSTU.Lek9.Namescape2.Program;
using Lek9;

namespace SSTU.Lek9.Namascace1
{
    class Program
    {
        static void Main(string[] args)
        {
            Prog p = new Prog();
            Car car = new Car();
            int[] arr = new int[10];
            try
            {
                try
                {
                    Object b = car;
                    p = p as Prog;
                    //Console.WriteLine(p);
                    if (b is Prog)
                    {
                        p = (Prog)b;
                    }
                    arr[10] = 10;
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Inner Try");
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index" + ex.Message);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("All Exception");
            }
            finally
            {
                Console.WriteLine("Всегда");
            }
            Console.WriteLine(Meth());
            //Ручное генерирование ошибки
            try
            {
                throw new MyException();
            }
            catch (MyException ex)
            {
                Console.WriteLine("Обработка нашего исключения");
                ex.Log();
            }
        }

        static string Meth()
        {
            try
            {
                try
                {
                    Object b = null;
                    return b.ToString();
                }
                catch (Exception)
                {
                    return "Inner Exception";
                }
                finally
                {
                    Console.WriteLine("Inner Finally");
                }
            }
            catch (Exception)
            {
                return "Exception";
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }

        enum Color
        {
            red = 1, black = 2, white = 3


        }
    }
}

