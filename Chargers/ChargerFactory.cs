using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargers
{
    public enum ChargerTypes { Car, Powerbk, Wall };

    public class ChargerFactory
    {
       
        public static ICharger GetCharger(ChargerTypes chargerType)
        {
            ICharger charger = null;
            
            switch (chargerType)
            {
                case ChargerTypes.Car : { charger = new CarCharger(); break; }
                case ChargerTypes.Powerbk: { charger = new Powerbank(); break; }
                case ChargerTypes.Wall: { charger = new WallCharger(); break; }

            }
            return charger;
        }
    }
}
