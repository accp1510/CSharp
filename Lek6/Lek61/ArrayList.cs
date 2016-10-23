using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Lek61
{
    class ArrayList<T> : IEnumerable<T>
    {
        private T[] arr;
        public ArrayList()
        {
            arr = new T[0];

        }
        public ArrayList(int capacity)
        {
            arr = new T[capacity];
        }

        public int Capacity { get { return arr.Length; } }
        public int Count { get; private set; }

        public void Insert(int index, T val)
        {
            arr[index] = val;
        }

        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        /// <summary>
        /// добавить элемент
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            if (Capacity == 0)
            {
                arr = new T[4];
            }
            if (Capacity == Count)
            {
                T[] temp = new T[Capacity * 2];
                Array.Copy(arr, temp, Capacity);
                arr = temp;
            }
            arr[Count] = t;
            Count++;
        }
        /// <summary>
        /// удалить элемент
        /// </summary>
        /// <param name="index">номер удаляемого элемента</param>
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
