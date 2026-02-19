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
            _allMarketPlayers.Add(new Forward("Ansu Fati", 21, 120m));
            _allMarketPlayers.Add(new Forward("Ousmane Dembélé", 30, 40m));
            _allMarketPlayers.Add(new Forward("Ferran Torres", 30, 40m));
            _allMarketPlayers.Add(new Forward("Riyad Mahrez", 33, 30m));
            _allMarketPlayers.Add(new Forward("Ángel Di María", 35, 20m));
            _allMarketPlayers.Add(new Forward("Sadio Mané", 32, 50m));
            _allMarketPlayers.Add(new Forward("Gonçalo Ramos", 24, 50m));
            _allMarketPlayers.Add(new Forward("Benjamin Šeško", 21, 90m));
            _allMarketPlayers.Add(new Forward("Youssoufa Moukoko", 20, 60m));
            _allMarketPlayers.Add(new Forward("Rasmus Højlund", 22, 70m));
            _allMarketPlayers.Add(new Forward("Mason Greenwood", 24, 30m));
            _allMarketPlayers.Add(new Forward("Dusan Vlahović", 27, 60m));
            _allMarketPlayers.Add(new Forward("João Félix", 27, 60m));
            _allMarketPlayers.Add(new Forward("Olivier Giroud", 37, 15m));
            _allMarketPlayers.Add(new Forward("Ángel Correa", 30, 40m));
            _allMarketPlayers.Add(new Forward("Raphinha", 30, 50m));
            _allMarketPlayers.Add(new Forward("Neymar Jr", 32, 90m));
            _allMarketPlayers.Add(new Forward("Karim Benzema", 36, 20m));
            _allMarketPlayers.Add(new Forward("Lamine Yamal", 17, 250m));
            _allMarketPlayers.Add(new Forward("Lionel Messi", 30, 750m));
            _allMarketPlayers.Add(new Forward("Cristiano Ronaldo", 30, 670m));

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
            _allMarketPlayers.Add(new Midfielder("Bruno Fernandes", 29, 70m));
            _allMarketPlayers.Add(new Midfielder("Mason Mount", 26, 70m));
            _allMarketPlayers.Add(new Midfielder("Sergej Milinković-Savić", 30, 60m));
            _allMarketPlayers.Add(new Midfielder("Martin Zubimendi", 27, 50m));
            _allMarketPlayers.Add(new Midfielder("Nicolò Barella", 29, 60m));
            _allMarketPlayers.Add(new Midfielder("Alex Baena", 22, 50m));
            _allMarketPlayers.Add(new Midfielder("Javi Martínez", 34, 20m));
            _allMarketPlayers.Add(new Midfielder("Sergio Busquets", 35, 15m));
            _allMarketPlayers.Add(new Midfielder("Rodri", 30, 70m));
            _allMarketPlayers.Add(new Midfielder("Federico Valverde", 27, 60m));
            _allMarketPlayers.Add(new Midfielder("Toni Kroos", 34, 25m));
            _allMarketPlayers.Add(new Midfielder("Kevin De Bruyne", 32, 100m));
            _allMarketPlayers.Add(new Midfielder("Joshua Kimmich", 30, 90m));

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
            _allMarketPlayers.Add(new Defender("Wiliam Saliba", 24, 90m));
            _allMarketPlayers.Add(new Defender("Raphaël Varane", 31, 50m));
            _allMarketPlayers.Add(new Defender("Marquinhos", 30, 60m));
            _allMarketPlayers.Add(new Defender("Dayot Upamecano", 28, 70m));
            _allMarketPlayers.Add(new Defender("Presnel Kimpembe", 30, 50m));
            _allMarketPlayers.Add(new Defender("Nicolás Tagliafico", 33, 30m));
            _allMarketPlayers.Add(new Defender("Pau Torres", 30, 50m));
            _allMarketPlayers.Add(new Defender("Milan Škriniar", 30, 50m));
            _allMarketPlayers.Add(new Defender("Wiliam Pacho", 24, 75m));

            // ===== VRATARJI (Goalkeeper) =====
            _allMarketPlayers.Add(new Goalkeeper("Thibaut Courtois", 32, 40m));
            _allMarketPlayers.Add(new Goalkeeper("Alisson Becker", 31, 45m));
            _allMarketPlayers.Add(new Goalkeeper("Ederson Moraes", 30, 30m));
            _allMarketPlayers.Add(new Goalkeeper("Gianluigi Donnarumma", 27, 45m));
            _allMarketPlayers.Add(new Goalkeeper("Mike Maignan", 30, 40m));
            _allMarketPlayers.Add(new Goalkeeper("Jan Oblak", 31, 40m));
            _allMarketPlayers.Add(new Goalkeeper("David de Gea", 33, 30m));
            _allMarketPlayers.Add(new Goalkeeper("André Onana", 30, 35m));
            _allMarketPlayers.Add(new Goalkeeper("Jan Sommer", 34, 35m));
            _allMarketPlayers.Add(new Goalkeeper("Joan García", 23, 50m));
            _allMarketPlayers.Add(new Goalkeeper("David Raya", 30, 50m));
            _allMarketPlayers.Add(new Goalkeeper("Emiliano Martínez", 31, 30m));
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