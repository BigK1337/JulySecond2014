using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double book1 = 5.75;
            double book2 = 8.00;
            int k;
            Console.WriteLine("Hitchhikers Guide to the Galaxy is: $" + book1);
            Console.WriteLine("Dune is: $" + book2);
            if (book1 < book2)
            {
                k = -1;
                Console.Write(k);
            }
            else if (book1 > book2)
            {
                k = 1;
                Console.Write(k);
            }
            else
            {
                k = 0;
                Console.Write(k);
            }
            Console.ReadLine();
        }
    }
}
