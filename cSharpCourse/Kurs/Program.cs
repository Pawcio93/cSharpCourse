using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine(a + "+" + b + "=" + (a + b));
            Console.WriteLine(a + "-" + b + "=" + (a - b));
            Console.WriteLine(a + "/" + b + "=" + (a / (double)b)); // (double) rzutowanie
            Console.WriteLine(a + "*" + b + "=" + (a * b));

            Console.WriteLine(a + "%" + b + "=" + (a % b)); // wypisuje resztę
            Console.WriteLine(a++); // postinkrementacja i preinkrementacja (dekrementacja)
            Console.WriteLine(a);

            a += 3; // a = a + 3 -= , /= , *= 
            Console.WriteLine(a);


            Console.ReadLine();
        }
    }
}
