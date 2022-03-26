using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s) { Message = s; }
        public String Message { get; set; }
    }

}
