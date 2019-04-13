using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary
{
    public class SMSProvider
    {
        
        public delegate void SMSReceivedDelegate(MyMessage message);
        public event SMSReceivedDelegate SMSReceived;

        public delegate string FormatDelegate(MyMessage message);
        public event FormatDelegate Formatter;


        public void DoSMSReceived(MyMessage message)
        {
            RaiseSMSReceivedEvent(message);
        }
        private void RaiseSMSReceivedEvent (MyMessage message)
        {
            //(SMSReceived as SMSReceivedDelegate)?.Invoke(message);
          
            SMSReceivedDelegate handler = SMSReceived as SMSReceivedDelegate;
            if (handler != null) { handler(message); }
        }

        public string DoFormat(MyMessage message)
        {
            return RaiseFormatEvent(message);
                                           
        }
        private string RaiseFormatEvent(MyMessage message)
        {   string retmsg = "";
            FormatDelegate handler = Formatter as FormatDelegate;
            if (handler != null) { retmsg=handler(message); }
            return retmsg;
        }


    }
}
