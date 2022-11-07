using SneakAttack.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakAttack.Models
{
    public class Player
    {
        public Player(Roles playerRole, string playername)
        {
            PlayerRole = playerRole;
            Playername = playername;
        }

        public string Playername { get; set; }
        public Roles PlayerRole { get; set; }
    }
}
