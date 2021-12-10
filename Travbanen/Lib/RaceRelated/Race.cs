using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travbanen.Lib.RaceRelated
{
    public class Race
    {
        public string Type { get; private set; }
        public RaceColor Color { get; private set; }
        public double Distance { get; private set; }

        public List<Ekvipage> Contestants { get; private set; }
        
        private Stopwatch time;

        public Race(string raceType, double distance)
        {
            Type = raceType;
            Contestants = new List<Ekvipage>();
            Distance = distance;
            Color = GenerateRandomColor();
        }

        private RaceColor GenerateRandomColor()
        {
            Array colors = Enum.GetValues(typeof(RaceColor));
            Random random = new Random();
            return (RaceColor)colors.GetValue(random.Next(colors.Length));
        }

        /// <summary>
        /// Add a contestant
        /// This could also have been GetConstants out from color if a manager was added which holded all contestants
        /// </summary>
        /// <param name="ekvipage"></param>
        public void AddContestant(Ekvipage ekvipage)
        {
            Contestants.Add(ekvipage);
        }

        /// <summary>
        /// Starts the race
        /// </summary>
        public void Start()
        {
            time.Start();
            foreach (Ekvipage ekvipage in Contestants)
            {
                
            }
        }
    }
}
