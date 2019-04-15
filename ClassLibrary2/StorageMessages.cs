using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary
{
    public class StorageMessages
    {
        private int vMyCapacity;
        private List<MyMessage> vListMessages;
        public List<MyMessage> ListMessages { get { return vListMessages; } set { vListMessages = value; } }
        public int MyCapacity { get { return vMyCapacity; } set { vMyCapacity = value; } }

        public  void Add(MyMessage message)
        {
            int availableCap=MyCapacity - ListMessages.Count();
            if (availableCap==0)
              { ListMessages.RemoveAt(0);} //remove the oldes one

            ListMessages.Add(message);
        }

        public void Remove(MyMessage message)
        { ListMessages.Remove(message); }
    }
}
