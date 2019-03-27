﻿using System;
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

        private void RaiseSMSReceivedEvent (string message)
        {
            SMSReceived?.Invoke(message);
            /*
            var handler = SMSReceived;
            if (handler != null) { handler(message); }
            */
        }
    }
}
