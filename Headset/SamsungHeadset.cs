using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headset
{
    public class SamsungHeadset : IPlayback
    {
        private IOutput vOutput;

        public SamsungHeadset(IOutput output)
        {
            vOutput = output;
        }
        public void Play()
        {
            vOutput.WriteLine($"Playing {nameof(SamsungHeadset)} sound");
        }
    }
}
