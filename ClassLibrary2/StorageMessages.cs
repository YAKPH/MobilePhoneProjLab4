using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary
{
    public class StorageMessages
    {
        private List<MyMessage> vListMessages;
        public List<MyMessage> ListMessages { get { return vListMessages; } set { vListMessages = value; } }

        public  void Add(MyMessage message)
        { ListMessages.Add(message);  }

        public void Remove(MyMessage message)
        { ListMessages.Remove(message); }
    }
}
