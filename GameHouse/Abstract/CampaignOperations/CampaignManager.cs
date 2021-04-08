using GameHouse.Entities.GameEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHouse.Abstract.CampaignOperations
{
    public class CampaignManager : ICampaignService
    {
        public void SummerSale(Game game, Game game1, Game game2)
        {
            Console.WriteLine("\nKampanyaya katılmak için şu oyunları eklediniz: " + game.GameName + " , " + game1.GameName + " , "+ game2.GameName +"\nYAZ İNDİRİMİ KAMPANYASINA BAŞARIYLA KATILDINIZ.");
        }
    }
}
