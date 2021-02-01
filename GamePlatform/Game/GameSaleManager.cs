using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Campaign;
using GamePlatform.Customer;

namespace GamePlatform.Game
{
    public class GameSaleManager:IGameSaleService
    {
        public double _finalPrice { get; set; }
        
        
        public GameSaleManager(Campaigns campaign, Games game)
        {
            
            _finalPrice = game.GamePrice * campaign.DiscountRate / 100;
        }
        public void GameSale(Games game, Campaigns campaign,Customers customer)
        {
            Console.WriteLine(customer.FirstName+" "+customer.LastName+" adlı kullanıcı "+game.GameName+" adlı oyunu "+campaign.DiscountRate+" indirimle "+_finalPrice+" TL'ye aldı.");
        }
    }
}
