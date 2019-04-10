using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary
{
    public class SMSProvider
    {
        
        public delegate void SMSReceivedDelegate(string message);
        public event SMSReceivedDelegate SMSReceived;

        public delegate string FormatDelegate(string message);
        public event FormatDelegate Formatter;


        public void DoSMSReceived(string message)
        {
            RaiseSMSReceivedEvent(message);
        }
        private void RaiseSMSReceivedEvent (string message)
        {
            //(SMSReceived as SMSReceivedDelegate)?.Invoke(message);
          
            SMSReceivedDelegate handler = SMSReceived as SMSReceivedDelegate;
            if (handler != null) { handler(message); }
        }

        public string DoFormat(string message)
        {
            return RaiseFormatEvent(message);
                                           
        }
        private string RaiseFormatEvent(string message)
        {   string str = "";
            FormatDelegate handler = Formatter as FormatDelegate;
            if (handler != null) { str=handler(message); }
            return str;
        }


    }
}
