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

            /*
            Output.WriteLine("");
            Output.WriteLine("PHONE DESCRIPTION:");
            
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Camera Parameters: {Camera.ToString()}");
            descriptionBuilder.AppendLine($"Sim Card: {Simcard.ToString()}");
            return descriptionBuilder.ToString();
            */
            return "";
        }
    }
}
