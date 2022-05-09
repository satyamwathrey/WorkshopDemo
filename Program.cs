using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WorkshopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "jupiter";
            string str2 = "rejupit";

            char [] ch1 =str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            
            Array.Sort(ch1);
            Array.Sort(ch2);

            String sort1 = new string(ch1);
            String sort2 = new string(ch2);

            if (sort1 == sort2)
            {
                Console.WriteLine("Both strings are anagrams");
            }
            else
            {
                Console.WriteLine("Both strings are not anagrams");
            }

            Console.ReadLine();
        }
    }
}
