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

        // Vratar - posebna logika: 10% možnost da sploh da gol
        // Ob uspehu: 1 gol (75%), 2 gola (20%), 3 gole (3%), 4 gole (1%), 5 golov (1%)
        private int GenerateGoalkeeperGoals()
        {
            // 10% verjetnost da sploh zadane
            if (_rng.NextDouble() >= 0.10)
                return 0;

            // Ob uspehu: naključno določi točno število golov
            double roll = _rng.NextDouble();
            if (roll < 0.75) return 1;        // 75%
            if (roll < 0.95) return 2;        // 20%
            if (roll < 0.98) return 3;        //  3%
            if (roll < 0.99) return 4;        //  1%
            return 5;                          //  1%
        }

        // //objektna metoda - generira gole za enega igralca
        public int GenerateGoals(PlayerBase player)
        {
            int goals;

            // //polimorfizem - preverimo dejanski tip igralca
            if (player is Goalkeeper gk)
            {
                // Vratar ima svojo posebno logiko
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

                // Baza golov = vrednost × faktor
                // Nato dodamo ±20% naključnosti (dobra/slaba sezona)
                double baseGoals = (double)player.Value * factor;
                double variance = baseGoals * 0.20;
                goals = (int)(baseGoals + _rng.NextDouble() * variance * 2 - variance);
                goals = Math.Max(0, goals); // Ne moremo imeti negativnih golov

                // //polimorfizem - nastavi gole v samem objektu
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

            // Vratar – prišteji karierne gole
            if (player is Goalkeeper gkCareer)
                gkCareer.CareerGoals += gkCareer.Goals;

            // Vsak igralec dobi +1 sezono v klubu
            player.SeasonsAtClub++;

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