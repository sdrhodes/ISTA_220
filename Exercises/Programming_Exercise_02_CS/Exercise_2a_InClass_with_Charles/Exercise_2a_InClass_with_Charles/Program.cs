using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2a_InClass_with_Charles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum ten integers.");
            int sum = 0;
            int count = 0;
            Sum();
            Console.WriteLine($"The sum is {sum}.");

            void Sum()
            {
                count++;
                Console.WriteLine($"Enter integer {count}:");
                sum += int.Parse(Console.ReadLine());
                if (count < 10)
                {
                    Sum();
                }
                else
	            {
                    return;
	            }

            }
                
        }
    }
}
