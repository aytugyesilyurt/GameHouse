using System;
using System.Collections.Generic;
using System.Text;
using GameHouse.Entities.GameEntities;

namespace GameHouse.Abstract.CampaignOperations
{
    public interface ICampaignService
    {
        void SummerSale(Game game, Game game1, Game game2);
    }
}
