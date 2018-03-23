using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysA
{
    class Program
    {
        static void Main(string[] args)
        {
            sumArray();
        }

       
        public static void sumArray()
        {
            int[] arrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            int sum = 0;
            int count = 0;
            int avg = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                int j = arrayA[i];
                sum = sum + j;
                count++;
            }
            Console.WriteLine("Count = " + (count));
            Console.WriteLine("Sum = " + (sum));
            avg = (sum / count);
            Console.WriteLine("Mean = " + (avg));
        }
    }
}
