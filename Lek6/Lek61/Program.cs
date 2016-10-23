using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek61
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "bmw";
            int[] arr = new int[10];
            arr[9] = 10;

            car[0] = "Ivan";
            car[3] = "Petr";
            Console.WriteLine(car[0]);
            car[2] = "Iven";


            MyArray<string> myArr = new MyArray<string>(10);
            MyArray<int> myArr1 = new MyArray<int>(10);
            MyArray<Car> myArr2 = new MyArray<Car>(10);

            myArr1.Insert(0, 1);
            myArr.Insert(0, "a");
            myArr2.Insert(0, car);


            //нельза использовать string, так как стоит ограничение на T
            //StructArray<string> s = new StructArray<string>(10);
            StructArray<int> s = new StructArray<int>();

            Dictionary<int, string> d = new Dictionary<int, string>();
            List<int> l = new List<int>();


            ArrayList<string> list = new ArrayList<string>();
            list.Add("Ivan");
            list.Add("Pert");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
