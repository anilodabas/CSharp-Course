using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfaces.OracleCostumerDal;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager manager = new PersonManager();
            //Customer customer = new Customer() {
            //    Id = 1,
            //    FirstName = "Anıl",
            //    LastName = "Odabaş",
            //    Address = "İstanbul"
            //};
            //Student student = new Student() 
            //{

            //    Id = 1,
            //    FirstName = "Engin",
            //    LastName = "Demiroğ",
            //    Department = "Computer Sciences"

            //};
            //manager.Add(student);
            //manager.Add(customer);

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCostumerDal());
            ICostumerDal[] costumerDals = new ICostumerDal[3] {
                new SqlServerCustomerDal(),
                new OracleCostumerDal(),
                new MySqlCostumerDal()
                
            };
            foreach(var costumerDal in costumerDals)
            {
                costumerDal.Add();
            }


            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
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
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
