using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargers
{
    public class ChargerFactory
    {

        public static ICharger GetCharger()
        {
            ICharger charger = null;

            Console.WriteLine("Choose type of Charger to use:");
            Console.WriteLine("1- Car Charger");
            Console.WriteLine("2- Powerbank");
            Console.WriteLine("3- Wall Charger");

            string input;
            int inputType;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out inputType));        

            switch (inputType)
            {
                case 1: { charger = new CarCharger(); break; }
                case 2: { charger = new Powerbank(); break; }
                case 3: { charger = new WallCharger(); break; }

            }
            return charger;
        }
    }
}
