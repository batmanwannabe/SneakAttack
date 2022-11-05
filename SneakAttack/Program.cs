using SneakAttack.Enums;
using SneakAttack.Models;
using SneakAttack.Utils;
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

        for (var i = 1; i <= n; i++)
        {
            Roles randomRole = RandomRole(killerCreated, rnd);
            if(randomRole == Roles.Killer)  killerCreated = true;

            var role = new Role(randomRole);
            var player = new Player(role, "P"+i.ToString());

            playerList.Add(player);

            Logger.PlayerLog(player);
        }

        PlayRounds(playerList);


    }

    private static void PlayRounds(List<Player> players)
    {
        int rounds = players.Count - 1;
        var killer = players.Where(x => x.PlayerRole.RoleName == Roles.Killer).FirstOrDefault();
        var playersAfterKill = players;

        for (int i = 1; i < rounds + 1; i++)
        {
            var round = new Round(i, playersAfterKill.Where(x => x.PlayerRole.RoleName != Roles.Killer), killer);
            playersAfterKill = round.PlayRound();
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