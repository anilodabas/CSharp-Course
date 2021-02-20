using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasess
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Delete();

            Database database1 = new Oracle();
            database1.Add();
            database1.Delete();

            Console.ReadLine();

        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }
    class Oracle : Database
    {  
        public override void Delete()
        {
            Console.WriteLine("deleted by Oracle");
        }
    }
}
