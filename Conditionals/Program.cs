using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1;

            Console.WriteLine("Enter a number: ");

            number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= 0 && number1 <= 100)
            {
                Console.WriteLine("The number is in between 0-100");
            }
            else if (number1 > 100 && number1 <= 200)
            {
                Console.WriteLine("The number is in between 101-200");
            }
            else if(number1 > 200 || number1 < 0)
            {
                Console.WriteLine("The number is less than 0 or greater than 200");
            }

            Console.ReadLine();
            
        }
    }
}
