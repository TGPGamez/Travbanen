using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travbanen.Lib.Interfaces;

namespace Travbanen.Lib
{
    public class Horse : INumberSIgn
    {
        public double Speed { get; private set; }

        private int number;
        public int Number { get => number; set => number = value; }

        private RaceColor raceColor;
        public RaceColor RaceColor { get => raceColor; set => raceColor = value; }

        public TimeSpan FinishTime { get; set; }

        public int GalopTimes { get; set; }

        public Horse(double speed, int number, RaceColor raceColor)
        {
            Speed = speed;
            Number = number;
            RaceColor = RaceColor;
            GalopTimes = 0;
        }

    }
}
