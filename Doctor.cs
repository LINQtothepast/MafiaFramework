using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    class Doctor
    {
        public static string DoctorName;

        public static void DoctorRole(string name)
        {
            DoctorName = name;
        }

        public static void SwitchTo()
        {
            while (Game.GameOngoing == true)
            {
                Console.WriteLine("Doctor");
                Game.GameOngoing = false;

            }
        }
    }
}
