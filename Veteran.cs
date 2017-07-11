using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class Veteran
    {
        private static string VeteranName;

        public static void VeteranRole(string name)
        {
            VeteranName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Veteran");
                Game.GameOngoing = false;

            }
        }
    }
}
