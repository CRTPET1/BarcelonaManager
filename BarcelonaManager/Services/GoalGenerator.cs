using BarcelonaManager.Models;
using System;
using System.Collections.Generic;

namespace BarcelonaManager.Services
{
    public delegate void GoalsGeneratedHandler(string playerName, string position, int goals);

    public class GoalGenerator
    {
        private readonly Random _rng = new Random();

        public event GoalsGeneratedHandler OnGoalsGenerated;

        private const double ForwardGoalFactor = 0.40;   // Napadalci: veliko golov
        private const double MidfielderGoalFactor = 0.15;   // Vezisti: manj golov
        private const double DefenderGoalFactor = 0.03;   // Branilci: redki goli
        private const double GenericGoalFactor = 0.05;

        private int GenerateGoalkeeperGoals()
        {
            if (_rng.NextDouble() >= 0.10)
                return 0;

            double roll = _rng.NextDouble();
            if (roll < 0.75) return 1;        // 75%
            if (roll < 0.95) return 2;        // 20%
            if (roll < 0.98) return 3;        //  3%
            if (roll < 0.99) return 4;        //  1%
            return 5;                          //  1%
        }

        public int GenerateGoals(PlayerBase player)
        {
            int goals;

            if (player is Goalkeeper gk)
            {
                goals = GenerateGoalkeeperGoals();
                gk.Goals = goals;
            }
            else
            {
                double factor = GenericGoalFactor;

                if (player is Forward)
                    factor = ForwardGoalFactor;
                else if (player is Midfielder)
                    factor = MidfielderGoalFactor;
                else if (player is Defender)
                    factor = DefenderGoalFactor;

                double baseGoals = (double)player.Value * factor;
                double variance = baseGoals * 0.20;
                goals = (int)(baseGoals + _rng.NextDouble() * variance * 2 - variance);
                goals = Math.Max(0, goals); // Ne moremo imeti negativnih golov

                if (player is Forward f)
                {
                    f.Goals = goals;
                    f.CareerGoals += goals;  // Prištej h kariernim golom
                }
                else if (player is Midfielder m)
                {
                    m.Goals = goals;
                    m.Assists = (int)(goals * 1.5 + _rng.Next(0, 5));
                    m.CareerGoals += goals;               // Karierni goli
                    m.CareerAssists += m.Assists;         // Karierne asistence
                }
                else if (player is Defender)
                {
                    player.CareerGoals += goals;          // Branilci redko, a vseeno beležimo
                }
            }

            if (player is Goalkeeper gkCareer)
                gkCareer.CareerGoals += gkCareer.Goals;

            player.SeasonsAtClub++;

            OnGoalsGenerated?.Invoke(player.Name, player.Position, goals);

            return goals;
        }

        public static Dictionary<string, int> GenerateForTeam(IEnumerable<PlayerBase> players)
        {
            var generator = new GoalGenerator();
            var results = new Dictionary<string, int>();

            foreach (var p in players)
            {
                int g = generator.GenerateGoals(p);
                results[p.Name] = g;
            }

            return results;
        }
    }
}