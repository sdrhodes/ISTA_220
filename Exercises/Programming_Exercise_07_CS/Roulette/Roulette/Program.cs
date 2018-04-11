using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roulette
{
    /// <summary>
    /// Create bet logic
    /// </summary>

    class RouletteWheel
    {
        static int[] wheel = new int[] {
        0,28,9,26,30,11,7,20,32,17,5,22,34,15,3,24,36,13,1,
            -1,27,10,25,29,12,8,19,31,18,6,21,33,16,4,23,35,14,2
    };

        Random random;

        public RouletteWheel(Random random)
        {
            this.random = random;
        }

        public int RandomSlot()
        {
            return random.Next(wheel.Length);
        }

        public static string SlotText(int slot)
        {
            if (wheel[slot] >= 0)
            {
                return wheel[slot].ToString();
            }
            else
            {
                return "00";
            }
        }

        public static Color SlotColor(int slot)
        {
            if (wheel[slot] > 0)
            {
                // Odd Numbers are red, even numbers are black
                return (wheel[slot] % 2 == 0) ? Color.Black : Color.Red;
            }
            else
            {
                // 0 and 00 are green
                return Color.Green;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RouletteWheel roulette = new RouletteWheel(new Random(2));

            for (int i = 0; i < 20; i++)
            {
                int slot = roulette.RandomSlot();
                Color color = RouletteWheel.SlotColor(slot);
                string text = RouletteWheel.SlotText(slot);
                Console.WriteLine("{0} {1}", text, color);
            }
        }
    }

}
