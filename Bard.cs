using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class Bard
    {
        public static string BardName;

        public static void BardRole(string name)
        {
            BardName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Bard");
                Game.GameOngoing = false;

            }
        }
    }
}
