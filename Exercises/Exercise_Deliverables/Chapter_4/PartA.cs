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
            try
            {
                createFarm();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
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
        }
    }
}

                

       

       
    

    



