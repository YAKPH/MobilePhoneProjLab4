using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLibrary
{
    public class MyMessage
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Text { get; set; }
        public string PhoneNo { get; set; }
        public DateTime ReceivingTime { get; set; }

        public void ChangeTextTo(string newtxt)
        {
            this.Text = newtxt;
        }

    }
}
