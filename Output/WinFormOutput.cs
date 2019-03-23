using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Output
{
    public class WinFormOutput : IOutput
    {
        public void WriteLine(string text)
        { 
           MessageBox.Show(text);
        }
    }
}
