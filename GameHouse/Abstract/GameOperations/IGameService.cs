using System;
using System.Collections.Generic;
using System.Text;
using GameHouse.Entities;
using GameHouse.Entities.GameEntities;

namespace GameHouse.Abstract.GameOperations
{
    public interface IGameService
    {
        void Buy(Game game, User user);
        void GoStorePage(Game game, User user);
        void Delete(Game game, User user);
    }
}
