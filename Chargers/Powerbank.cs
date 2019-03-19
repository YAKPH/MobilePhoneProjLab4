using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargers
{
    public class Powerbank:ICharger
    {
        public double CalculateChargingTime(int batteryCapacityMAh)
        {
            double hours = 0;
            hours = batteryCapacityMAh / (double)10000;
            return hours;
        }
    }
}
