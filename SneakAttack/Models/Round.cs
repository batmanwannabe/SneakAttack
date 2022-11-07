using SneakAttack.Utils;

namespace SneakAttack.Models
{
    public class Round
    {
        public Round(int roundNumber, IEnumerable<Player> players, Player killer)
        {
            RoundNumber = roundNumber;
            Players = players;
            Killer = killer;
        }

        public int RoundNumber { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public Player Killer { get; set; }

        public List<Player> PlayRound()
        {
            List<Player> playersAfterKill = KillByKiller();

            return playersAfterKill;
        }

        private List<Player> KillByKiller()
        {
            var playerToKillIndex = Randoms.RandomPlayer(Players);
            var playerToKill = Players.ElementAt(playerToKillIndex);

            Logger.KillLog(RoundNumber, Killer.Playername, playerToKill.Playername);

            var playersAfterKill = Players.Where(x => x.Playername != playerToKill.Playername).ToList();
            return playersAfterKill;
        }
    }
}
