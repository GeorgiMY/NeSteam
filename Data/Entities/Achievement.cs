using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Achievement
    {
        [Key]
        public int AchievementId { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(GameInstance))]
        public int GameId { get; set; }
        public Game GameInstance { get; set; }

        [ForeignKey(nameof(PlayerInstance))]
        public int PlayerId { get; set; }
        public Player PlayerInstance { get; set; }
    }
}
