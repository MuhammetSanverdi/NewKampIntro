using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Campaign
{
    public class CampaignManager:ICampaignService
    {
        public void Add(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya eklendi");
        }

        public void Update(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya güncellendi.");
        }

        public void Delete(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya silindi.");
        }
    }
}
