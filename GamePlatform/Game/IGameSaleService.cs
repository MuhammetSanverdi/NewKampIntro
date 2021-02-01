using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Campaign;
using GamePlatform.Customer;

namespace GamePlatform.Game
{
    public interface IGameSaleService
    {
        void GameSale(Games game, Campaigns campaign, Customers customer);
    }
}
