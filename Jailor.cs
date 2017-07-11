using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class Jailor
    {
        public static string JailorName;

        public static void JailorRole(string name)
        {
            JailorName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Jailor");
                Game.GameOngoing = false;

            }
        }
    }
}
