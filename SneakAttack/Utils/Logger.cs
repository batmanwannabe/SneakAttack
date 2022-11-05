using SneakAttack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakAttack.Utils
{
    public static class Logger
    {
        public static void PlayerLog(Player player)
        {
            Console.WriteLine(player.Playername.ToString()+ " " + player.PlayerRole.RoleName.ToString());
        }

        public static void KillLog(int roundId, string killerName, string playerName)
        {
            Console.WriteLine("Round {0}", roundId + 1);
            Console.WriteLine(killerName + " Killed " + playerName);
        }
    }
}
