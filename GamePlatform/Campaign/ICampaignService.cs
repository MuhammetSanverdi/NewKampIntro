using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.Customer;

namespace GamePlatform.Campaign
{
    public interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Update(Campaigns campaign);
        void Delete(Campaigns campaign);
    }
}
