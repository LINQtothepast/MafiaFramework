using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class ConArtist
    {
        public static string ConArtistName;

        public static void ConArtistRole(string name)
        {
            ConArtistName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("ConArtist");
                Game.GameOngoing = false;

            }
        }
    }
}
