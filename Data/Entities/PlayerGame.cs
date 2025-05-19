using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [PrimaryKey("PlayerId", "GameId")]
    public class PlayerGame
    {
        [ForeignKey(nameof(PlayerInstance))]
        public int PlayerId { get; set; }
        public Player PlayerInstance { get; set; }

        [ForeignKey(nameof(GameInstance))]
        public int GameId { get; set; }
        public Game GameInstance { get; set; }
    }
}
