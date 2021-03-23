using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {   
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"başarıyla listeye eklendi.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "başarıyla listeden kaldırıldı.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "listede güncellendi.");
        }
    }
}
