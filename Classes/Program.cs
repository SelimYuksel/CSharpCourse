using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //classın bir örneğini oluşturduk
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();

            customer.City = "Eskişehir";
            customer.Id = 1;
            customer.FirstName = "Selim";
            customer.LastName = "Yüksel";

            Customer customer2 = new Customer
            {
                Id = 2, FirstName = "Selim", LastName = "Yüksel", City = "Eskişehir"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

}
