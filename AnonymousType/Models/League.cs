using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousType.Models
{
    class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Team> Teams {get; set;}
    }
}
