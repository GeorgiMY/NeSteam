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
        
        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(GameInstance))]
        [Required]
        public int GameId { get; set; }
        public Game GameInstance { get; set; }
    }
}
