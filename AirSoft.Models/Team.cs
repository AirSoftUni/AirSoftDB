using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSoft.Models
{
    public class Team
    {
        public Team()
        {
            this.Players = new HashSet<Player>();
            this.CreatedGames = new HashSet<Game>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Game> CreatedGames { get; set; }
    }
}
