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

        public static IPlayback GetHeadSet(IOutput outputType,int inputType)
        {
           IPlayback headset = null;

           switch (inputType)
            {
                case 1: { headset = new iPhoneHeadset(outputType); break; }
                case 2: { headset = new SamsungHeadset(outputType);  break; }
                case 3: { headset = new EarForceStealthHeadset(outputType); break; }

            }
            return headset;

        }

    }
}
