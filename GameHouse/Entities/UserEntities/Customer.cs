using GameHouse.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHouse.Entities
{
    public class Customer : User, IEntity 
    {
        public string CardNumber { get; set; }
    }
}
