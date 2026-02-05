using BarcelonaManager.Models;

namespace BarcelonaManager.Services
{
    public class TransferMarket
    {
        public static bool BuyPlayer(Team team, Player player, decimal price)
        {
            if (Team.Budget >= price)
            {
                Team.Budget -= price;
                team.AddPlayer(player);
                return true;
            }
            return false;
        }

        public static void SellPlayer(Team team, Player player, decimal price)
        {
            Team.Budget += price;
            team.RemovePlayer(player);
        }
    }
}
