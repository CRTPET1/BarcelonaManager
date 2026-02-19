using BarcelonaManager.Models;
using System;
using System.Collections.Generic;

namespace BarcelonaManager.Services
{
    // //delegat - definicija tipa za obveščanje o generiranih golih
    // Ko generator ustvari gole za igralca, to "sporoči" naprej
    public delegate void GoalsGeneratedHandler(string playerName, string position, int goals);

    public class GoalGenerator
    {
        // //readonly podatek - generator naključnih števil, ustvarjen enkrat
        private readonly Random _rng = new Random();

        // //dogodek - sproži se za vsakega igralca ko se generirajo goli
        // //delegat - uporaba delegata kot tip za dogodek
        public event GoalsGeneratedHandler OnGoalsGenerated;

        // //const - faktorji: vrednost × faktor = baza golov na sezono
        // Primer: Forward z vrednostjo 100M → 100 × 0.40 = 40 golov (baza)
        private const double ForwardGoalFactor = 0.40;   // Napadalci: veliko golov
        private const double MidfielderGoalFactor = 0.15;   // Vezisti: manj golov
        private const double DefenderGoalFactor = 0.03;   // Branilci: redki goli
        private const double GenericGoalFactor = 0.05;

        // //objektna metoda - generira gole za enega igralca
        public int GenerateGoals(PlayerBase player)
        {
            double factor = GenericGoalFactor;

            // //polimorfizem - preverimo dejanski tip igralca
            if (player is Forward)
                factor = ForwardGoalFactor;
            else if (player is Midfielder)
                factor = MidfielderGoalFactor;
            else if (player is Defender)
                factor = DefenderGoalFactor;

            // Baza golov = vrednost × faktor
            // Primer: Forward vrednost 100M → 100 × 0.40 = 40 golov
            // Nato dodamo ±20% naključnosti (dobra/slaba sezona)
            double baseGoals = (double)player.Value * factor;
            double variance = baseGoals * 0.20;
            int goals = (int)(baseGoals + _rng.NextDouble() * variance * 2 - variance);
            goals = Math.Max(0, goals); // Ne moremo imeti negativnih golov

            // Nastavi gole v samem objektu (odvisno od tipa)
            // //polimorfizem
            if (player is Forward f)
                f.Goals = goals;
            else if (player is Midfielder m)
            {
                m.Goals = goals;
                // Vezisti imajo več podaj kot golov
                m.Assists = (int)(goals * 1.5 + _rng.Next(0, 5));
            }
            // Branilci nimajo Goals property - ne shranjujemo

            // //dogodek - obvestimo vse, ki poslušajo (npr. Form1 da osveži UI)
            OnGoalsGenerated?.Invoke(player.Name, player.Position, goals);

            return goals;
        }

        // //statična metoda - generira gole za celo ekipo naenkrat
        // Vrne slovar: ime_igralca → goli
        public static Dictionary<string, int> GenerateForTeam(IEnumerable<PlayerBase> players)
        {
            // //objektna metoda - ustvarimo instanco in jo uporabimo
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