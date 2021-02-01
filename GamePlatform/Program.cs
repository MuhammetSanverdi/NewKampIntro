using System;
using GamePlatform.Customer;
using GamePlatform.Campaign;
using GamePlatform.Game;


namespace GamePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaigns campaign = new Campaigns
            {
                CampaignId = 1,
                CampaignName = "Black Friday",
                DiscountRate = 20
            };
            CampaignManager campaignManager = new CampaignManager();
            

            Customers customer = new Customers
            {
                FirstName = "Muhammet",
                LastName = "Şanverdi",
                BirthYear = 1997,
                IdentificationNumber = 2341343124
            };
            CustomerManager customerManager = new CustomerManager(new CustomerVerificationManager());
            customerManager.Add(customer);

            Games game = new Games
            {
                GameId = 1,
                GameName = "Crysis 3",
                GameType = "Action",
                GamePrice = 150,
                
            };
            Games game1 = new Games
            {
                GameId = 2,
                GameName = "Dark Souls 3",
                GameType = "Adventure",
                GamePrice = 300,

            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game);

            campaignManager.Add(campaign);
            GameSaleManager gameSaleManager = new GameSaleManager(campaign, game);
            gameSaleManager.GameSale(game1,campaign,customer);
            campaignManager.Delete(campaign);
            gameManager.Delete(game);

        }
    }
}
