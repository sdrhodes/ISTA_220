using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{

    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine
                ("Which animal would you like to meet?");
            start:
            Console.WriteLine
                ("\r\n1. Pig\r\n2. Cow\r\n3. Horse\r\n4. Sheep\r\n5. Chicken");
            int userSelect = int.Parse(userInput = Console.ReadLine());
            if (userSelect >= 1 && userSelect <= 5)
            {
                switch (userSelect)
                {
                    case 1:
                        Animals animal1 = new Pig();
                        animalInfo(animal1);
                        break;
                    case 2:
                        Animals animal2 = new Cow();
                        animalInfo(animal2);
                         break;
                    case 3:
                        Animals animal3 = new Horse();
                        animalInfo(animal3);
                        break;
                    case 4:
                        Animals animal4 = new Sheep();
                        animalInfo(animal4);
                        break;
                    case 5:
                        Animals animal5 = new Chicken();
                        animalInfo(animal5);
                        break;
                }
            }
            else
            {
                Console.WriteLine
                    ("Please enter an integer between 1-5.");
                goto start;
            }

            string userInput1;
            Console.WriteLine
                ("Which crop would you like to explore?");
            Console.WriteLine
                ("1. Corn\r\n2. Soybeans\r\n3. Wheat");
            start1:
            int userSelect1 = int.Parse(userInput1 = Console.ReadLine());
            if (userSelect1 >= 1 && userSelect1 <= 3)
            {
                switch (userSelect1)
                {
                    case 1:
                        Crops crop1 = new Corn();
                        cropInfo(crop1);
                        break;
                    case 2:
                        Crops crop2 = new Soybean();
                        cropInfo(crop2);
                        break;
                    case 3:
                        Crops crop3 = new Wheat();
                        cropInfo(crop3);
                        break;

                }
            }
            else
            {
                Console.WriteLine
                    ("Please enter an integer between 1-3.");
                goto start1;
            }
            string userInput2;
            Console.WriteLine
                ("Would you like to visit more of the farm?");
            Console.WriteLine
                ("1. Yes\r\n2. No");
            start2:
            int userSelect2 = int.Parse(userInput2 = Console.ReadLine());
            if (userSelect2 >= 1 && userSelect2 <= 2)
            {
                switch (userSelect2)
                {
                    case 1:
                        goto start;
                    case 2:
                        return;
                }
            }
            else
            {
                Console.WriteLine
                    ("Please enter an integer between 1-2.");
                goto start2;
            }

            void animalInfo(Animals input)
            {
                var animal = input;
                Console.WriteLine
                    ("Your animal type is {0}\r\n" +
                    "Your animal's name is {1}\r\n" +
                    "Your animal's color is {2}\r\n" +
                    "Your animal says \"{3}\"",
                    animal.AnimalType, animal.AnimalName, 
                    animal.AnimalColor, animal.AnimalNoise);
                Console.ReadLine();
            }
            void cropInfo(Crops input)
            {
                var crop = input;
                Console.WriteLine
                    ("Your crop type is {0}\r\n" +
                    "Your crop's purpose is {1}\r\n" +
                    "Your crop's color is {2}\r\n", 
                    crop.CropType, crop.CropPurpose,
                    crop.CropColor);
                Console.ReadLine();
            }
        }
        
        /*
        public Animals animal1 = new Pig();

        static void Main(string[] args)
        {
            
        }

        private static void getAnimalInfo()
        {
            Console.WriteLine(animal1.AnimalColor);
        }

        
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            } 
        
        private static void createFarm()
        {
            createAnimals();
            createPlants();
            createBuildings();
        }

        private static void createBuildings()
        {
            throw new NotImplementedException();
        }

        private static void createPlants()
        {
            throw new NotImplementedException();
        }

        private static void createAnimals()
        {
            throw new NotImplementedException();
        }   */
    }
}

                

       

       
    

    



