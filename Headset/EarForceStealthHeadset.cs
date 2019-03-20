using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headset
{
    class EarForceStealthHeadset : IPlayback
    {
        private IOutput vOutput;

        public EarForceStealthHeadset(IOutput output)
        {
            vOutput = output;
        }
        public void Play()
        {
            vOutput.WriteLine($"Playing {nameof(EarForceStealthHeadset)} sound");
        }
    }
}
