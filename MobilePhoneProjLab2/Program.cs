using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Chargers;
using Headset;
using PhoneComponents;

namespace MobilePhoneProjLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayback headset = HeadsetFactory.GetHeadSet();
            ICharger charger = ChargerFactory.GetCharger();

            var mymobile = new SimCorpMobile(headset,charger);
            Console.WriteLine(mymobile);
            Console.ReadKey();

        }
    }
}
