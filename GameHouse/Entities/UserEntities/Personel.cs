using System;
using System.Collections.Generic;
using System.Text;
using GameHouse.Abstract;

namespace GameHouse.Entities
{
    public class Personel : User, IEntity
    {
        public string Department { get; set; }
    }
}
