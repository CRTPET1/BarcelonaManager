using BarcelonaManager.Models;
using System.Collections.Generic;

namespace BarcelonaManager.Services
{
    // Razred hrani bazo vseh tržnih igralcev
    // //static - statični razred, vse metode so statične (ni instanc)
    public class MarketPlayerDatabase
    {
        // //static - ena skupna lista za celo aplikacijo
        // //readonly podatek - lista sama je readonly (ne moremo je zamenjati)
        private static readonly List<PlayerBase> _allMarketPlayers = new List<PlayerBase>();

        // //const - ime baze je konstantno
        public const string DatabaseName = "Barcelona Transfer Market DB";

        // //konstruktor - statični konstruktor, pokliče se ENKRAT ob prvem dostopu do razreda
        static MarketPlayerDatabase()
        {
            // ===== NAPADALCI (Forward) =====
            _allMarketPlayers.Add(new Forward("Kylian Mbappé", 25, 180m));
            _allMarketPlayers.Add(new Forward("Erling Haaland", 23, 200m));
            _allMarketPlayers.Add(new Forward("Victor Osimhen", 25, 110m));
            _allMarketPlayers.Add(new Forward("Marcus Rashford", 26, 80m));
            _allMarketPlayers.Add(new Forward("Lautaro Martínez", 26, 90m));
            _allMarketPlayers.Add(new Forward("Rafael Leão", 24, 95m));
            _allMarketPlayers.Add(new Forward("Cody Gakpo", 24, 65m));
            _allMarketPlayers.Add(new Forward("Darwin Núñez", 24, 80m));
            _allMarketPlayers.Add(new Forward("Harry Kane", 30, 85m));
            _allMarketPlayers.Add(new Forward("Vinicius Jr", 23, 150m));

            // ===== VEZISTI (Midfielder) =====
            _allMarketPlayers.Add(new Midfielder("Jude Bellingham", 20, 180m));
            _allMarketPlayers.Add(new Midfielder("Pedri", 21, 120m));
            _allMarketPlayers.Add(new Midfielder("Jamal Musiala", 21, 130m));
            _allMarketPlayers.Add(new Midfielder("Florian Wirtz", 21, 130m));
            _allMarketPlayers.Add(new Midfielder("Eduardo Camavinga", 21, 80m));
            _allMarketPlayers.Add(new Midfielder("Declan Rice", 25, 90m));
            _allMarketPlayers.Add(new Midfielder("Martin Ødegaard", 25, 95m));
            _allMarketPlayers.Add(new Midfielder("Khvicha Kvaratskhelia", 23, 90m));
            _allMarketPlayers.Add(new Midfielder("Gavi", 19, 100m));
            _allMarketPlayers.Add(new Midfielder("Phil Foden", 23, 120m));

            // ===== BRANILCI (Defender) =====
            _allMarketPlayers.Add(new Defender("Alejandro Balde", 20, 70m));
            _allMarketPlayers.Add(new Defender("Jules Koundé", 25, 75m));
            _allMarketPlayers.Add(new Defender("Theo Hernández", 26, 70m));
            _allMarketPlayers.Add(new Defender("Joško Gvardiol", 22, 90m));
            _allMarketPlayers.Add(new Defender("Benjamin Pavard", 28, 45m));
            _allMarketPlayers.Add(new Defender("Rúben Dias", 26, 80m));
            _allMarketPlayers.Add(new Defender("William Saliba", 23, 80m));
            _allMarketPlayers.Add(new Defender("Fikayo Tomori", 26, 55m));
            _allMarketPlayers.Add(new Defender("Pau Cubarsí", 17, 40m));
            _allMarketPlayers.Add(new Defender("Virgil van Dijk", 32, 50m));
        }

        // //statična metoda - vrne kopijo celotne baze (da originala ne spremenimo po nesreči)
        public static List<PlayerBase> GetAllPlayers()
        {
            return new List<PlayerBase>(_allMarketPlayers);
        }

        // //statična metoda - doda igralca nazaj na trg (kliče se ko prodamo igralca)
        // TUDI ko sami ustvarimo igralca in ga prodamo - pristane na trgu
        public static void AddToMarket(PlayerBase player)
        {
            // Preverimo da ga ni že na trgu (izognemo se podvajanju)
            if (!_allMarketPlayers.Contains(player))
                _allMarketPlayers.Add(player);
        }

        // //statična metoda - posebej za dodajanje lastnih (ročno ustvarjenih) igralcev
        // Kliče se iz Form1 ko dodamo novega igralca z AddPlayerForm
        public static void RegisterCustomPlayer(PlayerBase player)
        {
            AddToMarket(player);
        }

        // //statična metoda - vrne število vseh tržnih igralcev
        public static int Count()
        {
            return _allMarketPlayers.Count;
        }

        // //indekser - dostop do posameznega igralca po indeksu kot pri polju
        public PlayerBase this[int index]
        {
            get
            {
                if (index >= 0 && index < _allMarketPlayers.Count)
                    return _allMarketPlayers[index];
                return null;
            }
        }
    }
}