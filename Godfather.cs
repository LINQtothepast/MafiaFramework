using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class Godfather
    {
        public static string GodfatherName;

        public static void GodfatherRole(string name)
        {
            GodfatherName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Godfather");
                Game.GameOngoing = false;

            }
        }
    }
}
