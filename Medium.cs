using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class Medium
    {
        private static string MediumName;

        public static void MediumRole(string name)
        {
            MediumName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Medium");
                Game.GameOngoing = false;

            }
        }
    }
}
