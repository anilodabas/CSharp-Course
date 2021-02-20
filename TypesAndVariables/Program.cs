using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal number6 = 10.5M; // para değerleri tutmak için kullanılır 
            double number5 = 10.4;   // 64 bit veri tutuşu var 
            char character = 'A';
            bool condition = true; // şart durumu false yada true değer tipi 
            byte number4 = 0; //0-255 arası tutuyor 
            short number3 = 32767;
            long number2 = 9223372036854775807; //64 bit yer kaplıyor
            int number1 = 2147483647; // 32 bit yer kaplıyor 
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);

            Console.WriteLine((int)Days.Friday);

            Console.WriteLine("Character is {0}", (int)character);
            Console.ReadLine();
        }
    }
    enum Days //Stringde tek tek yazmak yerine enum ile tek seferde yazılabilir. 
    {
        Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday 
    }
}

