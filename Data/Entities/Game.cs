using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Achievement> Achievements { get; set; }
        public ICollection<Player> Players { get; set; }
        [Required]
        public int GameCompanyId { get; set; }
        public GameCompany GameCompany { get; set; }
    }
}
