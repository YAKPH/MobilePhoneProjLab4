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
        private IPlayback vSpecHeadSet;
        public enum HeadsetTypes { iPhone, Samsung, EarForceStealth };

        public HeadsetFactory(HeadsetTypes headsetType)
        {
            vSpecHeadSet = GetHeadSet(headsetType);
        }          
        
        public IPlayback GetHeadSet(HeadsetTypes headsetType)
        {
            IPlayback headset = null;

            switch (headsetType)
            {
                case HeadsetTypes.iPhone: { headset = new iPhoneHeadset(); break; }
                case HeadsetTypes.Samsung: { headset = new SamsungHeadset();  break; }
                case HeadsetTypes.EarForceStealth: { headset = new EarForceStealthHeadset(); break; }

            }
            return headset;

        }

        public override string ToString()
        {   
            this.vSpecHeadSet.Play(this);
            return "";
        }
    }
}
