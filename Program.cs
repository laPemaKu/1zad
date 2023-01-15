using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";

            string s3 = s1.Remove(8);
            s3 = s3.Insert(7,s2.Substring(7));
            Console.WriteLine(s2.Substring(7));

            Console.WriteLine(s3);
            
            
            Console.ReadKey();
        }
    }
}
