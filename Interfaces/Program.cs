using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Selim",
                LastName = "Yüksel",
                Department = "Computer Programming"
            };

            manager.Add(student);

            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Nevser",
                LastName = "Yıldırım",
                Address = "Eskişehir"
            };

            manager.Add(customer);    //Add fonksiyonunda IPerson kullandığımız için, fonksiyona hem customer hem de student koyabiliriz. Customer ve Student bir person olduğu için IPerson kümesine bağlıdır.
                                      //Add fonksiyonunda IPerson kullanmadığımız durumda, PersonManager'da hem customer hem de student ayrı ayrı Add fonksiyonu eklememiz gerekirdi. 
        }
    }

    interface IPerson   //Soyut Nesne
    {
        int Id { get; set; }     //Metod imzası

        string FirstName { get; set; }

        string LastName { get; set; }
    }

    class Customer : IPerson   //Somut Nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Salary { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
