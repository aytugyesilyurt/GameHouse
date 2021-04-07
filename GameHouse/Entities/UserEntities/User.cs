using System;
using System.Collections.Generic;
using System.Text;

namespace GameHouse.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }
        public long NationalNumber { get; set; }


    }
}
