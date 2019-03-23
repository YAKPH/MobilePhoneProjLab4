using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Chargers;
using Headset;
using PhoneComponents;
using Output;
using static Headset.HeadsetFactory;

namespace MobilePhoneProjLab2
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleOutput outputType = new ConsoleOutput();

            HeadsetTypes inputHSType = ReadHeadSet(outputType);
            ChargerTypes inputChrgType = ReadCharger(outputType);

            IPlayback headset = HeadsetFactory.GetHeadSet(outputType, inputHSType);
            ICharger charger = ChargerFactory.GetCharger(inputChrgType);

            var mymobile = new SimCorpMobile(headset, charger, outputType);
            Console.WriteLine(mymobile);
            Console.ReadKey();

        }

        private static ChargerTypes ReadCharger(ConsoleOutput output)
        {
            output.WriteLine("Choose type of Head set to use:");
            output.WriteLine($"1-{ HeadsetTypes.iPhone}");
            output.WriteLine($"2-{ HeadsetTypes.Samsung}");
            output.WriteLine($"3-{ HeadsetTypes.EarForceStealth}");
            ChargerTypes chrgInputType = ReadAndValidateChrg();
            return chrgInputType;
        }

        private static HeadsetTypes ReadHeadSet(ConsoleOutput output)
        {
            output.WriteLine("Choose type of Charger to use:");
            output.WriteLine("1- Car Charger");
            output.WriteLine("2- Powerbank");
            output.WriteLine("3- Wall Charger");
            HeadsetTypes hsInputType = ReadAndValidateHS();
            return hsInputType;
        }

        private static ChargerTypes ReadAndValidateChrg()
        {
            string input;
            int inputType;
            ChargerTypes chrgInpType = ChargerTypes.Car;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out inputType));

            if (inputType == 1) chrgInpType=ChargerTypes.Car;
            else if (inputType == 2) chrgInpType=ChargerTypes.Powerbk;
            else if (inputType == 3) chrgInpType=ChargerTypes.Wall;

            return chrgInpType;
        }
        private static HeadsetTypes ReadAndValidateHS()
        {
            string input;
            int inputType;
            HeadsetTypes hsInpType = HeadsetTypes.iPhone;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out inputType));

            if (inputType == 1) hsInpType = HeadsetTypes.iPhone;
            else if (inputType == 2) hsInpType = HeadsetTypes.Samsung;
            else if (inputType == 3) hsInpType = HeadsetTypes.EarForceStealth;

            return hsInpType;
        }
    }
}
