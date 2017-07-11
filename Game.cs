using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaForConsole
{
    public class Game
    {
        private static List<User> UserList = new List<User>();
        public static bool GameOngoing = true;

        public static void SetUsersForGame()
        {
            UserList = UserCollection.ReturnPlayerList();
        }

        public static void GameStart(string currentUser)
        {
            foreach (var element in UserList)
            {
                if (element.UserName == currentUser)
                {
                    Sheriff.SheriffRole(element.UserName);
                    Sheriff.SwitchTo();
                    /*
                    switch (element.UserRole)
                    {
                        case 1:
                            Sheriff.SheriffRole(element.UserName);
                            Sheriff.SwitchTo();
                            break;
                        case 2:
                            Doctor.DoctorRole(element.UserName);
                            Doctor.SwitchTo();
                            break;
                        case 3:
                            Investigator.InvestigatorRole(element.UserName);
                            Investigator.SwitchTo();
                            break;
                        case 4:
                            Jailor.JailorRole(element.UserName);
                            Jailor.SwitchTo();
                            break;
                        case 5:
                            Medium.MediumRole(element.UserName);
                            Medium.SwitchTo();
                            break;
                        case 6:
                            Godfather.GodfatherRole(element.UserName);
                            Godfather.SwitchTo();
                            break;
                        case 7:
                            ConArtist.ConArtistRole(element.UserName);
                            ConArtist.SwitchTo();
                            break;
                        case 8:
                            Consigliere.ConsigliereRole(element.UserName);
                            Consigliere.SwitchTo();
                            break;
                        case 9:
                            RabbleRouser.RabbleRouserRole(element.UserName);
                            RabbleRouser.SwitchTo();
                            break;
                        case 10:
                            VillageIdiot.VillageIdiotRole(element.UserName);
                            VillageIdiot.SwitchTo();
                            break;
                        case 11:
                            Bard.BardRole(element.UserName);
                            Doctor.SwitchTo();
                            break;
                        case 12:
                            TownPsycho.TownPsychoRole(element.UserName);
                            TownPsycho.SwitchTo();
                            break;
                        case 13:
                            Veteran.VeteranRole(element.UserName);
                            Veteran.SwitchTo();
                            break;
                        case 14:
                            Vigilante.VigilanteRole(element.UserName);
                            Vigilante.SwitchTo();
                            break;
                        case 15:
                            TownWatch.TownWatchRole(element.UserName);
                            TownWatch.SwitchTo();
                            break;
                    }*/
                }                              
            }
        }
    }
}
