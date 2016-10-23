using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Lek8
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Hello");
            set.Add("Hello");
            set.Add("World");
            Console.WriteLine(set.Count);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            HashSet<string> setA = new HashSet<string> { "B", "A", "C", "D" };
            HashSet<string> setB = new HashSet<string> { "C", "D", "E", "F" };
            //объединение множеств
            setA.UnionWith(setB);
            foreach (var item in setA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //содание множества, в которых нет общих элементов мжножеств А и В
            setA = new HashSet<string> { "B", "A", "C", "D" };
            setA.SymmetricExceptWith(setB);
            foreach (var item in setA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //вычитание из множества А множество В
            setA = new HashSet<string> { "B", "A", "C", "D" };
            setA.ExceptWith(setB);
            foreach (var item in setA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
            //общие элементы множества А и множества В
            setA = new HashSet<string> { "B", "A", "C", "D" };
            setA.IntersectWith(setB);
            foreach (var item in setA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //отсортироавнное множество
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(10);
            sortedSet.Add(1);
            sortedSet.Add(5);
            foreach (var item in sortedSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            setA = new HashSet<string> { "B", "A", "C", "D" };
            SortedSet<string> s = new SortedSet<string>(setA);
            foreach (var item in s)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            BigInteger b = new BigInteger(1);
            for (int i = 1; i <= 50; i++)
            {
                b *= i;
            }
            Console.WriteLine(b);
            //BigInteger a = new BigInteger(1);
            //for (int i = 1; i <= 30000; i++)
            //{
            //    a *= i;
            //}
            //Console.WriteLine(a);


            //стек
            Stack<int> stack = new Stack<int>();
            //добавить элемент в начало
            stack.Push(10);
            PrintStack(stack);
            stack.Push(20);
            PrintStack(stack);
            stack.Push(5);
            PrintStack(stack);
            //удаление из начала
            stack.Pop();
            PrintStack(stack);
            stack.Pop();
            PrintStack(stack);
            stack.Push(100);
            PrintStack(stack);

            //очередь
            Console.WriteLine("\nОчередь");
            Queue<int> queue = new Queue<int>();
            //добавление в конец очереди
            queue.Enqueue(10);
            PrintStack(queue);
            queue.Enqueue(20);
            PrintStack(queue);
            queue.Enqueue(30);
            PrintStack(queue);
            //Удаление из начала очереди
            queue.Dequeue();
            PrintStack(queue);
            queue.Dequeue();
            PrintStack(queue);
            queue.Enqueue(100);
            PrintStack(queue);

        }

        private static void PrintStack(IEnumerable<int> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }            
            Console.WriteLine();
        }
    }
}
