using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            selectInspection:
            Console.WriteLine("Arms inspection at 0630!\r\n" +
                "General, which troops would you like to inspect?\r\n" +
                "1:: Personnelists\r\n" +
                "2:: Infantry\r\n" +
                "3:: Calvary");
            int inspectionChoice = int.Parse(Console.ReadLine());
            switch (inspectionChoice)
            {
                case 1:
                    Personnelist personnelist = new Personnelist();
                    personnelist.PresentForInspection();
                    break;
                case 2:
                    Infantryman infantryman = new Infantryman();
                    infantryman.PresentForInspection();
                    break;
                case 3:
                    Tanker tanker = new Tanker();
                    tanker.PresentForInspection();
                    break;
                default:
                    break;
            }
            Console.WriteLine("\r\nWould you like to inspect other troops? Y/N");
            string restartInspection = Console.ReadLine();
            switch (restartInspection)
            {
                case "y":
                    goto selectInspection;
                case "Y":
                    goto selectInspection;
                case "n":
                    break;
                case "N":
                    break;
                default:
                    break;
            }

            selectMission:
            Console.WriteLine("\r\nWhat is the mission, General?\r\n" +
                "1:: Give orders to personnel\r\n" +
                "2:: Give orders to the infantry\r\n" +
                "3:: give orders to the calvary.");
            int missionChoice = int.Parse(Console.ReadLine());

            switch (missionChoice)
            {
                case 1:
                    Personnelist personnelist = new Personnelist();
                    personnelist.PerformMission(personnelist.ToString());
                    break;

                case 2:
                    Infantryman infantryman = new Infantryman();
                    infantryman.PerformMission(infantryman.ToString());
                    break;

                case 3:
                    Tanker tanker = new Tanker();
                    tanker.PerformMission(tanker.ToString());
                    break;

                default:
                    break;
            }
            Console.WriteLine("\r\nThe mission was a success.\r\n\r\n" +
                "Would you like to perform another mission? Y/N");
            string restartMission = Console.ReadLine();
            switch (restartMission)
            {
                case "y":
                    goto selectMission;
                case "Y":
                    goto selectMission;
                case "n":
                    break;
                case "N":
                    break;
                default:
                    break;
            }

            Console.WriteLine("\r\nLet's meet some troops.");
            Infantryman fng = new Infantryman();
            fng.GetInfo();

            Console.WriteLine("The troops earned R&R. Dismissed");
            fng.Eat();
            fng.Sleep();
        }
    }
}
