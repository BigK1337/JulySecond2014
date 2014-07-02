using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        public void Compare (int a, int b)
        {
            if ( a < b)
            {
                Console.WriteLine(a + " is the smallest number");
            }

            else
            {
                Console.WriteLine(b + " is the smallest number");
            }
        }
        static void Main(string[] args)
        {
            for(int z = 0; z <1000; z++)
            {
                int x; 
            int y;
            Console.WriteLine("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter second number: ");
             y = Convert.ToInt32(Console.ReadLine());
             
                if (x < y)
                {
                    Console.WriteLine(x + " is the smallest number.");
                }
                else
                {
                    Console.WriteLine(y + " is the smallest number.");
                }
            }
        }
    }
}
