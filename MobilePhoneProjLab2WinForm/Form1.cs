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
            this.comboBoxFormat.SelectedIndex = 0;  //set default value for Format = "None"
        }

        private void InitializeComponentOutput(IOutput myOutputType)
        {
            vOutputType = myOutputType;

        }

        private void InitializeComponentMobile(Mobile mymobile)
        {
            vMyMobile = mymobile;
            vMyMobile.SMSProvider.SMSReceived += SMSProvider_SMSReceived;
            vSMSCounter = 0;
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
            this.vMyMobile.SMSProvider.DoSMSReceived($"Message #{vSMSCounter} is received.");
        }

        private void richTextSMSBox_TextChanged(object sender, EventArgs e)
        { }

        private void comboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var  selectedFormatItem = comboBoxFormat.SelectedItem;
        
            switch (selectedFormatItem.ToString())
            { case "None":  { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterNone; break; }
              case "Start with DateTime": { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterWithTime;  break; }
              case "End with DateTime": { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterWithTimeEnd;  break; }
              case "Uppercase": { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterUpper; break; }
              case "Lowercase": { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterLower;  break; }
              case "Short representation": { vMyMobile.SMSProvider.Formatter += SMSProvider_FormatterShort;  break; }

            }
            
        }
        private string SMSProvider_FormatterNone(string message)
        {
            return $"{message} {Environment.NewLine}";
        }

        private string SMSProvider_FormatterWithTime(string message)
        {
            return $"[{DateTime.Now}]: {message} {Environment.NewLine}";
        }

        private string SMSProvider_FormatterWithTimeEnd(string message)
        {
            return $"{message} [{DateTime.Now}] {Environment.NewLine}";
        }
        private string SMSProvider_FormatterUpper(string message)
        {
            return $"{message.ToUpper()} {Environment.NewLine}";
        }
        private string SMSProvider_FormatterLower(string message)
        { 
            return $"{message.ToLower() } {Environment.NewLine}";
        }
        private string SMSProvider_FormatterShort(string message)
        {
            string formattedStr = message.Substring(0, message.IndexOf(" is"));
            formattedStr+=".";
            return $"{formattedStr} {Environment.NewLine}";
        }

    }
}