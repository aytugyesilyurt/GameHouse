using System;
using System.Collections.Generic;
using System.Text;

namespace GameHouse.Entities.GameEntities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
