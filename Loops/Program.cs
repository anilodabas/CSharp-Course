using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
  public  class Program
    {
      static void Main(string[] args)
        {
            //ForLoop();
            //int number = 100;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number = number-2;
            //}
            //int number = 10;
            //do
            //{

            //} while (number >=11);

            //string[] students = new string[3] { "Engin", "Derin", "Salih" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            if (IsPrimeNumber(81))
            {
                Console.WriteLine("This is prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
           bool IsPrimeNumber(int number)
            {
                bool result = true;
                for (int i = 2; i < number-1; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                    }
                }
                return result;
            }   
           

        }
        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}
