using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avg_specifig_grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int count = 0;
            double avg = 0;
            Console.WriteLine("How many scores are you entering?");
            countNumbers();
            int avgcount = count;
            sumGrades();
            Console.WriteLine($"The average score is {avg}");
            letterGrade();
            Console.ReadLine();

            /*void countNumbers()
            {
                count = int.Parse(Console.ReadLine());
                if (count <= 0)
                {
                    Console.WriteLine("Please enter a valid number > 0.");
                    countNumbers();
                }
                else return;
            }*/

            void sumGrades()
            {
                Console.WriteLine("Grade:");
                if (count > 0)
                {
                    sum += int.Parse(Console.ReadLine());
                    --count;
                    sumGrades();
                }
                else
                {
                    avg = (sum / avgcount);
                }
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
