using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class RabbleRouser
    {
        private static string RabbleRouserName;

        public static void RabbleRouserRole(string name)
        {
            RabbleRouserName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("RabbleRouser");
                Game.GameOngoing = false;

            }
        }
    }
}
