using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    public class Wizard : Creature
    {
        public override string Name { get; set; }
        public override string Location { get; set; }
        public override void RingIsFoundEventHandle(object sender, RingIsFoundEventArgs e) { }

        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);
        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public Wizard(string name, string location) { Name = name; Location = location; }
        public Wizard() { }
        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Я был в {Location}. Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл и сам туда направляюсь! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
            Location = "Ривендейл";
        }
    }

}
