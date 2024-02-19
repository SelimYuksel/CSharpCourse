using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");
            Console.WriteLine(cities.Count);  // prints out 0 
            

            MyList<string> cities2 = new MyList<string>();
            cities2.Add("Eskişehir");
            cities2.Add("Eskişehir");
            cities2.Add("Eskişehir");
            cities2.Add("Eskişehir");
            cities2.Add("Eskişehir");
            cities2.Add("Eskişehir");
            Console.WriteLine(cities2.Count);
            


            Console.ReadLine();
        }
    }

    class MyList<T>  // T ----> type (string, int etc etc)
    {
        T[] _array;
        T[] _tempArray; // yedek dizi
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;  // _tempArray _array dizisinin referansını alır, bunu yapmazsak eleman sayısı arttığında _array dizisinin elemanları yok olur
            _array = new T[_array.Length + 1];  // Her eleman eklediğimizde eleman sayısını 1 arttır
            for(int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }
       
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
