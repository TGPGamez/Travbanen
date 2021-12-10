using System;
using Travbanen.Lib;
using Travbanen.Lib.RaceRelated;

namespace Travbanen
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race("SprinterDistance", 1600);

            Ekvipage cont1 = new Ekvipage(new Kusk("Tobias"), new Horse(new Random().Next(50, 65), 1, race.Color));
            Ekvipage cont2 = new Ekvipage(new Kusk("Tobias2"), new Horse(new Random().Next(50, 65), 2, race.Color));
            Ekvipage cont3 = new Ekvipage(new Kusk("Tobias3"), new Horse(new Random().Next(50, 65), 3, race.Color));

            race.AddContestant(cont1);
            race.AddContestant(cont2);
            race.AddContestant(cont3);

            Console.WriteLine(race.Type);
            Console.WriteLine(race.Distance);
            Console.WriteLine(race.Color);
            foreach (Ekvipage ekvipage in race.Contestants)
            {
                Console.WriteLine();
                Console.WriteLine(ekvipage.Kusk.Name);
                Console.WriteLine(ekvipage.Horse.Speed);
            }
        }
    }
}
