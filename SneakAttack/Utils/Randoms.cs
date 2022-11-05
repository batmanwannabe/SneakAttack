using SneakAttack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakAttack.Utils
{
    public static class Randoms
    {
        public static int RandomPlayer(IEnumerable<Player> players)
        {
            var rnd = new Random();
            return rnd.Next(players.Count());
            //return players.ElementAt(randomPlayerIndex);
        }
    }
}
