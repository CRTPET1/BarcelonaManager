using System.Collections.Generic;
using System.Linq;

namespace BarcelonaManager.Models
{
    public class Team : Entity
    {
        // ===== STATIČNO POLJE =====
        public static decimal Budget = 75_000_000; // 75M €

        public string Name { get; } = "FC Barcelona";

        private List<PlayerBase> players = new List<PlayerBase>();

        // PROPERTY za dostop
        public IReadOnlyList<PlayerBase> Players => players.AsReadOnly();

        // metode za ekipo
        public void AddPlayer(PlayerBase p)
        {
            if (!players.Contains(p))
                players.Add(p);
        }


        public void RemovePlayer(PlayerBase p)
        {
            if (players.Contains(p))
                players.Remove(p);
        }

        public int TotalGoals()
        {
            return players
                .OfType<Forward>()
                .Sum(f => f.Goals);
        }


        public override string Info()
        {
            return $"{Name} | {players.Count} igralcev | Golov skupaj: {TotalGoals()}";
        }

        public PlayerBase MostValuablePlayer()
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

        public PlayerBase this[int index]
        {
            get
            {
                if (index >= 0 && index < players.Count)
                    return players[index];
                return null;
            }
        }

    }
}
