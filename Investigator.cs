using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class Investigator
    {
        public static string InvestigatorName;

        public static void InvestigatorRole(string name)
        {
            InvestigatorName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Investigator");
                Game.GameOngoing = false;

            }
        }
    }
}
