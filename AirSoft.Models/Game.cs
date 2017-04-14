using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSoft.Models
{
    public class Game
    {
        public Game()
        {
            this.ParticipatingPlayers = new HashSet<Player>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public string Adress { get; set; }

        public DateTime StartDate { get; set; }

        public int CretorTeamId { get; set; }

        public virtual Team CreatorsTeam { get; set; }

        public virtual ICollection<Player> ParticipatingPlayers { get; set; }

    }
}
