using GameHouse.Entities;
using GameHouse.Entities.GameEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHouse.Abstract.GameOperations
{
    public class GamerManager : IGameService
    {
        public void Buy(Game game, User user)
        {
            Console.WriteLine("\nSayın " + user.UserName + " , "  + game.GameName + " isimli oyunu satın aldınız. Kütüphanenizden oyunu yükleyebilirsiniz.");
        }
        
        public void Delete(Game game, User user)
        {
            Console.WriteLine(game.GameName + " oyunu silindi.");
        }
        
        public void GoStorePage(Game game, User user)
        {
            Console.WriteLine(game.GameName + " oyunun sayfasına yönlendiriliyorsunuz. Lütfen bekleyiniz...");
        }
    }
}
