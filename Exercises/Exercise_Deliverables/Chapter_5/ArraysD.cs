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
            //reverseArray();
            //rotateArray();
            SortArray();
        }
        private static void SortArray()
        {
            //init new array
            int[] arrayA = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            //create second array of inputlength
            int length = arrayA.Length;
            int[] arrayB = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int[] arrayC = new int[] { 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 9, 9 };
            Compare();

            void Compare()
            {
                int a = 0;
                do
                {

                    if (arrayA[a] > arrayB[a + 1])
                    {
                        arrayB[a] = arrayA[a + 1];
                        arrayB[a + 1] = arrayA[a];
                        arrayB.CopyTo(arrayA, 0);

                    }

                    else if (arrayB[a + 1] > arrayA[a + 2])
                    {
                        arrayB[a + 1] = arrayA[a + 2];
                        arrayB[a + 2] = arrayA[a + 1];
                        arrayB.CopyTo(arrayA, 0);

                    }
                    /*else if (arrayA[a] == arrayB[a + 1])
                    {
                        arrayB[a + 1] = arrayB[a + 2];
                        arrayB[a + 2] = arrayA[a];
                        arrayB.CopyTo(arrayA, 0);
                    } */

                    a += 1;

                    if (a>=length-2)
                    {
                        a = 0;
                    }
                }
                while (arrayB[0] <= arrayB[length - 1] && !arrayB.SequenceEqual(arrayC));
                foreach (int i in arrayB)
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        


        /*
private static void rotateArray()
{
   //init new array
   int[] arrayA = new int[] { 0, 2, 4, 6, 8, 10 };
   //create variable of length of first array
   int length = arrayA.Length;
   //create second array of variable length
   int[] arrayB = new int[length];
   start:
   Console.WriteLine("Which direction would you like to shift your array? L/R?");
   string shiftdir = Console.ReadLine();
   Console.WriteLine("How many spaces would you like to shift your array?");
   int shiftspaces = int.Parse(Console.ReadLine());
   int count = length;
   int j = 0;

   for (int i = 0; i < arrayA.Length; i++)
   {
       //iterate through each value in arrayA
       j = arrayA[i];

       switch (shiftdir)
       {
           case "l":
               left();
               break;
           case "L":
               left();
               break;
           case "r":
               right();
               break;
           case "R":
               right();
               break;
           default:
               Console.WriteLine("Please enter L/R.");
               goto start;
       }

       void right()
       {
           //indexarrayB = sum(count+shift) remainder(%) constant length
           arrayB[ (count + shiftspaces) % length ] = j;
           count--;

       }
       void left()
       {
           //(count - shiftspaces) % length
           arrayB[mod((count - shiftspaces), length)] = j;
           count--;
       }
       int mod(int x, int m)
       {
           return (x % m + m) % m;
       }
   }    
   Console.WriteLine("\n");
   foreach (int i in arrayB)
   {
       Console.WriteLine(i);
   }
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
