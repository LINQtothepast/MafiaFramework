using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class TownWatch
    {
        private static string TownWatchName;

        public static void TownWatchRole(string name)
        {
            TownWatchName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Town Watch");
                Game.GameOngoing = false;

            }
        }
    }
}
