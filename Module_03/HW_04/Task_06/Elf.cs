using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    public class Elf : Creature
    {
        public override string Name { get; set; }
        public override string Location { get; set; }
        public Elf(string name, string location) { Name = name; Location = location; }
        public override void RingIsFoundEventHandle(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Я был в {Location}. Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
            Location = e.Message;
        }
    }

}
