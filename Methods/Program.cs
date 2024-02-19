using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int n1 = 20;
            //int number2 = 100;

            //var result = Sum2(ref n1, number2);
            //Console.WriteLine(result);
            //Console.WriteLine(n1);

            Console.WriteLine(Multiply(2,4));

            Console.WriteLine(Multiply(2,4,6));

            Console.WriteLine(MultiplyWithParams(1,3,4,5));

            Console.WriteLine(Add3(1,2,4,5,6,7));



            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(ref int number1, int number2 = 0)  //number 2 verilmezse default değer olarak 0 ver
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)  //Method overload
        {
            return number1 * number2 * number3;
        }

        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }

        static int MultiplyWithParams(params int[] numbers)
        {
            int result = 1;

            foreach(int num in numbers)
            {
                result *= num;
            }

            return result;
        }

        
    }
}
