using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();

            //ProductManager productManager = new ProductManager();
            //productManager.Update();
            //productManager.Add();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Anıl";
            customer.LastName = "Odabaş";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Anıl",
                LastName = "Kara"

            };

            Console.WriteLine(customer2.City);

            Console.ReadLine();
        }
    }
}



