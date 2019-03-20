using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headset
{
    public class HeadsetFactory
    {
        public enum HeadsetTypes { iPhone, Samsung, EarForceStealth };

        public static IPlayback GetHeadSet(IOutput output)
        {
            IPlayback headset = null;

            output.WriteLine("Choose type of Head set to use:");
            output.WriteLine($"1-{ HeadsetTypes.iPhone}");
            output.WriteLine($"2-{ HeadsetTypes.Samsung}");
            output.WriteLine($"3-{ HeadsetTypes.EarForceStealth}");

            string input;
            int inputType;

            do
            {
                input = Console.ReadLine(); //!!!!!!!!!!!!!!!!!!
            } while (!Int32.TryParse(input, out inputType));

            switch (inputType)
            {
                case 1: { headset = new iPhoneHeadset(output); break; }
                case 2: { headset = new SamsungHeadset(output);  break; }
                case 3: { headset = new EarForceStealthHeadset(output); break; }

            }
            return headset;

        }

    }
}
