using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class Consigliere
    {
        public static string ConsigliereName;

        public static void ConsigliereRole(string name)
        {
            ConsigliereName = name;
        }
        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Consigliere");
                Game.GameOngoing = false;

            }
        }
    }
}
