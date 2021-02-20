using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new FileLogger();
            customerManager.Add();
            Console.ReadLine();


        }
    }
    class CustomerManager
    {
        public ILogger logger { get; set; }
        public void Add()
        {
            logger.log();
            Console.WriteLine("Customer added!"); 
        }
    }
    class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
    class FileLogger : ILogger
    {
            public void log()
            {

                Console.WriteLine("Logged to File");
            }
    }
    class SmsLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to Sms");
        }
    }
    interface ILogger
    {
        void log();
    }
}
