using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Find();
            }
            catch(RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandleException(() =>
            {
                Find();

            });
                         
          
            
            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        public static void Find()
        {
            List<string> students = new List<string> { "Anıl", "Engin", "Derin" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
   
}
