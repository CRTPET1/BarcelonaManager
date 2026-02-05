using BarcelonaManager.Models;

namespace BarcelonaManager.Services
{
    public class TransferMarket
    {
        public static bool BuyPlayer(Team team, PlayerBase player, decimal price)
        {
            if (Team.Budget < price)
                return false;

            Team.Budget -= price;
            team.AddPlayer(player);
            return true;
        }

        public static void SellPlayer(Team team, PlayerBase player, decimal price)
        {
            Team.Budget += price;
            team.RemovePlayer(player);
        }
    }
}
