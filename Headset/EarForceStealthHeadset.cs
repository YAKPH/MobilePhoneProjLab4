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
        public void Play()
        {
            Console.WriteLine($"Playing {nameof(EarForceStealthHeadset)} sound");
        }
    }
}
