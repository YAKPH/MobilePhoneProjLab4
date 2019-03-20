using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headset
{
    class iPhoneHeadset : IPlayback
    {
        private IOutput vOutput;

        public iPhoneHeadset(IOutput output)
        {
            vOutput = output;
        }

        public void Play()
        {
            vOutput.WriteLine($"Playing {nameof(iPhoneHeadset)} sound");
        }
    }
}
