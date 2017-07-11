using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class VillageIdiot
    {
        private static string VillageIdiotName;

        public static void VillageIdiotRole(string name)
        {
            VillageIdiotName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Village Idiot");
                Game.GameOngoing = false;

            }
        }
    }
}
