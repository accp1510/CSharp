using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace Lek71
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable hash = new Hashtable();
            hash.Add("Иванов", "Иванов Иван Иванович");
            hash.Add("Петров", "Петров Иван Иванович");
            hash["Иванов"] = 12;
            hash.Add("петров", "Петров Иванович");
            Console.WriteLine("Петров " + "Петров".GetHashCode());
            Console.WriteLine("петров " + "петров".GetHashCode());

            Person p1 = new Person() { Name = "Иван", LastName = "Иванов" };

            Person p2 = new Person { Name = "Петр", LastName = "Петров" };
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            hash.Add(p1, p1);
            hash.Add(p2, p2);
            //Console.WriteLine(p1==p2);

            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic[1000] = "10";
            dic.Add(10, "20");
            dic[10] = "50";
            dic[100] = "10";
            foreach (var i in dic)
            {
                Console.WriteLine(i.Key + " -> "+i.Value);
            }

            Console.WriteLine();
            SortedList<string, string> sordetList = new SortedList<string, string>(new MySort());
            sordetList.Add("BAa", "b");
            sordetList.Add("aAa", "b");
            sordetList.Add("aa", "b"); 
            sordetList.Add("Bab", "b");

            foreach (var i in sordetList)
            {
                Console.WriteLine(i.Key + " -> " + i.Value);
            }

        }

        private static void MethodList()
        {
            //динамический масив
            ArrayList array = new ArrayList();
            array.Add("string");
            array.Add(121);
            array.Add(new Object());

            //список, реализованный с помощью массива
            List<object> list = new List<object>();
            list.Add("sad");
            list.Add(1423);
            list.Insert(2, "sd");
            list[0] = "aaa";

            //статический массив
            object[] obj = new object[10];
            obj[0] = "sad";
            obj[1] = 10;
            obj[2] = new object();

            string str = "abd";
            string str1 = "abd";
            string str2 = new String(new char[] { 'a', 'b', 'd' });
            Console.WriteLine(str == str2);


            //ссылочный список (классичесций список)
            LinkedList<string> linkedList = new LinkedList<string>();
            //добавление в начало списка
            linkedList.AddFirst("sad");
            linkedList.AddFirst("ass");
            //добавление поосле элемента "sad"
            linkedList.AddAfter(linkedList.Find("sad"), "newstrint");
            //добавление перед элемента "sad"
            linkedList.AddBefore(linkedList.Find("sad"), "before sad");
            //удаление последнего элемента
            linkedList.RemoveLast();
            //получение ссылки на следующий элемент
            Console.WriteLine(linkedList.First.Value);
            foreach (string s in linkedList)
            {
                Console.WriteLine(s);
            }

            List<int> listAdd = new List<int>();
            LinkedList<int> linkAdd = new LinkedList<int>();

            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 100000; i++)
            {
                listAdd.Insert(0, i);
            }
            timer.Stop();
            Console.WriteLine("List adding time: " + timer.ElapsedMilliseconds);

            timer.Reset();
            timer.Start();
            for (int i = 0; i < 100000; i++)
            {
                linkAdd.AddFirst(i);
            }
            timer.Stop();
            Console.WriteLine("LinkList add time: " + timer.ElapsedTicks);
            //Console.WriteLine("LinkedList adding time: " + timer.ElapsedMilliseconds);
            //Timer t = new Timer(delegate {Console.WriteLine("qwe");},null,0,1000);
            //Console.ReadLine();

            timer.Reset();
            timer.Start();
            Console.WriteLine(listAdd[50000]);
            timer.Stop();
            Console.WriteLine("List get time: " + timer.ElapsedTicks);


            timer.Reset();
            timer.Start();
            LinkedListNode<int> t = linkAdd.First;

            int count = 0;
            while (t != null)
            {
                if (count == 50000)
                {
                    Console.WriteLine(t.Value);
                    break;
                }
                t = t.Next;
                count++;
            }
            timer.Stop();
            Console.WriteLine("LinkedList get time: " + timer.ElapsedTicks);
        }




    }

    class MySort : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return y.CompareTo(x);
        }
    }


}
