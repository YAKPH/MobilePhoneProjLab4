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
      
        
        public static IPlayback GetHeadSet()
        {
            IPlayback headset = null;

            Console.WriteLine("Choose type of Head set to use:");
            Console.WriteLine($"1-{ HeadsetTypes.iPhone}");
            Console.WriteLine($"2-{ HeadsetTypes.Samsung}");
            Console.WriteLine($"3-{ HeadsetTypes.EarForceStealth}");

            string input;
            int inputType;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out inputType));

            switch (inputType)
            {
                case 1: { headset = new iPhoneHeadset(); break; }
                case 2: { headset = new SamsungHeadset();  break; }
                case 3: { headset = new EarForceStealthHeadset(); break; }

            }
            return headset;

        }

    }
}
