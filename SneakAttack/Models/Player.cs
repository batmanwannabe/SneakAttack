using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakAttack.Models
{
    public class Player
    {
        public Player(Role playerRole)
        {
            PlayerRole = playerRole;
        }

        public Role PlayerRole { get; set; }
    }
}
