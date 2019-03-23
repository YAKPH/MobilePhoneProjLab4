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

        public static ICharger GetCharger(int inputType)
        {
            ICharger charger = null;
            
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
