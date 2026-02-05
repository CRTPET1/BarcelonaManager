using System.Collections.Generic;
using System.Linq;

namespace BarcelonaManager.Models
{
    public class Team : Entity
    {
        // ===== STATIČNO POLJE =====
        public static decimal Budget = 75_000_000; // 75M €

        public string Name { get; } = "FC Barcelona";

        private List<Player> players = new List<Player>();

        // PROPERTY za dostop
        public IReadOnlyList<Player> Players => players.AsReadOnly();

        // metode za ekipo
        public void AddPlayer(Player p)
        {
            if (!players.Contains(p))
                players.Add(p);
        }

        public void RemovePlayer(Player p)
        {
            if (players.Contains(p))
                players.Remove(p);
        }

        public int TotalGoals()
        {
            return players.Sum(x => x.Goals);
        }

        public override string Info()
        {
            return $"{Name} | {players.Count} igralcev | Golov skupaj: {TotalGoals()}";
        }

        public Player MostValuablePlayer()
        {
            return players.OrderByDescending(p => p.Value).FirstOrDefault();
        }

        public double AverageAge()
        {
            return players.Count == 0 ? 0 : players.Average(p => p.Age);
        }

        public int TotalPlayersValue()
        {
            return (int)players.Sum(p => p.Value);
        }

        public Dictionary<string, int> PositionDistribution()
        {
            return players
                .GroupBy(p => p.Position)
                .ToDictionary(g => g.Key, g => g.Count());
        }

    }
}
