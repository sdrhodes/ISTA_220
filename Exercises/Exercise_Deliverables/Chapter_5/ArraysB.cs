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
            //sumArray();
            reverseArray();
        }

        private static void reverseArray()
        {
            //init new array
            int[] arrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            //create variable of length of first array
            int length = arrayA.Length;
            //create second array of variable length
            int[] arrayB = new int[length];
            int j = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {
                j = arrayA[i];
                arrayB[length-1] = j;
                length--;
            }
            foreach (int i in arrayB)
            {
                Console.WriteLine(i);
            }
        }

        /*
        private static void sumArray()
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
        */
    }
}
