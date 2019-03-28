using Chargers;
using Common;
using Headset;
using PhoneComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Headset.HeadsetFactory;

namespace MobilePhoneProjLab2WinForm
{
    public partial class Form1 : Form
    {
        private IOutput vOutputType;
        private Mobile vMyMobile;
        private int vSMSCounter;


        public Form1(IOutput myOutputType, Mobile mymobile)
        {    
            InitializeComponent();
            InitializeComponentOutput(myOutputType);
            InitializeComponentMobile(mymobile);
        }

        private void InitializeComponentOutput(IOutput myOutputType)
        {
            vOutputType = myOutputType;

        }

        private void InitializeComponentMobile(Mobile mymobile)
        {
            vMyMobile = mymobile;
            vMyMobile.SMSProvider.SMSReceived += SMSProvider_SMSReceived;
            vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterWithTime;
            vSMSCounter = 0;
        }

        private string SMSProvider_FormatterWithTime(string message)
        {
            return $"[{DateTime.Now}]: {message} {Environment.NewLine}";
        }

        private void SMSProvider_SMSReceived(string message)
        {
            //Show message
            message = this.vMyMobile.SMSProvider.DoFormat(message);
            this.richTextSMSBox.AppendText(message);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            vSMSCounter += 1;
            this.vMyMobile.SMSProvider.DoSMSReceived($"message #{vSMSCounter} is received.");
        }

        private void richTextSMSBox_TextChanged(object sender, EventArgs e)
        { }

    }
}
