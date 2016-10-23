using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek61
{
    //создание обобщенного класса
    //данный класс будет обрабатывать тип <T> , который будет известен в момент создания экземпляра данного класса
    class MyArray<T>
    {

        private T[] arr;
        public MyArray() { }
        public MyArray(int capacity)
        {
            arr = new T[capacity];
        }

        public int Length { get { return arr.Length; } }

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

    }
    //обобщенный класс с двумя типами <T,V>
    class MyArray<T, V> { }

    //если унаследоваться от обобщенного класса и указать у него тип(MyArray<string>), то класс потомок станет не обощненным
    class StringArray : MyArray<string> { }

    //если не указывать тип, о класс потомок будет обощненным
    class MyArray1<T> : MyArray<T>{ }

    //ограничение тип параметра Т
    //в данном случае вместо Т можно подставить значащий тип (int, long, float и т.д.)
    //
    class StructArray<T> : MyArray<T> where T : struct {
        
    }


}
