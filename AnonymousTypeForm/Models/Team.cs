using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymousTypeForm.Models
{
    class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        public League League { get; set; }

    }
}
