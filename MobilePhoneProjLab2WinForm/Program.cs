using Chargers;
using Common;
using Headset;
using Output;
using PhoneComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneProjLab2WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IOutput myOutputType = new WinFormOutput();
            Mobile mymobile =InstantiateSimCorpMobile(myOutputType);

            Application.Run(new FormMessageFiltering(myOutputType,mymobile));

        }

        private static Mobile InstantiateSimCorpMobile(IOutput myOutputType)
        {
            Mobile mobile=null;

            ICharger Charger = ChargerFactory.GetCharger(ChargerTypes.Powerbk);
            IPlayback Headset = HeadsetFactory.GetHeadSet(myOutputType, HeadsetTypes.iPhone);
            if (Charger != null)
                if (Headset != null)
                {
                    mobile = new SimCorpMobile(Headset, Charger, myOutputType);

                }
            return mobile;
        }
    }
}
