using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ArrayClass{
        private int[] __array;

        public ArrayClass(int[] array)
        {
            __array = array;
        }

        public void Print ()
        {
            for (var i = 0; i < __array.Length; i++)
            {
                Console.WriteLine(__array[i]);
            }
        }

        public void Delete ()
        {
            int[] newArray = new int[__array.Length-1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = __array[i];
            }
            __array = newArray;
        }

        public void Add(int value) 
        {
            int[] newArray = new int[__array.Length + 1];
            for (int i = 0; i < __array.Length; i++)
            {
                newArray[i] = __array[i];
            }
            newArray[newArray.Length - 1] = value;
            __array = newArray;
        }

        public void Insert (int index, int value)
        {
            int[] newArray = new int[__array.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = __array[i];
            }
            newArray[index] = value;
            for (int i = index+1; i < newArray.Length; i++)
            {
                newArray[i] = __array[i-1];
            }
            __array = newArray;
        }
    }

    class Program
    {
        public static ArrayClass Create (int[] array)
        {
            ArrayClass arr = new ArrayClass(array);
            return arr;
        }

        public static T Print<T>(int[] array)
        {
            return default(T);
        }

        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            //arr.Print();
            //arr.Delete();
            //Console.WriteLine("---");
            //arr.Print();

            //создание обобщенной коллекции
            
            List<List<List<int>>> array = new List<List<List<int>>>();
            //Print(3);
            //Print(3);
            //Print("Hello");
            //Print(true);

            Console.WriteLine(Print<ArrayClass>(new int[]{1,4,5,6 }));



        }
    }
}
