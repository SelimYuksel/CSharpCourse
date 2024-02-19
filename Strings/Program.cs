using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Selim Yüksel";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Fatih Yüksel"; //clone yaptık ama My name is Selim Yüksel yazar

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" "); //bulduğu ilk boşluğu sayar
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, "); //0. karakterden itibaren şunu ekle
            var result9 = sentence.Substring(3,4); //3. indexten itibaren 4 tane karakter yazar
            var result10 = sentence.ToLower(); //küçük harf
            var result11 = sentence.Replace(" ", "-");

            Console.WriteLine(result11);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Eskişehir";
            Console.WriteLine(city[0]);

            foreach (var letter in city)
            {
                Console.WriteLine(letter);
            }

            string city2 = "İstanbul";

            Console.WriteLine("{0} {1}", city, city2);
        }
    }
}
