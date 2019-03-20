using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Chargers;
using Headset;
using PhoneComponents;
using Output;

namespace MobilePhoneProjLab2
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleOutput output = new ConsoleOutput();
            IPlayback headset = HeadsetFactory.GetHeadSet(output);
            ICharger charger = ChargerFactory.GetCharger(output);

            var mymobile = new SimCorpMobile(headset,charger,output);
            Console.WriteLine(mymobile);
            Console.ReadKey();

        }
    }
}
