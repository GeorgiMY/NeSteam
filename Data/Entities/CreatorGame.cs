using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CreatorGame
    {
        [ForeignKey(nameof(CreatorInstance))]
        public int CreatorId { get; set; }
        public Creator CreatorInstance { get; set; }

        [ForeignKey(nameof(GameInstance))]
        public int GameId { get; set; }
        public Game GameInstance { get; set; }
    }
}
