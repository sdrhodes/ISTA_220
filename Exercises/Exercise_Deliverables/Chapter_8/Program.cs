﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            //Altered from Sanfoundry
            while (true)
            {
                int randnum = Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 - 100(0 to quit).");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < randnum)
                    {
                        Console.WriteLine("Low, try again.");
                        ++count;
                        continue;
                    }
                    else if (input > randnum)
                    {
                        Console.WriteLine("High, try again.");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Correct! The number was {0}!", randnum);
                        Console.WriteLine("It took you {0} {1}.\n", count, count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }

        }
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
