using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string city = "Ankara";
            //    //Console.WriteLine(city[0]);
            //    foreach(var item in city)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    string city2 = "İstanbul";
            //    string result = city + city2;

            //    Console.WriteLine(result);

            string sentence = "My name is Anıl Odabaş";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is";

            bool result3 = sentence.EndsWith("ş");
            bool result4 = sentence.StartsWith("M");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3, 4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2,5);
            Console.WriteLine(result13);
            Console.ReadLine();
        }

    }
}
