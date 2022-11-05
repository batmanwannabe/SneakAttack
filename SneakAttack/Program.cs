using SneakAttack.Enums;
using SneakAttack.Models;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Iteration 1
        Console.WriteLine("No of players: ");
        var n = Convert.ToInt32(Console.ReadLine());

        List<Player> playerList = new List<Player>();
        bool killerCreated = false;

        Random rnd = new Random();

        for (var i = 0; i < n; i++)
        {
            Roles randomRole = RandomRole(killerCreated, rnd);
            if(randomRole == Roles.Killer)  killerCreated = true;

            var role = new Role(randomRole);
            var player = new Player(role);

            playerList.Add(player);

            Console.WriteLine(player.PlayerRole.RoleName.ToString());
        }


    }

    private static Roles RandomRole(bool isKillerCreated, Random random)
    {
        Array values = Enum.GetValues(typeof(Roles));
        if (isKillerCreated)
        {
            Roles randomRole = (Roles)values.GetValue(random.Next(values.Length));
            while (randomRole == Roles.Killer)
            {
                randomRole = (Roles)values.GetValue(random.Next(values.Length));
            }
            
            return randomRole;
        }
        else
        {
            return (Roles)values.GetValue(random.Next(values.Length));
        }
    }
}