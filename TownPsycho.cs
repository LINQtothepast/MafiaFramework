using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class TownPsycho
    {
        private static string TownPsychoName;

        public static void TownPsychoRole(string name)
        {
            TownPsychoName = name;
        }
        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Town Psycho");
                Game.GameOngoing = false;

            }
        }
    }
}
