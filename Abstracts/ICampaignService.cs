using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstracts
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaignn);
        void Delete(Campaign campaign);
        
    }
}
