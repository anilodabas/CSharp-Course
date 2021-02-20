using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        protected int Id { get; set; }
        public void save()
        {   

        }
        public void delete()
        {

        }
    }
    class Student:Customer
    {
        public void save2()
        {
             
        }
    }
    class Course
    {
        public string Name { get; set; }
    }
}
