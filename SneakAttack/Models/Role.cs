using SneakAttack.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakAttack.Models
{
    public class Role
    {
        public Role(Roles role)
        {
            RoleName = role;
        }

        public Roles RoleName { get; set; }
    }
}
