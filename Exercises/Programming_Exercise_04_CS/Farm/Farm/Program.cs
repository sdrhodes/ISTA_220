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
            Console.WriteLine
                ("1. Pig\r\n2. Cow\r\n3. Horse\r\n4. Sheep\r\n5. Chicken");
            start:
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

                

       

       
    

    



