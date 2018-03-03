using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades_Any_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int sum = 0;
            int avg = 0;
            int count = 0;
            Console.WriteLine("Please enter scores. Press -1 when completed");
            sumNumbers();
            avgNumbers();
            letterGrade();
            Console.ReadKey();
            void sumNumbers()
            {
                input = int.Parse(Console.ReadLine());
                if (input >= 0 && input <= 100)
                {
                    sum += input;
                    Console.WriteLine("Please enter another score.");
                    count++;
                    sumNumbers();
                }
                else if (input < 0)
                {
                    return;
                }

                else
                {
                    return;
                }
            }
            void avgNumbers()
            {
                avg = (sum / count);
                Console.WriteLine($"The average is {avg}");
            }
            void letterGrade()
            {
                if (avg >= 90)
                {
                    char result = 'A';
                    Console.WriteLine($"The letter grade is {result}");
                    return;
                }
                else if (avg >= 80)
                {
                    char result = 'B';
                    Console.WriteLine($"The letter grade is {result}");
                    return;
                }
                else if (avg >= 70)
                {
                    char result = 'c';
                    Console.WriteLine($"The letter grade is {result}");
                    return;
                }
                else if (avg >= 60)
                {
                    char result = 'D';
                    Console.WriteLine($"The letter grade is {result}");
                    return;
                }
                else
                {
                    char result = 'F';
                    Console.WriteLine($"The letter grade is {result}");
                    return;
                }

            }

        }

    }

}
