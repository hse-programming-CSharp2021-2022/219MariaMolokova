using System;

namespace Task_06
{
    class Program
    {
        // Сори что без нормальных названий локаций, я не читала и не смотрела :(
        static void Main()
        {
            Wizard wizard = new("Гендальф", "Локация 1");
            Creature[] creatures =
            {
                new Human("Боромир", "Локация 2"),
                new Human("Арагорн", "Локация 3"),
                new Dwarf("Гимли", "Локация 4"),
                new Elf("Леголас", "Локация 5"),
                new Hobbit("Фродо", "Локация 6")
            };
            foreach (var creature in creatures)
            {
                wizard.RaiseRingIsFoundEvent += creature.RingIsFoundEventHandle;
            }
            wizard.SomeThisIsChangedInTheAir();
        }
    }

}
