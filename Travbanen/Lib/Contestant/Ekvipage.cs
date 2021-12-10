using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travbanen.Lib
{
    public class Ekvipage
    {
        public Kusk Kusk { get; private set; }
        public Horse Horse { get; private set; }

        private double currentDistance;

        public Ekvipage(Kusk kusk, Horse horse)
        {
            Kusk = kusk;
            Horse = horse;
        }

        public void Trav()
        {
            if (new Random().Next(0, 100) <= 5)
            {
                Horse.GalopTimes++;
                if (Horse.GalopTimes >= 2)
                {
                    //Disqualify
                }
            }
        }
    }
}
