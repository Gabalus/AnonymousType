using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousType.Models
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountGames { get; set; }
        public int Age { get; set; }
        
        public Team Team { get; set; }
       
    }
}
