using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headset
{
    public enum HeadsetTypes { iPhone, Samsung, EarForceStealth };

    public class HeadsetFactory
    {
    
        public static IPlayback GetHeadSet(IOutput outputType, HeadsetTypes hsType)
        {
           IPlayback headset = null;

           switch (hsType)
            {
                case HeadsetTypes.iPhone: { headset = new iPhoneHeadset(outputType); break; }
                case HeadsetTypes.Samsung: { headset = new SamsungHeadset(outputType);  break; }
                case HeadsetTypes.EarForceStealth: { headset = new EarForceStealthHeadset(outputType); break; }

            }
            return headset;

        }

    }
}
