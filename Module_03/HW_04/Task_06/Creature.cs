using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    public abstract class Creature
    {
        public abstract string Name { get; set; }
        public abstract string Location { get; set; }
        public abstract void RingIsFoundEventHandle(object sender, RingIsFoundEventArgs e);
    }
}
