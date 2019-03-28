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

        public void DoSMSReceived(string message)
        {
            for (int i = 0; i < 10; i++)
            {
                RaiseSMSReceivedEvent(message+(i+1)+"\n");
            }
           
        }
        private void RaiseSMSReceivedEvent (string message)
        {
            //(SMSReceived as SMSReceivedDelegate)?.Invoke(message);
          
            SMSReceivedDelegate handler = SMSReceived as SMSReceivedDelegate;
            if (handler != null) { handler(message); }
           
        }

    }
}
