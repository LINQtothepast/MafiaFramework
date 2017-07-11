using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class Vigilante
    {
        private static string VigilanteName;

        public static void VigilanteRole(string name)
        {
            VigilanteName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Vigilante");
                Game.GameOngoing = false;

            }
        }
    }
}
