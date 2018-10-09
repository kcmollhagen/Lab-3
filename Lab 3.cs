using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1-100");
            int n = int.Parse(Console.ReadLine());
            

            if (n % 2 != 0)
            {
                Console.WriteLine(n + "Odd");
                Console.ReadKey();
                if (n > 60)
                {
                    Console.WriteLine(n + "Odd");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(n + "Odd");
                    Console.ReadKey();
                }
            }
            
            

            else
            {
                if ((n > 1) && (n < 26))
                {
                    Console.WriteLine("Even and less than 25");
                    Console.ReadKey();
                }

                if ((n > 25) && (n < 61))
                {
                    Console.WriteLine("Even");
                    Console.ReadKey();
                }

                if (n>60)
                {
                    Console.WriteLine(n + "Even");
                    Console.ReadKey();
                }

            }
        }
    }
}
