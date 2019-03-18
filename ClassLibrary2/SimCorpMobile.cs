using Headset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Headset.HeadsetFactory;

namespace PhoneComponents   
{
    public class SimCorpMobile : Mobile
    {
        private readonly ScreenBase vScreen;
        private readonly BatteryBase vBattery;
        private readonly SimcardBase vSimcard;
        private readonly Camera vCamera;
        private readonly HeadsetFactory vHeadSet;

        public override ScreenBase Screen { get { return vScreen; } }
        public override BatteryBase Battery { get { return vBattery; } }
        public override SimcardBase Simcard { get { return vSimcard; } }
        public override Camera Camera { get { return vCamera; } }
        public override HeadsetFactory Headset { get { return vHeadSet; } }

        public SimCorpMobile()
        {
            var type = BatteryBase.BatteryTypes.LithiumIonBattery;
            int capacityMAh = 2200;
            vBattery = new BatteryBase(type, capacityMAh);

            string number = "+380959992299";
            var format = SimcardBase.SimFormats.Nano;
            vSimcard = new SimcardBase(number, format);

            HeadsetTypes userHeadSettype = SelectHeadsetType();
            vHeadSet = new HeadsetFactory(userHeadSettype);
            

            vCamera = new Camera
            {
                MegaPixels = 2000,
                IndivPixelSize = 1000,
                LensType = Camera.LensTypes.Dual,
                ZoomType = Camera.ZoomTypes.Optical
            };
            vScreen = new ScreenBase
            {
                HorizontalPixels = 640,
                VerticalPixels = 960,
                Diagonal = 3.5,
                ScreenType = ScreenBase.ScreenTypes.LCD
            };
        }

        private HeadsetTypes SelectHeadsetType()
        {
            HeadsetTypes type; 

            Console.WriteLine("Choose type of Head set to use:");
            Console.WriteLine($"1-{ HeadsetTypes.EarForceStealth}");
            Console.WriteLine($"2-{ HeadsetTypes.iPhone}");
            Console.WriteLine($"3-{ HeadsetTypes.Samsung}");

            string input;
            int inputType;

            do
            {input = Console.ReadLine();
            } while (!Int32.TryParse(input, out inputType));

            switch (inputType)
            {
                case 1: {type = HeadsetTypes.EarForceStealth; break; }
                case 2: {type = HeadsetTypes.iPhone; break; }
                case 3: {type = HeadsetTypes.Samsung; break; }
                default:
                    { type = HeadsetTypes.Samsung; break; }

            }

            return type;
        }
    }
}
