using Common;
using Headset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneComponents   
{
    public abstract class Mobile
    {

        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }
        public abstract Camera Camera { get; }
        public abstract SimcardBase Simcard { get; }

        public abstract IPlayback Headset { get; }
        public abstract ICharger Charger { get; }
        public abstract IOutput Output { get; }

        public override string ToString()
        {
            Headset.Play();

            double time = Charger.CalculateChargingTime(Battery.vBatteryCapacityMAh);
            Output.WriteLine($"Charging time for this battery and charger is {time} hours.");

            string phoneParams;
            phoneParams = "OTHER PHONE DESCRIPTION:\n";
            phoneParams += $"Screen Type: { Screen.ToString()}\n";
            phoneParams += $"Battery Type: {Battery.ToString()}\n";
            phoneParams += $"Camera Parameters: {Camera.ToString()}\n";
            phoneParams += $"Sim Card: {Simcard.ToString()}\n";
            Output.WriteLine(phoneParams);
           
            return "";
        }
    }
}
