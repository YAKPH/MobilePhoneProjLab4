using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneComponents
{
    public class BatteryBase
    {
        public int vBatteryCapacityMAh { get; }
        private BatteryTypes vBatteryType;
        public enum BatteryTypes { LithiumPolBattery, LithiumIonBattery, NickelCadmiumBattery };

        public BatteryBase(BatteryTypes batteryType, int batteryCapacityMAh)
        {
            vBatteryType = batteryType;
            vBatteryCapacityMAh = batteryCapacityMAh;
        }


        public override string ToString()
        {       
            string message = $"Type {vBatteryType.ToString()}";
            return message;
        }
    }
}
