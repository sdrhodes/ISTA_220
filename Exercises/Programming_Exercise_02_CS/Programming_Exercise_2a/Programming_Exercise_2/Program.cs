using System;

namespace Programming_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number?");
            double num1 = double.Parse(Console.ReadLine());
            //Compare(num1);
            double result1 = Compare(num1);
            Console.WriteLine("What is the second number?");
            double num2 = double.Parse(Console.ReadLine());
            //Compare(num2);
            double result2 = Compare(num2);
            Console.WriteLine("What is the third number?");
            double num3 = double.Parse(Console.ReadLine());
            //Compare(num3);
            double result3 = Compare(num3);
            Console.WriteLine("What is the fourth number?");
            double num4 = double.Parse(Console.ReadLine());
            //Compare(num4);
            double result4 = Compare(num4);
            Console.WriteLine("What is the fifth number?");
            double num5 = double.Parse(Console.ReadLine());
            //Compare(num5);
            double result5 = Compare(num5);
            Console.WriteLine("What is the sixth number?");
            double num6 = double.Parse(Console.ReadLine());
            //Compare(num6);
            double result6 = Compare(num6);
            Console.WriteLine("What is the seventh number?");
            double num7 = double.Parse(Console.ReadLine());
            //Compare(num7);
            double result7 = Compare(num7);
            Console.WriteLine("What is the eighth number?");
            double num8 = double.Parse(Console.ReadLine());
            //Compare(num8);
            double result8 = Compare(num8);
            Console.WriteLine("What is the ninth number?");
            double num9 = double.Parse(Console.ReadLine());
            //Compare(num9);
            double result9 = Compare(num9);
            Console.WriteLine("What is the tenth number?");
            double num10 = double.Parse(Console.ReadLine());
            //Compare(num10);
            double result10 = Compare(num10);

            Console.WriteLine
                ("The sum is {0}", (result1+result2+result3+result4+result5+result6+result7+result8+result9+result10));
            Console.ReadLine();
        }

        public static double Compare(double num)
        {   
            //check that input is correct, return input if valid, 
            //otherwise ask user to reenter number
            if (num < 0 || num > 100)
            {
                Console.WriteLine("Please enter a number between 0-100");
                num = double.Parse(Console.ReadLine());
                return num;
            }
            else
            {
                return num;
            }
        }
    }
}
