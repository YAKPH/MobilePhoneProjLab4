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

            int inputHS = ReadHeadSet(outputType);
            int inputChrg = ReadCharger(outputType);

            IPlayback headset = HeadsetFactory.GetHeadSet(outputType, inputHS);
            ICharger charger = ChargerFactory.GetCharger(inputChrg);

            var mymobile = new SimCorpMobile(headset, charger, outputType);
            Console.WriteLine(mymobile);
            Console.ReadKey();

        }

        private static int ReadCharger(ConsoleOutput output)
        {
            output.WriteLine("Choose type of Head set to use:");
            output.WriteLine($"1-{ HeadsetTypes.iPhone}");
            output.WriteLine($"2-{ HeadsetTypes.Samsung}");
            output.WriteLine($"3-{ HeadsetTypes.EarForceStealth}");        
            int inputType = ReadAndValidate();
            return inputType;
        }

        private static int ReadHeadSet(ConsoleOutput output)
        {
            output.WriteLine("Choose type of Charger to use:");
            output.WriteLine("1- Car Charger");
            output.WriteLine("2- Powerbank");
            output.WriteLine("3- Wall Charger");
            int inputType = ReadAndValidate();
            return inputType;
        }

        private static int ReadAndValidate()
        {
            string input;
            int inputType;

            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out inputType));

            return inputType;
        }
    }
}
