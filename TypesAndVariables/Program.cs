using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
                       
            int number1 = 2147483647;  //32 bit
            long number2 = 9223372036854775807;  //64 bit
            short number3 = 32767;
            byte number4 = 255;  //0-255
            double number5 = 10.32;
            decimal number6 = 10.4m;
            bool condition = true;
            char character = 'A';
            var variable = 10;
            variable = 'A';
            
            Console.WriteLine("Number 1 is {0}", number1);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 4 is {0}", number4);
            Console.WriteLine("Number 5 is {0}", number5);
            Console.WriteLine("Condition is :", condition);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character's ASCII value is : {0}", (int)character);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Variable is : {0}", variable);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday 
    }
}
